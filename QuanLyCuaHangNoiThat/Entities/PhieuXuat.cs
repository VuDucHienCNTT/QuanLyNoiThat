using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat.Entities
{
    public class PhieuXuat
    {
        private string mapx;

        public string Mapx
        {
            get { return mapx; }
            set { mapx = value; }
        }
        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private DateTime ngayxuat;

        public DateTime Ngayxuat
        {
            get { return ngayxuat; }
            set { ngayxuat = value; }
        }

        public PhieuXuat(string mapx, string manv, string makh, DateTime ngayxuat)
        {
            this.mapx = mapx;
            this.manv = manv;
            this.makh = makh;
            this.ngayxuat = ngayxuat;
        }
        public PhieuXuat()
        {
        }
    }
}
