using BusinessCommon;
using DevExpress.XtraBars;
using QuanLyDoanhNghiep.Database;
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
    public partial class frm_Menu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private string id = frmDangNhap.MaNguoiDung;
        public frm_Menu()
        {
            InitializeComponent();
            PhanQuyen();
            AddForm(new frmTrangChu());
        }
        public void AddForm(Form f)
        {
            this.panelMain.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.panelMain.Controls.Add(f);
            f.Show();
        }
        private void PhanQuyen()
        {
            //Mặc định ribbon ẩn
            ribbonAdmin.Visible = false;
            ribbonKho.Visible = false;
            ribbonKinhDoanh.Visible = false;
            ribbonNhanSu.Visible = false;
            ribbonTaiChinh.Visible = false;
            //Mặc định group trong ribbon Quản lý ẩn
            ribbonPageGroupKho.Visible = false;
            ribbonPageGroupKinhDoanh.Visible = false;
            ribbonPageGroupNhanSu.Visible = false;


            msql = "exec LoadPhanQuyen N'"+ frmDangNhap.MaNguoiDung +"'";
            DataTable dt = comm.GetDataTable(mconnectstring, msql, "");
            if (dt != null)
            {
                string PB = dt.Rows[0]["TenPhongBan"].ToString();
                switch (PB)
                {
                    case "ADMIN":
                        ribbonAdmin.Visible = true;
                        ribbonKho.Visible = true;
                        ribbonKinhDoanh.Visible = true;
                        ribbonNhanSu.Visible = true;
                        ribbonTaiChinh.Visible = true;

                        ribbonPageGroupKho.Visible = true;
                        ribbonPageGroupKinhDoanh.Visible = true;
                        ribbonPageGroupNhanSu.Visible = true;
                        break;
                    case "Phòng giám đốc":
                        ribbonKho.Visible = true;
                        ribbonKinhDoanh.Visible = true;
                        ribbonNhanSu.Visible = true;
                        ribbonTaiChinh.Visible = true;

                        ribbonPageGroupKho.Visible = true;
                        ribbonPageGroupKinhDoanh.Visible = true;
                        ribbonPageGroupNhanSu.Visible = true;
                        break;
                    case "Phòng kinh doanh":
                        ribbonKinhDoanh.Visible = true;
                        ribbonPageGroupKinhDoanh.Visible = true;
                        break;
                    case "Bộ phận kho Hàng":
                        ribbonKho.Visible = true;
                        ribbonPageGroupKho.Visible = true;
                        break;
                    case "Phòng nhân sự":
                        ribbonNhanSu.Visible = true;
                        ribbonPageGroupNhanSu.Visible = true;
                        break;
                    case "Phòng tài chính":
                        ribbonTaiChinh.Visible = true;
                        break;
                    default:
                        ev.QFrmThongBao("Nhân sự này chưa phân phòng ban. Vui lòng liên hệ bộ phận nhân sự !");
                        break;
                }
            }
            else
                ev.QFrmThongBaoError("Có lỗi xảy ra vui lòng thử lại !");

        }
        private void btnKhachHang_KD_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinKhachHang();
            AddForm(f);
        }

        private void btnSanPham_KD_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinSanPham();
            AddForm(f);
        }

        private void btnDonDatHang_KD_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachDonDatHang();
            AddForm(f);
        }

        private void btnNguoiDung_NS_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinNguoiDung();
            AddForm(f);
        }

        private void btnCongViec_NS_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinCongViec();
            AddForm(f);
        }

        private void btnPhongBan_NS_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinPhongBan();
            AddForm(f);
        }

        private void btnChucVu_NS_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinChucVu();
            AddForm(f);
        }

        private void btnChamCong_NS_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmChamCong();
            AddForm(f);
        }

        private void btnNguyenLieu_Kho_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinNguyenLieu();
            AddForm(f);
        }

        private void btnNhaCungCap_Kho_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinNhaCungCap();
            AddForm(f);
        }

        private void btnPhieuSanXuat_Kho_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachPhieuSanXuat();
            AddForm(f);
        }

        private void btnPhieuXuatKho_Kho_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachPhieuXuatKho();
            AddForm(f);
        }

        private void btnTheoThangNam_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmThongKeDoanhThuTheoThangNam();
            AddForm(f);
        }

        private void btnTuKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
    
        }

        private void btnThuNoKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmThongKeThuCongNo();
            AddForm(f);
        }

        private void btnTraTienNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmThongKeTraCongNo();
            AddForm(f);
        }

        private void btnLuongNhanVien_TC_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongKeLuongNhanVien();
            AddForm(f);
        }

        private void btnTrangChu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmTrangChu();
            AddForm(f);
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            frmDangNhap frmDangnhap = new frmDangNhap();
            frmDangnhap.ShowDialog();
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmDoiMatKhau().ShowDialog();
        }

        private void ribbtnTrangChu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmTrangChu();
            AddForm(f);
        }

        private void barBtnThongTinNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmThongTinNguoiDung(id);
            AddForm(f);
        }

        private void barBtnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDoiMatKhau();
            AddForm(f);
        }

        private void barBtnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            frmDangNhap frmDangnhap = new frmDangNhap();
            frmDangnhap.ShowDialog();
        }

        private void barBtnPhieuNhapNguyenLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachPhieuNhapNguyenLieu();
            AddForm(f);
        }

        private void barBtnPhieuSanXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachPhieuSanXuat();
            AddForm(f);
        }

        private void barBtnPhieuXuatKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachPhieuXuatKho();
            AddForm(f);
        }

        private void barBtnDonDatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachDonDatHang();
            AddForm(f);
        }

        private void barBtnChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmChamCong();
            AddForm(f);
        }

        private void barBtnThongTinCongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinCongViec();
            AddForm(f);
        }

        private void barBtnHopDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmHopDong();
            AddForm(f);
        }

        private void barBtnDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmThongKeDoanhThuTheoThangNam();
            AddForm(f);
        }

        private void barBtnCongNo_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmThongKeThuCongNo();
            AddForm(f);
        }

        private void barBtnTraCongNo_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmThongKeTraCongNo();
            AddForm(f);
        }

        private void barBtnLuongNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongKeLuongNhanVien();
            AddForm(f);
        }

        private void barBtnNguyenLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinNguyenLieu();
            AddForm(f);
        }

        private void barBtnNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinNhaCungCap();
            AddForm(f);
        }

        private void barBtnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinKhachHang();
            AddForm(f);
        }

        private void barBtnSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinSanPham();
            AddForm(f);
        }

        private void barBtnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinNguoiDung();
            AddForm(f);
        }

        private void barBtnChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinChucVu();
            AddForm(f);
        }

        private void barBtnPhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachThongTinPhongBan();
            AddForm(f);
        }

        private void barKhoNguyenLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachKhoNguyenLieu();
            AddForm(f);
        }

        private void barKhoSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmDanhSachKhoSanPham();
            AddForm(f);
        }
    }
}