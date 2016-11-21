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
    class CTPhieuXuatBLL
    {
        CTPhieuXuatDAL dal = new CTPhieuXuatDAL();

        // Thêm chi tiết phiếu xuất
        public void ThemCTPX(CTPhieuXuat ctpx)
        {
            dal.ThemCTPX(ctpx);
        }
        // Sửa chi tiết phiếu xuất
        public void SuaCTPX(CTPhieuXuat ctpx)
        {
            dal.SuaCTPX(ctpx);
        }
        // Xóa chi tiết phiếu xuất
        public void XoaCTPX(CTPhieuXuat ctpx)
        {
            dal.XoaCTPX(ctpx);
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dal.LayDuLieu(DieuKien);
        }
        // Lấy thông tin phiếu xuất
        public DataTable LayThongTinPX(string DieuKien)
        {
            return dal.LayThongTinPX(DieuKien);
        }
        // Lấy thông tin sản phẩm
        public DataTable LayThongTinSP(string DieuKien)
        {
            return dal.LayThongTinSP(DieuKien);
        }
    }
}
