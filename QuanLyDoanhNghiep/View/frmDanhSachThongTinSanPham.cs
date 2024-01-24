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
    public partial class frmDanhSachThongTinSanPham : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachThongTinSanPham()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadSanPham N'"+txtTimKiem.Text+"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KHACHHANG");
            dgvSanPham.DataSource = tb;

            dgvSanPham.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns["DonGia"].HeaderText = "Giá";
            dgvSanPham.Columns["KichThuoc"].HeaderText = "Kích thước";
            dgvSanPham.Columns["MauSac"].HeaderText = "Màu sắc";
            dgvSanPham.Columns["TrongLuong"].HeaderText = "Trọng lượng";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThongTinSanPham secondForm = new frmThongTinSanPham(null);
            secondForm.ShowDialog();
            LoadDGV();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvSanPham.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString();
            new frmThongTinSanPham(id).ShowDialog();
            LoadDGV();
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
