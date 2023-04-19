using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyCoffeeShop.Controls
{
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        public event EventHandler clickAdd = null;

        public event EventHandler clickRemove = null;

        #region Events
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            clickAdd?.Invoke(this, e);
        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            clickRemove?.Invoke(this, e);
        }
        #endregion

        #region Methods
        public string Title { get => lbName.Text; set => lbName.Text = value; }
        public string Price { get => lbPrice.Text; set => lbPrice.Text = value; }
        public Image Photo { get => pbPhoto.Image; set => pbPhoto.Image = value; }
        #endregion
    }
}
