using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyCuaHangNoiThat.Entities;

namespace QuanLyCuaHangNoiThat.DataAccessLayer
{
    public class PhieuNhapDAL
    {
        DataAccessHelper dah = new DataAccessHelper();
        public DataTable Getdata()
        {
            return dah.GetDataTable("Select MaPN,MaNV,MaNCC,NgayNhap from tblPhieuNhap");
        }
        // Thêm phiếu nhập
        public void ThemPN(PhieuNhap pn)
        {
            dah.ThucThiCauLenhSQL("INSERT INTO tblPhieuNhap VALUES('"+pn.Mapn+"','"+pn.Manv+"','"+pn.Mancc+"','"+pn.Ngaynhap+"')");
        }
        // Sửa phiếu nhập
        public void SuaPN(PhieuNhap pn)
        {
            dah.ThucThiCauLenhSQL("UPDATE tblPhieuNhap SET MaNCC ='" + pn.Mancc + "', NgayNhap ='" + pn.Ngaynhap + "' where MaPN='" + pn.Mapn + "'");
        }
        // Xóa phiếu nhập
        public void XoaPN(PhieuNhap pn)
        {
            dah.ThucThiCauLenhSQL("DELETE FROM tblPhieuNhap where MaPN='" + pn.Mapn + "'");
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dah.GetDataTable("Select * from tblPhieuNhap " +DieuKien);
        }
        // Lấy thông tin nhân viên
        public DataTable LayThongTinNV(string DieuKien)
        {
            return dah.GetDataTable("Select MaNV from tblNhanVien " + DieuKien);
        }
        // Lấy thông tin nhà cung cấp
        public DataTable LayThongTinNCC(string DieuKien)
        {
            return dah.GetDataTable("Select MaNCC from tblNhaCungCap " + DieuKien);
        }
    }
}
