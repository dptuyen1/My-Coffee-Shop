namespace MyCoffeeShop.Forms
{
    partial class fInvoice
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInvoice));
            this.dtgvInvoice = new System.Windows.Forms.DataGridView();
            this.label32 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvInvoice
            // 
            this.dtgvInvoice.AllowUserToAddRows = false;
            this.dtgvInvoice.AllowUserToDeleteRows = false;
            this.dtgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvInvoice.Location = new System.Drawing.Point(0, 0);
            this.dtgvInvoice.MultiSelect = false;
            this.dtgvInvoice.Name = "dtgvInvoice";
            this.dtgvInvoice.ReadOnly = true;
            this.dtgvInvoice.RowHeadersWidth = 51;
            this.dtgvInvoice.Size = new System.Drawing.Size(784, 494);
            this.dtgvInvoice.TabIndex = 7;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(362, 519);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(153, 23);
            this.label32.TabIndex = 22;
            this.label32.Text = "Tổng doanh thu:";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotalPrice.DefaultText = "";
            this.tbTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalPrice.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tbTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.tbTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalPrice.Location = new System.Drawing.Point(522, 508);
            this.tbTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.PasswordChar = '\0';
            this.tbTotalPrice.PlaceholderText = "";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.SelectedText = "";
            this.tbTotalPrice.Size = new System.Drawing.Size(250, 40);
            this.tbTotalPrice.TabIndex = 21;
            this.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.dtgvInvoice);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvInvoice;
        private System.Windows.Forms.Label label32;
        private Guna.UI2.WinForms.Guna2TextBox tbTotalPrice;
    }
}