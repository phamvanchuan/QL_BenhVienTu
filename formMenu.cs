using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BenhVien
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýNgườiDùngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formQLNguoiDung form = new formQLNguoiDung();
            form.Show();
        }

        private void báoCáoSửDụngThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formBaoCaoThuoc();
            form.ShowDialog();
        }

        private void bệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formDSKhamBenh();
            form.ShowDialog();
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formQLThuoc();
            form.ShowDialog();
        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap form = new DangNhap();
            form.Show();
        }

        private void phiếuKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formPhieuKhamBenh();
            form.ShowDialog();
        }

        private void hóaĐơnThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formHoaDon();
            form.ShowDialog();
        }

        private void traCứuBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formTraCuuBenhNhan();
            form.ShowDialog();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formBCDoanhThu();
            form.ShowDialog();
        }

        private void toaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formChiTietToaThuoc();
            form.ShowDialog();
        }
    }
}
