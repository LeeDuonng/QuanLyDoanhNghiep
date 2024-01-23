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
    public partial class frmThongTinNhaCungCap : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id;
        public frmThongTinNhaCungCap(string id)
        {
            InitializeComponent();
            this.id = id;
        }
   

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(id != null)
            {
                msql = "EXEC SuaNhaCungCap " +
                 "@MaNhaCungCap = '" + txtMaNhaCungCap.Text + "'," +
                 "@TenNhaCungCap = N'" + txtTenNhaCungCap.Text + "'," +
                 "@DiaChi = N'" + txtDiaChi.Text + "'," +
                 "@SoDienThoai = '" + txtSoDienThoai.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Sửa thành công");
                this.Close();
            }
            else
            {
                msql = "EXEC ThemNhaCungCap " +
                 "@MaNhaCungCap = '" + txtMaNhaCungCap.Text + "'," +
                 "@TenNhaCungCap = N'" + txtTenNhaCungCap.Text + "'," +
                 "@DiaChi = N'" + txtDiaChi.Text + "'," +
                 "@SoDienThoai = '" + txtSoDienThoai.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Thêm thành công");
                this.Close();
            }
 
        }

        private void frmThongTinNhaCungCap_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                txtMaNhaCungCap.Enabled = false;
                msql = "select * from tblNhaCungCap where MaNhaCungCap = '" + id + "'";
                DataTable dt = comm.GetDataTable(mconnectstring, msql, "SuaNhaCungCap");
                txtMaNhaCungCap.Text = dt.Rows[0]["MaNhaCungCap"].ToString();
                txtTenNhaCungCap.Text = dt.Rows[0]["TenNhaCungCap"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtSoDienThoai.Text = dt.Rows[0]["SoDienThoai"].ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            msql = "delete from tblNhaCungCap where MaNhaCungCap = '" + id + "'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Xoá thành công");
            this.Close();
        }
    }
}
