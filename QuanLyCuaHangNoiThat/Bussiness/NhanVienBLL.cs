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
    class NhanVienBLL
    {
        NhanVienDAL dal = new NhanVienDAL();
        //
        public DataTable LoadNV()
        {
            return dal.Getdata();
        }
        //Thêm nhân viên
        public void ThemNV(NhanVien nv)
        {
            dal.ThemNV(nv);
        }
        // Sửa nhân viên
        public void SuaNV(NhanVien nv)
        {
            dal.SuaNV(nv);
        }
        // Xóa nhân viên
        public void XoaNV(NhanVien nv)
        {
            dal.XoaNV(nv);
        }
        // Hàm lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dal.LayDuLieu(DieuKien);
        }
    }
}
