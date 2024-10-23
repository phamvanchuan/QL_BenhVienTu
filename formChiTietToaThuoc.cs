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
    public partial class formChiTietToaThuoc : Form
    {
        public formChiTietToaThuoc()
        {
            InitializeComponent();
        }

        private void xoaText()
        {
            cbxMaThuoc.Text = "";
            cbxMaPK.Text = "";
            txtCachDung.Text = "";
            txtSoLuong.Text = "";
            cbxMaPK.Enabled = true;
            cbxMaThuoc.Enabled = true;
        }
        private void formChiTietToaThuoc_Load(object sender, EventArgs e)
        {
            dgvToaThuoc.DataSource = DataAcces.GetDataTable("Select * from ChiTietToaThuoc");
            dgvToaThuoc.Columns[0].HeaderText = "Mã PK";
            dgvToaThuoc.Columns[1].HeaderText = "Mã Thuốc";
            dgvToaThuoc.Columns[2].HeaderText = "Số Lượng";
            dgvToaThuoc.Columns[3].HeaderText = "Cách Dùng";
            DataAcces.loadComBox(cbxMaPK, "Select MaPK from PhieuKham");
            DataAcces.loadComBox(cbxMaThuoc, "Select MaThuoc from Thuoc");
        }

        private void dgvThuoc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvToaThuoc.CurrentRow != null)
            {
                cbxMaPK.Text = dgvToaThuoc.CurrentRow.Cells[0].Value.ToString();
                cbxMaThuoc.Text = dgvToaThuoc.CurrentRow.Cells[1].Value.ToString();
                txtSoLuong.Text = dgvToaThuoc.CurrentRow.Cells[2].Value.ToString();
                txtCachDung.Text = dgvToaThuoc.CurrentRow.Cells[3].Value.ToString();
                cbxMaPK.Enabled = false;
                cbxMaThuoc.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formMenu();
            form.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String sql = "Insert into ChiTietToaThuoc values(N'" + cbxMaPK.Text + "', N'"
                + cbxMaThuoc.Text + "', " + txtSoLuong.Text + ", N'" + txtCachDung.Text + "')";
            DataAcces.AddEditDelete(sql);
            MessageBox.Show("Thêm Thành Công", "Thông Báo");
            dgvToaThuoc.DataSource = DataAcces.GetDataTable("Select * from ChiTietToaThuoc");
            xoaText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql = "Delete from ChiTietToaThuoc where MaPK = N'" + cbxMaPK.Text + "' and MaThuoc = N'" + cbxMaThuoc.Text + "'";
            DataAcces.AddEditDelete(sql);
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            dgvToaThuoc.DataSource = DataAcces.GetDataTable("Select * from ChiTietToaThuoc");
            xoaText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String sql = "Update ChiTietToaThuoc set SoLuong = " + txtSoLuong.Text + ", "
                + "CachDung = N'" + txtCachDung.Text + "' "
                + "where MaPK = N'" + cbxMaPK.Text + "' and MaThuoc = N'" + cbxMaThuoc.Text + "'";
            DataAcces.AddEditDelete(sql);
            MessageBox.Show("Sửa Thành Công", "Thông Báo");
            dgvToaThuoc.DataSource = DataAcces.GetDataTable("Select * from ChiTietToaThuoc");
            xoaText();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xoaText();
        }

        private void cbxMaPK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
