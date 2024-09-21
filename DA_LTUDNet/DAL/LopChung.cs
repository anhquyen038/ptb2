using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_LTUDNet
{
    internal class LopChung
    {
        string diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LT .Net (File Thầy)\\DA_LTNet\\DA_LTUDNet\\DA_LTUDNet\\KHACHSAN.mdf\";Integrated Security=True";
        SqlConnection con;
        //= new SqlConnection(diaChi);
        public LopChung() {
            con = new SqlConnection(diaChi);
        }
        public DataTable LoadData(String sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void Nonquery(String sqlN)
        {
            SqlCommand comm = new SqlCommand(sqlN, con);
            con.Open();
            int kq = comm.ExecuteNonQuery();
            con.Close();
            if (kq >= 1)
            {
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
        }
        public int Scalar(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int kq =(int) cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
        public int Scalar1(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int kq = (int)cmd.ExecuteNonQuery();
            con.Close();
            return kq;
        }
    }
}
