using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_LTUDNet.DAL
{
    internal class DalLogin
    {
        LopChung lopChung;
        public DalLogin()
        {
            lopChung = new LopChung();
        }
        public int DalLoginKH(string taiKhoan,string matKhau)
        {
            string sql = "select count(*) from TaiKhoan where " +
               " TenDangNhap = '" +taiKhoan + "' and MatKhau = '" + matKhau + "'  ";
            return lopChung.Scalar(sql);
        }
    }
}
