using Guna.UI2.WinForms;
using MyCoffeeShop.Controls;
using MyCoffeeShop.DAO;
using MyCoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Menu = MyCoffeeShop.DTO.Menu;

namespace MyCoffeeShop.Forms
{
    public partial class fPos : Form
    {
        private static CultureInfo culture = new CultureInfo("vi-VN");

        private static int staff_id, shift_id;

        private static string username, shift;

        public fPos()
        {
            InitializeComponent();

            Init();
        }

        #region Events
        private void btnTable_click(object sender, EventArgs e)
        {
            Table table = (sender as Guna2GradientButton).Tag as Table;
            int table_id = table.Id;
            //lvOrder.Tag = (sender as Guna2GradientButton).Tag;
            lvOrder.Tag = table;
            tbSum.Text = tbDiscount.Text = tbDiscountPrice.Text = tbValue.Text = tbTotalPrice.Text = tbTableInfo.Text = string.Empty;
            ShowBill(table_id, shift_id);
        }

        private void btnClearProduct_click(object sender, EventArgs e)
        {
            try
            {
                Table table = lvOrder.Tag as Table;
                Product product = (sender as ucProduct).Tag as Product;
                int table_id = table.Id;
                int product_id = product.Id;
                int invoice_id = InvoiceDAO.Instance.GetUnpaidInvoiceId(table_id, shift_id);
                int quantity = DetailsDAO.Instance.GetQuantity(invoice_id, product_id);

                if (quantity == -1)
                {
                    MessageBox.Show("Không có sản phẩm để xóa!", "Thông báo");
                }
                else
                {
                    DetailsDAO.Instance.Delete(invoice_id, product_id);
                    InvoiceDAO.Instance.Delete(invoice_id);
                }

                LoadTable();
                ShowBill(table_id, shift_id);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddProduct_click(object sender, EventArgs e)
        {
            try
            {
                Table table = lvOrder.Tag as Table;
                Product product = (sender as ucProduct).Tag as Product;
                int table_id = table.Id;
                int product_id = product.Id;
                int invoice_id = InvoiceDAO.Instance.GetUnpaidInvoiceId(table_id, shift_id);

                if (invoice_id == -1)
                {
                    InvoiceDAO.Instance.Insert(table_id, shift_id);
                    int max_invoice_id = InvoiceDAO.Instance.GetMaxInvoiceId();
                    DetailsDAO.Instance.Insert(max_invoice_id, product_id);
                }
                else
                    DetailsDAO.Instance.Insert(invoice_id, product_id);

                LoadTable();
                ShowBill(table_id, shift_id);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCate_click(object sender, EventArgs e)
        {
            tbSearchProduct.Text = string.Empty;

            int id = ((sender as Guna2GradientButton).Tag as Category).Id;

            LoadProductByCategoryId(id);
        }

        private void btnCateAll_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flpProduct.Controls)
            {
                var p = (ucProduct)item;
                p.Visible = p.Title.ToLower().Contains(tbSearchProduct.Text.Trim().ToLower());
            }
        }

        private void tbCustomer_IconRightClick(object sender, EventArgs e)
        {
            string phone = tbCustomer.Text;

            LoadDiscountByPhone(phone);

            if (tbDiscount.Text != string.Empty)
            {
                string sum = tbSum.Text, discount_price = tbDiscountPrice.Text, total_price = tbTotalPrice.Text;

                float s = SwitchCurrency(sum), d = SwitchCurrency(discount_price), t = SwitchCurrency(total_price);

                float value = float.Parse(tbValue.Text.Substring(0, tbValue.Text.IndexOf("%")));

                if (s != -1 && d != -1 && t != -1)
                {
                    d = s * (value / 100);
                    t = s - d;
                    tbTotalPrice.Text = t.ToString("c", culture);
                    tbDiscountPrice.Text = d.ToString("c", culture);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            try
            {
                Table first_table = lvOrder.Tag as Table;
                Table second_table = cbbTable.SelectedItem as Table;

                int first_id = first_table.Id;
                int second_id = second_table.Id;

                if (first_id == second_id)
                    MessageBox.Show("Bạn đã ở bàn hiện tại rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn chuyển từ " + (first_table).Name + " sang " + (second_table).Name + " không?", 
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        TableDAO.Instance.SwitchTable(first_id, second_id, shift_id);
                        LoadTable();
                    }
                }    
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lvOrder.Tag as Table;
                int table_id = table.Id;
                int invoice_id = InvoiceDAO.Instance.GetUnpaidInvoiceId(table_id, shift_id);


                if (invoice_id != -1)
                {
                    DialogResult re = MessageBox.Show("Bạn có muốn thanh toán hóa đơn của " + table.Name + " không?" + "\nTổng tiền cần thanh toán là: " + tbTotalPrice.Text,
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (re == DialogResult.Yes)
                    {
                        int total_quantity = DetailsDAO.Instance.SumQuantity(invoice_id);
                        float total_price = SwitchCurrency(tbTotalPrice.Text);
                        float discount_price = SwitchCurrency(tbDiscountPrice.Text);
                        string staff_name = username;
                        if (total_price != -1)
                        {
                            InvoiceDAO.Instance.Update(invoice_id, total_quantity, total_price, discount_price, staff_name);
                            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTable();
                            ShowBill(table_id, shift_id);
                        }
                    }
                }
                else
                    MessageBox.Show("Bàn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lvOrder.Tag as Table;
                int table_id = table.Id;
                int invoice_id = InvoiceDAO.Instance.GetUnpaidInvoiceId(table_id, shift_id);


                if (invoice_id != -1)
                {
                    if (lvOrder.SelectedItems.Count == 0)
                    {
                        DialogResult re = MessageBox.Show("Bạn có xóa hết sản phẩm trong hóa đơn của " + table.Name + " không?",
                                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (re == DialogResult.Yes)
                            DetailsDAO.Instance.Delete(invoice_id);
                    }
                    else
                    {
                        ListViewItem item = lvOrder.SelectedItems[0];
                        string name = item.SubItems[0].Text;
                    }
                    
                }
                else
                    MessageBox.Show("Menu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LoadTable();
                ShowBill(table_id, shift_id);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            int unpaid_invoice = InvoiceDAO.Instance.CountUnpaidInvoice();

            if (unpaid_invoice > 0)
                MessageBox.Show("Có hóa đơn chưa thanh toán, vui lòng hoàn tất thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.Close();
        }
        #endregion

        #region Methods
        void Init()
        {
            staff_id = GetStaffId();
            shift_id = GetShiftId();
            username = GetStaffName(staff_id);
            shift = GetShiftName(shift_id);
            lbUsername.Text += username;
            lbShift.Text = shift;
            LoadTable();
            LoadCate();
            LoadProduct();
            LoadSwitchTable();
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tables = TableDAO.Instance.GetTableList();

            foreach (Table table in tables)
            {
                Guna2GradientButton btn = new Guna2GradientButton() { Width = TableDAO.width, Height = TableDAO.height };
                btn.Text = table.Name;
                btn.Font = new Font("Tahoma", 10);
                btn.ForeColor = Color.Black;
                btn.Click += btnTable_click;
                btn.Tag = table;

                if (table.Status)
                {
                    btn.FillColor = ColorTranslator.FromHtml("#43b692");
                    btn.FillColor2 = ColorTranslator.FromHtml("#099773");
                    btn.Text += "\nCó người";
                }
                else
                {
                    btn.FillColor = ColorTranslator.FromHtml("#9bb2e5");
                    btn.FillColor2 = ColorTranslator.FromHtml("#698cbf");
                    btn.Text += "\nBàn trống";
                }

                flpTable.Controls.Add(btn);
            }
        }

        void LoadSwitchTable()
        {
            cbbTable.DataSource = TableDAO.Instance.GetTableList();
            cbbTable.DisplayMember = "Name";
        }

        void LoadCate()
        {
            List<Category> categories = CategoryDAO.Instance.GetCategoryList();

            foreach (Category category in categories)
            {
                Guna2GradientButton btn = new Guna2GradientButton() { Width = CategoryDAO.width, Height = CategoryDAO.width };
                btn.Text = category.Name;
                btn.Font = new Font("Tahoma", 10);
                btn.ForeColor = Color.Black;
                btn.FillColor = ColorTranslator.FromHtml("#ffffff");
                btn.FillColor2 = ColorTranslator.FromHtml("#ffffff");
                btn.Tag = category;
                btn.Click += btnCate_click;
                flpCate.Controls.Add(btn);
            }
        }

        void LoadProduct()
        {
            flpProduct.Controls.Clear();

            List<Product> products = ProductDAO.Instance.GetProductList();

            foreach (Product product in products)
            {
                ucProduct uc = new ucProduct()
                {
                    Title = product.Name,
                    Price = product.Price.ToString("c", culture),
                };

                if (product.Photo != null)
                {
                    var v = product.Photo;
                    using (MemoryStream ms = new MemoryStream(v))
                        uc.Photo = Image.FromStream(ms);
                }
                else
                    uc.Photo = Image.FromFile(Application.StartupPath + @"/Image/juice.png");


                uc.clickAdd += btnAddProduct_click;
                uc.clickRemove += btnClearProduct_click;
                uc.Tag = product;

                flpProduct.Controls.Add(uc);
            }
        }

        void LoadProductByCategoryId(int id)
        {
            flpProduct.Controls.Clear();

            List<Product> products = ProductDAO.Instance.GetProductList(id);

            foreach (Product product in products)
            {
                ucProduct uc = new ucProduct()
                {
                    Title = product.Name,
                    Price = product.Price.ToString("c", culture),
                };

                if (product.Photo != null)
                {
                    var v = product.Photo;
                    using (MemoryStream ms = new MemoryStream(v))
                        uc.Photo = Image.FromStream(ms);
                }
                else
                    uc.Photo = Image.FromFile(Application.StartupPath + @"/Image/juice.png");

                uc.clickAdd += btnAddProduct_click;
                uc.clickRemove += btnClearProduct_click;
                uc.Tag = product;

                flpProduct.Controls.Add(uc);
            }
        }

        void LoadDiscountByPhone(string phone)
        {
            List<Discount> discounts = DiscountDAO.Instance.GetDiscountList(phone);

            if (discounts.Count == 0)
                MessageBox.Show("Vui lòng kiểm lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            foreach (Discount discount in discounts)
            {
                tbDiscount.Text = discount.Name;
                tbValue.Text = discount.Value.ToString() + "%";
            }
        }

        void ShowBill(int table_id, int shift_id)
        {
            lvOrder.Items.Clear();

            List<Menu> bills = MenuDAO.Instance.GetMenuItem(table_id, shift_id);

            float sum = 0, discount_price = 0;

            foreach (Menu bill in bills)
            {
                ListViewItem item = new ListViewItem(bill.Name.ToString());
                item.SubItems.Add(bill.Quantity.ToString());
                item.SubItems.Add(bill.Price.ToString("c", culture));
                item.SubItems.Add(bill.Unit_price.ToString("c", culture));
                sum += bill.Unit_price;

                lvOrder.Items.Add(item);
            }

            string table_name = (lvOrder.Tag as Table).Name;
            tbTableInfo.Text = table_name;
            tbStaff.Text = username;
            tbSum.Text = sum.ToString("c", culture);
            tbTotalPrice.Text = sum.ToString("c", culture);
            tbDiscountPrice.Text = discount_price.ToString("c", culture);
        }

        int GetStaffId()
        {
            List<Working> works = WorkingDAO.Instance.GetWorkingList();
            return works[0].Staff_id;
        }

        int GetShiftId()
        {
            List<Working> works = WorkingDAO.Instance.GetWorkingList();
            return works[0].Shift_id;
        }

        string GetStaffName(int id)
        {
            List<Staff> staffs = StaffDAO.Instance.GetStaffListById(id);
            return staffs[0].Name;
        }

        string GetShiftName(int id)
        {
            List<Shift> shifts = ShiftDAO.Instance.GetShiftListById(id);
            return shifts[0].Name;
        }

        float SwitchCurrency(string currency)
        {
            float f;

            bool b = float.TryParse(currency, NumberStyles.Currency, culture.NumberFormat, out f);

            if (b)
                return f;

            return -1;
        }
        #endregion
    }
}
