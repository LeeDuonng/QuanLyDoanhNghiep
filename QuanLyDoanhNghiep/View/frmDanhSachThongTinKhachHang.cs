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
    public partial class frmDanhSachThongTinKhachHang : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachThongTinKhachHang()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadKhachHang N'"+txtTimKiem.Text+"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KHACHHANG");
            dgvKhachHang.DataSource = tb;

            dgvKhachHang.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns["HoTen"].HeaderText = "Họ tên";
            dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmThongTinKhachHang(null).ShowDialog();
            LoadDGV();

        }

        private void dgvKhachHang_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvKhachHang.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
            new frmThongTinKhachHang(id).ShowDialog();
            LoadDGV();
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
