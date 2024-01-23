using BusinessCommon;
using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep.Database
{
    public partial class frmChamCong : Form
    {
        public static string mconnectstring = Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        public frmChamCong()
        {
            InitializeComponent();
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            msql = "exec LoadChamCong";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "LoadChamCong");
            dgvChamCong.DataSource = tb;

            dgvChamCong.Columns["MaNguoiDung"].Visible = false;

            dgvChamCong.Columns["HoTen"].HeaderText = "Họ tên";
            dgvChamCong.Columns["HoTen"].ReadOnly = true;
            dgvChamCong.Columns["TenPhongBan"].HeaderText = "Tên phòng ban";
            dgvChamCong.Columns["TenPhongBan"].ReadOnly = true;
            dgvChamCong.Columns["TenChucVu"].HeaderText = "Chức vụ";
            dgvChamCong.Columns["TenChucVu"].ReadOnly = true;

            var cTinhTrang = new DataGridViewComboBoxColumn();
            cTinhTrang.Name = "TinhTrang";
            cTinhTrang.HeaderText = "Tình trạng";
            cTinhTrang.DropDownWidth = 160;
            cTinhTrang.Width = 90;
            cTinhTrang.MaxDropDownItems = 3;
            cTinhTrang.FlatStyle = FlatStyle.Flat;
            cTinhTrang.Items.Add("Một công");
            cTinhTrang.Items.Add("Nửa công");
            cTinhTrang.Items.Add("Nghỉ");
            cTinhTrang.DefaultCellStyle.NullValue = "Một công";
            dgvChamCong.Columns.Add(cTinhTrang);
        }

        private void btnHoanThanhh_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvChamCong.Rows.Count - 1; i++)
                {
                    string tinhtrang = string.IsNullOrEmpty(dgvChamCong.Rows[i].Cells["TinhTrang"].Value?.ToString()) ? "Một công" : dgvChamCong.Rows[i].Cells["TinhTrang"].Value.ToString();
                    msql = "exec ThemChamCong '" + dgvChamCong.Rows[i].Cells["MaNguoiDung"].Value.ToString() + "', N'" + tinhtrang + "'";
                    comm.RunSQL(mconnectstring, msql);
                }
                ev.QFrmThongBao("Chấm công ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " hoàn tất");
            }
            catch
            {
                ev.QFrmThongBaoError("Có lỗi xảy ra. Vui lòng thử lại");

            }
        }
    }
}
