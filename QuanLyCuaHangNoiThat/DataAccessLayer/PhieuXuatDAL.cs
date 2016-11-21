using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyCuaHangNoiThat.Entities;

namespace QuanLyCuaHangNoiThat.DataAccessLayer
{
    public class PhieuXuatDAL
    {
        DataAccessHelper dah = new DataAccessHelper();
        public DataTable Getdata()
        {
            return dah.GetDataTable("Select MaPX,MaNV,MaKH,NgayXuat from tblPhieuXuat");
        }

        // Thêm phiếu xuất
        public void ThemPX(PhieuXuat px)
        {
            dah.ThucThiCauLenhSQL("INSERT INTO tblPhieuXuat VALUES('" + px.Mapx + "','" + px.Manv + "','" + px.Makh + "','" + px.Ngayxuat + "')");
        }
        // Sửa phiếu xuất
        public void SuaPX(PhieuXuat px)
        {
            dah.ThucThiCauLenhSQL("UPDATE tblPhieuXuat SET  MaKH ='" + px.Makh + "',NgayXuat ='" + px.Ngayxuat + "' where MaPX='" + px.Mapx + "'");
        }
        // Xóa phiếu xuất
        public void XoaPX(PhieuXuat px)
        {
            dah.ThucThiCauLenhSQL("DELETE FROM tblPhieuXuat where MaPX='" + px.Mapx + "'");
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dah.GetDataTable("Select * from tblPhieuXuat " + DieuKien);
        }
        // Lấy thông tin nhân viên
        public DataTable LayThongTinNV(string DieuKien)
        {
            return dah.GetDataTable("Select MaNV from tblNhanVien " + DieuKien);
        }
        // Lấy thông tin khách hàng
        public DataTable LayThongTinKH(string DieuKien)
        {
            return dah.GetDataTable("Select MaKH from tblKhachHang " + DieuKien);
        }
    }
}
