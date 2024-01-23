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
    public partial class frmPhieuSanXuat : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmPhieuSanXuat()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadPhieuSanXuat N'" + txtTimKiem.Text + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "LoadPhieuXuatKho");
            dgv.DataSource = tb;

            dgv.Columns["MaPhieuSanXuat"].HeaderText = "Mã phiếu";
            dgv.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgv.Columns["SoLuong"].HeaderText = "Số lượng";
            dgv.Columns["NgaySanXuat"].HeaderText = "Ngày sản xuất";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgv.Rows[e.RowIndex].Cells["MaPhieuSanXuat"].Value.ToString();
            new frmDanhSachChiTietPhieuSanXuat(id).ShowDialog();
            LoadDGV();
        }
    }
}
