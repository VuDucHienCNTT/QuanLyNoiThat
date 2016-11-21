using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat.Entities
{
    public class SanPham
    {
        private string masp;

        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        private string tensp;

        public string Tensp
        {
            get { return tensp; }
            set { tensp = value; }
        }
        private int soluongcon;

        public int Soluongcon
        {
            get { return soluongcon; }
            set { soluongcon = value; }
        }

        private string donvitinh;
         public string Donvitinh
        {
            get { return donvitinh; }
            set { donvitinh = value; }
        }
         public SanPham()
         {
         }
         public SanPham(string masp, string tensp, int soluongcon, string donvitinh)
         {
             this.masp = masp;
             this.tensp = tensp;
             this.soluongcon = soluongcon;
             this.donvitinh = donvitinh;
         }
    }
}
