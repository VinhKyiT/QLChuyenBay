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
    public partial class SanBay : Form
    {
        private DAL.QuanLyChuyenBayEntities db = new DAL.QuanLyChuyenBayEntities();
        public SanBay()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnThoatSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Method

        private void LoadData()
        {
            var result = from c in db.SanBays select c;
            dgvSanBay.DataSource = result.ToList();
            Binding();
        }

        private void Binding()
        {
            txtMaSanBay.Clear();
            txtTenSanBay.Clear();
            txtTinhThanh.Clear();

            txtMaSanBay.DataBindings.Add("Text", dgvSanBay.DataSource, "MaSanBay");
            txtTenSanBay.DataBindings.Add("Text", dgvSanBay.DataSource, "TenSanBay");
            txtTinhThanh.DataBindings.Add("Text", dgvSanBay.DataSource, "TinhThanh");
        }

        #endregion

        private void btnThemSB_Click(object sender, EventArgs e)
        {
            string maSanBay = txtMaSanBay.Text;
            string tenSanBay = txtTenSanBay.Text;
            string tinhThanh = txtTinhThanh.Text;

            DAL.SanBay sb = db.SanBays.Where(l => l.MaSanBay == maSanBay).SingleOrDefault();
            if (sb != null)
            {
                MessageBox.Show("Mã sân bay đã tồn tại");
                return;
            } else if (String.IsNullOrEmpty(maSanBay) || String.IsNullOrEmpty(tenSanBay) || String.IsNullOrEmpty(tinhThanh))
            {
                MessageBox.Show("Không được bỏ trống thông tin");
                return;
            }
            else
            {
                sb = new DAL.SanBay();
                sb.MaSanBay = maSanBay;
                sb.TenSanBay = tenSanBay;
                sb.TinhThanh = tinhThanh;
                db.SanBays.Add(sb);
                db.SaveChanges();
                LoadData();
            }
        }
    }
}
