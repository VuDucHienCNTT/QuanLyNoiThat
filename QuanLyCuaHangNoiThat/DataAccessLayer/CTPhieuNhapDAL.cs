using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyCuaHangNoiThat.Entities;

namespace QuanLyCuaHangNoiThat.DataAccessLayer
{
    class CTPhieuNhapDAL
    {
        DataAccessHelper dah = new DataAccessHelper();
        // Thêm chi tiết phiếu nhập
        public void ThemCTPN(CTPhieuNhap ctpn)
        {
            dah.ThucThiCauLenhSQL("INSERT INTO tblCTPN VALUES('" + ctpn.Mapn + "','" + ctpn.Masp + "','" + ctpn.Soluongnhap + "','" + ctpn.Dongianhap + "',(" + ctpn.Soluongnhap + " * " + ctpn.Dongianhap + "),'" + ctpn.Donvitinh + "')");
        }
        // Sửa chi tiết phiếu nhập
        public void SuaCTPN(CTPhieuNhap ctpn)
        {
            dah.ThucThiCauLenhSQL("UPDATE tblCTPN SET SoLuongNhap ='" + ctpn.Soluongnhap + "', DonGiaNhap ='" + ctpn.Dongianhap + "', ThanhTien =(" + ctpn.Soluongnhap + " * " + ctpn.Dongianhap + "), DonViTinh ='" + ctpn.Donvitinh + "' where MaPN ='" + ctpn.Mapn + "'");
        }
        // Xóa chi tiết phiếu nhập
        public void XoaCTPN(CTPhieuNhap ctpn)
        {
            dah.ThucThiCauLenhSQL("DELETE FROM tblCTPN where  MaPN ='" + ctpn.Mapn + "'");
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dah.GetDataTable("Select * from tblCTPN " + DieuKien);
        }
        // Lấy thông tin phiếu nhập
        public DataTable LayThongTinPN(string DieuKien)
        {
            return dah.GetDataTable("Select MaPN from tblPhieuNhap " + DieuKien);
        }
        // Lấy thông tin sản phẩm
        public DataTable LayThongTinSP(string DieuKien)
        {
            return dah.GetDataTable("Select MaSP from tblSanPham " + DieuKien);
        }
    }
}
