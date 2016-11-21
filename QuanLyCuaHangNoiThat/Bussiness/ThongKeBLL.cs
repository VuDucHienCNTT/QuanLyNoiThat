using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyCuaHangNoiThat.Entities;
using QuanLyCuaHangNoiThat.DataAccessLayer;

namespace QuanLyCuaHangNoiThat.Bussiness
{
    class ThongKeBLL
    {
        ThongKeDAL dal = new ThongKeDAL();
        public DataTable ThongKeSPBanCham()
        {
            return dal.ThongKeSPBanCham();
        }
    }
}
