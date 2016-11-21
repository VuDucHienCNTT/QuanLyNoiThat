using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyCuaHangNoiThat.Entities;

namespace QuanLyCuaHangNoiThat.DataAccessLayer
{
   public class NhanVienDAL
    {
       DataAccessHelper dah = new DataAccessHelper();
       //
       public DataTable Getdata()
       {
           return dah.GetDataTable("select MaNV,TenNV,GioiTinh,NgaySinh,DiaChi,DienThoai from tblNhanVien");
       }
       //Thêm nhân viên
       public void ThemNV(NhanVien nv)
       {
           dah.ThucThiCauLenhSQL("INSERT INTO tblNhanVien VALUES('"+nv.Manv+"',N'"+nv.Tennv+"',N'"+nv.Gioitinh+"','"+nv.Ngaysinh+"',N'"+nv.Diachi+"','"+nv.Sdt+"')");
       }
       // Sửa nhân viên
       public void SuaNV(NhanVien nv)
       {
           dah.ThucThiCauLenhSQL("UPDATE tblNhanVien SET TenNV =N'"+nv.Tennv+"', GioiTinh =N'"+nv.Gioitinh+"', NgaySinh ='"+nv.Ngaysinh+"', DiaChi =N'"+nv.Diachi+"', DienThoai ='"+nv.Sdt+"' where MaNV='"+nv.Manv+"'");
       }
       // Xóa nhân viên
       public void XoaNV(NhanVien nv)
       {
           dah.ThucThiCauLenhSQL("DELETE FROM tblNhanVien where MaNV ='"+nv.Manv+"'");
       }
       // Hàm lấy dữ liệu đổ lên datagridview
       public DataTable LayDuLieu(string DieuKien)
       {
           return dah.GetDataTable("Select * from tblNhanVien " +DieuKien);
       }       
    }
}
