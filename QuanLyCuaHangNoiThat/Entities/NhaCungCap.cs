using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat.Entities
{
    public class NhaCungCap
    {
        private string mancc;

        public string Mancc
        {
            get { return mancc; }
            set { mancc = value; }
        }
        private string tenncc;

        public string Tenncc
        {
            get { return tenncc; }
            set { tenncc = value; }
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
        public NhaCungCap()
        {
        }
        public NhaCungCap(string mancc, string tenncc, string diachi, int sdt)
        {
            this.mancc = mancc;
            this.tenncc = tenncc;
            this.diachi = diachi;
            this.sdt = sdt;
        }
    }
}
