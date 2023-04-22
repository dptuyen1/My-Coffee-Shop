using MyCoffeeShop.DAO;
using System.Windows.Forms;

namespace MyCoffeeShop.Forms
{
    public partial class fDetails : Form
    {
        private int invoice_id;

        public fDetails(int invoice_id)
        {
            this.invoice_id = invoice_id;
            InitializeComponent();
            Init();
        }

        void Init()
        {
            dtgvDetails.DataSource = DetailsDAO.Instance.GetDetailsList(invoice_id);
        }
    }
}
