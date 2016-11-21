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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        DataAccessHelper dah = new DataAccessHelper();
        PhieuNhap et = new PhieuNhap();
        PhieuNhapBLL bll = new PhieuNhapBLL();
        bool themmoi;
        public void KhoaDieuKhien()
        {
            txtMaPN.Enabled = false;
            cboMaNV.Enabled = false;
            cboMaNCC.Enabled = false;
            dtmNgayNhap.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnLamMoi.Enabled = true;
            btnDong.Enabled = true;
        }
        public void MoDieuKhien()
        {
            txtMaPN.Enabled = true;
            cboMaNV.Enabled = true;
            cboMaNCC.Enabled = true;
            dtmNgayNhap.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;
            btnDong.Enabled = true;
        }
        public void HienThiDuLieu(string ht)
        {
            dgvDSPNhap.DataSource = bll.LayDuLieu(ht);
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            cboCotTK.Text = "Mã Phiếu Nhập";
            HienThiDuLieu("");
            //lấy tt nv
            cboMaNV.DataSource = bll.LayThongTinNV("");
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.DisplayMember = "MaNV";
            //lấy tt ncc
            cboMaNCC.DataSource = bll.LayThongTinNCC("");
            cboMaNCC.ValueMember = "MaNCC";
            cboMaNCC.DisplayMember = "MaNCC";
        }
        public void LamMoi()
        {
            txtMaPN.Text = Mapn();
            cboMaNV.Text = "";
            cboMaNCC.Text = "";
            dtmNgayNhap.Text = "";
            txtTuTK.Text = "";
            txtMaPN.Focus();
        }
        private string Mapn()
        {
            DataTable dt = bll.LoadPN();
            if (dt.Rows.Count == 0) return "PN01";
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
                return "PN0" + (mamax + 1).ToString();
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvDSPNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int dongchon = e.RowIndex;
                txtMaPN.Text = dgvDSPNhap[0, dongchon].Value.ToString();
                cboMaNV.Text = dgvDSPNhap[1, dongchon].Value.ToString();
                cboMaNCC.Text = dgvDSPNhap[2, dongchon].Value.ToString();
                dtmNgayNhap.Text = dgvDSPNhap[3, dongchon].Value.ToString();
                KhoaDieuKhien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaPN.Enabled = false;
            themmoi = true;
            LamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaPN.Enabled = false;
            cboMaNV.Enabled = false;
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                et.Mapn = txtMaPN.Text;
                bll.XoaPN(et);
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
            if (cboMaNV.Text == "" || cboMaNCC.Text == "" || dtmNgayNhap.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (themmoi == true)
            {
                try
                {
                    et.Mapn = Mapn();
                    et.Manv = cboMaNV.Text;
                    et.Mancc = cboMaNCC.Text;
                    et.Ngaynhap = DateTime.Parse(dtmNgayNhap.Text);
                    bll.ThemPN(et);

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
                    et.Mapn = txtMaPN.Text;
                    et.Manv = cboMaNV.Text;
                    et.Mancc = cboMaNCC.Text;
                    et.Ngaynhap = DateTime.Parse(dtmNgayNhap.Text);
                    bll.SuaPN(et);
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
            if (cboCotTK.Text == "Mã Phiếu Nhập")
            {
                dgvDSPNhap.DataSource = dah.GetDataTable("select * from tblPhieuNhap where MaPN like '%" + txtTuTK.Text.Trim() + "%'");
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
