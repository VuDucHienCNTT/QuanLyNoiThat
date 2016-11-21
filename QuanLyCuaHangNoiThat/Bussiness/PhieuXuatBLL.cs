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
    class PhieuXuatBLL
    {
        PhieuXuatDAL dal = new PhieuXuatDAL();
        public DataTable LoadPX()
        {
            return dal.Getdata();
        }
        // Thêm phiếu xuất
        public void ThemPX(PhieuXuat px)
        {
            dal.ThemPX(px);
        }
        // Sửa phiếu xuất
        public void SuaPX(PhieuXuat px)
        {
            dal.SuaPX(px);
        }
        // Xóa phiếu xuất
        public void XoaPX(PhieuXuat px)
        {
            dal.XoaPX(px);
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dal.LayDuLieu(DieuKien);
        }
        // Lấy thông tin nhân viên
        public DataTable LayThongTinNV(string DieuKien)
        {
            return dal.LayThongTinNV(DieuKien);
        }
        // Lấy thông tin khách hàng
        public DataTable LayThongTinKH(string DieuKien)
        {
            return dal.LayThongTinKH(DieuKien);
        }
    }
}
