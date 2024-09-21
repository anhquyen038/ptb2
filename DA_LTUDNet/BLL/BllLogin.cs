using DA_LTUDNet.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_LTUDNet.BLL
{
    internal class BllLogin
    {
        DAL.DalLogin dalLogin;
        DangNhap DN;
        LopChung lopChung;

        public BllLogin(DangNhap TaC)
        {
            dalLogin = new DAL.DalLogin();
            DN = TaC;
            lopChung = new LopChung();
        }
        public void BllLoginKH()
        {
            int kq = dalLogin.DalLoginKH(DN.txt_TaiKhoan.Text, DN.txt_MatKhau.Text);
            if (kq >= 1)
            {
                MessageBox.Show("Đăng nhập thành công !");
                TrangChu f = new TrangChu();
                f.ShowDialog();
            }
            else MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác !");
        }
    }
}
