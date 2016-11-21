using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat.Entities
{
    public class CTPhieuNhap
    {
        private string mactpn;

        public string Mactpn
        {
            get { return mactpn; }
            set { mactpn = value; }
        }
        private string mapn;

        public string Mapn
        {
            get { return mapn; }
            set { mapn = value; }
        }
        private string masp;

        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        private int soluongnhap;

        public int Soluongnhap
        {
            get { return soluongnhap; }
            set { soluongnhap = value; }
        }
        private float dongianhap;

        public float Dongianhap
        {
            get { return dongianhap; }
            set { dongianhap = value; }
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

        public CTPhieuNhap()
        {
        }
        public CTPhieuNhap(string mapn, string masp, int soluongnhap, float dongianhap, float thanhtien, string donvitinh)
        {
            this.mapn = mapn;
            this.masp = masp;
            this.soluongnhap = soluongnhap;
            this.dongianhap = dongianhap;
            this.thanhtien = thanhtien;
            this.donvitinh = donvitinh;
        }
    }
}
