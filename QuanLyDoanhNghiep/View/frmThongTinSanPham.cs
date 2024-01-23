using BusinessCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep.View
{
    public partial class frmThongTinSanPham : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id;
        private string fileAddress; 
        private string fileName;
        private string fileSavePath;
        public frmThongTinSanPham(string id)
        {
            InitializeComponent();
            this.id = id;
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
                pcbSanPham.Image = cloneImage(fileAddress);
                fileName = Path.GetFileName(fileAddress);
                string saveDirectory = Application.StartupPath;
                fileSavePath = saveDirectory + @"\Images\" + fileName;
            }   
        }
        private void SaveHinh()
        {
            if (pcbSanPham.Image != null)
            {
                // Convert the image in the PictureBox to a byte array
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pcbSanPham.Image.Save(ms, pcbSanPham.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }

                // Use parameterized query to avoid SQL injection
                string msql = $"UPDATE tblSanPham SET HinhAnh = 0x{BitConverter.ToString(imageBytes).Replace("-", "")} WHERE MaSanPham = '{id}'";
                comm.RunSQL(mconnectstring, msql);
            }
            else
            {
                ev.QFrmThongBao("Không có hình để lưu.");
            }
        }
        private void LoadHinhFromDatabase()
        {
            string msql = $"SELECT HinhAnh FROM tblSanPham WHERE MaSanPham = '{id}'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "");
            if (tb.Rows.Count > 0 && tb.Rows[0]["HinhAnh"] != DBNull.Value)
            {
                byte[] imageBytes = (byte[])tb.Rows[0]["HinhAnh"];

                Image loadedImage;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    loadedImage = Image.FromStream(ms);
                }
                pcbSanPham.Image = loadedImage;
            }
            else
            {
                ev.QFrmThongBao("Không tìm thấy dữ liệu hình ảnh cho ID này.");
            }
        }


        private void pcbSanPham_Click(object sender, EventArgs e)
        {
            LoadHinh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                msql = "EXEC SuaSanPham " +
                 "@MaSanPham = '" + txtMaSanPham.Text + "'," +
                 "@TenSanPham = N'" + txtTenSanPham.Text + "'," +
                 "@DonGia = '" + txtGia.Text + "'," +
                 "@KichThuoc = N'" + txtKichThuoc.Text + "'," +
                 "@TrongLuong = '" + txtTrongLuong.Text + "'," +
                 "@MauSac = N'" + txtMauSac.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                SaveHinh();
                ev.QFrmThongBao("Sửa thành công");
                this.Close();
            }
            else
            {
                msql = "EXEC ThemSanPham " +
                "@MaSanPham = '" + txtMaSanPham.Text + "'," +
                 "@TenSanPham = N'" + txtTenSanPham.Text + "'," +
                 "@DonGia = '" + txtGia.Text + "'," +
                 "@KichThuoc = N'" + txtKichThuoc.Text + "'," +
                 "@TrongLuong = '" + txtTrongLuong.Text + "'," +
                 "@MauSac = N'" + txtMauSac.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                SaveHinh();
                ev.QFrmThongBao("Thêm thành công");
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            msql = "exec XoaSanPham '" + id + "'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Xoá thành công");
            this.Close();
        }

        private void frmThongTinSanPham_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                txtMaSanPham.Enabled = false;
                msql = "select * from tblSanPham where MaSanPham = '" + id + "'";
                DataTable dt = comm.GetDataTable(mconnectstring, msql, "SanPham");
                txtMaSanPham.Text = dt.Rows[0]["MaSanPham"].ToString();
                txtTenSanPham.Text = dt.Rows[0]["TenSanPham"].ToString();
                txtGia.Text = dt.Rows[0]["DonGia"].ToString();
                txtKichThuoc.Text = dt.Rows[0]["KichThuoc"].ToString();
                txtTrongLuong.Text = dt.Rows[0]["TrongLuong"].ToString();
                txtMauSac.Text = dt.Rows[0]["MauSac"].ToString();
                LoadHinhFromDatabase();
            }
        }
    }
}
