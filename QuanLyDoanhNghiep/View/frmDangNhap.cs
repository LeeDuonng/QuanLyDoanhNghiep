using BusinessCommon;
using QuanLyDoanhNghiep.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep
{
    public partial class frmDangNhap : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public static string MaNguoiDung;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTaiKhoan.Text) && !string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    msql = "exec LoadDangNhap '" + txtTaiKhoan.Text + "', '" + txtMatKhau.Text + "'";
                    DataTable dt = comm.GetDataTable(mconnectstring, msql, "haha");
                    if (dt != null)
                    {
                        MaNguoiDung = dt.Rows[0]["MaNguoiDung"].ToString();
                        frm_Menu frm_Menu = new frm_Menu();
                        this.Hide();
                        frm_Menu.ShowDialog();
                    }
                    else
                    {
                        ev.QFrmThongBaoError("Tài khoản hoặc mật khẩu không chính xác !");
                    }
                }
                else
                {
                    ev.QFrmThongBaoError("Vui lòng nhập đầy đủ thông tin !");
                }
            }
            catch
            {
                ev.QFrmThongBaoError("Tài khoản hoặc mật khẩu không chính xác !");
            }
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPassword.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }
    }
}
