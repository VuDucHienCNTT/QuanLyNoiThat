using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyCuaHangNoiThat.Entities;

namespace QuanLyCuaHangNoiThat.DataAccessLayer
{
    public class NhaCungCapDAL
    {
        DataAccessHelper dah = new DataAccessHelper();

        public DataTable Getdata()
        {
            return dah.GetDataTable("Select MaNCC,TenNCC,DiaChi,DienThoai from tblNhaCungCap");
        }
        // Thêm nhà cung cấp
        public void ThemNCC(NhaCungCap ncc)
        {
            dah.ThucThiCauLenhSQL("INSERT INTO tblNhaCungCap VALUES('"+ncc.Mancc+"',N'"+ncc.Tenncc+"',N'"+ncc.Diachi+"','"+ncc.Sdt+"')");
        }
        // Sửa nhà cung cấp
        public void SuaNCC(NhaCungCap ncc)
        {
            dah.ThucThiCauLenhSQL("UPDATE tblNhaCungCap SET TenNCC=N'"+ncc.Tenncc+"', DiaChi =N'"+ncc.Diachi+"', DienThoai='"+ncc.Sdt+"' where MaNCC ='"+ncc.Mancc+"'");
        }
        // Xóa nhà cung cấp
        public void XoaNCC(NhaCungCap ncc)
        {
            dah.ThucThiCauLenhSQL("DELETE FROM tblNhaCungCap where MaNCC ='"+ncc.Mancc+"'");
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dah.GetDataTable("Select * from tblNhaCungCap " +DieuKien);
        }
    }
}
