using BusinessCommon;
using DevExpress.Xpo.DB.Helpers;
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
    public partial class frmThongKeDoanhThuTheoThangNam : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        //private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmThongKeDoanhThuTheoThangNam()
        {

            InitializeComponent();
            cbNam.SelectedIndex = 0;
            cbThang.SelectedIndex = 0;
            LoadDGV();
    
        }
        private void LoadDGV()
        {
            if (cbNam.Text == "Tất cả" && cbThang.Text == "Tất cả")
                msql = "exec LoadThongKeDoanhThuThangNam @Thang = Null, @Nam = Null, @TimKiem = N'"+txtTimKiem.Text+"'";
            else if (cbNam.Text != "Tất cả" && cbThang.Text == "Tất cả")
                msql = "exec LoadThongKeDoanhThuThangNam @Thang = Null, @Nam = "+cbNam.Text+", @TimKiem = N'" + txtTimKiem.Text + "'";
            else if (cbNam.Text == "Tất cả" && cbThang.Text != "Tất cả")
                msql = "exec LoadThongKeDoanhThuThangNam @Thang = "+cbThang.Text+", @Nam = Null, @TimKiem = N'" + txtTimKiem.Text + "'";
            else if (cbNam.Text != "Tất cả" && cbThang.Text != "Tất cả")
                msql = "exec LoadThongKeDoanhThuThangNam @Thang = "+cbThang.Text+", @Nam = "+cbNam.Text+", @TimKiem = N'" + txtTimKiem.Text + "'";
            dgvThongKeThangNam.DataSource = comm.GetDataTable(mconnectstring, msql, "hH");

            dgvThongKeThangNam.Columns["MaPhieuXuatKho"].HeaderText = "Mã phiếu";
            dgvThongKeThangNam.Columns["NgayXuatKho"].HeaderText = "Ngày xuất";
            dgvThongKeThangNam.Columns[2].HeaderText = "Khách hàng";
            dgvThongKeThangNam.Columns[3].HeaderText = "Nhân viên";
            dgvThongKeThangNam.Columns["GhiChu"].HeaderText = "Ghi chú";
            dgvThongKeThangNam.Columns["DoanhThu"].HeaderText = "Doanh thu";

        }

        private void cbNam_DropDownClosed(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void cbThang_DropDownClosed(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dgvThongKeThangNam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvThongKeThangNam.Rows[e.RowIndex].Cells[0].Value.ToString();
            new frmChiTietDoanhThuThangNam(id).ShowDialog();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            new frm_rpt_ThongKeDoanhThu().ShowDialog();
        }
    }
}
