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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        DataAccessHelper dah=new DataAccessHelper();
        KhachHangBLL bll = new KhachHangBLL();
        KhachHang et = new KhachHang();
        bool themmoi;
        public void KhoaDieuKhien()
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            cboGioiTinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnLamMoi.Enabled = true;
            btnDong.Enabled = true;
        }
        public void MoDieuKhien()
        {
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            cboGioiTinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnLamMoi.Enabled = true;
            btnDong.Enabled = true;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThiDuLieu("");
        }
        public void LamMoi()
        {
            txtMaKH.Text = Makh();
            txtTenKH.Text = "";
            cboGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTuTK.Text = "";
            txtMaKH.Focus();
        }
        private string Makh()
        {
            DataTable dt = bll.LoadKH();
            if (dt.Rows.Count == 0) return "KH01";
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
                return "KH0" + (mamax + 1).ToString();
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
        public void HienThiDuLieu(string ht)
        {
            dgvDSKhachHang.DataSource = bll.LayDuLieu(ht);
        }
        private void dgvDSKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int dongchon = e.RowIndex;
                txtMaKH.Text = dgvDSKhachHang[0, dongchon].Value.ToString();
                txtTenKH.Text = dgvDSKhachHang[1, dongchon].Value.ToString();
                cboGioiTinh.Text = dgvDSKhachHang[2, dongchon].Value.ToString();
                txtDiaChi.Text = dgvDSKhachHang[3, dongchon].Value.ToString();
                txtSDT.Text = dgvDSKhachHang[4, dongchon].Value.ToString();
                KhoaDieuKhien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaKH.Enabled = false;
            themmoi = true;
            LamMoi();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaKH.Enabled = false;
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                et.Makh = txtMaKH.Text;
                bll.XoaKH(et);
                DialogResult xn = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(xn==DialogResult.Yes)
                {
                    MessageBox.Show("Bạn đã xóa thành công!","Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    HienThiDuLieu("");
                    LamMoi();
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa!","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenKH.Text==""||cboGioiTinh.Text==""||txtDiaChi.Text=="")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(themmoi==true)
            {
                try
                {
                    et.Makh = Makh();
                    et.Tenkh = txtTenKH.Text;
                    et.Gioitinh = cboGioiTinh.Text;
                    et.Diachi = txtDiaChi.Text;
                    et.Sdt = double.Parse(txtSDT.Text);
                    bll.ThemKH(et);
                    MessageBox.Show("Bạn đã thêm mới thành công!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    HienThiDuLieu("");
                    LamMoi();
                }
                catch
                {
                    MessageBox.Show("Lỗi không thể thêm mới!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    et.Makh = txtMaKH.Text;
                    et.Tenkh = txtTenKH.Text;
                    et.Gioitinh = cboGioiTinh.Text;
                    et.Diachi = txtDiaChi.Text;
                    et.Sdt = double.Parse(txtSDT.Text);
                    bll.SuaKH(et);
                    MessageBox.Show("Bạn đã sửa thành công!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    KhoaDieuKhien();
                    HienThiDuLieu("");
                    LamMoi();
                }
                catch
                {
                    MessageBox.Show("Lỗi không thể sửa!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

            }
        }
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            if (cboCotTK.Text == "Mã Khách Hàng")
            {
                    dgvDSKhachHang.DataSource = dah.GetDataTable("select * from tblKhachHang where MaKH like '%" + txtTuTK.Text.Trim() + "%'");
            }
            else
            {
                dgvDSKhachHang.DataSource = dah.GetDataTable("select * from tblKhachHang where TenKH like N'%" + txtTuTK.Text.Trim() + "%'");
            }
            LamMoi();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn đóng không?","Xác Nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(tb==DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }
    }
}
