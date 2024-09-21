using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_LTUDNet.DAL
{
    internal class DalKhachHang
    {
        LopChung lopChung;
        public DalKhachHang() {
            lopChung = new LopChung();
        }
        public DataTable LoadSV()
        {
            String sqlGrid = "select * from KhachHang";
            return lopChung.LoadData(sqlGrid);
        }
        public void DalThemKH(string MaKH,String HoTen,String MaCCCD,DateTime ngay,string MaPhong)
        {
            String sql = "insert into KhachHang values ('" + MaKH + "',N'" + HoTen + "','" + MaCCCD + "' ,Convert(Datetime,'" + ngay + "', 103) ,'" + MaPhong + "',null,null)";
            lopChung.Nonquery(sql);
        }
        public void DalSuaKH(string MaKH, String HoTen, String MaCCCD, DateTime ngay, string MaPhong)
        {
            string sql = " UPDATE KhachHang set HoTen = N'" + HoTen + "'," +
               "SoCCCD = '" + MaCCCD + "'," +
               "NgayDen = Convert(Datetime,'" + ngay + "',103) ," +
               "MaPhong = '" + MaPhong + "' ," +
               "SoNgayLuuTru = null,ThanhTien = null" +
               " WHERE MaKH = '" + MaKH + "' ";
            lopChung.Nonquery(sql);
        }
        public void DalXoaKH(String MaKH)
        {
            string sql = " DELETE FROM KhachHang WHERE MaKH = '" + MaKH + "' ";
            lopChung.Nonquery(sql);
        }
        public DataTable DalTimKiemKH(String MaKH,String HoTen)
        {
            String sql = "select * from KhachHang where " +
                "MaKH like '%" + MaKH + "%' and HoTen like '%" + HoTen + "%'";
            return lopChung.LoadData(sql);
        }
    }
}
