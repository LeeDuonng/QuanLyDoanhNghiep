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
    public partial class frmThongTinNguoiDung : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id;
        private string fileAddress;
        private string fileName;
        private string fileSavePath;
        public frmThongTinNguoiDung(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void Loadfrm()
        {
            if (id != null)
            {
                txtMaNguoiDung.Enabled = false;
                msql = "select * from tblNguoiDung where MaNguoiDung = '" + id + "'";
                DataTable dt = comm.GetDataTable(mconnectstring, msql, "NGUOIDUNG");
                txtMaNguoiDung.Text = dt.Rows[0]["MaNguoiDung"].ToString();
                txtHoTenNguoiDung.Text = dt.Rows[0]["HoTen"].ToString();
                DateNgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString();
                string gt = dt.Rows[0]["GioiTinh"].ToString();
                if (gt == "Nam")
                    btnNam.Checked = true;
                else btnNam.Checked = false;
                if (gt == "Nữ")
                    btnNu.Checked = true;
                else btnNu.Checked = false;
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtSoDienThoai.Text = dt.Rows[0]["SoDienThoai"].ToString();
                txtCCCD.Text = dt.Rows[0]["CCCD"].ToString();
                LoadHinhFromDatabase();
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string gt = null;
            if(btnNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";

            if (id != null)
            {
                msql = "EXEC SuaNguoiDung " +
                 "@MaNguoiDung = '" + txtMaNguoiDung.Text + "'," +
                 "@HoTen = N'" + txtHoTenNguoiDung.Text + "'," +
                 "@NgaySinh = '" + DateNgaySinh.Text + "'," +
                 "@GioiTinh = N'" + gt + "'," +
                 "@DiaChi = N'" + txtDiaChi.Text + "'," +
                 "@SoDienThoai = N'" + txtSoDienThoai.Text + "'," +
                 "@CCCD = N'" + txtCCCD.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                SaveHinh();
                ev.QFrmThongBao("Sửa thành công");
                this.Close();
            }
            else
            {
                msql = "EXEC ThemNguoiDung " +
                 "@MaNguoiDung = '" + txtMaNguoiDung.Text + "'," +
                 "@HoTen = N'" + txtHoTenNguoiDung.Text + "'," +
                 "@NgaySinh = '" + DateNgaySinh.Text + "'," +
                 "@GioiTinh = N'" + gt + "'," +
                 "@DiaChi = N'" + txtDiaChi.Text + "'," +
                 "@SoDienThoai = N'" + txtSoDienThoai.Text + "'," +
                 "@CCCD = N'" + txtCCCD.Text + "'";
                comm.RunSQL(mconnectstring, msql);
                SaveHinh();
                ev.QFrmThongBao("Thêm thành công");
                this.Close();
            }
            var f = new frmThongTinNguoiDung(id);
            this.Close();
            new frm_Menu().AddForm(f);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            msql = "exec XoaNguoiDung '" + id + "'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Xoá thành công");
            this.Close();
        }

        private void frmThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            Loadfrm();
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
                string msql = $"UPDATE tblNguoiDung SET HinhAnh = 0x{BitConverter.ToString(imageBytes).Replace("-", "")} WHERE MaNguoiDung = '{id}'";
                comm.RunSQL(mconnectstring, msql);
            }
            else
            {
                ev.QFrmThongBao("Không có hình để lưu.");
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

        private void pcb_Click(object sender, EventArgs e)
        {
            LoadHinh();        
        }
    }
}
