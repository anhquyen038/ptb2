using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_LTUDNet
{
    public partial class DangNhap : Form
    {
        BLL.BllLogin bllLogin;
        public DangNhap()
        {
            InitializeComponent();
            lopChung = new LopChung();
            bllLogin = new BLL.BllLogin(this);
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_TaiKhoan.Text = String.Empty;
            txt_MatKhau.Text = String.Empty;
        }
        LopChung lopChung;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            //string sql = "select count(*) from TaiKhoan where " +
            //    " TenDangNhap = '" + txt_TaiKhoan.Text + "' and MatKhau = '" + txt_MatKhau.Text + "'  ";
            //int kq = lopChung.Scalar(sql);
            //if (kq >= 1)
            //{
            //    MessageBox.Show("Đăng nhập thành công !");
            //    TrangChu f = new TrangChu();
            //    this.Visible = false;
            //    f.ShowDialog();
            //    this.Visible = true;
            //}
            //else MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác !");
            bllLogin.BllLoginKH();

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
