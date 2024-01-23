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
    public partial class frmThongTinChucVu : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id;
        public frmThongTinChucVu(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                msql = "EXEC SuaChucVu " +
                 "@MaChucVu = '" + txtMaChucVu.Text + "'," +
                 "@TenChucVu = N'" + txtTenChucVu.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Sửa thành công");
                this.Close();
            }
            else
            {
                msql = "EXEC ThemChucVu " +
                 "@MaChucVu = '" + txtMaChucVu.Text + "'," +
                 "@TenChucVu = N'" + txtTenChucVu.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Thêm thành công");
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            msql = "exec XoaChucVu '"+ txtMaChucVu.Text +"'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Xoá thành công");
            this.Close();
        }

        private void frmThongTinChucVu_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                txtMaChucVu.Enabled = false;
                msql = "select * from tblChucVu where MaChucVu = '" + id + "'";
                DataTable dt = comm.GetDataTable(mconnectstring, msql, "ChucVu");
                txtMaChucVu.Text = dt.Rows[0]["MaChucVu"].ToString();
                txtTenChucVu.Text = dt.Rows[0]["TenChucVu"].ToString();
            }
        }
    }
}
