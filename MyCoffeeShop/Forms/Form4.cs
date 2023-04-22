using MyCoffeeShop.DAO;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace MyCoffeeShop.Forms
{
    public partial class fInvoice : Form
    {
        private static CultureInfo culture = new CultureInfo("vi-VN");

        private static float total_price;

        public fInvoice()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            DateTime now = DateTime.Now;
            dtgvInvoice.DataSource = InvoiceDAO.Instance.GetInvoiceList(now);
            dtgvInvoice.Columns[6].DefaultCellStyle.FormatProvider = culture;
            dtgvInvoice.Columns[6].DefaultCellStyle.Format = "c";
            total_price = Calculate(dtgvInvoice);
            tbTotalPrice.Text = total_price.ToString("c", culture);
        }

        float Calculate(DataGridView dtgv)
        {
            double total = 0;

            foreach (DataGridViewRow row in dtgv.Rows)
                total += Convert.ToDouble(row.Cells[6].Value);

            return (float)total;
        }
    }
}
