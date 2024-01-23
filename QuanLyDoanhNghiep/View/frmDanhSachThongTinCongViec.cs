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
    public partial class frmDanhSachThongTinCongViec : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachThongTinCongViec()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadThongTinCongViec N'"+ txtTimKiem.Text +"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "ThongTinCongViec");
            dgvCongViec.DataSource = tb;
            dgvCongViec.Columns["MaNguoiDung"].Visible = false;
            dgvCongViec.Columns["HoTen"].HeaderText = "Tên người dùng";
            dgvCongViec.Columns["TenChucVu"].HeaderText = "Chức vụ";
            dgvCongViec.Columns["TenPhongBan"].HeaderText = "Phòng ban";
        }

        private void dgvCongViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvCongViec.Rows[e.RowIndex].Cells["MaNguoiDung"].Value.ToString();
            new frmThongTinCongViec(id).ShowDialog();
            LoadDGV();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            new frmThongTinCongViec(null).ShowDialog();
            LoadDGV();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
