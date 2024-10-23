using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_BenhVien
{
    internal static class DataAcces
    {
        private static string url = @"Data Source=DESKTOP-CDSNGVK\MAY1;Initial Catalog=QLBenhVien;Integrated Security=True";

        public static SqlConnection taoKetNoi()
        {
            return new SqlConnection(url);
        }
        //lay du lieu
        public static DataTable GetDataTable(String sql)
        {
            SqlConnection conn = taoKetNoi();
            conn.Open();
            SqlDataAdapter data = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            data.Fill(dt);
            conn.Close();
            dt.Dispose();
            return dt;
        }
        // phương thức thêm - sửa - xóa
        public static void AddEditDelete(string sql)
        {
            SqlConnection conn = taoKetNoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        /*
        public static String getValue(string sql)
        {
            SqlConnection conn = taoKetNoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object kq = cmd.ExecuteScalar();
            if (kq == null)
            {
                return "";
            }
            else
            {
                return kq.ToString();
            }
        }*/
        //day du lieu vao combobox
        public static void loadComBox(ComboBox cmb, String sql)
        {
            SqlConnection conn = taoKetNoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            cmb.Items.Clear();
            while (reader.Read())
            {
                String item = reader.GetString(0);
                cmb.Items.Add(item);
            }
            reader.Close();
            conn.Close();
        }
    }
}
