using MyCoffeeShop.DAO;
using MyCoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace MyCoffeeShop.Forms
{
    public partial class fAdmin : Form
    {
        #region Properties
        private static CultureInfo culture = new CultureInfo("vi-VN");

        private static int staff_id;

        private static string username;

        private static DateTime now = DateTime.Now;

        private static DateTime previous, next;

        private BindingSource product_source = new BindingSource();

        private BindingSource category_source = new BindingSource();

        private BindingSource table_source = new BindingSource();

        private BindingSource staff_source = new BindingSource();

        private BindingSource account_source = new BindingSource();

        private BindingSource customer_source = new BindingSource();

        private BindingSource discount_source = new BindingSource();

        private BindingSource shift_source = new BindingSource();
        #endregion
        public fAdmin()
        {
            InitializeComponent();

            Init();
        }

        #region Events
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Invoice
        private void btnStat_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;

            LoadInvoiceByDates(from, to);
        }

        private void btnLoadI_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = dtpTo.Value = DateTime.Now;
            cbbShift.DataSource = null;
            LoadInvoice();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            if (now != DateTime.Now)
                now = DateTime.Now;
            tbDateTime.Text = now.ToString();
            LoadInvoiceByDate(now);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            previous = now.AddDays(-1);
            tbDateTime.Text = previous.ToString();
            LoadInvoiceByDate(previous);
            now = previous;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            next = now.AddDays(1);
            tbDateTime.Text = next.ToString();
            LoadInvoiceByDate(next);
            now = next;
        }

        private void cbbShift_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Shift shift = cbbShift.SelectedItem as Shift;
            int shift_id = shift.Id;

            LoadInvoiceByShift(shift_id);
        }

        private void cbbShift_DropDown(object sender, EventArgs e)
        {
            LoadShiftToCbb(cbbShift);
        }
        #endregion

        #region Category

        private void btnAddC_Click(object sender, EventArgs e)
        {
            string name = tbCateName.Text;

            if (CategoryDAO.Instance.Insert(name))
            {
                MessageBox.Show("Thêm danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategory();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdateC_Click(object sender, EventArgs e)
        {
            int category_id = Convert.ToInt32(tbCateID.Text);
            string name = tbCateName.Text;

            if (CategoryDAO.Instance.Update(category_id, name))
            {
                MessageBox.Show("Thay đổi thông tin danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategory();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelC_Click(object sender, EventArgs e)
        {
            int category_id = Convert.ToInt32(tbCateID.Text);

            int result = CategoryDAO.Instance.doesHaveProduct(category_id);

            if (result > 0)
            {
                MessageBox.Show("Không thể xóa danh mục có chứa sản phẩm trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CategoryDAO.Instance.Delete(category_id))
            {
                MessageBox.Show("Xóa danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategory();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLoadC_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }

        #endregion

        #region Product
        private void btnAddP_Click(object sender, EventArgs e)
        {
            string name = tbProductName.Text;
            float price = (float)nudProductPrice.Value;
            string img_path = tbProductPath.Text;
            int category_id = (cbbProductCate.SelectedItem as Category).Id;

            if (ProductDAO.Instance.Insert(name, price, img_path, category_id))
            {
                MessageBox.Show("Thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProduct();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelP_Click(object sender, EventArgs e)
        {
            int product_id = Convert.ToInt32(tbProductID.Text);

            int result = ProductDAO.Instance.isInDetails(product_id);

            if (result > 0)
            {
                MessageBox.Show("Không thể xóa sản phẩm đã có trong hóa đơn trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ProductDAO.Instance.Delete(product_id))
            {
                MessageBox.Show("Xóa món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProduct();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdateP_Click(object sender, EventArgs e)
        {
            int product_id = Convert.ToInt32(tbProductID.Text);
            string name = tbProductName.Text;
            float price = (float)nudProductPrice.Value;
            string img_path = tbProductPath.Text;
            int category_id = (cbbProductCate.SelectedItem as Category).Id;

            if (ProductDAO.Instance.Update(product_id, name, price, img_path, category_id))
            {
                MessageBox.Show("Thay đổi thông tin món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProduct();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLoadP_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                tbProductPath.Text = open.FileName;
                pbProductPhoto.Image = new Bitmap(path);
            }
        }

        private void btnDelPath_Click(object sender, EventArgs e)
        {
            if (tbProductPath.Text == string.Empty)
                MessageBox.Show("Đường dẫn trống!", "Thông báo");
            else
            {
                tbProductPath.Text = string.Empty;
                pbProductPhoto.Image = null;
            }
        }

        private void tbProductID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvProduct.SelectedCells.Count > 0)
            {
                int id = (int)dtgvProduct.SelectedCells[0].OwningRow.Cells["category_id"].Value;

                Category category = CategoryDAO.Instance.GetCategoryByID(id);

                cbbProductCate.SelectedItem = category;

                int index = -1;

                int i = 0;

                foreach (Category c in cbbProductCate.Items)
                {
                    if (c.Id == category.Id)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbbProductCate.SelectedIndex = index;
            }
        }
        #endregion

        #region Table
        private void btnAddT_Click(object sender, EventArgs e)
        {
            string name = tbTableName.Text;
            bool status = Convert.ToBoolean(nupTableStatus.Value);

            if (TableDAO.Instance.Insert(name, status))
            {
                MessageBox.Show("Thêm bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelT_Click(object sender, EventArgs e)
        {
            int table_id = Convert.ToInt32(tbTableID.Text);

            int result = TableDAO.Instance.isInInvoice(table_id);

            if (result > 0)
            {
                MessageBox.Show("Không thể xóa bàn đã có trong hóa đơn trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TableDAO.Instance.Delete(table_id))
            {
                MessageBox.Show("Xóa bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdateT_Click(object sender, EventArgs e)
        {
            int table_id = Convert.ToInt32(tbTableID.Text);
            string name = tbTableName.Text;
            bool status = Convert.ToBoolean(nupTableStatus.Value);

            if (TableDAO.Instance.Update(table_id, name, status))
            {
                MessageBox.Show("Thay đổi thông tin bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLoadT_Click(object sender, EventArgs e)
        {
            LoadTable();
        }
        #endregion

        #region Staff
        private void btnAddS_Click(object sender, EventArgs e)
        {
            string name = tbStaffName.Text;
            string phone = tbStaffPhone.Text;
            string address = tbStaffAdrress.Text;

            if (StaffDAO.Instance.Insert(name, phone, address))
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaff();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelS_Click(object sender, EventArgs e)
        {
            int staff_id = Convert.ToInt32(tbStaffID.Text);

            bool isAdmin = AccountDAO.Instance.isAdmin(staff_id);

            if (isAdmin)
            {
                MessageBox.Show("Không thể xóa quản trị viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (StaffDAO.Instance.Delete(staff_id))
            {
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaff();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdateS_Click(object sender, EventArgs e)
        {
            int staff_id = Convert.ToInt32(tbStaffID.Text);
            string name = tbStaffName.Text;
            string phone = tbStaffPhone.Text;
            string address = tbStaffAdrress.Text;

            if (StaffDAO.Instance.Update(staff_id, name, phone, address))
            {
                MessageBox.Show("Thay đổi nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaff();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLoadS_Click(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void tbStaffPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
        #endregion

        #region Account
        private void btnAddA_Click(object sender, EventArgs e)
        {
            string username = tbAccountU.Text;
            string password = tbAccountP.Text;
            bool type = Convert.ToBoolean(nupAccountType.Value);
            int staff_id = (cbbAccountS.SelectedItem as Staff).Id;

            if (type)
                MessageBox.Show("Hệ thống chỉ có duy nhất 1 tài khoản quản trị viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    if (AccountDAO.Instance.Insert(username, password, type, staff_id))
                    {
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccount();
                    }
                    else
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("Mỗi nhân viên chỉ được sở hữu 1 tài khoản, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelA_Click(object sender, EventArgs e)
        {
            bool type = Convert.ToBoolean(nupAccountType.Value);
            int staff_id = (cbbAccountS.SelectedItem as Staff).Id;

            if (type)
                MessageBox.Show("Không thể xóa tài khoản quản trị viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (AccountDAO.Instance.Delete(staff_id))
                {
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccount();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateA_Click(object sender, EventArgs e)
        {
            string username = tbAccountU.Text;
            string password = tbAccountP.Text;
            bool type = Convert.ToBoolean(nupAccountType.Value);
            int staff_id = (cbbAccountS.SelectedItem as Staff).Id;

            if (type)
                MessageBox.Show("Hệ thống chỉ có duy nhất 1 tài khoản quản trị viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    if (AccountDAO.Instance.Update(username, password, type, staff_id))
                    {
                        MessageBox.Show("Thay đổi thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccount();
                    }
                    else
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("Mỗi nhân viên chỉ được sở hữu 1 tài khoản, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadA_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void tbAccountID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvAccount.SelectedCells.Count > 0)
            {
                int id = (int)dtgvAccount.SelectedCells[0].OwningRow.Cells["staff_id"].Value;

                Staff staff = StaffDAO.Instance.GetStaffByID(id);

                cbbAccountS.SelectedItem = staff;

                int index = -1;

                int i = 0;

                foreach (Staff s in cbbAccountS.Items)
                {
                    if (s.Id == staff.Id)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbbAccountS.SelectedIndex = index;
            }
        }
        #endregion

        #endregion

        #region Methods

        #region Properties
        void Init()
        {
            InitProperties();
            LoadDataSource();
            LoadResource();
            AddBinding();
            Set();
        }

        void LoadResource()
        {
            LoadInvoice();
            LoadCategory();
            LoadProduct();
            LoadCateToProductCbb(cbbProductCate);
            LoadTable();
            LoadStaff();
            LoadAccount();
            LoadStaffToAccountCbb(cbbAccountS);
            LoadCustomer();
        }

        void AddBinding()
        {
            AddProductBinding();
            AddCategoryBinding();
            AddTableBinding();
            AddStaffBinding();
            AddAccountBinding();
            AddCustomerBinding();
        }

        void InitProperties()
        {
            staff_id = GetStaffId();
            username = GetStaffName(staff_id);
            lbUsername.Text += username;
            dtpFrom.Value = dtpTo.Value = DateTime.Now;
            tbDateTime.Text = now.ToString();

        }

        void LoadDataSource()
        {
            dtgvProduct.DataSource = product_source;
            dtgvCategory.DataSource = category_source;
            dtgvTable.DataSource = table_source;
            dtgvStaff.DataSource = staff_source;
            dtgvAccount.DataSource = account_source;
            dtgvCustomer.DataSource = customer_source;
            dtgvDiscount.DataSource = discount_source;
        }

        void Set()
        {
            SetCurrency(dtgvInvoice);
            SetCurrency(dtgvProduct);
        }

        void SetCurrency(DataGridView dtgv)
        {
            List<int> list = GetColumnIndex(dtgv);

            foreach (int item in list)
            {
                dtgv.Columns[item].DefaultCellStyle.FormatProvider = culture;
                dtgv.Columns[item].DefaultCellStyle.Format = "c";
            }
        }

        List<int> GetColumnIndex(DataGridView dtgv)
        {
            List<int> list = new List<int>();
            foreach (DataGridViewColumn column in dtgv.Columns)
            {
                if (column.ValueType == typeof(float) || column.ValueType == typeof(double))
                    list.Add(column.Index);
            }
            return list;
        }

        int GetStaffId()
        {
            List<Working> works = WorkingDAO.Instance.GetWorkingList();
            return works[0].Staff_id;
        }

        string GetStaffName(int id)
        {
            List<Staff> staffs = StaffDAO.Instance.GetStaffListById(id);
            return staffs[0].Name;
        }

        #endregion

        #region Invoice
        void LoadShiftToCbb(ComboBox cbb)
        {
            cbb.DataSource = ShiftDAO.Instance.GetShiftList();
            cbb.DisplayMember = "name";
        }

        void LoadInvoice()
        {
            dtgvInvoice.DataSource = InvoiceDAO.Instance.GetInvoiceList();
        }

        void LoadInvoiceByDates(DateTime from, DateTime to)
        {
            dtgvInvoice.DataSource = InvoiceDAO.Instance.GetInvoiceList(from, to);
        }

        void LoadInvoiceByDate(DateTime created_date)
        {
            dtgvInvoice.DataSource = InvoiceDAO.Instance.GetInvoiceList(created_date);
        }

        void LoadInvoiceByShift(int shift_id)
        {
            dtgvInvoice.DataSource = InvoiceDAO.Instance.GetInvoiceList(shift_id);
        }
        #endregion

        #region Category
        void LoadCategory()
        {
            category_source.DataSource = CategoryDAO.Instance.GetCategoryList();
        }

        void AddCategoryBinding()
        {
            tbCateID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbCateName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Product
        void LoadProduct()
        {
            product_source.DataSource = ProductDAO.Instance.GetProductList();
        }

        void AddProductBinding()
        {
            tbProductID.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbProductName.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "name", true, DataSourceUpdateMode.Never));
            tbProductPath.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "path", true, DataSourceUpdateMode.Never));
            nudProductPrice.DataBindings.Add(new Binding("Value", dtgvProduct.DataSource, "price", true, DataSourceUpdateMode.Never));
            pbProductPhoto.DataBindings.Add(new Binding("Image", dtgvProduct.DataSource, "photo", true));
        }

        void LoadCateToProductCbb(ComboBox cbb)
        {
            cbb.DataSource = CategoryDAO.Instance.GetCategoryList();
            cbb.DisplayMember = "Name";
        }
        #endregion

        #region Table
        void LoadTable()
        {
            table_source.DataSource = TableDAO.Instance.GetTableList();
        }

        void AddTableBinding()
        {
            tbTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "name", true, DataSourceUpdateMode.Never));
            nupTableStatus.DataBindings.Add(new Binding("Value", dtgvTable.DataSource, "status", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Staff
        void LoadStaff()
        {
            staff_source.DataSource = StaffDAO.Instance.GetStaffList();
        }

        void AddStaffBinding()
        {
            tbStaffID.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbStaffName.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "name", true, DataSourceUpdateMode.Never));
            tbStaffPhone.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "phone", true, DataSourceUpdateMode.Never));
            tbStaffAdrress.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "address", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Account
        void LoadAccount()
        {
            account_source.DataSource = AccountDAO.Instance.GetAccountList();
        }

        void AddAccountBinding()
        {
            tbAccountID.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "staff_id", true, DataSourceUpdateMode.Never));
            tbAccountU.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "username", true, DataSourceUpdateMode.Never));
            tbAccountP.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "password", true, DataSourceUpdateMode.Never));
            nupAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "type", true, DataSourceUpdateMode.Never));
        }

        void LoadStaffToAccountCbb(ComboBox cbb)
        {
            cbb.DataSource = StaffDAO.Instance.GetStaffList();
            cbb.DisplayMember = "Name";
        }
        #endregion

        #region Customer
        void LoadCustomer()
        {
            customer_source.DataSource = CustomerDAO.Instance.GetCustomerList();
        }

        void AddCustomerBinding()
        {
            tbCustomerID.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbCustomerName.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "name", true, DataSourceUpdateMode.Never));
            tbCustomerPhone.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "phone", true, DataSourceUpdateMode.Never));
            tbCustomerAddress.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "address", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #endregion
    }
}
