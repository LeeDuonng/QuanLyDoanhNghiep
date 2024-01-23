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
    public partial class frmThongTinKhachHang : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id;
        public frmThongTinKhachHang(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                msql = "EXEC SuaKhachHang " +
                 "@MaKhachHang = '" + txtMaKhachHang.Text + "'," +
                 "@HoTen = N'" + txtHoTenKhachHang.Text + "'," +
                 "@DiaChi = N'" + txtDiaChi.Text + "'," +
                 "@SoDienThoai = N'" + txtSoDienThoai.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Sửa thành công");
                this.Close();
            }
            else
            {
                msql = "EXEC ThemKhachHang " +
                 "@MaKhachHang = '" + txtMaKhachHang.Text + "'," +
                 "@HoTen = N'" + txtHoTenKhachHang.Text + "'," +
                 "@DiaChi = N'" + txtDiaChi.Text + "'," +
                 "@SoDienThoai = N'" + txtSoDienThoai.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Thêm thành công");
                this.Close();
            }
        }

        private void frmThongTinKhachHang_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                txtMaKhachHang.Enabled = false;
                msql = "select * from tblKhachHang where MaKhachHang = '" + id + "'";
                DataTable dt = comm.GetDataTable(mconnectstring, msql, "KhachHang");
                txtMaKhachHang.Text = dt.Rows[0]["MaKhachHang"].ToString();
                txtHoTenKhachHang.Text = dt.Rows[0]["HoTen"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtSoDienThoai.Text = dt.Rows[0]["SoDienThoai"].ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            msql = "exec XoaKhachHang '" + id + "'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Xoá thành công");
            this.Hide();
        }
    }
    
}
