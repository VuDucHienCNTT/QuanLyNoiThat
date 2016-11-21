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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        DataAccessHelper dah = new DataAccessHelper();
        NhanVienBLL bll = new NhanVienBLL();
        NhanVien et = new NhanVien();
        bool themmoi;
        public void KhoaDieuKhien()
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            cboGioiTinh.Enabled = false;
            dtmNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnLamMoi.Enabled = true;
            btnDong.Enabled = true;
        }
        public void MoDieuKhien()
        {
            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            cboGioiTinh.Enabled = true;
            dtmNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;
            btnDong.Enabled = true;
        }
        public void HienThiDuLieu(string ht)
        {
            dgvDSNhanVien.DataSource = bll.LayDuLieu(ht);
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThiDuLieu("");
        }
        public void LamMoi()
        {
            txtMaNV.Text = Manv();
            txtTenNV.Text = "";
            cboGioiTinh.Text = "";
            dtmNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTuTK.Text = "";
            txtMaNV.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int dongchon = e.RowIndex;
                txtMaNV.Text = dgvDSNhanVien[0, dongchon].Value.ToString();
                txtTenNV.Text = dgvDSNhanVien[1, dongchon].Value.ToString();
                cboGioiTinh.Text = dgvDSNhanVien[2, dongchon].Value.ToString();
                dtmNgaySinh.Text = dgvDSNhanVien[3, dongchon].Value.ToString();
                txtDiaChi.Text = dgvDSNhanVien[4, dongchon].Value.ToString();
                txtSDT.Text = dgvDSNhanVien[5, dongchon].Value.ToString();
                KhoaDieuKhien();
        }
        // Mã tự tăng
        private string Manv()
        {
            DataTable dt = bll.LoadNV();
            if (dt.Rows.Count == 0) return "NV01";
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
                return "NV0" + (mamax + 1).ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaNV.Enabled = false;
            themmoi = true;
            LamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaNV.Enabled = false;
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                et.Manv = txtMaNV.Text;
                bll.XoaNV(et);
                DialogResult xn = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác Nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(xn==DialogResult.Yes)
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
            if (txtTenNV.Text == "" || cboGioiTinh.Text == "" || dtmNgaySinh.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(themmoi==true)
            {
                    try
                    {
                        et.Manv = Manv();
                        et.Tennv = txtTenNV.Text;
                        et.Gioitinh = cboGioiTinh.Text;
                        et.Ngaysinh = DateTime.Parse(dtmNgaySinh.Text);
                        et.Diachi = txtDiaChi.Text;
                        et.Sdt = double.Parse(txtSDT.Text);
                        bll.ThemNV(et);
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
                    et.Manv= txtMaNV.Text;
                    et.Tennv = txtTenNV.Text;
                    et.Gioitinh = cboGioiTinh.Text;
                    et.Ngaysinh = DateTime.Parse(dtmNgaySinh.Text);
                    et.Diachi = txtDiaChi.Text;
                    et.Sdt = double.Parse(txtSDT.Text);
                    bll.SuaNV(et);
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
            if (cboCotTK.Text == "Mã Nhân Viên")
            {
                dgvDSNhanVien.DataSource = dah.GetDataTable("select * from tblNhanVien where MaNV like '%" + txtTuTK.Text.Trim() + "%'");
            }
            else
            {
                dgvDSNhanVien.DataSource = dah.GetDataTable("select * from tblNhanVien where TenNV like N'%" + txtTuTK.Text.Trim() + "%'");
            }
            LamMoi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn đóng không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tb==DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }
    }
}
