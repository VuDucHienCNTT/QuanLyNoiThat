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
   public class NhaCungCapBLL
    {
        NhaCungCapDAL dal = new NhaCungCapDAL();
        public DataTable LoadNCC()
        {
            return dal.Getdata();
        }
        // Thêm nhà cung cấp
        public void ThemNCC(NhaCungCap ncc)
        {
            dal.ThemNCC(ncc);
        }
        // Sửa nhà cung cấp
        public void SuaNCC(NhaCungCap ncc)
        {
            dal.SuaNCC(ncc);
        }
        // Xóa nhà cung cấp
        public void XoaNCC(NhaCungCap ncc)
        {
            dal.XoaNCC(ncc);
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dal.LayDuLieu(DieuKien);
        }
   }
}
