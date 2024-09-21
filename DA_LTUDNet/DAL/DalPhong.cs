using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_LTUDNet.DAL
{
    internal class DalPhong
    {
        LopChung lopChung;
        public DalPhong() { 
            lopChung = new LopChung();
        }
        public DataTable LoadPhong()
        {
            String sqlGrid = "select * from Phong";
            return lopChung.LoadData(sqlGrid);
        }
    }
}
