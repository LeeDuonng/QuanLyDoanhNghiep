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
    public partial class frmDanhSachKhoSanPham : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachKhoSanPham()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadKhoSanPham N'" + txtTimKiem.Text + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "CHUCVU");
            dgv.DataSource = tb;

            dgv.Columns["MaSanPham"].Visible = false;
            dgv.Columns["TenSanPham"].HeaderText = "Sản phẩm";
            dgv.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv.Columns["SoLuong"].HeaderText = "Số lượng tồn kho";
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgv.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString();
            new frmThongTinSanPham(id).ShowDialog();
            LoadDGV();
        }
    }
}
