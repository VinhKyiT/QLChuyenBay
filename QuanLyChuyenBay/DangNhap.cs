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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "admin" && this.textBox2.Text == "123");
            this.Hide();
            QuanLyCSDL csdl = new QuanLyCSDL();
            csdl.ShowDialog();
            csdl = null;
            this.Show();
        }
    }
}
