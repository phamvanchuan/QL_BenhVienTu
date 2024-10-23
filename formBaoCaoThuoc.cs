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
    public partial class formBaoCaoThuoc : Form
    {
        public formBaoCaoThuoc()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new formMenu();
            form.ShowDialog();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            String sql = @"Select Thuoc.MaThuoc,
                                  Thuoc.TenThuoc,
                                  Thuoc.DonVi,
                                  Thuoc.DonGia,
                                  HoaDonThuoc.NgayBan
                           from Thuoc, HoaDonThuoc, ChiTietToaThuoc
                           where Thuoc.MaThuoc = ChiTietToaThuoc.MaThuoc 
                                 and ChiTietToaThuoc.MaPK = HoaDonThuoc.MaPK
                                 and MONTH(HoaDonThuoc.NgayBan) = '" + cbxThang.Text +
                               "' and YEAR(HoaDonThuoc.NgayBan) = '" + txtNam.Text + "'";
            dgvBaoCaoThuoc.DataSource = DataAcces.GetDataTable(sql);
            dgvBaoCaoThuoc.Columns[0].HeaderText = "Mã Thuốc";
            dgvBaoCaoThuoc.Columns[1].HeaderText = "Tên Thuốc";
            dgvBaoCaoThuoc.Columns[2].HeaderText = "Đơn Vị";
            dgvBaoCaoThuoc.Columns[3].HeaderText = "Đơn Giá";
            dgvBaoCaoThuoc.Columns[4].HeaderText = "Ngày Bán";
        }
    }
}
