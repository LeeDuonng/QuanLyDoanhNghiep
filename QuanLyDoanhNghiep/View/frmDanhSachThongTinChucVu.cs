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
    public partial class frmDanhSachThongTinChucVu : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachThongTinChucVu()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadChucVu N'"+txtTimKiem.Text+"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "CHUCVU");
            dgvChucVu.DataSource = tb;

            dgvChucVu.Columns["MaChucVu"].HeaderText = "Mã phòng ban";
            dgvChucVu.Columns["TenChucVu"].HeaderText = "Tên chức vụ";
        }
    
        private void dgvChucVu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvChucVu.Rows[e.RowIndex].Cells["MaChucVu"].Value.ToString();
            new frmThongTinChucVu(id).ShowDialog();
            LoadDGV();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            new frmThongTinChucVu(null).ShowDialog();
            LoadDGV();
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
