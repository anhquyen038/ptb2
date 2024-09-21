using DA_LTUDNet.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_LTUDNet
{
    public partial class TrangChu : Form
    {
        BLL.BllKhachHang bllKH;
        BllPhong bllPhong;
        public TrangChu()
        {
            InitializeComponent();
            lopChung = new LopChung();
            bllKH = new BllKhachHang(this);
            bllPhong = new BllPhong(this);
        }

        LopChung lopChung;
        public void LoadCB()
        {
            //String diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LT .Net (File Thầy)\\DA_LTNet\\DA_LTUDNet\\DA_LTUDNet\\KHACHSAN.mdf\";Integrated Security=True";
            //SqlConnection conn = new SqlConnection(diaChi);
            //String sqlGrid = "select * from Phong";
            //SqlDataAdapter da = new SqlDataAdapter(sqlGrid, conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //cb_MaPhong.DataSource = lopChung.LoadData(sqlGrid);
            //cb_MaPhong.DisplayMember = "MaPhong";
            //cb_MaPhong.ValueMember = "MaPhong";
            bllPhong.BllLoadPhong();
            
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            LoadCB();
            LoadGrid();
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhToan f = new ThanhToan();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan f = new ThongTinTaiKhoan();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }
        public void LoadGrid()
        {
            //String diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LT .Net (File Thầy)\\DA_LTNet\\DA_LTUDNet\\DA_LTUDNet\\KHACHSAN.mdf\";Integrated Security=True";
            //SqlConnection conn = new SqlConnection(diaChi);
            //String sqlGrid = "select * from KhachHang";
            //SqlDataAdapter da = new SqlDataAdapter(sqlGrid, conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = lopChung.LoadData(sqlGrid);
            bllKH.LoadKH();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            LoadGrid();
            txt_Dem.Text = String.Empty;
            txt_HoTen.Text = String.Empty;  
            txt_MaCCCD.Text = String.Empty; 
            txt_MaKH.Text = String.Empty;   
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKH.Text = dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString();
            txt_HoTen.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            txt_MaCCCD.Text = dataGridView1.CurrentRow.Cells["SoCCCD"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NgayDen"].Value.ToString();
            tam = 1;
            cb_MaPhong.SelectedValue = dataGridView1.CurrentRow.Cells["MaPhong"].Value.ToString();
            tam = 0;
        }
        int tam = 0;

        private void cb_MaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tam == 0)
            {
                //string diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LT .Net (File Thầy)\\DA_LTNet\\DA_LTUDNet\\DA_LTUDNet\\KHACHSAN.mdf\";Integrated Security=True";
                //SqlConnection con = new SqlConnection(diaChi);
                string sql = " select * from KhachHang where MaPhong = '" + cb_MaPhong.SelectedValue.ToString() + "' ";

                //SqlDataAdapter da = new SqlDataAdapter(sql, con);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                dataGridView1.DataSource = lopChung.LoadData(sql);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            //string diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LT .Net (File Thầy)\\DA_LTNet\\DA_LTUDNet\\DA_LTUDNet\\KHACHSAN.mdf\";Integrated Security=True";
            //SqlConnection con = new SqlConnection(diaChi);
            //String sql = "select * from KhachHang where " +
            //    "MaKH like '%" + txt_MaKH.Text + "%' and HoTen like '%" + txt_HoTen.Text + "%'";
            //SqlDataAdapter da = new SqlDataAdapter(sql, con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = lopChung.LoadData(sql);
            bllKH.BllTimKH();

        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            //string diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LT .Net (File Thầy)\\DA_LTNet\\DA_LTUDNet\\DA_LTUDNet\\KHACHSAN.mdf\";Integrated Security=True";
            //SqlConnection con = new SqlConnection(diaChi);
            //String sql = "select * from KhachHang where " +
            //    "MaKH like '%" + txt_MaKH.Text + "%' and HoTen like '%" + txt_HoTen.Text + "%'";
            //String sql = "insert into KhachHang values ('" + txt_MaKH.Text + "',N'" + txt_HoTen.Text + "','"+txt_MaCCCD.Text+"' ,Convert(Datetime,'" + dateTimePicker1.Value + "', 103) ,'"+cb_MaPhong.SelectedValue.ToString()+"',null,null)";
            //lopChung.Nonquery(sql);
            bllKH.BllThemKH();
            //SqlDataAdapter da = new SqlDataAdapter(sql, con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            LoadGrid();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //string diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LT .Net (File Thầy)\\DA_LTNet\\DA_LTUDNet\\DA_LTUDNet\\KHACHSAN.mdf\";Integrated Security=True";
            //SqlConnection con = new SqlConnection(diaChi);
            //string sql = " UPDATE KhachHang set HoTen = N'" + txt_HoTen.Text + "'," +
            //    "SoCCCD = '"+txt_MaCCCD.Text+"'," +
            //    "NgayDen = Convert(Datetime,'" + dateTimePicker1.Value + "',103) ," +
            //    "MaPhong = '" + cb_MaPhong.SelectedValue.ToString() + "' ," +
            //    "SoNgayLuuTru = null,ThanhTien = null"+
            //    " WHERE MaKH = '" + txt_MaKH.Text + "' ";
            //pictureBox1.Image.Save("C:\\Users\\anhqu\\OneDrive\\Pictures\\" + txt_TenHinh.Text);
            //SqlDataAdapter da = new SqlDataAdapter(sql, con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //lopChung.Nonquery( sql);
            bllKH.BllSuaKH();
            LoadGrid();
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            //string diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LT .Net (File Thầy)\\DA_LTNet\\DA_LTUDNet\\DA_LTUDNet\\KHACHSAN.mdf\";Integrated Security=True";
            //SqlConnection con = new SqlConnection(diaChi);
            //string sql = " DELETE FROM KhachHang WHERE MaKH = '"+txt_MaKH.Text+"' ";
            //lopChung.Nonquery(sql);
            //SqlDataAdapter da = new SqlDataAdapter(sql, con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            bllKH.BllXoaKH();
            LoadGrid();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            //string diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LT .Net (File Thầy)\\DA_LTNet\\DA_LTUDNet\\DA_LTUDNet\\KHACHSAN.mdf\";Integrated Security=True";
            //SqlConnection con = new SqlConnection(diaChi);
            String sql = "Select count(*) from KhachHang";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //con.Open();
            int kq = lopChung.Scalar(sql);
                //(int) cmd.ExecuteScalar();
            txt_Dem.Text = kq.ToString();
            //con.Close();
        }


    }
}
