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
    public partial class frmDanhSachChiTietPhieuSanXuat : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id;
        
        public frmDanhSachChiTietPhieuSanXuat(string id)
        {
            InitializeComponent();
            this.id = id;
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadChiTietPhieuSanXuat N'" + id + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "LoadPhieuXuatKho");
            dgv.DataSource = tb;

            dgv.Columns["TenNguyenLieu"].HeaderText = "Nguyên liệu";
            dgv.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgv.Columns["SoLuong"].HeaderText = "Số lượng";
            dgv.ReadOnly = true;
        }
    }
}
