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
    public partial class frmDanhSachThongTinNguoiDung : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachThongTinNguoiDung()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadNguoiDung N'"+txtTimKiem.Text+"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "LoadNguoiDung");
            dgvNguoiDung.DataSource = tb;

            dgvNguoiDung.Columns["MaNguoiDung"].HeaderText = "Mã người dùng";
            dgvNguoiDung.Columns["HoTen"].HeaderText = "Họ tên";
            dgvNguoiDung.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvNguoiDung.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvNguoiDung.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgvNguoiDung.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvNguoiDung.Columns["CCCD"].HeaderText = "Số căn cước công dân";
        }


        private void dgvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvNguoiDung.Rows[e.RowIndex].Cells["MaNguoiDung"].Value.ToString();
            new frmThongTinNguoiDung(id).ShowDialog();
            LoadDGV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThongTinNguoiDung secondForm = new frmThongTinNguoiDung(null);
            secondForm.Show();
            LoadDGV();
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
