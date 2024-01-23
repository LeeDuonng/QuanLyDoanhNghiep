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
    public partial class frmThongTinPhongBan : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id;
        public frmThongTinPhongBan(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                msql = "EXEC SuaPhongBan " +
                 "@MaPhongBan = '" + txtMaPhongBan.Text + "'," +
                 "@TenPhongBan = N'" + txtTenPhongBan.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Sửa thành công");
                this.Close();
            }
            else
            {
                msql = "EXEC ThemPhongBan " +
                 "@MaPhongBan = '" + txtMaPhongBan.Text + "'," +
                 "@TenPhongBan = N'" + txtTenPhongBan.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Thêm thành công");
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            msql = "exec XoaPhongBan '" + id + "'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Xoá thành công");
            this.Close();
        }

        private void frmThongTinPhongBan_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                txtMaPhongBan.Enabled = false;
                msql = "select * from tblPhongBan where MaPhongBan = '" + id + "'";
                DataTable dt = comm.GetDataTable(mconnectstring, msql, "PhongBan");
                txtMaPhongBan.Text = dt.Rows[0]["MaPhongBan"].ToString();
                txtTenPhongBan.Text = dt.Rows[0]["TenPhongBan"].ToString();
            }
        }
    }
}
