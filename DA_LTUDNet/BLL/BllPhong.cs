using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_LTUDNet.BLL
{
    internal class BllPhong
    {
        DAL.DalPhong dalP;
        TrangChu TT;
        LopChung lopChung;

        public BllPhong(TrangChu TaC)
        {
            dalP = new DAL.DalPhong();
            TT = TaC;
            lopChung = new LopChung();
        }
        public void BllLoadPhong()
        {
            TT.cb_MaPhong.DataSource = dalP.LoadPhong();
            TT.cb_MaPhong.DisplayMember = "MaPhong";
            TT.cb_MaPhong.ValueMember = "MaPhong";
        }
    }
}
