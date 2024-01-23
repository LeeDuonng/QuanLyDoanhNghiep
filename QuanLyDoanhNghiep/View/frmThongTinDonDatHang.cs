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

namespace QuanLyDoanhNghiep
{
    public partial class frmThongTinDonDatHang : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id;
        public frmThongTinDonDatHang(string id)
        {
            InitializeComponent();
            this.id = id;
            LoadCbo();
        }
        private void LoadCbo()
        {
            msql = "SELECT * FROM tblPhieuXuatKho where MaPhieuXuatKho = '" + id +"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DonDatHang");
      

            msql = "exec LoadKhachHang";
            DataTable tbb = comm.GetDataTable(mconnectstring, msql, "DonDatHang");
            cbMaKhachHang.DataSource = tbb.Copy();
            cbMaKhachHang.DisplayMember = "HoTen";
            cbMaKhachHang.ValueMember = "MaKhachHang";
            cbMaKhachHang.SelectedIndex = -1;

            msql = "exec LoadSanPham";
            DataTable tbbb = comm.GetDataTable(mconnectstring, msql, "DonDatHang");
            cbMaSanPham.DataSource = tbbb.Copy();
            cbMaSanPham.DisplayMember = "TenSanPham";
            cbMaSanPham.ValueMember = "MaSanPham";
            cbMaSanPham.SelectedIndex = -1;
        }
    }
}
