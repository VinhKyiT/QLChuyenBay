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
    public partial class QuanLyCSDL : Form
    {
        public QuanLyCSDL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanBay sb = new SanBay();
            sb.ShowDialog();
            sb = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyTuyenBay tb = new QuanLyTuyenBay();
            tb.ShowDialog();
            tb = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyChuyenBay cb = new QuanLyChuyenBay();
            cb.ShowDialog();
            cb = null;
            this.Show();
        }
    }
}
