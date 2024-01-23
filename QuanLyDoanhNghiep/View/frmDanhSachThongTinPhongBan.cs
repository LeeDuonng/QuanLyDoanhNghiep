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
    public partial class frmDanhSachThongTinPhongBan : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachThongTinPhongBan()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadPhongBan N'"+txtTimKiem.Text+"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "LoadPhongBan");
            dgvPhongBan.DataSource = tb;

            dgvPhongBan.Columns["MaPhongBan"].HeaderText = "Mã phòng ban";
            dgvPhongBan.Columns["TenPhongBan"].HeaderText = "Tên phòng ban";
        }

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvPhongBan.Rows[e.RowIndex].Cells["MaPhongBan"].Value.ToString();
            new frmThongTinPhongBan(id).ShowDialog();
            LoadDGV();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            new frmThongTinPhongBan(null).ShowDialog();
            LoadDGV();
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
