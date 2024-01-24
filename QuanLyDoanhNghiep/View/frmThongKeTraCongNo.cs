using BusinessCommon;
using QuanLyDoanhNghiep.Report;
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
    public partial class frmThongKeTraCongNo : Form
    {

        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmThongKeTraCongNo()
        {
            InitializeComponent();
            LoadDGV();
        }

        private void LoadDGV()
        {
            msql = "exec LoadThongKeTraCongNo N'"+txtTimKiem.Text+"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KHACHHANG");
            dgv.DataSource = tb;

            dgv.Columns["MaPhieuNhap"].HeaderText = "Mã phiếu";
            dgv.Columns["TenNhaCungCap"].HeaderText = "Nhà cung cấp";
            dgv.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            dgv.Columns["Tổng công nợ"].HeaderText = "Tổng công nợ";
            dgv.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            new frm_rpt_TraCongNo().ShowDialog();
            LoadDGV();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgv.Rows[e.RowIndex].Cells["MaPhieuNhap"].Value.ToString();
            new frmDanhSachChiTietPhieuNhap(id).ShowDialog();
            LoadDGV();
        }
    }
}