using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangNoiThat.DataAccessLayer
{
   public class ThongKeDAL
    {
        DataAccessHelper dah = new DataAccessHelper();
        public DataTable ThongKeSPBanCham()
        {
            DataTable dt = new DataTable();
            dt = dah.GetDataTable("select top(1) s.MaSP,s.TenSP,sum(x.SoLuongXuat) [Số lượng bán] from tblSanPham s,tblCTPX x where s.MaSP=x.MaSP group by s.MaSP,s.TenSP order by [Số lượng bán] asc");
            return dt;
        }
    }
}
