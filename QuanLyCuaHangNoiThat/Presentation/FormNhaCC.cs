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
    public partial class frmNhaCC : Form
    {
        public frmNhaCC()
        {
            InitializeComponent();
        }
        DataAccessHelper dah = new DataAccessHelper();
        NhaCungCapBLL bll = new NhaCungCapBLL();
        NhaCungCap et = new NhaCungCap();
        bool themmoi;
        public void KhoaDieuKhien()
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
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
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;
            btnDong.Enabled = true;
        }
        public void LamMoi()
        {
            txtMaNCC.Text = Mancc();
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTuTK.Text = "";
            txtMaNCC.Focus();
        }
        private string Mancc()
        {
            DataTable dt = bll.LoadNCC();
            if (dt.Rows.Count == 0) return "NCC01";
            else
            {
                string a = dt.Rows[0][0].ToString();
                int mamax = int.Parse(a.Substring(3, a.Length - 3));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string b = dt.Rows[i][0].ToString();
                    int ma = int.Parse(b.Substring(3, b.Length - 3));
                    if (ma > mamax)
                        mamax = ma;
                }
                return "NCC0" + (mamax + 1).ToString();
            }
        }
        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            LamMoi();
        }
        public void HienThiDuLieu(string ht)
        {
            dgvDSNhaCC.DataSource = bll.LayDuLieu(ht);
        }
        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThiDuLieu("");
        }
        private void dgvDSNhaCC_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
                int dongchon = e.RowIndex;
                txtMaNCC.Text = dgvDSNhaCC[0, dongchon].Value.ToString();
                txtTenNCC.Text = dgvDSNhaCC[1, dongchon].Value.ToString();
                txtDiaChi.Text = dgvDSNhaCC[2, dongchon].Value.ToString();
                txtSDT.Text = dgvDSNhaCC[3, dongchon].Value.ToString();
                KhoaDieuKhien();
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaNCC.Enabled = false;
            themmoi = true;
            LamMoi();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaNCC.Enabled = false;
            themmoi = false;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                et.Mancc = txtMaNCC.Text;
                bll.XoaNCC(et);
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
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (themmoi == true)
            {
                try
                {
                    et.Mancc = Mancc();
                    et.Tenncc = txtTenNCC.Text;
                    et.Diachi = txtDiaChi.Text;
                    et.Sdt = double.Parse(txtSDT.Text);
                    bll.ThemNCC(et);
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
                    et.Mancc = txtMaNCC.Text;
                    et.Tenncc = txtTenNCC.Text;
                    et.Diachi = txtDiaChi.Text;
                    et.Sdt = double.Parse(txtSDT.Text);
                    bll.SuaNCC(et);
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
            if (cboCotTK.Text == "Mã Nhà Cung Cấp")
            {
                dgvDSNhaCC.DataSource = dah.GetDataTable("select * from tblNhaCungCap where MaNCC like '%" + txtTuTK.Text.Trim() + "%'");
            }
            else
            {
                dgvDSNhaCC.DataSource = dah.GetDataTable("select * from tblNhaCungCap where TenNCC like N'%" + txtTuTK.Text.Trim() + "%'");
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
