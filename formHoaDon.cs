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
    public partial class formHoaDon : Form
    {
        public formHoaDon()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formMenu();
            form.ShowDialog();
        }

        private void xoaText()
        {
            txtMaHD.Text = "";
            cbxMaPK.Text = "";
            txtTienKham.Text = "";
            txtTienThuoc.Text = "";
            dtpNgayBan.Value = DateTime.Now;
        }
        private void formHoaDon_Load(object sender, EventArgs e)
        {
            String sql1 = "Select  MaPK from PhieuKham";
            DataAcces.loadComBox(cbxMaPK, sql1);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String sql = "Insert into HoaDonThuoc values(N'" + txtMaHD.Text + "', '"
                + dtpNgayBan.Text + "', " + txtTienThuoc.Text + ", " + txtTienKham.Text + ", N'"
                + cbxMaPK.Text + "')";
            DataAcces.AddEditDelete(sql);
            MessageBox.Show("Lưu thành Công", "Thông Báo");
            
        }
    }
}
