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
    class SanPhamBLL
    {
        SanPhamDAL dal = new SanPhamDAL();

        public DataTable LoadSP()
        {
            return dal.Getdata();
        }
        // Thêm sản phẩm
        public void ThemSP(SanPham sp)
        {
            dal.ThemSP(sp);
        }
        // Sửa sản phẩm 
        public void SuaSP(SanPham sp)
        {
            dal.SuaSP(sp);
        }
        // Xóa sản phẩm
        public void XoaSP(SanPham sp)
        {
            dal.XoaSP(sp);
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dal.LayDuLieu(DieuKien);
        }
    }
}
