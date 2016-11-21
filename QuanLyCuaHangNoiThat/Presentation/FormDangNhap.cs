using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangNoiThat.DataAccessLayer;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        DataAccessHelper dah = new DataAccessHelper();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {          
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TaiKhoan= txtTaiKhoan.Text.ToString();
            string MatKhau= txtMatKhau.Text.ToString();
            int so = dah.GetValue("Select count(*) from tblDangNhap where TaiKhoan = '" + txtTaiKhoan.Text.Trim() + "' And MatKhau = '" + txtMatKhau.Text.Trim() + "'");            
            if (so > 0)
            {
                this.Hide();
                MessageBox.Show("Đăng Nhập Thành Công!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                frmChinh frm = new frmChinh();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ckbHienMK.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult xn = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xn == DialogResult.Yes)
            {
                Application.Exit();
                this.Dispose();
            }
        }

        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ckbHienMK.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
