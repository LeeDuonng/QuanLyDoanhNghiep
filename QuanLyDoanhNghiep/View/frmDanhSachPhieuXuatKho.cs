using BusinessCommon;
using DevExpress.ClipboardSource.SpreadsheetML;
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
    public partial class frmDanhSachPhieuXuatKho : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachPhieuXuatKho()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadPhieuXuatKho N'"+ txtTimKiem.Text +"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "LoadPhieuXuatKho");
            dgvDonDatHang.DataSource = tb;

            dgvDonDatHang.Columns["MaPhieuXuatKho"].HeaderText = "Mã phiếu xuất kho";
            dgvDonDatHang.Columns["HoTen"].HeaderText = "Họ tên";
            dgvDonDatHang.Columns["NgayXuatKho"].HeaderText = "Ngày xuất kho";
            dgvDonDatHang.Columns["GhiChu"].HeaderText = "Ghi chú";
            dgvDonDatHang.Columns["TrangThaiPhieu"].HeaderText = "Trạng thái";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dgvDonDatHang_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvDonDatHang.Rows[e.RowIndex].Cells["MaPhieuXuatKho"].Value.ToString();
            new frmThongTinPhieuXuatKho(id).ShowDialog();
            LoadDGV();
        }
    }
}

