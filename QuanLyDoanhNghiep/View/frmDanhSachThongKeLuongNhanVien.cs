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
    public partial class frmDanhSachThongKeLuongNhanVien : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachThongKeLuongNhanVien()
        {
            InitializeComponent();
            LoadDGV();
        }

        private void LoadDGV()
        {
            msql = "exec LoadThongKeLuongNhanVien";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KHACHHANG");
            dgv.DataSource = tb;

            dgv.Columns["HoTen"].HeaderText = "Tên nhân viên";
            dgv.Columns["Công"].HeaderText = "Công";
            dgv.Columns["NgayLuong"].HeaderText = "Ngày lương";
            dgv.Columns["Ngay"].HeaderText = "Ngày làm việc";
            dgv.Columns["Lương"].HeaderText = "Lương thực nhận";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            new frm_rpt_BangLuongNV().ShowDialog();
            LoadDGV();
        }
    }
}
