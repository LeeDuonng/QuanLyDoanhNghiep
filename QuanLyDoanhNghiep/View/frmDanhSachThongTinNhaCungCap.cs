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
    public partial class frmDanhSachThongTinNhaCungCap : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachThongTinNhaCungCap()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadNhaCungCap N'"+ txtTimKiem.Text +"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KHACHHANG");
            dgvNhaCungCap.DataSource = tb;
            dgvNhaCungCap.Columns["MaNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
            dgvNhaCungCap.Columns["TenNhaCungCap"].HeaderText = "Tên Nhà Cung Cấp";
            dgvNhaCungCap.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvNhaCungCap.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmThongTinNhaCungCap(null).ShowDialog();
            LoadDGV();
        }
        private void dgvNhaCungCap_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvNhaCungCap.Rows[e.RowIndex].Cells["MaNhaCungCap"].Value.ToString();
            new frmThongTinNhaCungCap(id).ShowDialog();
            LoadDGV();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
