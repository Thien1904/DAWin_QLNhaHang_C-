namespace Quanlynhahang
{
    partial class tablequanli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tablequanli));
            this.cbbdanhmuc = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addmon = new System.Windows.Forms.Button();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenmonan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmmon = new System.Windows.Forms.NumericUpDown();
            this.cbbtenmon = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.admin = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phímTắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónĐangChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.tongtien = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.TextBox();
            this.btngiamgia = new System.Windows.Forms.Button();
            this.nmgiamgia = new System.Windows.Forms.NumericUpDown();
            this.flbban = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmmon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmgiamgia)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbdanhmuc
            // 
            this.cbbdanhmuc.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbdanhmuc.FormattingEnabled = true;
            this.cbbdanhmuc.Location = new System.Drawing.Point(118, 2);
            this.cbbdanhmuc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbdanhmuc.Name = "cbbdanhmuc";
            this.cbbdanhmuc.Size = new System.Drawing.Size(340, 26);
            this.cbbdanhmuc.TabIndex = 1;
            this.cbbdanhmuc.SelectedIndexChanged += new System.EventHandler(this.cbbdanhmuc_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addmon);
            this.panel3.Controls.Add(this.lsvBill);
            this.panel3.Controls.Add(this.tenmonan);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.nmmon);
            this.panel3.Controls.Add(this.cbbtenmon);
            this.panel3.Controls.Add(this.cbbdanhmuc);
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(614, 500);
            this.panel3.TabIndex = 5;
            // 
            // addmon
            // 
            this.addmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addmon.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.addmon.FlatAppearance.BorderSize = 2;
            this.addmon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmon.ForeColor = System.Drawing.Color.Black;
            this.addmon.Image = ((System.Drawing.Image)(resources.GetObject("addmon.Image")));
            this.addmon.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addmon.Location = new System.Drawing.Point(462, 3);
            this.addmon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addmon.Name = "addmon";
            this.addmon.Size = new System.Drawing.Size(83, 50);
            this.addmon.TabIndex = 15;
            this.addmon.Text = "Thêm món";
            this.addmon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addmon.UseVisualStyleBackColor = false;
            this.addmon.Click += new System.EventHandler(this.addmon_Click_1);
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.Color.Gainsboro;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.ForeColor = System.Drawing.Color.Red;
            this.lsvBill.GridLines = true;
            this.lsvBill.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lsvBill.Location = new System.Drawing.Point(3, 57);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(608, 443);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 290;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá mỗi món";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 125;
            // 
            // tenmonan
            // 
            this.tenmonan.AutoSize = true;
            this.tenmonan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tenmonan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tenmonan.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.tenmonan.ForeColor = System.Drawing.Color.DarkGreen;
            this.tenmonan.Location = new System.Drawing.Point(10, 30);
            this.tenmonan.Name = "tenmonan";
            this.tenmonan.Size = new System.Drawing.Size(96, 21);
            this.tenmonan.TabIndex = 4;
            this.tenmonan.Text = "Tên món ăn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại món ăn :\r\n";
            // 
            // nmmon
            // 
            this.nmmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nmmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmmon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nmmon.Location = new System.Drawing.Point(549, 19);
            this.nmmon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nmmon.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmmon.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nmmon.Name = "nmmon";
            this.nmmon.Size = new System.Drawing.Size(54, 24);
            this.nmmon.TabIndex = 3;
            this.nmmon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbtenmon
            // 
            this.cbbtenmon.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbtenmon.FormattingEnabled = true;
            this.cbbtenmon.Location = new System.Drawing.Point(118, 30);
            this.cbbtenmon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbtenmon.Name = "cbbtenmon";
            this.cbbtenmon.Size = new System.Drawing.Size(342, 26);
            this.cbbtenmon.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admin,
            this.tàiKhoảnToolStripMenuItem,
            this.phímTắtToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // admin
            // 
            this.admin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.admin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.admin.ForeColor = System.Drawing.Color.Blue;
            this.admin.Image = ((System.Drawing.Image)(resources.GetObject("admin.Image")));
            this.admin.ImageTransparentColor = System.Drawing.Color.White;
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(81, 24);
            this.admin.Text = "Admin";
            this.admin.ToolTipText = "Quản Lí Phần Mềm:\r\n+ Quản Lí Tài Khoản\r\n+ Quản Lí Bàn Ăn\r\n+ Quản Lí Thức Ăn\r\n+ Qu" +
    "ản Lí Doanh Thu\r\n";
            this.admin.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.tàiKhoảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tàiKhoảnToolStripMenuItem.Image")));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Thông Tin Cá Nhân";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // phímTắtToolStripMenuItem
            // 
            this.phímTắtToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.phímTắtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem,
            this.thêmMónĐangChọnToolStripMenuItem,
            this.đóngChươngTrìnhToolStripMenuItem});
            this.phímTắtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phímTắtToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.phímTắtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phímTắtToolStripMenuItem.Image")));
            this.phímTắtToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.phímTắtToolStripMenuItem.Name = "phímTắtToolStripMenuItem";
            this.phímTắtToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.phímTắtToolStripMenuItem.Text = "Phím Tắt";
            this.phímTắtToolStripMenuItem.ToolTipText = "Các Phím Tắt Nhanh";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(294, 24);
            this.thanhToánToolStripMenuItem.Text = "Thanh Toán ";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // thêmMónĐangChọnToolStripMenuItem
            // 
            this.thêmMónĐangChọnToolStripMenuItem.Name = "thêmMónĐangChọnToolStripMenuItem";
            this.thêmMónĐangChọnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.thêmMónĐangChọnToolStripMenuItem.Size = new System.Drawing.Size(294, 24);
            this.thêmMónĐangChọnToolStripMenuItem.Text = "Thêm Món Đang Chọn";
            this.thêmMónĐangChọnToolStripMenuItem.Click += new System.EventHandler(this.thêmMónĐangChọnToolStripMenuItem_Click);
            // 
            // đóngChươngTrìnhToolStripMenuItem
            // 
            this.đóngChươngTrìnhToolStripMenuItem.Name = "đóngChươngTrìnhToolStripMenuItem";
            this.đóngChươngTrìnhToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.đóngChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(294, 24);
            this.đóngChươngTrìnhToolStripMenuItem.Text = "Đóng Chương Trình";
            this.đóngChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.đóngChươngTrìnhToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.đăngXuấtToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngXuấtToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.đăngXuấtToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem1.Image")));
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(104, 24);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.đăngXuấtToolStripMenuItem1.ToolTipText = "Đăng Xuất Khỏi Tài Khoản Hiện Tại";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click_1);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnthanhtoan.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnthanhtoan.FlatAppearance.BorderSize = 2;
            this.btnthanhtoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnthanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.ForeColor = System.Drawing.Color.Black;
            this.btnthanhtoan.Location = new System.Drawing.Point(500, 532);
            this.btnthanhtoan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(83, 50);
            this.btnthanhtoan.TabIndex = 11;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = false;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lbTotalPrice.Location = new System.Drawing.Point(180, 546);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(113, 24);
            this.lbTotalPrice.TabIndex = 14;
            this.lbTotalPrice.Text = "Tổng Tiền:";
            // 
            // tongtien
            // 
            this.tongtien.BackColor = System.Drawing.Color.White;
            this.tongtien.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tongtien.Location = new System.Drawing.Point(290, 542);
            this.tongtien.Multiline = true;
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            this.tongtien.Size = new System.Drawing.Size(145, 28);
            this.tongtien.TabIndex = 12;
            this.tongtien.Text = "0";
            this.tongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.select.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select.ForeColor = System.Drawing.Color.Red;
            this.select.Location = new System.Drawing.Point(778, 46);
            this.select.Multiline = true;
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(300, 27);
            this.select.TabIndex = 15;
            this.toolTip1.SetToolTip(this.select, "Tên Tài Khoản Đang Đăng Nhập");
            // 
            // btngiamgia
            // 
            this.btngiamgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngiamgia.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btngiamgia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btngiamgia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiamgia.Location = new System.Drawing.Point(11, 542);
            this.btngiamgia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btngiamgia.Name = "btngiamgia";
            this.btngiamgia.Size = new System.Drawing.Size(114, 40);
            this.btngiamgia.TabIndex = 0;
            this.btngiamgia.Text = "Giảm \r\nGiá(%)";
            this.btngiamgia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngiamgia.UseVisualStyleBackColor = false;
            // 
            // nmgiamgia
            // 
            this.nmgiamgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nmgiamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmgiamgia.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nmgiamgia.Location = new System.Drawing.Point(66, 552);
            this.nmgiamgia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nmgiamgia.Name = "nmgiamgia";
            this.nmgiamgia.Size = new System.Drawing.Size(54, 24);
            this.nmgiamgia.TabIndex = 1;
            this.nmgiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flbban
            // 
            this.flbban.AutoScroll = true;
            this.flbban.ForeColor = System.Drawing.Color.Yellow;
            this.flbban.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flbban.Location = new System.Drawing.Point(621, 87);
            this.flbban.Name = "flbban";
            this.flbban.Size = new System.Drawing.Size(528, 496);
            this.flbban.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(619, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 27);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Tình Trạng Đăng Nhập";
            // 
            // tablequanli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1149, 582);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.nmgiamgia);
            this.Controls.Add(this.btngiamgia);
            this.Controls.Add(this.tongtien);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.flbban);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "tablequanli";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Nhà Hàng";
            this.TransparencyKey = System.Drawing.Color.Navy;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tablequanli_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmmon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmgiamgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbdanhmuc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nmmon;
        private System.Windows.Forms.ComboBox cbbtenmon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admin;
        private System.Windows.Forms.Label tenmonan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.TextBox tongtien;
        private System.Windows.Forms.Button addmon;
        private System.Windows.Forms.TextBox select;
        private System.Windows.Forms.Button btngiamgia;
        private System.Windows.Forms.NumericUpDown nmgiamgia;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel flbban;
        private System.Windows.Forms.ToolStripMenuItem phímTắtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónĐangChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
    }
}