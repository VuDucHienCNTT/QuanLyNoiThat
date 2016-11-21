using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat.Entities
{
    public class NhanVien
    {
        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private string tennv;

        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }
        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private DateTime ngaysinh;

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private double sdt;

        public double Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public NhanVien()
        {
        }
        public NhanVien(string manv, string tennv, string gioitinh, DateTime ngaysinh, string diachi, int sdt)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.sdt = sdt;
        }
    }
}
