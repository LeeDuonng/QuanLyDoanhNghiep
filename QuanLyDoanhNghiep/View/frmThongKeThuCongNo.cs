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
    public partial class frmThongKeThuCongNo : Form
    {

        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmThongKeThuCongNo()
        {
            InitializeComponent();
            LoadDGV();
        }

        private void LoadDGV()
        {
            msql = "exec LoadThongKeThuCongNo N'"+txtTimKiem.Text+"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KHACHHANG");
            dgv.DataSource = tb;
            dgv.Columns["MaPhieuXuatKho"].HeaderText = "Mã phiếu";
            dgv.Columns["NgayXuatKho"].HeaderText = "Ngày xuất";
            dgv.Columns[2].HeaderText = "Tên khách hàng";
            dgv.Columns[3].HeaderText = "Tên nhân viên";
            dgv.Columns["GhiChu"].HeaderText = "Ghi chú";
            dgv.Columns["DoanhThu"].HeaderText = "Doanh thu";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            new frm_rpt_ThuCongNo().ShowDialog();
            LoadDGV();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
