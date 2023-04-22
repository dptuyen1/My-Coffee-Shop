namespace MyCoffeeShop.Controls
{
    partial class ucProduct
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDelProduct = new Guna.UI2.WinForms.Guna2Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pbPhoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnDelProduct);
            this.guna2Panel1.Controls.Add(this.lbPrice);
            this.guna2Panel1.Controls.Add(this.lbName);
            this.guna2Panel1.Controls.Add(this.pbPhoto);
            this.guna2Panel1.Controls.Add(this.btnAddProduct);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(300, 200);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(229)))));
            this.btnDelProduct.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProduct.ForeColor = System.Drawing.Color.Black;
            this.btnDelProduct.Location = new System.Drawing.Point(3, 146);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(294, 50);
            this.btnDelProduct.TabIndex = 4;
            this.btnDelProduct.Text = "Xóa sản phẩm";
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(98, 57);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(51, 19);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "label2";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(98, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 19);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "label1";
            // 
            // pbPhoto
            // 
            this.pbPhoto.ImageRotate = 0F;
            this.pbPhoto.Location = new System.Drawing.Point(10, 10);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(70, 70);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 1;
            this.pbPhoto.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(229)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 90);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(294, 50);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm sản phẩm";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(300, 200);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private Guna.UI2.WinForms.Guna2PictureBox pbPhoto;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private Guna.UI2.WinForms.Guna2Button btnDelProduct;
    }
}
