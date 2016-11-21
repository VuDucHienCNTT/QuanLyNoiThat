using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyCuaHangNoiThat.Entities;

namespace QuanLyCuaHangNoiThat.DataAccessLayer
{
    public class KhachHangDAL
    {
        DataAccessHelper dah = new DataAccessHelper();

        public DataTable Getdata()
        {
            return dah.GetDataTable("select MaKH,TenKH,GioiTinh,DiaChi,DienThoai from tblKhachHang");
        }
        // Thêm khách hàng
        public void ThemKH(KhachHang kh)
        {
            dah.ThucThiCauLenhSQL("INSERT INTO tblKhachHang VALUES('" + kh.Makh + "',N'" + kh.Tenkh + "',N'" + kh.Gioitinh + "',N'" + kh.Diachi + "','" + kh.Sdt + "')");
        }
        // Sửa khách hàng
        public void SuaKH(KhachHang kh)
        {
            dah.ThucThiCauLenhSQL("UPDATE tblKhachHang SET TenKH =N'" + kh.Tenkh + "', GioiTinh =N'" + kh.Gioitinh + "', DiaChi =N'" + kh.Diachi + "', DienThoai ='" + kh.Sdt + "' where MaKH = '" + kh.Makh + "'");
        }
        // Xóa khách hàng
        public void XoaKH(KhachHang kh)
        {
            dah.ThucThiCauLenhSQL("DELETE FROM tblKhachHang where MaKH = '"+kh.Makh+"'");
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dah.GetDataTable("Select * from tblKhachHang " +DieuKien);
        }
    }
}
