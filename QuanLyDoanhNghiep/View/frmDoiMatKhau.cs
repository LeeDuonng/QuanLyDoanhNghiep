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

        private void txtNLMKC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMKM.Text !=  txtNLMKC.Text)
            {
                label.Text = "Nhập lại mật khẩu mới chưa trùng khớp";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                msql = "exec LoadDoiMatKhau '" + frmDangNhap.MaNguoiDung + "', '" + txtMKC.Text + "', '" + txtNLMKC.Text + "'";
                DataTable dt = comm.GetDataTable(mconnectstring, msql, "");
                ev.QFrmThongBao("Đổi mật khẩu thành công");
            }
            catch 
            { 
                ev.QFrmThongBaoError("Đổi mật khẩu không thành công. Vui lòng thử lại"); 
            }
        }
    }
}
