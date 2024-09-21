using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_LTUDNet
{
    public partial class ThongTinTaiKhoan : Form
    {
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
            lopChung = new LopChung();
        }
        LopChung lopChung;
        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            if(txt_NhapMKMoi.Text == txt_NhapLaiMK.Text)
            {
                string sql = " UPDATE TaiKhoan set MatKhau = '"+txt_NhapLaiMK.Text+"' " +
                    "where TenDangNhap = '"+txt_TaiKhoan.Text+"' ";
                //pictureBox1.Image.Save("C:\\Users\\anhqu\\OneDrive\\Pictures\\" + txt_TenHinh.Text);
                int kq = lopChung.Scalar1(sql);
                if (kq >= 1)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công !");
                }
                else MessageBox.Show("Thay đổi mật khẩu không thành công !");
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng mật khẩu bạn vừa nhập !");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
