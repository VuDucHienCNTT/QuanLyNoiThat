using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCuaHangNoiThat.Entities;
using QuanLyCuaHangNoiThat.DataAccessLayer;

namespace QuanLyCuaHangNoiThat.Bussiness
{
    class PhieuNhapBLL
    {
        PhieuNhapDAL dal = new PhieuNhapDAL();
        NhaCungCapBLL bll = new NhaCungCapBLL();
        public DataTable LoadPN()
        {
            return dal.Getdata();
        }
        // Thêm phiếu nhập
        public void ThemPN(PhieuNhap pn)
        {
            dal.ThemPN(pn);
        }
        // Sửa phiếu nhập
        public void SuaPN(PhieuNhap pn)
        {
            dal.SuaPN(pn);
        }
        // Xóa phiếu nhập
        public void XoaPN(PhieuNhap pn)
        {
            dal.XoaPN(pn);
        }
        // Lấy dữ liệu đổ lên datagridview
        public DataTable LayDuLieu(string DieuKien)
        {
            return dal.LayDuLieu(DieuKien);
        }
        // Lấy thông tin nhân viên
        public DataTable LayThongTinNV(string DieuKien)
        {
            return dal.LayThongTinNV(DieuKien);
        }
        // Lấy thông tin nhà cung cấp
        public DataTable LayThongTinNCC(string DieuKien)
        {
            return dal.LayThongTinNCC(DieuKien);
        }
    }
}
