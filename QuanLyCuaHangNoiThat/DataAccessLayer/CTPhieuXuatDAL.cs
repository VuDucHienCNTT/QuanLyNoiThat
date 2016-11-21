using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyCuaHangNoiThat.Entities;

namespace QuanLyCuaHangNoiThat.DataAccessLayer
{
   public class CTPhieuXuatDAL
    {
       DataAccessHelper dah = new DataAccessHelper();
       
        // Thêm chi tiết phiếu xuất
       public void ThemCTPX(CTPhieuXuat ctpx)
       {
           dah.ThucThiCauLenhSQL("INSERT INTO tblCTPX VALUES('" + ctpx.Mapx + "','" + ctpx.Masp + "','" + ctpx.Soluongxuat + "','" + ctpx.Dongiaxuat + "',(" + ctpx.Soluongxuat + " * " + ctpx.Dongiaxuat + "),'" + ctpx.Donvitinh + "')");
       }
        // Sửa chi tiết phiếu xuất
       public void SuaCTPX(CTPhieuXuat ctpx)
       {
           dah.ThucThiCauLenhSQL("UPDATE tblCTPX SET SoLuongXuat ='" + ctpx.Soluongxuat + "', DonGiaXuat ='" + ctpx.Dongiaxuat + "', ThanhTien =(" + ctpx.Soluongxuat + " * " + ctpx.Dongiaxuat + "), DonViTinh ='" + ctpx.Donvitinh + "' where MaPX ='" + ctpx.Mapx + "'");
       }
        // Xóa chi tiết phiếu xuất
       public void XoaCTPX(CTPhieuXuat ctpx)
       {
           dah.ThucThiCauLenhSQL("DELETE FROM tblCTPX where MaPX ='" + ctpx.Mapx + "'");
       }
       // Lấy dữ liệu đổ lên datagridview
       public DataTable LayDuLieu(string DieuKien)
       { 
           return dah.GetDataTable("Select * from tblCTPX " + DieuKien);
       }
       // Lấy thông tin phiếu xuất
       public DataTable LayThongTinPX(string DieuKien)
       {
           return dah.GetDataTable("Select MaPX from tblPhieuXuat " +DieuKien);
       }
       // Lấy thông tin sản phẩm
       public DataTable LayThongTinSP(string DieuKien)
       {
           return dah.GetDataTable("Select MaSP from tblSanPham " +DieuKien);
       }
    }
}
