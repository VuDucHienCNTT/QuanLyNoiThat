using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyCuaHangNoiThat.Entities;

namespace QuanLyCuaHangNoiThat.DataAccessLayer
{
    public class SanPhamDAL
    {
        DataAccessHelper dah = new DataAccessHelper();

        public DataTable Getdata()
        {
            return dah.GetDataTable("Select MaSP,TenSP,SoLuongCon,DonViTinh from tblSanPham");
        }
        // Thêm sản phẩm
        public void ThemSP(SanPham sp)
        {
            dah.ThucThiCauLenhSQL("INSERT INTO tblSanPham VALUES('"+sp.Masp+"',N'"+sp.Tensp+"',N'"+sp.Soluongcon+"',N'"+sp.Donvitinh+"')");
        }
        // Sửa sản phẩm 
        public void SuaSP(SanPham sp)
        {
            dah.ThucThiCauLenhSQL("UPDATE tblSanPham SET TenSP =N'"+sp.Tensp+"', SoLuongCon =N'"+sp.Soluongcon+"', DonViTinh =N'"+sp.Donvitinh+"' where MaSP='"+sp.Masp+"'");
        }
        // Xóa sản phẩm
        public void XoaSP(SanPham sp)
        {
            dah.ThucThiCauLenhSQL("DELETE FROM tblSanPham where MaSP = '"+sp.Masp+"'");
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dah.GetDataTable("Select * from tblSanPham " + DieuKien);
        }
    }
}
