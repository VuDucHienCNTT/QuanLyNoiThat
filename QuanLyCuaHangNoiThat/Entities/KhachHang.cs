using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat.Entities
{
    public class KhachHang
    {
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private string tenkh;

        public string Tenkh
        {
            get { return tenkh; }
            set { tenkh = value; }
        }
        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
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
        public KhachHang(string makh, string tenkh, string gioitinh, string diachi, double sdt)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
        }
        public KhachHang()
        {
        }
    }
}
