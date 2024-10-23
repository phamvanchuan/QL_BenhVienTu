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
    public partial class formBCDoanhThu : Form
    {
        public formBCDoanhThu()
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
                                  Thuoc.DonGia * ChiTietToaThuoc.SoLuong,
                                  HoaDonThuoc.TienThuoc + HoaDonThuoc.TienKham,
                                  HoaDonThuoc.NgayBan
                           from Thuoc, HoaDonThuoc, ChiTietToaThuoc
                           where Thuoc.MaThuoc = ChiTietToaThuoc.MaThuoc 
                                 and ChiTietToaThuoc.MaPK = HoaDonThuoc.MaPK
                                 and MONTH(HoaDonThuoc.NgayBan) = '" + cbxThang.Text +
                               "' and YEAR(HoaDonThuoc.NgayBan) = '" + txtNam.Text + "'";
            dgvDoanhThu.DataSource = DataAcces.GetDataTable(sql);
            dgvDoanhThu.Columns[0].HeaderText = "Mã Thuốc";
            dgvDoanhThu.Columns[1].HeaderText = "Tên Thuốc";
            dgvDoanhThu.Columns[2].HeaderText = "Giá Gốc";
            dgvDoanhThu.Columns[3].HeaderText = "Tổng Tiền";
            dgvDoanhThu.Columns[4].HeaderText = "Ngày Bán";
        }
    }
}
