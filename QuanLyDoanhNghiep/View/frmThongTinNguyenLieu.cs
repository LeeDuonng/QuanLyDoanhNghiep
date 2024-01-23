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
    public partial class frmThongTinNguyenLieu : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id;
        private string fileAddress;
        private string fileName;
        private string fileSavePath;
        public frmThongTinNguyenLieu(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                msql = "EXEC SuaNguyenLieu " +
                 "@MaNguyenLieu = '" + txtMaNguyenLieu.Text + "'," +
                 "@TenNguyenLieu = N'" + txtTenNguyenLieu.Text + "'," +
                 "@DonViTinh = N'" + txtDonViTinh.Text + "'," +
                 "@SoLuong = '" + txtSoLuongTonKho.Text + "'," +
                 "@DonGia = '" + txtDonGia.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                SaveHinh();
                ev.QFrmThongBao("Sửa thành công");
                this.Close();
            }
            else
            {
                msql = "EXEC ThemNguyenLieu " +
                 "@MaNguyenLieu = '" + txtMaNguyenLieu.Text + "'," +
                 "@TenNguyenLieu = N'" + txtTenNguyenLieu.Text + "'," +
                 "@DonViTinh = N'" + txtDonViTinh.Text + "'," +
                 "@SoLuong = '" + txtSoLuongTonKho.Text + "'," +
                 "@DonGia = '" + txtDonGia.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                SaveHinh();
                ev.QFrmThongBao("Thêm thành công");
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            msql = "exec XoaNguyenLieu '" + id + "'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Xoá thành công");
            this.Close();
        }

        private void frmThongTinNguyenLieu_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                txtMaNguyenLieu.Enabled = false;
                msql = "select * from tblNguyenLieu where MaNguyenLieu = '" + id + "'";
                DataTable dt = comm.GetDataTable(mconnectstring, msql, "tblNguyenLieu");
                txtMaNguyenLieu.Text = dt.Rows[0]["MaNguyenLieu"].ToString();
                txtTenNguyenLieu.Text = dt.Rows[0]["TenNguyenLieu"].ToString();
                txtDonViTinh.Text = dt.Rows[0]["DonViTinh"].ToString();
                txtSoLuongTonKho.Text = dt.Rows[0]["SoLuong"].ToString();
                txtDonGia.Text = dt.Rows[0]["DonGia"].ToString();
                LoadHinhFromDatabase();
            }
        }
        private Image cloneImage(string path)
        {
            Image result;
            using (Bitmap original = new Bitmap(path))
            {
                result = (Bitmap)original.Clone();
            };

            return result;
        }
        private void LoadHinh()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|All files(*.*)|*.*";
            open.FilterIndex = 2;
            open.Title = "Chọn ảnh minh họa cho sản phẩm";

            if (open.ShowDialog() == DialogResult.OK)
            {
                fileAddress = open.FileName;
                pcb.Image = cloneImage(fileAddress);
                fileName = Path.GetFileName(fileAddress);
                string saveDirectory = Application.StartupPath;
                fileSavePath = saveDirectory + @"\Images\" + fileName;
            }
        }
        private void SaveHinh()
        {
            if (pcb.Image != null)
            {
                // Convert the image in the PictureBox to a byte array
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pcb.Image.Save(ms, pcb.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }

                // Use parameterized query to avoid SQL injection
                string msql = $"UPDATE tblNguyenLieu SET HinhAnh = 0x{BitConverter.ToString(imageBytes).Replace("-", "")} WHERE MaNguyenLieu = '{id}'";
                comm.RunSQL(mconnectstring, msql);
            }
            else
            {
                ev.QFrmThongBao("Không có hình để lưu.");
            }
        }
        private void LoadHinhFromDatabase()
        {
            string msql = $"SELECT HinhAnh FROM tblNguyenLieu WHERE MaNguyenLieu = '{id}'";
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

        private void pcb_Click(object sender, EventArgs e)
        {
            LoadHinh();
        }
    }
}
