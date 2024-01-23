namespace QuanLyDoanhNghiep
{
    partial class frmThongTinDonDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinDonDatHang));
            this.txtMaDonDatHang = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbMaKhachHang = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cbMaSanPham = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtSoLuong = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.dateNgayDatHang = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnLuu = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // txtMaDonDatHang
            // 
            this.txtMaDonDatHang.BackColor = System.Drawing.Color.Transparent;
            this.txtMaDonDatHang.BaseColor = System.Drawing.Color.White;
            this.txtMaDonDatHang.BorderColor = System.Drawing.Color.Black;
            this.txtMaDonDatHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDonDatHang.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaDonDatHang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaDonDatHang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaDonDatHang.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonDatHang.Location = new System.Drawing.Point(237, 41);
            this.txtMaDonDatHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDonDatHang.Name = "txtMaDonDatHang";
            this.txtMaDonDatHang.PasswordChar = '\0';
            this.txtMaDonDatHang.Radius = 10;
            this.txtMaDonDatHang.SelectedText = "";
            this.txtMaDonDatHang.Size = new System.Drawing.Size(200, 39);
            this.txtMaDonDatHang.TabIndex = 8;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(27, 46);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(206, 30);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Mã Đơn Đặt Hàng ";
            // 
            // cbMaKhachHang
            // 
            this.cbMaKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cbMaKhachHang.BaseColor = System.Drawing.Color.White;
            this.cbMaKhachHang.BorderColor = System.Drawing.Color.Black;
            this.cbMaKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.cbMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKhachHang.ForeColor = System.Drawing.Color.Black;
            this.cbMaKhachHang.FormattingEnabled = true;
            this.cbMaKhachHang.Location = new System.Drawing.Point(237, 96);
            this.cbMaKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaKhachHang.Name = "cbMaKhachHang";
            this.cbMaKhachHang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbMaKhachHang.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbMaKhachHang.Radius = 10;
            this.cbMaKhachHang.Size = new System.Drawing.Size(200, 37);
            this.cbMaKhachHang.TabIndex = 11;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(27, 99);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(183, 30);
            this.gunaLabel2.TabIndex = 10;
            this.gunaLabel2.Text = "Mã Khách Hàng ";
            // 
            // cbMaSanPham
            // 
            this.cbMaSanPham.BackColor = System.Drawing.Color.Transparent;
            this.cbMaSanPham.BaseColor = System.Drawing.Color.White;
            this.cbMaSanPham.BorderColor = System.Drawing.Color.Black;
            this.cbMaSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSanPham.FocusedColor = System.Drawing.Color.Empty;
            this.cbMaSanPham.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSanPham.ForeColor = System.Drawing.Color.Black;
            this.cbMaSanPham.FormattingEnabled = true;
            this.cbMaSanPham.Location = new System.Drawing.Point(237, 149);
            this.cbMaSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaSanPham.Name = "cbMaSanPham";
            this.cbMaSanPham.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbMaSanPham.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbMaSanPham.Radius = 10;
            this.cbMaSanPham.Size = new System.Drawing.Size(200, 37);
            this.cbMaSanPham.TabIndex = 13;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(27, 152);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(160, 30);
            this.gunaLabel3.TabIndex = 12;
            this.gunaLabel3.Text = "Mã Sản Phẩm ";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.txtSoLuong.BaseColor = System.Drawing.Color.White;
            this.txtSoLuong.BorderColor = System.Drawing.Color.Black;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSoLuong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSoLuong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(237, 201);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.Radius = 10;
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(200, 39);
            this.txtSoLuong.TabIndex = 15;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(27, 207);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(117, 30);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "Số Lượng ";
            // 
            // dateNgayDatHang
            // 
            this.dateNgayDatHang.BackColor = System.Drawing.Color.Transparent;
            this.dateNgayDatHang.BaseColor = System.Drawing.Color.White;
            this.dateNgayDatHang.BorderColor = System.Drawing.Color.Black;
            this.dateNgayDatHang.CustomFormat = "yyyy-MM-dd";
            this.dateNgayDatHang.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateNgayDatHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateNgayDatHang.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayDatHang.ForeColor = System.Drawing.Color.Black;
            this.dateNgayDatHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayDatHang.Location = new System.Drawing.Point(237, 256);
            this.dateNgayDatHang.Margin = new System.Windows.Forms.Padding(2);
            this.dateNgayDatHang.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayDatHang.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayDatHang.Name = "dateNgayDatHang";
            this.dateNgayDatHang.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateNgayDatHang.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateNgayDatHang.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateNgayDatHang.OnPressedColor = System.Drawing.Color.Black;
            this.dateNgayDatHang.Radius = 10;
            this.dateNgayDatHang.Size = new System.Drawing.Size(200, 48);
            this.dateNgayDatHang.TabIndex = 55;
            this.dateNgayDatHang.Text = "2023-11-30";
            this.dateNgayDatHang.Value = new System.DateTime(2023, 11, 30, 18, 43, 58, 863);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(27, 263);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(179, 30);
            this.gunaLabel5.TabIndex = 54;
            this.gunaLabel5.Text = "Ngày Đặt Hàng ";
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BaseColor = System.Drawing.Color.Red;
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = null;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(207, 329);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 15;
            this.btnXoa.Size = new System.Drawing.Size(100, 47);
            this.btnXoa.TabIndex = 57;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLuu
            // 
            this.btnLuu.AnimationHoverSpeed = 0.07F;
            this.btnLuu.AnimationSpeed = 0.03F;
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = null;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(103, 329);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Radius = 15;
            this.btnLuu.Size = new System.Drawing.Size(100, 47);
            this.btnLuu.TabIndex = 67;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmThongTinDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 405);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dateNgayDatHang);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.cbMaSanPham);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cbMaKhachHang);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtMaDonDatHang);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThongTinDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtMaDonDatHang;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbMaKhachHang;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cbMaSanPham;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtSoLuong;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDateTimePicker dateNgayDatHang;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnLuu;
    }
}