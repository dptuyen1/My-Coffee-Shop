namespace MyCoffeeShop.Forms
{
    partial class fPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPos));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbShift = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCate = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCateAll = new Guna.UI2.WinForms.Guna2GradientButton();
            this.flpProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tbStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTableInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDiscountPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.tbTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelAll = new Guna.UI2.WinForms.Guna2Button();
            this.lvOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSwitchTable = new Guna.UI2.WinForms.Guna2Button();
            this.cbbTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.flpCate.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnLogOut);
            this.guna2GradientPanel1.Controls.Add(this.lbShift);
            this.guna2GradientPanel1.Controls.Add(this.lbUsername);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(144)))), ((int)(((byte)(185)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(199)))), ((int)(((byte)(220)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1664, 100);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogOut.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogOut.ImageRotate = 0F;
            this.btnLogOut.Location = new System.Drawing.Point(1573, 22);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogOut.Size = new System.Drawing.Size(64, 54);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lbShift
            // 
            this.lbShift.AutoSize = true;
            this.lbShift.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShift.Location = new System.Drawing.Point(95, 22);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(104, 23);
            this.lbShift.TabIndex = 0;
            this.lbShift.Text = "Xin chào, ";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(95, 61);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(104, 23);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Xin chào, ";
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 210);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(250, 500);
            this.flpTable.TabIndex = 1;
            // 
            // flpCate
            // 
            this.flpCate.AutoScroll = true;
            this.flpCate.Controls.Add(this.btnCateAll);
            this.flpCate.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCate.Location = new System.Drawing.Point(274, 106);
            this.flpCate.Name = "flpCate";
            this.flpCate.Size = new System.Drawing.Size(650, 130);
            this.flpCate.TabIndex = 0;
            // 
            // btnCateAll
            // 
            this.btnCateAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCateAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCateAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCateAll.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCateAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCateAll.FillColor = System.Drawing.Color.White;
            this.btnCateAll.FillColor2 = System.Drawing.Color.White;
            this.btnCateAll.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCateAll.ForeColor = System.Drawing.Color.Black;
            this.btnCateAll.Location = new System.Drawing.Point(3, 3);
            this.btnCateAll.Name = "btnCateAll";
            this.btnCateAll.Size = new System.Drawing.Size(100, 100);
            this.btnCateAll.TabIndex = 0;
            this.btnCateAll.Text = "Tất cả";
            this.btnCateAll.Click += new System.EventHandler(this.btnCateAll_Click);
            // 
            // flpProduct
            // 
            this.flpProduct.AutoScroll = true;
            this.flpProduct.Location = new System.Drawing.Point(274, 290);
            this.flpProduct.Name = "flpProduct";
            this.flpProduct.Size = new System.Drawing.Size(650, 600);
            this.flpProduct.TabIndex = 2;
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchProduct.DefaultText = "";
            this.tbSearchProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchProduct.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbSearchProduct.ForeColor = System.Drawing.Color.Black;
            this.tbSearchProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchProduct.Location = new System.Drawing.Point(400, 242);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.PasswordChar = '\0';
            this.tbSearchProduct.PlaceholderText = "Nhập từ khóa...";
            this.tbSearchProduct.SelectedText = "";
            this.tbSearchProduct.Size = new System.Drawing.Size(400, 43);
            this.tbSearchProduct.TabIndex = 3;
            this.tbSearchProduct.TextChanged += new System.EventHandler(this.tbSearchProduct_TextChanged);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.tbStaff);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.tbTableInfo);
            this.guna2ShadowPanel1.Controls.Add(this.label6);
            this.guna2ShadowPanel1.Controls.Add(this.tbDiscountPrice);
            this.guna2ShadowPanel1.Controls.Add(this.tbValue);
            this.guna2ShadowPanel1.Controls.Add(this.btnPay);
            this.guna2ShadowPanel1.Controls.Add(this.tbTotalPrice);
            this.guna2ShadowPanel1.Controls.Add(this.label5);
            this.guna2ShadowPanel1.Controls.Add(this.tbDiscount);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.tbCustomer);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.tbSum);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.btnDelAll);
            this.guna2ShadowPanel1.Controls.Add(this.lvOrder);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(930, 100);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(734, 821);
            this.guna2ShadowPanel1.TabIndex = 4;
            // 
            // tbStaff
            // 
            this.tbStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStaff.DefaultText = "";
            this.tbStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStaff.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbStaff.ForeColor = System.Drawing.Color.Black;
            this.tbStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStaff.Location = new System.Drawing.Point(475, 469);
            this.tbStaff.Name = "tbStaff";
            this.tbStaff.PasswordChar = '\0';
            this.tbStaff.PlaceholderText = "";
            this.tbStaff.ReadOnly = true;
            this.tbStaff.SelectedText = "";
            this.tbStaff.Size = new System.Drawing.Size(240, 43);
            this.tbStaff.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nhân viên:";
            // 
            // tbTableInfo
            // 
            this.tbTableInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTableInfo.DefaultText = "";
            this.tbTableInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTableInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTableInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTableInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTableInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTableInfo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbTableInfo.ForeColor = System.Drawing.Color.Black;
            this.tbTableInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTableInfo.Location = new System.Drawing.Point(266, 469);
            this.tbTableInfo.Name = "tbTableInfo";
            this.tbTableInfo.PasswordChar = '\0';
            this.tbTableInfo.PlaceholderText = "";
            this.tbTableInfo.ReadOnly = true;
            this.tbTableInfo.SelectedText = "";
            this.tbTableInfo.Size = new System.Drawing.Size(81, 43);
            this.tbTableInfo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Bàn:";
            // 
            // tbDiscountPrice
            // 
            this.tbDiscountPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiscountPrice.DefaultText = "";
            this.tbDiscountPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiscountPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiscountPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscountPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscountPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiscountPrice.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbDiscountPrice.ForeColor = System.Drawing.Color.Black;
            this.tbDiscountPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiscountPrice.Location = new System.Drawing.Point(561, 616);
            this.tbDiscountPrice.Name = "tbDiscountPrice";
            this.tbDiscountPrice.PasswordChar = '\0';
            this.tbDiscountPrice.PlaceholderText = "";
            this.tbDiscountPrice.ReadOnly = true;
            this.tbDiscountPrice.SelectedText = "";
            this.tbDiscountPrice.Size = new System.Drawing.Size(154, 43);
            this.tbDiscountPrice.TabIndex = 15;
            // 
            // tbValue
            // 
            this.tbValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbValue.DefaultText = "";
            this.tbValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbValue.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbValue.ForeColor = System.Drawing.Color.Black;
            this.tbValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbValue.Location = new System.Drawing.Point(474, 616);
            this.tbValue.Name = "tbValue";
            this.tbValue.PasswordChar = '\0';
            this.tbValue.PlaceholderText = "";
            this.tbValue.ReadOnly = true;
            this.tbValue.SelectedText = "";
            this.tbValue.Size = new System.Drawing.Size(81, 43);
            this.tbValue.TabIndex = 14;
            // 
            // btnPay
            // 
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(18, 753);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(697, 45);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
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
            this.tbTotalPrice.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.tbTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalPrice.Location = new System.Drawing.Point(266, 665);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.PasswordChar = '\0';
            this.tbTotalPrice.PlaceholderText = "";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.SelectedText = "";
            this.tbTotalPrice.Size = new System.Drawing.Size(449, 43);
            this.tbTotalPrice.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 672);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tổng tiền:";
            // 
            // tbDiscount
            // 
            this.tbDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiscount.DefaultText = "";
            this.tbDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiscount.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbDiscount.ForeColor = System.Drawing.Color.Black;
            this.tbDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiscount.Location = new System.Drawing.Point(266, 616);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.PasswordChar = '\0';
            this.tbDiscount.PlaceholderText = "";
            this.tbDiscount.ReadOnly = true;
            this.tbDiscount.SelectedText = "";
            this.tbDiscount.Size = new System.Drawing.Size(202, 43);
            this.tbDiscount.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giảm giá:";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCustomer.DefaultText = "0932012306";
            this.tbCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCustomer.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbCustomer.ForeColor = System.Drawing.Color.Black;
            this.tbCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCustomer.IconRight = ((System.Drawing.Image)(resources.GetObject("tbCustomer.IconRight")));
            this.tbCustomer.Location = new System.Drawing.Point(266, 567);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.PasswordChar = '\0';
            this.tbCustomer.PlaceholderText = "Nhập số điện thoại...";
            this.tbCustomer.SelectedText = "";
            this.tbCustomer.Size = new System.Drawing.Size(449, 43);
            this.tbCustomer.TabIndex = 8;
            this.tbCustomer.IconRightClick += new System.EventHandler(this.tbCustomer_IconRightClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khách hàng:";
            // 
            // tbSum
            // 
            this.tbSum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSum.DefaultText = "";
            this.tbSum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSum.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbSum.ForeColor = System.Drawing.Color.Black;
            this.tbSum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSum.Location = new System.Drawing.Point(266, 518);
            this.tbSum.Name = "tbSum";
            this.tbSum.PasswordChar = '\0';
            this.tbSum.PlaceholderText = "";
            this.tbSum.ReadOnly = true;
            this.tbSum.SelectedText = "";
            this.tbSum.Size = new System.Drawing.Size(449, 43);
            this.tbSum.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tạm tính:";
            // 
            // btnDelAll
            // 
            this.btnDelAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAll.ForeColor = System.Drawing.Color.Black;
            this.btnDelAll.Location = new System.Drawing.Point(675, 14);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(40, 30);
            this.btnDelAll.TabIndex = 2;
            this.btnDelAll.Text = "X";
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // lvOrder
            // 
            this.lvOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvOrder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrder.FullRowSelect = true;
            this.lvOrder.GridLines = true;
            this.lvOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvOrder.HideSelection = false;
            this.lvOrder.Location = new System.Drawing.Point(15, 50);
            this.lvOrder.MultiSelect = false;
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(700, 403);
            this.lvOrder.TabIndex = 1;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            this.lvOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwitchTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSwitchTable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchTable.ForeColor = System.Drawing.Color.Black;
            this.btnSwitchTable.Location = new System.Drawing.Point(130, 736);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(111, 40);
            this.btnSwitchTable.TabIndex = 17;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // cbbTable
            // 
            this.cbbTable.BackColor = System.Drawing.Color.Transparent;
            this.cbbTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTable.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbbTable.ForeColor = System.Drawing.Color.Black;
            this.cbbTable.ItemHeight = 30;
            this.cbbTable.Location = new System.Drawing.Point(24, 740);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(100, 36);
            this.cbbTable.TabIndex = 18;
            // 
            // fPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 921);
            this.Controls.Add(this.cbbTable);
            this.Controls.Add(this.btnSwitchTable);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.flpProduct);
            this.Controls.Add(this.flpCate);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fPos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.TopMost = true;
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.flpCate.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label lbShift;
        private System.Windows.Forms.Label lbUsername;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogOut;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.FlowLayoutPanel flpCate;
        private System.Windows.Forms.FlowLayoutPanel flpProduct;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchProduct;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvOrder;
        private Guna.UI2.WinForms.Guna2Button btnDelAll;
        private Guna.UI2.WinForms.Guna2TextBox tbTotalPrice;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tbDiscount;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbCustomer;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbSum;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnSwitchTable;
        private Guna.UI2.WinForms.Guna2GradientButton btnCateAll;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2TextBox tbValue;
        private Guna.UI2.WinForms.Guna2TextBox tbDiscountPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbTableInfo;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTable;
        private Guna.UI2.WinForms.Guna2TextBox tbStaff;
        private System.Windows.Forms.Label label7;
    }
}