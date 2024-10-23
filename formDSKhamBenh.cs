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
    public partial class formDSKhamBenh : Form
    {
        public formDSKhamBenh()
        {
            InitializeComponent();
        }
        private void xoaText()
        {
            txtMaBN.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            rdbNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
        }
        private void formDSKhamBenh_Load(object sender, EventArgs e)
        {
            dgvBenhNhan.DataSource = DataAcces.GetDataTable("select * from BenhNhan");
            dgvBenhNhan.Columns[0].HeaderText = "Mã";
            dgvBenhNhan.Columns[1].HeaderText = "Họ Tên";
            dgvBenhNhan.Columns[2].HeaderText = "Ngày Sinh";
            dgvBenhNhan.Columns[3].HeaderText = "Giới Tính";
            dgvBenhNhan.Columns[4].HeaderText = "Địa Chỉ";
            txtMaBN.Focus();
            xoaText();
        }

        private void dgvBenhNhan_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvBenhNhan.CurrentRow != null)
            {
                txtMaBN.Text = dgvBenhNhan.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dgvBenhNhan.CurrentRow.Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvBenhNhan.CurrentRow.Cells[2].Value.ToString();
                string gioiTinh = dgvBenhNhan.CurrentRow.Cells[3].Value.ToString();
                if(gioiTinh == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else if(gioiTinh == "Nữ") 
                { 
                    rdbNu.Checked = true;
                }
                txtDiaChi.Text = dgvBenhNhan.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String gioiTinh = null;
            if(rdbNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if(rdbNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            String sql = "Insert into BenhNhan values(N'" + txtMaBN.Text +
                "', N'" + txtHoTen.Text + "', '" + dtpNgaySinh.Text +
                "', N'" + gioiTinh + "', N'" + txtDiaChi.Text + "')";
            DataAcces.AddEditDelete(sql);
            dgvBenhNhan.DataSource = DataAcces.GetDataTable("select * from BenhNhan");
            MessageBox.Show("Đã thêm thành công", "Thông Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            xoaText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String gioiTinh = null;
            if (rdbNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdbNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            String sql = "Update BenhNhan set TenBN=N'" + txtHoTen.Text +
                "', NgaySinh='" + dtpNgaySinh.Text +
                "', GioiTinh=N'" + gioiTinh +
                "', DiaChi=N'" + txtDiaChi.Text +
                "' where MaBN=N'" + txtMaBN.Text + "'";
            DataAcces.AddEditDelete(sql);
            dgvBenhNhan.DataSource = DataAcces.GetDataTable("select * from BenhNhan");
            MessageBox.Show("Đã sửa thành công", "Thông Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            xoaText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formMenu();
            form.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql = "Delete from BenhNhan where MaBN=N'" + txtMaBN.Text + "'";
            DataAcces.AddEditDelete(sql);
            dgvBenhNhan.DataSource = DataAcces.GetDataTable("select * from BenhNhan");
            MessageBox.Show("Đã xóa thành công", "Thông Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            xoaText();
        }
    }
}
