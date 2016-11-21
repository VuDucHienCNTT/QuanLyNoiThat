using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat.Entities
{
   public class CTPhieuXuat
    {
       private string mactpx;

        public string Mactpx
        {
            get { return mactpx; }
            set { mactpx = value; }
        }
        private string mapx;

        public string Mapx
        {
            get { return mapx; }
            set { mapx = value; }
        }
        private string masp;

        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        private int soluongxuat;

        public int Soluongxuat
        {
            get { return soluongxuat; }
            set { soluongxuat = value; }
        }
        private float dongiaxuat;

        public float Dongiaxuat
        {
            get { return dongiaxuat; }
            set { dongiaxuat = value; }
        }
        private float thanhtien;

        public float Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        private string donvitinh;

        public string Donvitinh
        {
            get { return donvitinh; }
            set { donvitinh = value; }
        }

        public CTPhieuXuat()
        {
        }
        public CTPhieuXuat(string mapx, string masp, int soluongxuat, float dongiaxuat, float thanhtien, string donvitinh)
        {
            this.mapx = mapx;
            this.masp = masp;
            this.soluongxuat = soluongxuat;
            this.dongiaxuat = dongiaxuat;
            this.thanhtien = thanhtien;
            this.donvitinh = donvitinh;
        }
    }
}
