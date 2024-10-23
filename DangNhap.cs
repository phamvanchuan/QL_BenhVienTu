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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string sql = "select * from NguoiDung where TenDangNhap=N'" + txtUser.Text +
            "' and MatKhau=N'" + txtPassWord.Text + "'";
            
            DataTable dt = DataAcces.GetDataTable(sql);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông Báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                string a = dt.Rows[0]["TenDangNhap"].ToString();
                string b = dt.Rows[0]["MatKhau"].ToString();
                var frm = new fomDoiMatKhau(a, b);
                this.Hide();
                formMenu form = new formMenu();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông Báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
                txtUser.SelectAll();
                txtPassWord.Text = "";
            }
        }
    }
}
