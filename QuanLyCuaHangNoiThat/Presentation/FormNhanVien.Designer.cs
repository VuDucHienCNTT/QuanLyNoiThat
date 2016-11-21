namespace QuanLyCuaHangNoiThat
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDSNhanVien = new System.Windows.Forms.GroupBox();
            this.dgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTTNhanVien = new System.Windows.Forms.GroupBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNhan = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboCotTK = new System.Windows.Forms.ComboBox();
            this.txtTuTK = new System.Windows.Forms.TextBox();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.tblTuTK = new System.Windows.Forms.Label();
            this.lblCot = new System.Windows.Forms.Label();
            this.grpDSNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.grpTTNhanVien.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDSNhanVien
            // 
            this.grpDSNhanVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.grpDSNhanVien.Controls.Add(this.dgvDSNhanVien);
            this.grpDSNhanVien.Location = new System.Drawing.Point(38, 376);
            this.grpDSNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.grpDSNhanVien.Name = "grpDSNhanVien";
            this.grpDSNhanVien.Padding = new System.Windows.Forms.Padding(4);
            this.grpDSNhanVien.Size = new System.Drawing.Size(949, 257);
            this.grpDSNhanVien.TabIndex = 0;
            this.grpDSNhanVien.TabStop = false;
            this.grpDSNhanVien.Text = "Danh Sách Nhân Viên";
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNhanVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDSNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNhanVien.Location = new System.Drawing.Point(4, 23);
            this.dgvDSNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.Size = new System.Drawing.Size(941, 230);
            this.dgvDSNhanVien.TabIndex = 0;
            this.dgvDSNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNhanVien_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Tên Nhân Viên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.HeaderText = "Địa Chỉ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DienThoai";
            this.Column6.HeaderText = "Số Điện Thoại";
            this.Column6.Name = "Column6";
            // 
            // grpTTNhanVien
            // 
            this.grpTTNhanVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.grpTTNhanVien.Controls.Add(this.cboGioiTinh);
            this.grpTTNhanVien.Controls.Add(this.dtmNgaySinh);
            this.grpTTNhanVien.Controls.Add(this.txtSDT);
            this.grpTTNhanVien.Controls.Add(this.txtDiaChi);
            this.grpTTNhanVien.Controls.Add(this.txtTenNV);
            this.grpTTNhanVien.Controls.Add(this.txtMaNV);
            this.grpTTNhanVien.Controls.Add(this.lblTenNV);
            this.grpTTNhanVien.Controls.Add(this.lblNgaySinh);
            this.grpTTNhanVien.Controls.Add(this.lblGioiTinh);
            this.grpTTNhanVien.Controls.Add(this.lblSDT);
            this.grpTTNhanVien.Controls.Add(this.lblDiaChi);
            this.grpTTNhanVien.Controls.Add(this.lblMaNV);
            this.grpTTNhanVien.Location = new System.Drawing.Point(38, 71);
            this.grpTTNhanVien.Name = "grpTTNhanVien";
            this.grpTTNhanVien.Size = new System.Drawing.Size(949, 150);
            this.grpTTNhanVien.TabIndex = 0;
            this.grpTTNhanVien.TabStop = false;
            this.grpTTNhanVien.Text = "Thông Tin Nhân Viên";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(253, 103);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboGioiTinh.Size = new System.Drawing.Size(69, 27);
            this.cboGioiTinh.TabIndex = 2;
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.CustomFormat = "MM/dd/yyyy";
            this.dtmNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaySinh.Location = new System.Drawing.Point(594, 27);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(110, 26);
            this.dtmNgaySinh.TabIndex = 3;
            this.dtmNgaySinh.Value = new System.DateTime(2015, 5, 15, 0, 0, 0, 0);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(594, 103);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(181, 26);
            this.txtSDT.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(594, 67);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(181, 26);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(253, 67);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(181, 26);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(253, 30);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(181, 26);
            this.txtMaNV.TabIndex = 0;
            // 
            // lblTenNV
            // 
            this.lblTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(133, 70);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(114, 19);
            this.lblTenNV.TabIndex = 8;
            this.lblTenNV.Text = "Tên Nhân Viên:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(489, 33);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(83, 19);
            this.lblNgaySinh.TabIndex = 9;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(133, 106);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(77, 19);
            this.lblGioiTinh.TabIndex = 10;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // lblSDT
            // 
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(489, 106);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(44, 19);
            this.lblSDT.TabIndex = 11;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(489, 70);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(65, 19);
            this.lblDiaChi.TabIndex = 12;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(133, 33);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(112, 19);
            this.lblMaNV.TabIndex = 13;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // lblNhan
            // 
            this.lblNhan.BackColor = System.Drawing.Color.Silver;
            this.lblNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNhan.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhan.Location = new System.Drawing.Point(0, 0);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(1030, 49);
            this.lblNhan.TabIndex = 5;
            this.lblNhan.Text = "NHÂN VIÊN";
            this.lblNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788743_Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(312, 329);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 33);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788884_delete_16;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(598, 329);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 33);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788917_Wrench;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(407, 329);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 33);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788769_Cancel__Red;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(898, 329);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 33);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1429364447_gtk_refresh;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(797, 329);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(97, 33);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = " Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426626169_Save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(503, 329);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 33);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLyCuaHangNoiThat.Properties.Resources.Search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(693, 329);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 33);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboCotTK
            // 
            this.cboCotTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCotTK.FormattingEnabled = true;
            this.cboCotTK.Items.AddRange(new object[] {
            "Mã Nhân Viên",
            "Tên Nhân Viên"});
            this.cboCotTK.Location = new System.Drawing.Point(253, 25);
            this.cboCotTK.Name = "cboCotTK";
            this.cboCotTK.Size = new System.Drawing.Size(136, 27);
            this.cboCotTK.TabIndex = 7;
            // 
            // txtTuTK
            // 
            this.txtTuTK.Location = new System.Drawing.Point(615, 26);
            this.txtTuTK.Name = "txtTuTK";
            this.txtTuTK.Size = new System.Drawing.Size(160, 26);
            this.txtTuTK.TabIndex = 8;
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.tblTuTK);
            this.grpTimKiem.Controls.Add(this.lblCot);
            this.grpTimKiem.Controls.Add(this.txtTuTK);
            this.grpTimKiem.Controls.Add(this.cboCotTK);
            this.grpTimKiem.Location = new System.Drawing.Point(38, 241);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(949, 69);
            this.grpTimKiem.TabIndex = 7;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm Kiếm";
            // 
            // tblTuTK
            // 
            this.tblTuTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTuTK.Location = new System.Drawing.Point(489, 29);
            this.tblTuTK.Name = "tblTuTK";
            this.tblTuTK.Size = new System.Drawing.Size(112, 19);
            this.tblTuTK.TabIndex = 15;
            this.tblTuTK.Text = "Từ Tìm Kiếm:";
            // 
            // lblCot
            // 
            this.lblCot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCot.Location = new System.Drawing.Point(133, 29);
            this.lblCot.Name = "lblCot";
            this.lblCot.Size = new System.Drawing.Size(91, 19);
            this.lblCot.TabIndex = 14;
            this.lblCot.Text = "Tìm Theo:";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1030, 653);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblNhan);
            this.Controls.Add(this.grpTTNhanVien);
            this.Controls.Add(this.grpDSNhanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.grpDSNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.grpTTNhanVien.ResumeLayout(false);
            this.grpTTNhanVien.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDSNhanVien;
        private System.Windows.Forms.DataGridView dgvDSNhanVien;
        private System.Windows.Forms.GroupBox grpTTNhanVien;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboCotTK;
        private System.Windows.Forms.TextBox txtTuTK;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label tblTuTK;
        private System.Windows.Forms.Label lblCot;
    }
}