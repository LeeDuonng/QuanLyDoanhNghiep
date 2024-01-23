using BusinessCommon;
using QuanLyDoanhNghiep.Report;
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
    public partial class frmHopDong : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmHopDong()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadHopDong N'" + txtTimKiem.Text + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "ThongTinCongViec");
            dgv.DataSource = tb;
            dgv.Columns["MaNguoiDung"].Visible = false;
            dgv.Columns["HoTen"].HeaderText = "Tên người dùng";
            dgv.Columns["TenChucVu"].HeaderText = "Chức vụ";
            dgv.Columns["TenPhongBan"].HeaderText = "Phòng ban";
            dgv.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(ev.QFrmThongBao_YesNo("Bạn muốn in hợp đồng của nhân viên này chứ ?"))
            {
                string id = dgv.Rows[e.RowIndex].Cells["MaNguoiDung"].Value.ToString();
                new frm_rpt_HopDong(id).ShowDialog();
            }
        }
    }
}
