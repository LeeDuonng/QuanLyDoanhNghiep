using BusinessCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep.View
{
    public partial class frmThongTinCongViec : Form
    {

        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id;
        public frmThongTinCongViec(string id)
        {
            InitializeComponent();
            this.id = id;
            LoadCbo();
        }
        private void LoadCbo()
        {
            if (id == null)
            {
                cbMaNguoiDung.Visible = true;
                msql = "SELECT [tblNguoiDung].[MaNguoiDung],[HoTen] FROM [QLDN].[dbo].[tblNguoiDung] " +
             "LEFT JOIN [QLDN].[dbo].[tblThongTinCongViec] ON [tblNguoiDung].[MaNguoiDung] = [tblThongTinCongViec].[MaNguoiDung] " +
             "WHERE [tblThongTinCongViec].[MaNguoiDung] IS NULL;";
                DataTable tbND = comm.GetDataTable(mconnectstring, msql, "ThongTinCongViec");
                cbMaNguoiDung.DataSource = tbND.Copy();
                cbMaNguoiDung.DisplayMember = "HoTen";
                cbMaNguoiDung.ValueMember = "MaNguoiDung";
            }

            msql = "exec LoadPhongBan ''";
            DataTable tbPB = comm.GetDataTable(mconnectstring, msql, "ThongTinCongViec");
            cbMaPhongBan.DataSource = tbPB.Copy();
            cbMaPhongBan.DisplayMember = "TenPhongBan";
            cbMaPhongBan.ValueMember = "MaPhongBan";
            cbMaPhongBan.SelectedIndex = -1;

            msql = "exec LoadChucVu ''";
            DataTable tbCV = comm.GetDataTable(mconnectstring, msql, "ThongTinCongViec");
            cbMaChucVu.DataSource = tbCV.Copy();
            cbMaChucVu.DisplayMember = "TenChucVu";
            cbMaChucVu.ValueMember = "MaChucVu";
            cbMaChucVu.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != null)
                {
                    msql = "EXEC SuaThongTinCongViec " +
                     "@MaNguoiDung = '" + id + "'," +
                     "@MaChucVu = '" + cbMaChucVu.SelectedValue + "'," +
                     "@MaPhongBan = '" + cbMaPhongBan.SelectedValue + "'," +
                     "@NgayBatDau = '" + dateNgayBatDau.Text + "'," +
                     "@NgayKetThuc = '" + dateNgayKetThuc.Text + "'," +
                     "@MucLuong = '" + txtMucLuong.Text + "'";
                    comm.RunSQL(mconnectstring, msql);
                    ev.QFrmThongBao("Sửa thành công");
                    this.Close();
                }
                else
                {
                    msql = "EXEC ThemThongTinCongViec " +
                     "@MaNguoiDung = '" + cbMaNguoiDung.SelectedValue + "'," +
                     "@MaChucVu = '" + cbMaChucVu.SelectedValue + "'," +
                     "@MaPhongBan = '" + cbMaPhongBan.SelectedValue + "'," +
                     "@NgayBatDau = '" + dateNgayBatDau.Text + "'," +
                     "@NgayKetThuc = '" + dateNgayKetThuc.Text + "'," +
                     "@MucLuong = '" + txtMucLuong.Text + "'";
                    comm.RunSQL(mconnectstring, msql);
                    ev.QFrmThongBao("Thêm thành công");
                    this.Close();
                }
            }
            catch(Exception ex) { ev.QFrmThongBaoError("Lỗi: "+ ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            msql = "exec XoaNguoiDung '" + id + "'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Xoá thành công");
            this.Close();
        }

        private void frmThongTinCongViec_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                txtMaNguoiDung.Visible = true;
                msql = "exec LoadMaNguoiDung '" + id + "'";
                DataTable dt = comm.GetDataTable(mconnectstring, msql, "CongViec");
                txtMaNguoiDung.Text = dt.Rows[0]["HoTen"].ToString();
                cbMaChucVu.Text = dt.Rows[0]["TenChucVu"].ToString();
                cbMaPhongBan.Text = dt.Rows[0]["TenPhongBan"].ToString();
                dateNgayBatDau.Text = dt.Rows[0]["NgayBatDau"].ToString();
                dateNgayKetThuc.Text = dt.Rows[0]["NgayKetThuc"].ToString();
                txtMucLuong.Text = dt.Rows[0]["NgayLuong"].ToString();
                LoadHinhFromDatabase();
            }
        }
        private void LoadHinhFromDatabase()
        {
            string msql = $"SELECT HinhAnh FROM tblNguoiDung WHERE MaNguoiDung = '{id}'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "");
            if (tb.Rows.Count > 0 && tb.Rows[0]["HinhAnh"] != DBNull.Value)
            {
                byte[] imageBytes = (byte[])tb.Rows[0]["HinhAnh"];

                Image loadedImage;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    loadedImage = Image.FromStream(ms);
                }
                pcb.Image = loadedImage;
            }
            else
            {
                ev.QFrmThongBao("Không tìm thấy dữ liệu hình ảnh cho ID này.");
            }
        }
    }
}
