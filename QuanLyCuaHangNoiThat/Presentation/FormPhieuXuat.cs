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
    public partial class frmPhieuXuat : Form
    {
        public frmPhieuXuat()
        {
            InitializeComponent();
        }
        DataAccessHelper dah=new DataAccessHelper();
        PhieuXuat et = new PhieuXuat();
        PhieuXuatBLL bll = new PhieuXuatBLL();
        bool themmoi;
        public void KhoaDieuKhien()
        {
            txtMaPX.Enabled = false;
            cboMaNV.Enabled = false;
            cboMaKH.Enabled = false;
            dtmNgayXuat.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnLamMoi.Enabled = true;
            btnDong.Enabled = true;
        }
        public void MoDieuKhien()
        {
            txtMaPX.Enabled = true;
            cboMaNV.Enabled = true;
            cboMaKH.Enabled = true;
            dtmNgayXuat.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;
            btnDong.Enabled = true;
        }
        public void HienThiDuLieu(string ht)
        {
            dgvDSPXuat.DataSource = bll.LayDuLieu(ht);
        }
        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            cboCotTK.Text = "Mã Phiếu Xuất";
            HienThiDuLieu("");
            //lay tt nv
            cboMaNV.DataSource = bll.LayThongTinNV("");
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.DisplayMember = "MaNV";
            //lay tt kh
            cboMaKH.DataSource = bll.LayThongTinKH("");
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.DisplayMember = "MaKH";
        }
        public void LamMoi()
        {
            txtMaPX.Text = Mapx();
            cboMaNV.Text = "";
            cboMaKH.Text = "";
            dtmNgayXuat.Text = "";
            txtTuTK.Text = "";
            txtMaPX.Focus();
        }
        private string Mapx()
        {
            DataTable dt = bll.LoadPX();
            if (dt.Rows.Count == 0) return "PX01";
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
                return "PX0" + (mamax + 1).ToString();
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvDSPXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int dongchon = e.RowIndex;
                txtMaPX.Text = dgvDSPXuat[0, dongchon].Value.ToString();
                cboMaNV.Text = dgvDSPXuat[1, dongchon].Value.ToString();
                cboMaKH.Text = dgvDSPXuat[2, dongchon].Value.ToString();
                dtmNgayXuat.Text = dgvDSPXuat[3, dongchon].Value.ToString();
                KhoaDieuKhien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaPX.Enabled = false;
            themmoi = true;
            LamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaPX.Enabled = false;
            cboMaNV.Enabled = false;
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                et.Mapx = txtMaPX.Text;
                bll.XoaPX(et);
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
            if (cboMaNV.Text == "" || cboMaKH.Text == "" || dtmNgayXuat.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (themmoi == true)
            {
                try
                {
                    et.Mapx = Mapx();
                    et.Manv = cboMaNV.Text;
                    et.Makh = cboMaKH.Text;
                    et.Ngayxuat = DateTime.Parse(dtmNgayXuat.Text);
                    bll.ThemPX(et);
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
                    et.Mapx = txtMaPX.Text;
                    et.Manv = cboMaNV.Text;
                    et.Makh = cboMaKH.Text;
                    et.Ngayxuat = DateTime.Parse(dtmNgayXuat.Text);
                    bll.SuaPX(et);
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
            if (cboCotTK.Text == "Mã Phiếu Xuất")
            {
                dgvDSPXuat.DataSource = dah.GetDataTable("select * from tblPhieuXuat where MaPX like '%" + txtTuTK.Text.Trim() + "%'");
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
