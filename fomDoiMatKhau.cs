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
    public partial class fomDoiMatKhau : Form
    {
        private string a;
        private string b;
        public fomDoiMatKhau(string a, string b)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "Update NguoiDung set MatKhau=N'" + txtMkmoi2.Text +
                "' where TenDangNhap=N'" + a +
                "' and MatKhau=N'" + b + "'";
            DataAcces.AddEditDelete(sql);
        }
    }
}
