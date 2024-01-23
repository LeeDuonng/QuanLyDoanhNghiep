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
    public partial class frm_Logo : Form
    {
        private Timer timer;

        public frm_Logo()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 5000; // 2 giây
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Hide();
            new frmDangNhap().ShowDialog();
        }
    }
}
