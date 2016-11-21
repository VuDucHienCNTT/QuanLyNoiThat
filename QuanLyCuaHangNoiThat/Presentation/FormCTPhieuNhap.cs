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
using QuanLyCuaHangNoiThat.Bussiness;
using QuanLyCuaHangNoiThat.Entities;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmCTPhieuNhap : Form
    {
        public frmCTPhieuNhap()
        {
            InitializeComponent();
        }
        DataAccessHelper dah = new DataAccessHelper();
        CTPhieuNhap et = new CTPhieuNhap();
        CTPhieuNhapBLL bll = new CTPhieuNhapBLL();
        bool themmoi;
        public void KhoaDieuKhien()
        {
            cboMaPN.Enabled = false;
            cboMaSP.Enabled = false;
            txtSLNhap.Enabled = false;
            txtDGNhap.Enabled = false;
            txtThanhTien.Enabled = false;
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
            cboMaPN.Enabled = true;
            cboMaSP.Enabled = true;
            txtSLNhap.Enabled = true;
            txtDGNhap.Enabled = true;
            txtThanhTien.Enabled = true;
            txtDonViTinh.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;
            btnDong.Enabled = true;
        }
        public void HienThiDuLieu(string ht)
        {
            dgvDSCTPNhap.DataSource = bll.LayDuLieu(ht);
        }

        private void frmCTPhieuNhap_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            cboCotTK.Text = "Mã Phiếu Nhập";
            HienThiDuLieu("");
            // lay tt pn
            cboMaPN.DataSource = bll.LayThongTinPN("");
            cboMaPN.ValueMember = "MaPN";
            cboMaPN.DisplayMember = "MaPN";
            //lay tt sp
            cboMaSP.DataSource = bll.LayThongTinSP("");
            cboMaSP.ValueMember = "MaSP";
            cboMaSP.DisplayMember = "MaSP";

        }
        public void LamMoi()
        {
            cboMaPN.Text = "";
            cboMaSP.Text = "";
            txtSLNhap.Text = "";
            txtDGNhap.Text = "";
            txtThanhTien.Text = "";
            txtDonViTinh.Text = "VND";
            txtTuTK.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvDSCTPNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int dongchon = e.RowIndex;
                cboMaPN.Text = dgvDSCTPNhap[0, dongchon].Value.ToString();
                cboMaSP.Text = dgvDSCTPNhap[1, dongchon].Value.ToString();
                txtSLNhap.Text = dgvDSCTPNhap[2, dongchon].Value.ToString();
                txtDGNhap.Text = dgvDSCTPNhap[3, dongchon].Value.ToString();
                txtThanhTien.Text = dgvDSCTPNhap[4, dongchon].Value.ToString();
                txtDonViTinh.Text = dgvDSCTPNhap[5, dongchon].Value.ToString();
                KhoaDieuKhien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            themmoi = true;
            LamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            cboMaPN.Enabled = false;
            cboMaSP.Enabled = false;
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                et.Mapn = cboMaPN.Text;
                bll.XoaCTPN(et);
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
            if (cboMaPN.Text == "" || cboMaSP.Text == "" || txtSLNhap.Text == "" || txtDGNhap.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (themmoi == true)
            {
                try
                {
                    et.Mapn = cboMaPN.Text;
                    et.Masp = cboMaSP.Text;
                    et.Soluongnhap = int.Parse(txtSLNhap.Text);
                    et.Dongianhap = float.Parse(txtDGNhap.Text);
                    et.Donvitinh = txtDonViTinh.Text;
                    bll.ThemCTPN(et);
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
                    et.Mapn = cboMaPN.Text;
                    et.Masp = cboMaSP.Text;
                    et.Soluongnhap = int.Parse(txtSLNhap.Text);
                    et.Dongianhap = float.Parse(txtDGNhap.Text);
                    et.Donvitinh = txtDonViTinh.Text;
                    bll.SuaCTPN(et);
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
                dgvDSCTPNhap.DataSource = dah.GetDataTable("select * from tblCTPN where MaPN like '%" + txtTuTK.Text.Trim() + "%'");
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
