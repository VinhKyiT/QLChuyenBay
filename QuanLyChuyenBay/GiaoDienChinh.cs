using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenBay
{
    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();         
            dn.ShowDialog();
            dn = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TraCuu tc = new TraCuu();
            tc.ShowDialog();
            tc = null;
            this.Show();
        }

        private void traCứuChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TraCuu tc = new TraCuu();
            tc.ShowDialog();
            tc = null;
            this.Show();
        }
    }
}
