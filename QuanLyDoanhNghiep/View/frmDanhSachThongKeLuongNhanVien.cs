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
            LoadCbo();
            LoadDGV();
        }

        private void LoadCbo()
        {
            // Tạo danh sách các đối tượng DateTime
            List<DateTime> dateList = new List<DateTime>();
            for (int year = DateTime.Now.Year; year >= 2018; year--)
            {
                for (int month = 12; month >= 1; month--)
                {
                    dateList.Add(new DateTime(year, month, 1));
                }
            }
            dateList.RemoveRange(0, 11);
            // Tạo ComboBox và thiết lập các thuộc tính
            cbo.DisplayMember = "Display";
            cbo.ValueMember = "Value";
            cbo.DataSource = dateList.Select(date => new
            {
                Display = date.ToString("MM/yyyy"),
                Value = date.ToString("yyyy-MM-dd")
            }).ToList();
        }
        private void LoadDGV()
        {
            msql = "exec LoadThongKeLuongNhanVien '"+cbo.SelectedValue+"'";
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
            new frm_rpt_BangLuongNV(cbo.SelectedValue.ToString()).ShowDialog();
            LoadDGV();
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDGV();  
        }
    }
}
