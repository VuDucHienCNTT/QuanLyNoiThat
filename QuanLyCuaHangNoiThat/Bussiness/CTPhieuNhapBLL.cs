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
    class CTPhieuNhapBLL
    {
        CTPhieuNhapDAL dal = new CTPhieuNhapDAL();

        // Thêm chi tiết phiếu nhập
        public void ThemCTPN(CTPhieuNhap ctpn)
        {
            dal.ThemCTPN(ctpn);
        }
        // Sửa chi tiết phiếu nhập
        public void SuaCTPN(CTPhieuNhap ctpn)
        {
            dal.SuaCTPN(ctpn);
        }
        // Xóa chi tiết phiếu nhập
        public void XoaCTPN(CTPhieuNhap ctpn)
        {
            dal.XoaCTPN(ctpn);
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dal.LayDuLieu(DieuKien);
        }
        // Lấy thông tin phiếu nhập
        public DataTable LayThongTinPN(string DieuKien)
        {
            return dal.LayThongTinPN(DieuKien);
        }
        // Lấy thông tin sản phẩm
        public DataTable LayThongTinSP(string DieuKien)
        {
            return dal.LayThongTinSP(DieuKien);
        }
    }
}
