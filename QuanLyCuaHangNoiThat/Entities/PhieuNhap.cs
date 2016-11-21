using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat.Entities
{
    public class PhieuNhap
    {
        private string mapn;

        public string Mapn
        {
            get { return mapn; }
            set { mapn = value; }
        }
        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private string mancc;

        public string Mancc
        {
            get { return mancc; }
            set { mancc = value; }
        }
        private DateTime ngaynhap;

        public DateTime Ngaynhap
        {
            get { return ngaynhap; }
            set { ngaynhap = value; }
        }
        public PhieuNhap()
        {
        }
        public PhieuNhap(string mapn, string manv, string mancc, DateTime ngaynhap)
        {
            this.mapn = mapn;
            this.manv = manv;
            this.mancc = mancc;
            this.ngaynhap = ngaynhap;
        }
    }
}
