namespace QuanLyDoanhNghiep.View
{
    partial class frmThongTinCongViec
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
            this.dateNgayBatDau = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cbMaPhongBan = new Guna.UI.WinForms.GunaComboBox();
            this.cbMaChucVu = new Guna.UI.WinForms.GunaComboBox();
            this.txtMucLuong = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnLuu = new Guna.UI.WinForms.GunaButton();
            this.dateNgayKetThuc = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.pcb = new System.Windows.Forms.PictureBox();
            this.cbMaNguoiDung = new Guna.UI.WinForms.GunaComboBox();
            this.txtMaNguoiDung = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNgayBatDau
            // 
            this.dateNgayBatDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateNgayBatDau.BackColor = System.Drawing.Color.Transparent;
            this.dateNgayBatDau.BaseColor = System.Drawing.Color.White;
            this.dateNgayBatDau.BorderColor = System.Drawing.Color.Black;
            this.dateNgayBatDau.CustomFormat = "yyyy-MM-dd";
            this.dateNgayBatDau.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateNgayBatDau.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayBatDau.ForeColor = System.Drawing.Color.Black;
            this.dateNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayBatDau.Location = new System.Drawing.Point(212, 330);
            this.dateNgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dateNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayBatDau.Name = "dateNgayBatDau";
            this.dateNgayBatDau.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateNgayBatDau.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateNgayBatDau.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateNgayBatDau.OnPressedColor = System.Drawing.Color.Black;
            this.dateNgayBatDau.Radius = 10;
            this.dateNgayBatDau.Size = new System.Drawing.Size(214, 39);
            this.dateNgayBatDau.TabIndex = 63;
            this.dateNgayBatDau.Text = "2023-11-30";
            this.dateNgayBatDau.Value = new System.DateTime(2023, 11, 30, 0, 0, 0, 0);
            // 
            // cbMaPhongBan
            // 
            this.cbMaPhongBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.cbMaPhongBan.BaseColor = System.Drawing.Color.White;
            this.cbMaPhongBan.BorderColor = System.Drawing.Color.Black;
            this.cbMaPhongBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPhongBan.FocusedColor = System.Drawing.Color.Empty;
            this.cbMaPhongBan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaPhongBan.ForeColor = System.Drawing.Color.Black;
            this.cbMaPhongBan.FormattingEnabled = true;
            this.cbMaPhongBan.Location = new System.Drawing.Point(212, 277);
            this.cbMaPhongBan.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaPhongBan.Name = "cbMaPhongBan";
            this.cbMaPhongBan.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbMaPhongBan.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbMaPhongBan.Radius = 10;
            this.cbMaPhongBan.Size = new System.Drawing.Size(214, 36);
            this.cbMaPhongBan.TabIndex = 62;
            // 
            // cbMaChucVu
            // 
            this.cbMaChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cbMaChucVu.BaseColor = System.Drawing.Color.White;
            this.cbMaChucVu.BorderColor = System.Drawing.Color.Black;
            this.cbMaChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaChucVu.FocusedColor = System.Drawing.Color.Empty;
            this.cbMaChucVu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaChucVu.ForeColor = System.Drawing.Color.Black;
            this.cbMaChucVu.FormattingEnabled = true;
            this.cbMaChucVu.Location = new System.Drawing.Point(612, 277);
            this.cbMaChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaChucVu.Name = "cbMaChucVu";
            this.cbMaChucVu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbMaChucVu.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbMaChucVu.Radius = 10;
            this.cbMaChucVu.Size = new System.Drawing.Size(230, 36);
            this.cbMaChucVu.TabIndex = 61;
            // 
            // txtMucLuong
            // 
            this.txtMucLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMucLuong.BackColor = System.Drawing.Color.Transparent;
            this.txtMucLuong.BaseColor = System.Drawing.Color.White;
            this.txtMucLuong.BorderColor = System.Drawing.Color.Black;
            this.txtMucLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMucLuong.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMucLuong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMucLuong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMucLuong.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucLuong.Location = new System.Drawing.Point(612, 221);
            this.txtMucLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtMucLuong.Name = "txtMucLuong";
            this.txtMucLuong.PasswordChar = '\0';
            this.txtMucLuong.Radius = 10;
            this.txtMucLuong.SelectedText = "";
            this.txtMucLuong.Size = new System.Drawing.Size(230, 38);
            this.txtMucLuong.TabIndex = 58;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(62, 330);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(148, 30);
            this.gunaLabel7.TabIndex = 56;
            this.gunaLabel7.Text = "Ngày Bắt Đầu";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(453, 221);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(127, 30);
            this.gunaLabel5.TabIndex = 55;
            this.gunaLabel5.Text = "Mức Lương";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(62, 277);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(121, 30);
            this.gunaLabel3.TabIndex = 54;
            this.gunaLabel3.Text = "Phòng Ban";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(453, 277);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 30);
            this.gunaLabel2.TabIndex = 53;
            this.gunaLabel2.Text = "Chức Vụ";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(62, 221);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 30);
            this.gunaLabel1.TabIndex = 52;
            this.gunaLabel1.Text = "Người Dùng";
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
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = null;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(465, 395);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 15;
            this.btnXoa.Size = new System.Drawing.Size(88, 37);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = null;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(379, 395);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Radius = 15;
            this.btnLuu.Size = new System.Drawing.Size(81, 37);
            this.btnLuu.TabIndex = 66;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dateNgayKetThuc
            // 
            this.dateNgayKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateNgayKetThuc.BackColor = System.Drawing.Color.Transparent;
            this.dateNgayKetThuc.BaseColor = System.Drawing.Color.White;
            this.dateNgayKetThuc.BorderColor = System.Drawing.Color.Black;
            this.dateNgayKetThuc.CustomFormat = "yyyy-MM-dd";
            this.dateNgayKetThuc.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateNgayKetThuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayKetThuc.ForeColor = System.Drawing.Color.Black;
            this.dateNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayKetThuc.Location = new System.Drawing.Point(612, 330);
            this.dateNgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dateNgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayKetThuc.Name = "dateNgayKetThuc";
            this.dateNgayKetThuc.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateNgayKetThuc.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateNgayKetThuc.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateNgayKetThuc.OnPressedColor = System.Drawing.Color.Black;
            this.dateNgayKetThuc.Radius = 10;
            this.dateNgayKetThuc.Size = new System.Drawing.Size(230, 39);
            this.dateNgayKetThuc.TabIndex = 69;
            this.dateNgayKetThuc.Text = "2023-11-30";
            this.dateNgayKetThuc.Value = new System.DateTime(2023, 11, 30, 0, 0, 0, 0);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(453, 330);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(152, 30);
            this.gunaLabel4.TabIndex = 68;
            this.gunaLabel4.Text = "Ngày Hết Hạn";
            // 
            // pcb
            // 
            this.pcb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb.Location = new System.Drawing.Point(297, 22);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(317, 176);
            this.pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb.TabIndex = 70;
            this.pcb.TabStop = false;
            // 
            // cbMaNguoiDung
            // 
            this.cbMaNguoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.cbMaNguoiDung.BaseColor = System.Drawing.Color.White;
            this.cbMaNguoiDung.BorderColor = System.Drawing.Color.Black;
            this.cbMaNguoiDung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNguoiDung.FocusedColor = System.Drawing.Color.Empty;
            this.cbMaNguoiDung.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNguoiDung.ForeColor = System.Drawing.Color.Black;
            this.cbMaNguoiDung.FormattingEnabled = true;
            this.cbMaNguoiDung.Location = new System.Drawing.Point(212, 218);
            this.cbMaNguoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaNguoiDung.Name = "cbMaNguoiDung";
            this.cbMaNguoiDung.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbMaNguoiDung.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbMaNguoiDung.Radius = 10;
            this.cbMaNguoiDung.Size = new System.Drawing.Size(214, 36);
            this.cbMaNguoiDung.TabIndex = 71;
            this.cbMaNguoiDung.Visible = false;
            // 
            // txtMaNguoiDung
            // 
            this.txtMaNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.txtMaNguoiDung.BaseColor = System.Drawing.Color.White;
            this.txtMaNguoiDung.BorderColor = System.Drawing.Color.Silver;
            this.txtMaNguoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNguoiDung.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaNguoiDung.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaNguoiDung.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaNguoiDung.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNguoiDung.Location = new System.Drawing.Point(212, 218);
            this.txtMaNguoiDung.Name = "txtMaNguoiDung";
            this.txtMaNguoiDung.PasswordChar = '\0';
            this.txtMaNguoiDung.Radius = 10;
            this.txtMaNguoiDung.SelectedText = "";
            this.txtMaNguoiDung.Size = new System.Drawing.Size(214, 38);
            this.txtMaNguoiDung.TabIndex = 72;
            this.txtMaNguoiDung.Visible = false;
            // 
            // frmThongTinCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 470);
            this.Controls.Add(this.txtMaNguoiDung);
            this.Controls.Add(this.cbMaNguoiDung);
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.dateNgayKetThuc);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dateNgayBatDau);
            this.Controls.Add(this.cbMaPhongBan);
            this.Controls.Add(this.cbMaChucVu);
            this.Controls.Add(this.txtMucLuong);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThongTinCongViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công Việc";
            this.Load += new System.EventHandler(this.frmThongTinCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDateTimePicker dateNgayBatDau;
        private Guna.UI.WinForms.GunaComboBox cbMaPhongBan;
        private Guna.UI.WinForms.GunaComboBox cbMaChucVu;
        private Guna.UI.WinForms.GunaTextBox txtMucLuong;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnLuu;
        private Guna.UI.WinForms.GunaDateTimePicker dateNgayKetThuc;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.PictureBox pcb;
        private Guna.UI.WinForms.GunaComboBox cbMaNguoiDung;
        private Guna.UI.WinForms.GunaTextBox txtMaNguoiDung;
    }
}