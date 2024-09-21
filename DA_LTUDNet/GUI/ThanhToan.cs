using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_LTUDNet
{
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
            lopChung = new LopChung();
        }
        LopChung lopChung;
        public void LoadGrid()
        {
            //String diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LT .Net (File Thầy)\\DA_LTNet\\DA_LTUDNet\\DA_LTUDNet\\KHACHSAN.mdf\";Integrated Security=True";
            //SqlConnection conn = new SqlConnection(diaChi);
            String sqlGrid = "select MaKH,HoTen,NgayDen,K.MaPhong,DonGia from KhachHang K,Phong P where K.MaPhong = P.MaPhong";
            //SqlDataAdapter da = new SqlDataAdapter(sqlGrid, conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            dataGridView1.DataSource =lopChung.LoadData(sqlGrid) ;
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txt_PhongO.Text = dataGridView1.CurrentRow.Cells["MaPhong"].Value.ToString();
            string ngayDen = dataGridView1.CurrentRow.Cells["NgayDen"].Value.ToString();
            DateTime dateTime = DateTime.ParseExact(ngayDen, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime now = DateTime.Now;
            TimeSpan difference = now - dateTime;
            int days = difference.Days;
            txt_NgayO.Text = days.ToString();
            txt_GiaPhong.Text = dataGridView1.CurrentRow.Cells["DonGia"].Value.ToString();
            //txt_MaCCCD.Text = dataGridView1.CurrentRow.Cells["SoCCCD"].Value.ToString();
        }

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            int ngay = int.Parse(txt_NgayO.Text);
            int giaTien =int.Parse(txt_GiaPhong.Text);
            int thanhTien = ngay * giaTien;
            txt_ThanhToan.Text = thanhTien.ToString();
        }
    }
}
