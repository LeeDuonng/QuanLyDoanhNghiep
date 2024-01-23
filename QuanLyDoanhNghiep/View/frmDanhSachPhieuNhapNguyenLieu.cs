﻿ using BusinessCommon;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils;
using DevExpress.XtraEditors.Filtering.Templates;
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
    public partial class frmDanhSachPhieuNhapNguyenLieu : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmDanhSachPhieuNhapNguyenLieu()
        {
            InitializeComponent();
            LoadDGV();
            LoadCbo();
        }

        private void LoadDGV()
        {
            msql = "exec LoadNguyenLieu ''";
            DataTable tbNL = comm.GetDataTable(mconnectstring, msql, "DonDatHang");

            dgv.Columns.Clear();

            var cMaNL = new DataGridViewComboBoxColumn();
            cMaNL.Name = "MaNguyenLieu";
            cMaNL.HeaderText = "Nguyên liệu";
            cMaNL.DropDownWidth = 160;
            cMaNL.Width = 90;
            cMaNL.MaxDropDownItems = 3;
            cMaNL.FlatStyle = FlatStyle.Flat;
            cMaNL.DataSource = tbNL;
            cMaNL.DisplayMember = "TenNguyenLieu";
            cMaNL.ValueMember = "MaNguyenLieu";
            dgv.Columns.Add(cMaNL);//Ma hang

            // Đơn vị tính
            DataGridViewTextBoxColumn cDVT = new DataGridViewTextBoxColumn();
            cDVT.Name = "DVT";
            cDVT.HeaderText = "Đơn vị tính";
            cDVT.ReadOnly = true;
            dgv.Columns.Add(cDVT);
            // Đơn giá
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
            cbNCC.Items.Clear();
            msql = "exec LoadNhaCungCap ''";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DonDatHang");
            cbNCC.DataSource = tb.Copy();
            cbNCC.DisplayMember = "TenNhaCungCap";
            cbNCC.ValueMember = "MaNhaCungCap";
            cbNCC.SelectedIndex = -1;
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            msql = "exec LoadNguyenLieu ''";
            DataTable tbNL = comm.GetDataTable(mconnectstring, msql, "DonDatHang");

            try
            {
                if (e.ColumnIndex == 0)
                {
                    string maNguyenLieu = dgv.Rows[e.RowIndex].Cells["MaNguyenLieu"].Value.ToString();

                    DataRow[] selectedRows = tbNL.Select($"MaNguyenLieu = '{maNguyenLieu}'");

                    if (selectedRows.Length > 0)
                    {
                        // Update the "DonViTinh" and "DonGia" cells in the DataGridView
                        dgv.Rows[e.RowIndex].Cells["DVT"].Value = selectedRows[0]["DonViTinh"].ToString();
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
                string maphieunhap = "PN_" + a + "_" + cbNCC.SelectedValue.ToString();

                msql = "exec ThemPhieuNhapNguyenLieu '" + maphieunhap + "', '" + cbNCC.SelectedValue + "', '" + dateNgayNhap.Text + "'";
                comm.RunSQL(mconnectstring, msql);

                msql = "exec LoadNguyenLieu ''";
                DataTable tbNL = comm.GetDataTable(mconnectstring, msql, "DonDatHang");

                for (int i = 0; i < dgv.Rows.Count - 1; i++)
                {
                    string maNguyenLieu = dgv.Rows[i].Cells["MaNguyenLieu"].Value.ToString();
                    DataRow[] selectedRows = tbNL.Select($"MaNguyenLieu = '{maNguyenLieu}'");

                    msql = "exec ThemChiTietPhieuNhapNguyenLieu '" + maphieunhap + "', '" + selectedRows[0]["MaNguyenLieu"].ToString() + "', '" + dgv.Rows[i].Cells["SoLuong"].Value.ToString() + "' ";
                    comm.RunSQL(mconnectstring, msql);
                }

                new frm_rpt_PhieuNhapNguyenLieu(maphieunhap).ShowDialog();
                ev.QFrmThongBao("Thêm thành công !");
            }
            catch (Exception ex)
            {
                ev.QFrmThongBaoError("Lỗi: "+ ex.Message);
            }
        }
    }
}
