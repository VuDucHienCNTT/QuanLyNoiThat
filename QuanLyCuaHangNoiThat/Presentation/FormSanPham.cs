using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangNoiThat.Entities;
using QuanLyCuaHangNoiThat.Bussiness;
using QuanLyCuaHangNoiThat.DataAccessLayer;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        DataAccessHelper dah = new DataAccessHelper();
        SanPhamBLL bll = new SanPhamBLL();
        SanPham et = new SanPham();
        bool themmoi;
        public void KhoaDieuKhien()
        {
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtSoLuongCon.Enabled = false;
            txtDonViTinh.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnLamMoi.Enabled = true;
            btnDong.Enabled = true;
        }
        public void MoDieuKhien()
        {
            txtMaSP.Enabled = true;
            txtTenSP.Enabled = true;
            txtSoLuongCon.Enabled = true;
            txtDonViTinh.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;
            btnDong.Enabled = true;
        }
        public void LamMoi()
        {
            txtMaSP.Text = Masp();
            txtTenSP.Text = "";
            txtSoLuongCon.Text = "";
            txtDonViTinh.Text = "";
            txtTuTK.Text = "";
            txtMaSP.Focus();
        }
        private string Masp()
        {
            DataTable dt = bll.LoadSP();
            if (dt.Rows.Count == 0) return "SP01";
            else
            {
                string a = dt.Rows[0][0].ToString();
                int mamax = int.Parse(a.Substring(2, a.Length - 2));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string b = dt.Rows[i][0].ToString();
                    int ma = int.Parse(b.Substring(2, b.Length - 2));
                    if (ma > mamax)
                        mamax = ma;
                }
                return "SP0" + (mamax + 1).ToString();
            }
        }
        public void HienThiDuLieu(string ht)
        {
            dgvDSSanPham.DataSource = bll.LayDuLieu(ht);
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThiDuLieu("");
        }
        private void dgvDSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int dongchon = e.RowIndex;
                txtMaSP.Text = dgvDSSanPham[0, dongchon].Value.ToString();
                txtTenSP.Text = dgvDSSanPham[1, dongchon].Value.ToString();
                txtSoLuongCon.Text = dgvDSSanPham[2, dongchon].Value.ToString();
                txtDonViTinh.Text = dgvDSSanPham[3, dongchon].Value.ToString();
                KhoaDieuKhien();

        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaSP.Enabled = false;
            themmoi = true;
            LamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaSP.Enabled = false;
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                et.Masp = txtMaSP.Text;
                bll.XoaSP(et);
                DialogResult xn = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xn == DialogResult.Yes)
                {
                    MessageBox.Show("Bạn đã xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDuLieu("");
                    LamMoi();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenSP.Text==""||txtSoLuongCon.Text==""||txtDonViTinh.Text=="")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(themmoi==true)
            {
                try
                {
                    et.Masp = Masp();
                    et.Tensp = txtTenSP.Text;
                    et.Soluongcon = int.Parse(txtSoLuongCon.Text);
                    et.Donvitinh = txtDonViTinh.Text;
                    bll.ThemSP(et);
                    MessageBox.Show("Bạn đã thêm mới thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KhoaDieuKhien();
                    HienThiDuLieu("");
                    LamMoi();

                }
                catch
                {
                    MessageBox.Show("Lỗi không thể thêm mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    et.Masp = txtMaSP.Text;
                    et.Tensp = txtTenSP.Text;
                    et.Soluongcon= int.Parse(txtSoLuongCon.Text);
                    et.Donvitinh = txtDonViTinh.Text;
                    bll.SuaSP(et);
                    MessageBox.Show("Bạn đã sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KhoaDieuKhien();
                    HienThiDuLieu("");
                    LamMoi();

                }
                catch
                {
                    MessageBox.Show("Lỗi không thể sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            if (cboCotTK.Text == "Mã Sản Phẩm")
            {
                dgvDSSanPham.DataSource = dah.GetDataTable("select * from tblSanPham where MaSP like '%" + txtTuTK.Text.Trim() + "%'");
            }
            else
            {
                dgvDSSanPham.DataSource = dah.GetDataTable("select * from tblSanPham where TenSP like N'%" + txtTuTK.Text.Trim() + "%'");
            }
            LamMoi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn đóng không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }
    }
}
