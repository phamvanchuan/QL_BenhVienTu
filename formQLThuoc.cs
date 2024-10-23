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
    public partial class formQLThuoc : Form
    {
        public formQLThuoc()
        {
            InitializeComponent();
        }

        private void xoaText()
        {
            txtMaThuoc.Text = "";
            txtMaThuoc.Enabled = true;
            txtMaThuoc.Focus();
            txtTenThuoc.Text = "";
            txtDonVi.Text = "";
            txtDonGia.Text = "";
        }
        private void formQLThuoc_Load(object sender, EventArgs e)
        {
            dgvThuoc.DataSource = DataAcces.GetDataTable("select * from Thuoc");
            dgvThuoc.Columns[0].HeaderText = "Mã Thuốc";
            dgvThuoc.Columns[1].HeaderText = "Tên Thuốc";
            dgvThuoc.Columns[2].HeaderText = "Đơn Vị";
            dgvThuoc.Columns[3].HeaderText = "Đơn Giá";
            xoaText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Thuoc values (N'" +
                txtMaThuoc.Text + "', N'" + txtTenThuoc.Text + "', N'" +
                txtDonVi.Text + "', " + txtDonGia.Text + ")";
            DataAcces.AddEditDelete(sql);
            dgvThuoc.DataSource = DataAcces.GetDataTable("select * from Thuoc");
            MessageBox.Show("Thêm thành công", "Thông Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            xoaText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from Thuoc where MaThuoc=N'" + txtMaThuoc.Text + "'";
            DataAcces.GetDataTable(sql);
            dgvThuoc.DataSource = DataAcces.GetDataTable("select * from Thuoc");
            MessageBox.Show("Xóa thành công", "Thông Báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            xoaText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update Thuoc set TenThuoc=N'" + txtTenThuoc.Text +
                "', DonVi=N'" + txtDonVi.Text +
                "', DonGia=" + txtDonGia.Text +
                " where MaThuoc=N'" + txtMaThuoc.Text + "'";
            DataAcces.GetDataTable(sql);
            dgvThuoc.DataSource = DataAcces.GetDataTable("select * from Thuoc");
            MessageBox.Show("Sửa thành công", "Thông Báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            xoaText();
        }

        private void dgvThuoc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThuoc.CurrentRow != null)
            {
                txtMaThuoc.Text = dgvThuoc.CurrentRow.Cells[0].Value.ToString();
                txtMaThuoc.Enabled = false;
                txtTenThuoc.Text = dgvThuoc.CurrentRow.Cells[1].Value.ToString();
                txtDonVi.Text = dgvThuoc.CurrentRow.Cells[2].Value.ToString();
                txtDonGia.Text = dgvThuoc.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formMenu();
            form.ShowDialog();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xoaText();
        }

        private void dgvThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
