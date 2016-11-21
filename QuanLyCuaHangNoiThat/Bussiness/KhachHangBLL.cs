using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyCuaHangNoiThat.Entities;
using QuanLyCuaHangNoiThat.DataAccessLayer;

namespace QuanLyCuaHangNoiThat.Bussiness
{
     public class KhachHangBLL
    {
        KhachHangDAL dal = new KhachHangDAL();
        public DataTable LoadKH()
        {
            return dal.Getdata();
        }
        // Thêm khách hàng
        public void ThemKH(KhachHang kh)
        {
            dal.ThemKH(kh);
        }
        // Sửa khách hàng
        public void SuaKH(KhachHang kh)
        {
            dal.SuaKH(kh);
        }
        // Xóa khách hàng
        public void XoaKH(KhachHang kh)
        {
            dal.XoaKH(kh);
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dal.LayDuLieu(DieuKien);
        }
    }
}
