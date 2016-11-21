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
using QuanLyCuaHangNoiThat.Entities;
using QuanLyCuaHangNoiThat.Bussiness;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmCTPhieuXuat : Form
    {
        public frmCTPhieuXuat()
        {
            InitializeComponent();
        }
        DataAccessHelper dah = new DataAccessHelper();
        CTPhieuXuat et = new CTPhieuXuat();
        CTPhieuXuatBLL bll = new CTPhieuXuatBLL();
        bool themmoi;
        public void KhoaDieuKhien()
        {
            cboMaPX.Enabled = false;
            cboMaSP.Enabled = false;
            txtSLXuat.Enabled = false;
            txtDGXuat.Enabled = false;
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
            cboMaPX.Enabled = true;
            cboMaSP.Enabled = true;
            txtSLXuat.Enabled = true;
            txtDGXuat.Enabled = true;
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
            dgvDSCTPXuat.DataSource = bll.LayDuLieu(ht);
        }

        private void frmCTPhieuXuat_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            cboCotTK.Text = "Mã Phiếu Xuất";
            HienThiDuLieu("");
            //lay tt px
            cboMaPX.DataSource = bll.LayThongTinPX("");
            cboMaPX.ValueMember = "MaPX";
            cboMaPX.DisplayMember = "MaPX";
            //lay tt sp
            cboMaSP.DataSource = bll.LayThongTinSP("where SoLuongCon>0");
            cboMaSP.ValueMember = "MaSP";
            cboMaSP.DisplayMember = "MaSP";
        }
        public void LamMoi()
        {
            cboMaPX.Text = "";
            cboMaSP.Text = "";
            txtSLXuat.Text = "";
            txtDGXuat.Text = "";
            txtThanhTien.Text = "";
            txtDonViTinh.Text = "VND";
            txtTuTK.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvDSCTPXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int dongchon = e.RowIndex;
                cboMaPX.Text = dgvDSCTPXuat[0, dongchon].Value.ToString();
                cboMaSP.Text = dgvDSCTPXuat[1, dongchon].Value.ToString();
                txtSLXuat.Text = dgvDSCTPXuat[2, dongchon].Value.ToString();
                txtDGXuat.Text = dgvDSCTPXuat[3, dongchon].Value.ToString();
                txtThanhTien.Text = dgvDSCTPXuat[4, dongchon].Value.ToString();
                txtDonViTinh.Text = dgvDSCTPXuat[5, dongchon].Value.ToString();
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
            cboMaPX.Enabled = false;
            cboMaSP.Enabled = false;
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                et.Mapx = cboMaPX.Text;
                bll.XoaCTPX(et);
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
            if(cboMaPX.Text==""||cboMaSP.Text==""||txtSLXuat.Text==""||txtDGXuat.Text=="")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (themmoi == true)
            {
                try
                {
                    et.Mapx = cboMaPX.Text;
                    et.Masp = cboMaSP.Text;
                    et.Soluongxuat = int.Parse(txtSLXuat.Text);
                    et.Dongiaxuat = float.Parse(txtDGXuat.Text);
                    et.Donvitinh = txtDonViTinh.Text;
                    bll.ThemCTPX(et);
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
                    et.Mapx = cboMaPX.Text;
                    et.Masp = cboMaSP.Text;
                    et.Soluongxuat = int.Parse(txtSLXuat.Text);
                    et.Dongiaxuat = float.Parse(txtDGXuat.Text);
                    et.Donvitinh = txtDonViTinh.Text;
                    bll.SuaCTPX(et);
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
                dgvDSCTPXuat.DataSource = dah.GetDataTable("select * from tblCTPX where MaPX like '%" + txtTuTK.Text.Trim() + "%'");
            }
            LamMoi();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn đóng không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();//giai phong tai nguyen
            }
        }
    }
}
