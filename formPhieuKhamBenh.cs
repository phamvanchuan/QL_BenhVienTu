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
    public partial class formPhieuKhamBenh : Form
    {
        public formPhieuKhamBenh()
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
            txtMaPK.Text = "";
            dtpNgayKham.Value = DateTime.Now;
            txtTrieuChung.Text = "";
            txtLoaiBenh.Text = "";
            cbxMaBN.Text = "";
            txtMaPK.Enabled = true;
            txtMaPK.Focus();
        }
        private void formPhieuKhamBenh_Load(object sender, EventArgs e)
        {
            xoaText();
            dgvPhieuKham.DataSource = DataAcces.GetDataTable("Select * from PhieuKham");
            dgvPhieuKham.Columns[0].HeaderText = "Mã PK";
            dgvPhieuKham.Columns[1].HeaderText = "Ngày Khám";
            dgvPhieuKham.Columns[2].HeaderText = "Triệu Chứng";
            dgvPhieuKham.Columns[3].HeaderText = "Loại Bệnh";
            dgvPhieuKham.Columns[4].HeaderText = "Mã BN";
            DataAcces.loadComBox(cbxMaBN, "Select MaBN from BenhNhan");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String sql = "Insert into PhieuKham values(N'" + txtMaPK.Text + "', '"
                + dtpNgayKham.Text + "', N'" + txtTrieuChung.Text + "', N'"
                + txtLoaiBenh.Text + "', N'" + cbxMaBN.Text + "')";
            DataAcces.AddEditDelete(sql);
            MessageBox.Show("Thêm Thành Công", "Thông Báo");
            dgvPhieuKham.DataSource = DataAcces.GetDataTable("Select * from PhieuKham");
            xoaText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql = "Delete from PhieuKham where MaPK = N'" + txtMaPK.Text + "'";
            DataAcces.AddEditDelete(sql);
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            dgvPhieuKham.DataSource = DataAcces.GetDataTable("Select * from PhieuKham");
            xoaText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String sql = "Update PhieuKham set NgayKham = '" + dtpNgayKham.Text + "', "
                + "TrieuChung = N'" + txtTrieuChung.Text + "', "
                + "LoaiBenh = N'" + txtLoaiBenh.Text + "', "
                + "MaBN = N'" + cbxMaBN.Text + "' "
                + "where MaPK = N'" + txtMaPK.Text + "'";
            DataAcces.AddEditDelete(sql);
            MessageBox.Show("Sửa Thành Công", "Thông Báo");
            dgvPhieuKham.DataSource = DataAcces.GetDataTable("Select * from PhieuKham");
            xoaText();
        }

        private void dgvPhieuKham_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPhieuKham.CurrentRow != null)
            {
                txtMaPK.Text = dgvPhieuKham.CurrentRow.Cells[0].Value.ToString();
                dtpNgayKham.Text = dgvPhieuKham.CurrentRow.Cells[1].Value.ToString();
                txtTrieuChung.Text = dgvPhieuKham.CurrentRow.Cells[2].Value.ToString();
                txtLoaiBenh.Text = dgvPhieuKham.CurrentRow.Cells[3].Value.ToString();
                cbxMaBN.Text = dgvPhieuKham.CurrentRow.Cells[4].Value.ToString();
                txtMaPK.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xoaText();
        }

    }
}
