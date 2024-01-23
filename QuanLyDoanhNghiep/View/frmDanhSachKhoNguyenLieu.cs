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
    public partial class frmDanhSachKhoNguyenLieu : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachKhoNguyenLieu()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadKhoNguyenLieu N'" + txtTimKiem.Text + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "CHUCVU");
            dgv.DataSource = tb;

            dgv.Columns["MaNguyenLieu"].Visible = false;
            dgv.Columns["TenNguyenLieu"].HeaderText = "Nguyên liệu";
            dgv.Columns["SoLuong"].HeaderText = "Số lượng tồn kho";
            dgv.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgv.Rows[e.RowIndex].Cells["MaNguyenLieu"].Value.ToString();
            new frmThongTinNguyenLieu(id).ShowDialog();
            LoadDGV();
        }
    }
}
