using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_LTUDNet.BLL
{
    internal class BllKhachHang
    {
        DAL.DalKhachHang dalKH;
        TrangChu TT;
        LopChung lopChung;

        public BllKhachHang(TrangChu TaC)
        {
            dalKH = new DAL.DalKhachHang();
            TT = TaC;
            lopChung = new LopChung();
        }
        public void LoadKH()
        {
            TT.dataGridView1.DataSource = dalKH.LoadSV();
        }
        public void BllThemKH()
        {
            dalKH.DalThemKH(TT.txt_MaKH.Text, TT.txt_HoTen.Text, TT.txt_MaCCCD.Text, TT.dateTimePicker1.Value, TT.cb_MaPhong.SelectedValue.ToString());
        }
        public void BllSuaKH()
        {
            dalKH.DalSuaKH(TT.txt_MaKH.Text, TT.txt_HoTen.Text, TT.txt_MaCCCD.Text, TT.dateTimePicker1.Value, TT.cb_MaPhong.SelectedValue.ToString());
        }
        public void BllXoaKH()
        {
            dalKH.DalXoaKH(TT.txt_MaKH.Text);
        }
        public void BllTimKH()
        {
            TT.dataGridView1.DataSource =  dalKH.DalTimKiemKH(TT.txt_MaKH.Text,TT.txt_HoTen.Text);
        }
    }
}
