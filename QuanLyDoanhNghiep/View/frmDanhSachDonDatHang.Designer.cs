namespace QuanLyDoanhNghiep.View
{
    partial class frmDanhSachDonDatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbKhachHang = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtGhiChu = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.DateNgayDatHang = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLSDDH = new Guna.UI.WinForms.GunaButton();
            this.txtTongThanhTien = new Guna.UI.WinForms.GunaTextBox();
            this.label1324 = new System.Windows.Forms.Label();
            this.btnHT = new Guna.UI.WinForms.GunaButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbKhachHang);
            this.panel2.Controls.Add(this.gunaLabel7);
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Controls.Add(this.gunaLabel4);
            this.panel2.Controls.Add(this.DateNgayDatHang);
            this.panel2.Controls.Add(this.gunaLabel3);
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 174);
            this.panel2.TabIndex = 0;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cbKhachHang.BaseColor = System.Drawing.Color.White;
            this.cbKhachHang.BorderColor = System.Drawing.Color.Black;
            this.cbKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.cbKhachHang.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhachHang.ForeColor = System.Drawing.Color.Black;
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Items.AddRange(new object[] {
            "Chưa xuất kho",
            "Đã xuất kho"});
            this.cbKhachHang.Location = new System.Drawing.Point(195, 69);
            this.cbKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbKhachHang.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbKhachHang.Radius = 5;
            this.cbKhachHang.Size = new System.Drawing.Size(203, 36);
            this.cbKhachHang.TabIndex = 18;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel7.Location = new System.Drawing.Point(26, 72);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(134, 30);
            this.gunaLabel7.TabIndex = 17;
            this.gunaLabel7.Text = "Khách hàng";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGhiChu.BackColor = System.Drawing.Color.Transparent;
            this.txtGhiChu.BaseColor = System.Drawing.Color.White;
            this.txtGhiChu.BorderColor = System.Drawing.Color.Black;
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGhiChu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGhiChu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(521, 69);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.Radius = 10;
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(319, 93);
            this.txtGhiChu.TabIndex = 14;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel4.Location = new System.Drawing.Point(426, 72);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(91, 30);
            this.gunaLabel4.TabIndex = 11;
            this.gunaLabel4.Text = "Ghi chú";
            // 
            // DateNgayDatHang
            // 
            this.DateNgayDatHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateNgayDatHang.BackColor = System.Drawing.Color.Transparent;
            this.DateNgayDatHang.BaseColor = System.Drawing.Color.White;
            this.DateNgayDatHang.BorderColor = System.Drawing.Color.Black;
            this.DateNgayDatHang.CustomFormat = "yyyy-MM-dd";
            this.DateNgayDatHang.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateNgayDatHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateNgayDatHang.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNgayDatHang.ForeColor = System.Drawing.Color.Black;
            this.DateNgayDatHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNgayDatHang.Location = new System.Drawing.Point(195, 120);
            this.DateNgayDatHang.Margin = new System.Windows.Forms.Padding(2);
            this.DateNgayDatHang.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateNgayDatHang.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateNgayDatHang.Name = "DateNgayDatHang";
            this.DateNgayDatHang.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateNgayDatHang.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateNgayDatHang.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateNgayDatHang.OnPressedColor = System.Drawing.Color.Black;
            this.DateNgayDatHang.Radius = 10;
            this.DateNgayDatHang.Size = new System.Drawing.Size(203, 42);
            this.DateNgayDatHang.TabIndex = 10;
            this.DateNgayDatHang.Text = "2023-12-05";
            this.DateNgayDatHang.Value = new System.DateTime(2023, 12, 5, 13, 37, 13, 767);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.Location = new System.Drawing.Point(26, 120);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(167, 30);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Ngày đặt hàng";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Blue;
            this.gunaLabel1.Location = new System.Drawing.Point(339, 4);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(228, 37);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "ĐƠN ĐẶT HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 587);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(886, 355);
            this.panel4.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 40;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(886, 355);
            this.dgv.TabIndex = 0;
            this.dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv.ThemeStyle.ReadOnly = false;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.RowsStyle.Height = 22;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLSDDH);
            this.panel3.Controls.Add(this.txtTongThanhTien);
            this.panel3.Controls.Add(this.label1324);
            this.panel3.Controls.Add(this.btnHT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 529);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(886, 58);
            this.panel3.TabIndex = 1;
            // 
            // btnLSDDH
            // 
            this.btnLSDDH.AnimationHoverSpeed = 0.07F;
            this.btnLSDDH.AnimationSpeed = 0.03F;
            this.btnLSDDH.BackColor = System.Drawing.Color.Transparent;
            this.btnLSDDH.BaseColor = System.Drawing.Color.Blue;
            this.btnLSDDH.BorderColor = System.Drawing.Color.Black;
            this.btnLSDDH.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLSDDH.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLSDDH.FocusedColor = System.Drawing.Color.Empty;
            this.btnLSDDH.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLSDDH.ForeColor = System.Drawing.Color.White;
            this.btnLSDDH.Image = null;
            this.btnLSDDH.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLSDDH.Location = new System.Drawing.Point(0, 0);
            this.btnLSDDH.Margin = new System.Windows.Forms.Padding(2);
            this.btnLSDDH.Name = "btnLSDDH";
            this.btnLSDDH.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLSDDH.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLSDDH.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLSDDH.OnHoverImage = null;
            this.btnLSDDH.OnPressedColor = System.Drawing.Color.Black;
            this.btnLSDDH.Radius = 15;
            this.btnLSDDH.Size = new System.Drawing.Size(260, 58);
            this.btnLSDDH.TabIndex = 19;
            this.btnLSDDH.Text = "Lịch Sử Đơn Đặt Hàng";
            this.btnLSDDH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLSDDH.Click += new System.EventHandler(this.btnLSDDH_Click);
            // 
            // txtTongThanhTien
            // 
            this.txtTongThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongThanhTien.BackColor = System.Drawing.Color.Transparent;
            this.txtTongThanhTien.BaseColor = System.Drawing.Color.White;
            this.txtTongThanhTien.BorderColor = System.Drawing.Color.Black;
            this.txtTongThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongThanhTien.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTongThanhTien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTongThanhTien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTongThanhTien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongThanhTien.Location = new System.Drawing.Point(514, 10);
            this.txtTongThanhTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongThanhTien.Name = "txtTongThanhTien";
            this.txtTongThanhTien.PasswordChar = '\0';
            this.txtTongThanhTien.Radius = 5;
            this.txtTongThanhTien.ReadOnly = true;
            this.txtTongThanhTien.SelectedText = "";
            this.txtTongThanhTien.Size = new System.Drawing.Size(188, 40);
            this.txtTongThanhTien.TabIndex = 16;
            // 
            // label1324
            // 
            this.label1324.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1324.AutoSize = true;
            this.label1324.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1324.Location = new System.Drawing.Point(324, 14);
            this.label1324.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1324.Name = "label1324";
            this.label1324.Size = new System.Drawing.Size(184, 30);
            this.label1324.TabIndex = 15;
            this.label1324.Text = "Tổng thành tiền:";
            // 
            // btnHT
            // 
            this.btnHT.AnimationHoverSpeed = 0.07F;
            this.btnHT.AnimationSpeed = 0.03F;
            this.btnHT.BackColor = System.Drawing.Color.Transparent;
            this.btnHT.BaseColor = System.Drawing.Color.Blue;
            this.btnHT.BorderColor = System.Drawing.Color.Black;
            this.btnHT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHT.FocusedColor = System.Drawing.Color.Empty;
            this.btnHT.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHT.ForeColor = System.Drawing.Color.White;
            this.btnHT.Image = null;
            this.btnHT.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHT.Location = new System.Drawing.Point(708, 0);
            this.btnHT.Name = "btnHT";
            this.btnHT.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHT.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHT.OnHoverImage = null;
            this.btnHT.OnPressedColor = System.Drawing.Color.Black;
            this.btnHT.Radius = 10;
            this.btnHT.Size = new System.Drawing.Size(178, 58);
            this.btnHT.TabIndex = 0;
            this.btnHT.Text = "Hoàn Thành ";
            this.btnHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHT.Click += new System.EventHandler(this.btnHT_Click);
            // 
            // frmDanhSachDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 587);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDanhSachDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn đặt hàng";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDateTimePicker DateNgayDatHang;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaDataGridView dgv;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton btnHT;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtGhiChu;
        private Guna.UI.WinForms.GunaComboBox cbKhachHang;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtTongThanhTien;
        private System.Windows.Forms.Label label1324;
        private Guna.UI.WinForms.GunaButton btnLSDDH;
    }
}