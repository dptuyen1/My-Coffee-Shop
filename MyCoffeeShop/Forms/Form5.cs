using MyCoffeeShop.DAO;
using System.Globalization;
using System.Windows.Forms;

namespace MyCoffeeShop.Forms
{
    public partial class fDetails : Form
    {
        private int invoice_id;

        private static CultureInfo culture = new CultureInfo("vi-VN");

        public fDetails(int invoice_id)
        {
            this.invoice_id = invoice_id;
            InitializeComponent();
            Init();
        }

        void Init()
        {
            dtgvDetails.DataSource = DetailsDAO.Instance.GetDetailsList(invoice_id);
            dtgvDetails.Columns[2].DefaultCellStyle.FormatProvider = culture;
            dtgvDetails.Columns[2].DefaultCellStyle.Format = "c";
            dtgvDetails.Columns[4].DefaultCellStyle.FormatProvider = culture;
            dtgvDetails.Columns[4].DefaultCellStyle.Format = "c";
        }
    }
}
