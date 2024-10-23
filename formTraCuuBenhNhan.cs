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
    public partial class formTraCuuBenhNhan : Form
    {
        public formTraCuuBenhNhan()
        {
            InitializeComponent();
        }

        private void dtpNgayKham_ValueChanged(object sender, EventArgs e)
        {
            String sql = @"Select BenhNhan.MaBN, 
                                 BenhNhan.TenBN,
                                 BenhNhan.NgaySinh,
                                 BenhNhan.GioiTinh,
                                 BenhNhan.DiaChi
                          from BenhNhan, PhieuKham
                          where BenhNhan.MaBN = PhieuKham.MaBN 
                                and PhieuKham.NgayKham = '" + dtpNgayKham.Text + "'";
            dgvTraCuuBenhNhan.DataSource = DataAcces.GetDataTable(sql);
            dgvTraCuuBenhNhan.Columns[0].HeaderText = "Mã BN";
            dgvTraCuuBenhNhan.Columns[1].HeaderText = "Tên BN";
            dgvTraCuuBenhNhan.Columns[2].HeaderText = "Ngày Sinh";
            dgvTraCuuBenhNhan.Columns[3].HeaderText = "Giới Tính";
            dgvTraCuuBenhNhan.Columns[4].HeaderText = "Địa Chỉ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formMenu();
            form.ShowDialog();
        }

        private void formTraCuuBenhNhan_Load(object sender, EventArgs e)
        {
            
        }
    }
}
