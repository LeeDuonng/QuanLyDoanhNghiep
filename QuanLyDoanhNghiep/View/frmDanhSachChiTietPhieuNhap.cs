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
    public partial class frmDanhSachChiTietPhieuNhap : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id;

        public frmDanhSachChiTietPhieuNhap(string id)
        {
            InitializeComponent();
            this.id = id;
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadChiTietPhieuNhapNguyenLieu N'" + id + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "LoadPhieuXuatKho");
            dgv.DataSource = tb;

            dgv.Columns["TenNguyenLieu"].HeaderText = "Tên nguyên liệu";
            dgv.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgv.Columns["SoLuong"].HeaderText = "Số lượng";
            dgv.ReadOnly = true;
        }

        private void btnDTT_Click(object sender, EventArgs e)
        {
            msql = "update tblPhieuNhapNguyenLieu set TrangThai = N'Đã thanh toán' where MaPhieuNhap = N'" + id + "'";
            comm.RunSQL(mconnectstring, msql);
            new frm_rpt_PhieuNhapNguyenLieu(id).ShowDialog();
            ev.QFrmThongBao("Đổi trạng thái thành công");
            this.Close();
        }
    }
}
