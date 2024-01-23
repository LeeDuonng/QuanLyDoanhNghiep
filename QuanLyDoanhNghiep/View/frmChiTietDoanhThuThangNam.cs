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
    public partial class frmChiTietDoanhThuThangNam : Form
    {
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private string id;
        public frmChiTietDoanhThuThangNam(string id)
        {
            InitializeComponent();
            this.id = id;
            LoadDGV();
        }
        private void LoadDGV()
        {
            msql = "exec LoadChiTietPhieuXuatKho N'"+id+"'";
            dgv.DataSource = comm.GetDataTable(mconnectstring, msql, "hH");
        }
    }
}
