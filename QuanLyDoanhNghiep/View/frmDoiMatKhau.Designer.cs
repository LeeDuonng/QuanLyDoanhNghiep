namespace QuanLyDoanhNghiep.View
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnOk = new Guna.UI.WinForms.GunaButton();
            this.txtMKC = new Guna.UI.WinForms.GunaTextBox();
            this.txtMKM = new Guna.UI.WinForms.GunaTextBox();
            this.txtNLMKC = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHuy = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(121, 361);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.AnimationHoverSpeed = 0.07F;
            this.btnOk.AnimationSpeed = 0.03F;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BaseColor = System.Drawing.Color.Blue;
            this.btnOk.BorderColor = System.Drawing.Color.Black;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOk.FocusedColor = System.Drawing.Color.Empty;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Image = null;
            this.btnOk.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOk.Location = new System.Drawing.Point(260, 407);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOk.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOk.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOk.OnHoverImage = null;
            this.btnOk.OnPressedColor = System.Drawing.Color.Black;
            this.btnOk.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Radius = 15;
            this.btnOk.Size = new System.Drawing.Size(118, 47);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtMKC
            // 
            this.txtMKC.BackColor = System.Drawing.Color.Transparent;
            this.txtMKC.BaseColor = System.Drawing.Color.White;
            this.txtMKC.BorderColor = System.Drawing.Color.Black;
            this.txtMKC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKC.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMKC.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMKC.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMKC.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKC.Location = new System.Drawing.Point(284, 187);
            this.txtMKC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.PasswordChar = '*';
            this.txtMKC.Radius = 15;
            this.txtMKC.SelectedText = "";
            this.txtMKC.Size = new System.Drawing.Size(202, 39);
            this.txtMKC.TabIndex = 11;
            // 
            // txtMKM
            // 
            this.txtMKM.BackColor = System.Drawing.Color.Transparent;
            this.txtMKM.BaseColor = System.Drawing.Color.White;
            this.txtMKM.BorderColor = System.Drawing.Color.Black;
            this.txtMKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKM.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMKM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMKM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMKM.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKM.Location = new System.Drawing.Point(284, 254);
            this.txtMKM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '*';
            this.txtMKM.Radius = 15;
            this.txtMKM.SelectedText = "";
            this.txtMKM.Size = new System.Drawing.Size(202, 39);
            this.txtMKM.TabIndex = 12;
            // 
            // txtNLMKC
            // 
            this.txtNLMKC.BackColor = System.Drawing.Color.Transparent;
            this.txtNLMKC.BaseColor = System.Drawing.Color.White;
            this.txtNLMKC.BorderColor = System.Drawing.Color.Black;
            this.txtNLMKC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNLMKC.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNLMKC.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNLMKC.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNLMKC.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNLMKC.Location = new System.Drawing.Point(284, 325);
            this.txtNLMKC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNLMKC.Name = "txtNLMKC";
            this.txtNLMKC.PasswordChar = '*';
            this.txtNLMKC.Radius = 15;
            this.txtNLMKC.SelectedText = "";
            this.txtNLMKC.Size = new System.Drawing.Size(202, 39);
            this.txtNLMKC.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.AnimationHoverSpeed = 0.07F;
            this.btnHuy.AnimationSpeed = 0.03F;
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.BaseColor = System.Drawing.Color.Red;
            this.btnHuy.BorderColor = System.Drawing.Color.Black;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = null;
            this.btnHuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuy.Location = new System.Drawing.Point(123, 407);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuy.OnHoverImage = null;
            this.btnHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuy.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Radius = 15;
            this.btnHuy.Size = new System.Drawing.Size(118, 47);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 501);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNLMKC);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.txtMKC);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private Guna.UI.WinForms.GunaButton btnOk;
        private Guna.UI.WinForms.GunaTextBox txtMKC;
        private Guna.UI.WinForms.GunaTextBox txtMKM;
        private Guna.UI.WinForms.GunaTextBox txtNLMKC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnHuy;
    }
}