using BusinessCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep.View
{
    public partial class frmDoiMatKhau : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        private bool Checked()
        {
            if((txtMKM.Text == txtNLMKC.Text) && (!string.IsNullOrEmpty(txtMKC.Text)) && (!string.IsNullOrEmpty(txtMKM.Text)) && (!string.IsNullOrEmpty(txtNLMKC.Text)))
                return true;
            return false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (Checked())
                {
                    msql = "exec LoadDoiMatKhau '" + frmDangNhap.MaNguoiDung + "', '" + txtMKC.Text + "', '" + txtNLMKC.Text + "'";
                    DataTable dt = comm.GetDataTable(mconnectstring, msql, "");
                    if(dt != null) 
                        ev.QFrmThongBao("Đổi mật khẩu thành công");
                    else
                        ev.QFrmThongBao("Đổi mật khẩu không thành công");
                }
                else
                    ev.QFrmThongBao("Vui lòng thử lại");
            }
            catch 
            { 
                ev.QFrmThongBaoError("Đổi mật khẩu không thành công. Vui lòng thử lại"); 
            }
        }
    }
}
