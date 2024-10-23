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
    public partial class formQLNguoiDung : Form
    {
        public formQLNguoiDung()
        {
            InitializeComponent();
        }

        private void xoaText()
        {
            txtMaNV.Text = "";
            txtTenNguoiDung.Text = "";
            txtNgaySinh.Text = "";
            rdoNam.Checked = true;
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            cbxChucVu.Text = "";
            txtMaNV.Enabled = true;
        }
        private void formQLNguoiDung_Load(object sender, EventArgs e)
        {
            txtTenNguoiDung.Focus();
            dgvNguoiDung.DataSource = DataAcces.GetDataTable("select * from NguoiDung");
            dgvNguoiDung.Columns[0].HeaderText = "Mã ND";
            dgvNguoiDung.Columns[1].HeaderText = "Tên ND";
            dgvNguoiDung.Columns[2].HeaderText = "Ngày Sinh";
            dgvNguoiDung.Columns[3].HeaderText = "Giới Tính";
            dgvNguoiDung.Columns[4].HeaderText = "Địa Chỉ";
            dgvNguoiDung.Columns[5].HeaderText = "SĐT";
            dgvNguoiDung.Columns[6].HeaderText = "Tên ĐN";
            dgvNguoiDung.Columns[7].HeaderText = "Mật Khẩu";
            dgvNguoiDung.Columns[8].HeaderText = "Chức Vụ";
            xoaText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String gioiTinh = "Nữ";
            if(rdoNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if(rdoNu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            string sql = "insert into NguoiDung values(N'" +
                txtMaNV.Text + "',N'" +
                txtTenNguoiDung.Text + "',N'" +
                txtNgaySinh.Text + "',N'" +
                gioiTinh + "',N'" +
                txtDiaChi.Text + "',N'" +
                txtSoDienThoai.Text + "',N'" +
                txtTenDangNhap.Text + "',N'" +
                txtMatKhau.Text + "',N'" +
                cbxChucVu.Text + "')";
            DataAcces.AddEditDelete(sql);
            dgvNguoiDung.DataSource = DataAcces.GetDataTable("select * from NguoiDung");
            MessageBox.Show("Đã thêm thành công", "Thông Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            xoaText();
        }

        private void dgvNguoiDung_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvNguoiDung.CurrentRow != null)
            {
                txtMaNV.Text = dgvNguoiDung.CurrentRow.Cells[0].Value.ToString();
                txtMaNV.Enabled = false;
                txtTenNguoiDung.Text = dgvNguoiDung.CurrentRow.Cells[1].Value.ToString();
                txtNgaySinh.Text = dgvNguoiDung.CurrentRow.Cells[2].Value.ToString();
                string gioiTinh = dgvNguoiDung.CurrentRow.Cells[3].Value.ToString();
                if (gioiTinh == "Nữ")
                {
                    rdoNu.Checked = true;
                }
                else if (gioiTinh == "Nam")
                {
                    rdoNam.Checked = true;
                }
                txtDiaChi.Text = dgvNguoiDung.CurrentRow.Cells[4].Value.ToString();
                txtSoDienThoai.Text = dgvNguoiDung.CurrentRow.Cells[5].Value.ToString();
                txtTenDangNhap.Text = dgvNguoiDung.CurrentRow.Cells[6].Value.ToString();
                txtMatKhau.Text = dgvNguoiDung.CurrentRow.Cells[7].Value.ToString();
                cbxChucVu.Text = dgvNguoiDung.CurrentRow.Cells[8].Value.ToString();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            String gioiTinh = "Nữ";
            if (rdoNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if (rdoNu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            String sql = "Update NguoiDung set TenND=N'" + txtTenNguoiDung.Text +
                "', NgaySinh=N'" + txtNgaySinh.Text +
                "', GioiTinh=N'" + gioiTinh +
                "', DiaChi=N'" + txtDiaChi.Text +
                "', SDT=N'" + txtSoDienThoai.Text +
                "', TenDangNhap=N'" + txtTenDangNhap.Text +
                "', MatKhau=N'" + txtMatKhau.Text +
                "', ChucVu=N'" + cbxChucVu.Text +
                "' where MaND=N'" + txtMaNV.Text + "'";
            DataAcces.AddEditDelete(sql);
            dgvNguoiDung.DataSource = DataAcces.GetDataTable("select * from NguoiDung");
            MessageBox.Show("Đã sửa thành công", "Thông Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            xoaText();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from NguoiDung where MaND=N'" + txtMaNV.Text + "'";
            DataAcces.AddEditDelete(sql);
            dgvNguoiDung.DataSource = DataAcces.GetDataTable("select * from NguoiDung");
            MessageBox.Show("Đã xóa thành công", "Thông Báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            xoaText();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xoaText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu form = new formMenu();
            form.ShowDialog();
        }

        private void txtNgaySinh_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
