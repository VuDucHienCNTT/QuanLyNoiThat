using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        private void thoátCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.Show();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            this.KeyPreview= true;
        }

        private void frmChinh_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                if(e.KeyCode.Equals(Keys.X))
                {
                    thoátCtrlXToolStripMenuItem_Click(null, null);
                }
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.Show();
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            frmNhaCC frm = new frmNhaCC();
            frm.Show();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frm = new frmPhieuNhap();
            frm.Show();
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            frmPhieuXuat frm = new frmPhieuXuat();
            frm.Show();
        }

        private void btnCTPhieuNhap_Click(object sender, EventArgs e)
        {
            frmCTPhieuNhap frm = new frmCTPhieuNhap();
            frm.Show();
        }

        private void btnCTPhieuXuat_Click(object sender, EventArgs e)
        {
            frmCTPhieuXuat frm = new frmCTPhieuXuat();
            frm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCC frm = new frmNhaCC();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn đóng không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                Application.Exit();
                this.Dispose();
            }
        }

        private void toolPhieuNhap_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frm = new frmPhieuNhap();
            frm.ShowDialog();
        }

        private void phiếuXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPhieuXuat frm = new frmPhieuXuat();
            frm.ShowDialog();
        }

        private void chiTiếtPhiếuNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCTPhieuNhap frm = new frmCTPhieuNhap();
            frm.ShowDialog();
        }

        private void chiTiếtPhiếuXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCTPhieuXuat frm = new frmCTPhieuXuat();
            frm.ShowDialog();
        }
        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.Show();
        }
        //chay chu

        //int x = 200, y = 36, a = 1;
        //Random random = new Random();
        //private void tmrChuyenDong_Tick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        x += a;
        //        lblChinh.Location = new Point(x, y);
        //        if (x >= 298)
        //        {
        //            a = -1;
        //            lblChinh.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        //        }
        //        if (x <= 86)
        //        {
        //            a = 1;
        //            lblChinh.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Lỗi không thể chạy");
        //    }
        //}
    }
}
