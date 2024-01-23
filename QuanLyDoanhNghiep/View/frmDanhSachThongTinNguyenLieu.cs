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
    public partial class frmDanhSachThongTinNguyenLieu : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachThongTinNguyenLieu()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadNguyenLieu N'"+txtTimKiem.Text+"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KHACHHANG");
            dgvNguyenLieu.DataSource = tb;
            dgvNguyenLieu.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvNguyenLieu.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            dgvNguyenLieu.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dgvNguyenLieu.Columns["DonGia"].HeaderText = "Đơn Giá";
          
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThongTinNguyenLieu secondForm = new frmThongTinNguyenLieu(null);
            secondForm.Show();
            LoadDGV();
        }

        private void dgvNguyenLieu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvNguyenLieu.Rows[e.RowIndex].Cells["MaNguyenLieu"].Value.ToString();
            new frmThongTinNguyenLieu(id).ShowDialog();
            LoadDGV();
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            LoadDGV();

        }
    }
}
