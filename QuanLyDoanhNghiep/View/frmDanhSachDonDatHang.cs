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
    public partial class frmDanhSachDonDatHang : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachDonDatHang()
        {
            InitializeComponent();
            LoadDGV();
            LoadCbo();
        }
        private void LoadDGV()
        {
            msql = "exec LoadSanPham ''";
            DataTable tbNL = comm.GetDataTable(mconnectstring, msql, "LoadSanPham");

            dgv.Columns.Clear();

            var cMaSP = new DataGridViewComboBoxColumn();
            cMaSP.Name = "MaSanPham";
            cMaSP.HeaderText = "Mã sản phẩm";
            cMaSP.DropDownWidth = 160;
            cMaSP.Width = 90;
            cMaSP.MaxDropDownItems = 3;
            cMaSP.FlatStyle = FlatStyle.Flat;
            cMaSP.DataSource = tbNL;
            cMaSP.DisplayMember = "TenSanPham";
            cMaSP.ValueMember = "MaSanPham";
            dgv.Columns.Add(cMaSP);//Ma SP

            //Loại sản phẩm
            DataGridViewTextBoxColumn clMS = new DataGridViewTextBoxColumn();
            clMS.Name = "MauSac";
            clMS.HeaderText = "Màu sắc";
            clMS.ReadOnly = true;
            dgv.Columns.Add(clMS);
            // Giá
            DataGridViewTextBoxColumn cDongia = new DataGridViewTextBoxColumn();
            cDongia.Name = "DonGia";
            cDongia.HeaderText = "Đơn giá";
            cDongia.ReadOnly = true;
            dgv.Columns.Add(cDongia);
            // Số lượng
            DataGridViewTextBoxColumn cSoLuong = new DataGridViewTextBoxColumn();
            cSoLuong.Name = "SoLuong";
            cSoLuong.HeaderText = "Số lượng";
            dgv.Columns.Add(cSoLuong);

            // Thành tiền
            DataGridViewTextBoxColumn cThanhTien = new DataGridViewTextBoxColumn();
            cThanhTien.Name = "ThanhTien";
            cThanhTien.HeaderText = "Thành tiền";
            cThanhTien.ReadOnly = true;
            dgv.Columns.Add(cThanhTien);
        }

        private void LoadCbo()
        {
            cbKhachHang.Items.Clear();
            msql = "exec LoadKhachHang ''";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DonDatHang");
            cbKhachHang.DataSource = tb.Copy();
            cbKhachHang.DisplayMember = "HoTen";
            cbKhachHang.ValueMember = "MaKhachHang";
            cbKhachHang.SelectedIndex = -1;
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            msql = "exec LoadSanPham ''";
            DataTable tbSP = comm.GetDataTable(mconnectstring, msql, "DonDatHang");

            try
            {
                if (e.ColumnIndex == 0)
                {
                    string masp = dgv.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString();

                    DataRow[] selectedRows = tbSP.Select($"MaSanPham = '{masp}'");

                    if (selectedRows.Length > 0)
                    {
                        // Update the "DonViTinh" and "DonGia" cells in the DataGridView
                        dgv.Rows[e.RowIndex].Cells["MauSac"].Value = selectedRows[0]["MauSac"].ToString();
                        dgv.Rows[e.RowIndex].Cells["DonGia"].Value = selectedRows[0]["DonGia"].ToString();
                    }
                }

                if (e.ColumnIndex == 3)
                {
                    int sl = int.Parse(dgv.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString());
                    float dg = int.Parse(dgv.Rows[e.RowIndex].Cells["DonGia"].Value.ToString());
                    dgv.Rows[e.RowIndex].Cells["ThanhTien"].Value = (int)(sl * dg);
                }
            }
            catch (Exception ex)
            {
                ev.QFrmThongBaoError("Lỗi: " + ex.Message);
            }

            try
            {
                int TongTienSanXuat = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells["ThanhTien"].Value != null)
                    {
                        TongTienSanXuat += int.Parse(row.Cells["ThanhTien"].Value.ToString());
                        txtTongThanhTien.Text = (TongTienSanXuat + " VNĐ").ToString();
                    }
                }
            }
            catch { ev.QFrmThongBaoError("Vui lòng nhập lại số lượng. Sai định dạng số !"); }
        }

        private void btnHT_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentDateTime = DateTime.Now;
                string a = currentDateTime.ToString("yyyyMMddHHmmss");
                string madondathang = "PXK_" + a + "_" + cbKhachHang.SelectedValue.ToString();

                msql = "exec ThemDonDatHang '" + madondathang + "',N'" + txtGhiChu.Text + "', N'Chưa xuất kho','" + cbKhachHang.SelectedValue + "','" + frmDangNhap.MaNguoiDung + "', '" + DateNgayDatHang.Text + "'";
                comm.RunSQL(mconnectstring, msql);

                msql = "exec LoadSanPham ''";
                DataTable tbSP = comm.GetDataTable(mconnectstring, msql, "DonDatHang");

                for (int i = 0; i < dgv.Rows.Count - 1; i++)
                {
                    string masp = dgv.Rows[i].Cells["MaSanPham"].Value.ToString();
                    DataRow[] selectedRows = tbSP.Select($"MaSanPham = '{masp}'");

                    msql = "exec ThemChiTietDonDatHang '" + madondathang + "', '" + selectedRows[0]["MaSanPham"].ToString() + "', '" + dgv.Rows[i].Cells["SoLuong"].Value.ToString() + "' ";
                    comm.RunSQL(mconnectstring, msql);
                }

                new frm_rpt_DonDatHang(madondathang).ShowDialog();
                ev.QFrmThongBao("Thêm thành công !");
            }
            catch { ev.QFrmThongBaoError("Có lỗi xảy ra. Vui lòng thử lại sau !"); }

        }

        private void btnLSDDH_Click(object sender, EventArgs e)
        {
            new frmDanhSachPhieuXuatKho().ShowDialog();
        }
    }
}
