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
    public partial class frmThongTinPhieuXuatKho : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id;
        public frmThongTinPhieuXuatKho(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmThongTinPhieuXuatKho_Load(object sender, EventArgs e)
        {
            msql = "exec LoadChiTietPhieuXuatKho '" + id +"'";
            DataTable dt = comm.GetDataTable(mconnectstring, msql, "LoadPhieuXuatKho");
            dgvPhieuXuatKho.DataSource = dt;
            dgvPhieuXuatKho.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgvPhieuXuatKho.Columns["MauSac"].HeaderText = "Màu sắc";
            dgvPhieuXuatKho.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvPhieuXuatKho.Columns["SoLuong"].HeaderText = "Số lượng xuất";
        }

        private void btnXuatPhieu_Click(object sender, EventArgs e)
        {
            msql = "update tblPhieuXuatKho set TrangThaiPhieu = N'Đã xuất kho' where MaPhieuXuatKho = '" + id + "'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Xuất kho thành công");
            new frm_rpt_PhieuXuatKho(id).ShowDialog();
            this.Close();
        }
    }
}
