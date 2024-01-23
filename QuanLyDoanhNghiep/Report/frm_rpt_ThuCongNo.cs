using BusinessCommon;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep.Report
{
    public partial class frm_rpt_ThuCongNo : Form
    {
        public frm_rpt_ThuCongNo()
        {
            InitializeComponent();
            LoadRpt();
        }
        public static string mconnectstring = Database.Database.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        private clsEventArgs ev = new clsEventArgs("");
        private void LoadRpt()
        {
            //msql = "exec RptDonDatHang N'PXK_20231223122237_KH005'";
            msql = "exec RptThongKeThuCongNo";
            DataTable dt = comm.GetDataTable(mconnectstring, msql, "");
            ReportDataSource reportDataSource = new ReportDataSource("DataSet", dt);
            this.reportViewer1.LocalReport.ReportPath = "./rptThuCongNo.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            // Refresh the report
            this.reportViewer1.RefreshReport();
        }

        private void frm_rpt_ThuCongNo_Load(object sender, EventArgs e)
        {
        }
    }
}
