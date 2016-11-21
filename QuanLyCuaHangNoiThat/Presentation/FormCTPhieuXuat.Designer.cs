namespace QuanLyCuaHangNoiThat
{
    partial class frmCTPhieuXuat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNhan = new System.Windows.Forms.Label();
            this.grpDSCTPXuat = new System.Windows.Forms.GroupBox();
            this.dgvDSCTPXuat = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblDGXuat = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblMaPX = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblSLXuat = new System.Windows.Forms.Label();
            this.txtDGXuat = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtSLXuat = new System.Windows.Forms.TextBox();
            this.grpTTCTPNhap = new System.Windows.Forms.GroupBox();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.cboMaPX = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cboCotTK = new System.Windows.Forms.ComboBox();
            this.txtTuTK = new System.Windows.Forms.TextBox();
            this.lblCot = new System.Windows.Forms.Label();
            this.lblTuTK = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpDSCTPXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPXuat)).BeginInit();
            this.grpTTCTPNhap.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhan
            // 
            this.lblNhan.BackColor = System.Drawing.Color.Silver;
            this.lblNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNhan.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhan.Location = new System.Drawing.Point(0, 0);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(1153, 48);
            this.lblNhan.TabIndex = 1;
            this.lblNhan.Text = "CHI TIẾT PHIẾU XUẤT";
            this.lblNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDSCTPXuat
            // 
            this.grpDSCTPXuat.Controls.Add(this.dgvDSCTPXuat);
            this.grpDSCTPXuat.Location = new System.Drawing.Point(40, 360);
            this.grpDSCTPXuat.Name = "grpDSCTPXuat";
            this.grpDSCTPXuat.Size = new System.Drawing.Size(1076, 263);
            this.grpDSCTPXuat.TabIndex = 7;
            this.grpDSCTPXuat.TabStop = false;
            this.grpDSCTPXuat.Text = "Chi Tiết Phiếu Xuất";
            // 
            // dgvDSCTPXuat
            // 
            this.dgvDSCTPXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCTPXuat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSCTPXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTPXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvDSCTPXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSCTPXuat.Location = new System.Drawing.Point(3, 22);
            this.dgvDSCTPXuat.Name = "dgvDSCTPXuat";
            this.dgvDSCTPXuat.Size = new System.Drawing.Size(1070, 238);
            this.dgvDSCTPXuat.TabIndex = 0;
            this.dgvDSCTPXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCTPXuat_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaPX";
            this.Column2.HeaderText = "Mã Phiếu Xuất";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaSP";
            this.Column3.HeaderText = "Mã Sản Phẩm";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuongXuat";
            this.Column4.HeaderText = "Số Lượng Xuất";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DonGiaXuat";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column5.HeaderText = "Đơn Giá Xuất";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column6.HeaderText = "Thành Tiền";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DonViTinh";
            this.Column7.HeaderText = "Đơn Vị Tính";
            this.Column7.Name = "Column7";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788769_Cancel__Red;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(1027, 314);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 33);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788917_Wrench;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(533, 314);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 33);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788884_delete_16;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(723, 314);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 33);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788743_Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(438, 314);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 33);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblDGXuat
            // 
            this.lblDGXuat.AutoSize = true;
            this.lblDGXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGXuat.Location = new System.Drawing.Point(577, 30);
            this.lblDGXuat.Name = "lblDGXuat";
            this.lblDGXuat.Size = new System.Drawing.Size(107, 19);
            this.lblDGXuat.TabIndex = 0;
            this.lblDGXuat.Text = "Đơn Giá Xuất:";
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTinh.Location = new System.Drawing.Point(577, 104);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(96, 19);
            this.lblDonViTinh.TabIndex = 0;
            this.lblDonViTinh.Text = "Đơn Vị Tính:";
            // 
            // lblMaPX
            // 
            this.lblMaPX.AutoSize = true;
            this.lblMaPX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPX.Location = new System.Drawing.Point(182, 30);
            this.lblMaPX.Name = "lblMaPX";
            this.lblMaPX.Size = new System.Drawing.Size(115, 19);
            this.lblMaPX.TabIndex = 0;
            this.lblMaPX.Text = "Mã Phiếu Xuất:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(577, 67);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(90, 19);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Thành Tiền:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(182, 67);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(108, 19);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã Sản Phẩm:";
            // 
            // lblSLXuat
            // 
            this.lblSLXuat.AutoSize = true;
            this.lblSLXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLXuat.Location = new System.Drawing.Point(182, 104);
            this.lblSLXuat.Name = "lblSLXuat";
            this.lblSLXuat.Size = new System.Drawing.Size(116, 19);
            this.lblSLXuat.TabIndex = 0;
            this.lblSLXuat.Text = "Số Lượng Xuất:";
            // 
            // txtDGXuat
            // 
            this.txtDGXuat.Location = new System.Drawing.Point(698, 27);
            this.txtDGXuat.Name = "txtDGXuat";
            this.txtDGXuat.Size = new System.Drawing.Size(184, 26);
            this.txtDGXuat.TabIndex = 3;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(698, 64);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(184, 26);
            this.txtThanhTien.TabIndex = 4;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(698, 101);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(184, 26);
            this.txtDonViTinh.TabIndex = 5;
            this.txtDonViTinh.Text = "VND";
            // 
            // txtSLXuat
            // 
            this.txtSLXuat.Location = new System.Drawing.Point(332, 101);
            this.txtSLXuat.Name = "txtSLXuat";
            this.txtSLXuat.Size = new System.Drawing.Size(181, 26);
            this.txtSLXuat.TabIndex = 2;
            // 
            // grpTTCTPNhap
            // 
            this.grpTTCTPNhap.Controls.Add(this.cboMaSP);
            this.grpTTCTPNhap.Controls.Add(this.cboMaPX);
            this.grpTTCTPNhap.Controls.Add(this.txtSLXuat);
            this.grpTTCTPNhap.Controls.Add(this.txtDonViTinh);
            this.grpTTCTPNhap.Controls.Add(this.txtThanhTien);
            this.grpTTCTPNhap.Controls.Add(this.txtDGXuat);
            this.grpTTCTPNhap.Controls.Add(this.lblSLXuat);
            this.grpTTCTPNhap.Controls.Add(this.lblMaSP);
            this.grpTTCTPNhap.Controls.Add(this.lblTongTien);
            this.grpTTCTPNhap.Controls.Add(this.lblMaPX);
            this.grpTTCTPNhap.Controls.Add(this.lblDonViTinh);
            this.grpTTCTPNhap.Controls.Add(this.lblDGXuat);
            this.grpTTCTPNhap.Location = new System.Drawing.Point(40, 64);
            this.grpTTCTPNhap.Name = "grpTTCTPNhap";
            this.grpTTCTPNhap.Size = new System.Drawing.Size(1076, 144);
            this.grpTTCTPNhap.TabIndex = 0;
            this.grpTTCTPNhap.TabStop = false;
            this.grpTTCTPNhap.Text = "Thông Tin Chi Tiết Phiếu Xuất";
            // 
            // cboMaSP
            // 
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(332, 64);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(121, 27);
            this.cboMaSP.TabIndex = 7;
            // 
            // cboMaPX
            // 
            this.cboMaPX.FormattingEnabled = true;
            this.cboMaPX.Location = new System.Drawing.Point(332, 27);
            this.cboMaPX.Name = "cboMaPX";
            this.cboMaPX.Size = new System.Drawing.Size(121, 27);
            this.cboMaPX.TabIndex = 6;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1429364447_gtk_refresh;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(924, 314);
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
            this.btnLuu.Location = new System.Drawing.Point(628, 314);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 33);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cboCotTK
            // 
            this.cboCotTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCotTK.FormattingEnabled = true;
            this.cboCotTK.Items.AddRange(new object[] {
            "Mã Phiếu Xuất"});
            this.cboCotTK.Location = new System.Drawing.Point(332, 24);
            this.cboCotTK.Name = "cboCotTK";
            this.cboCotTK.Size = new System.Drawing.Size(136, 27);
            this.cboCotTK.TabIndex = 7;
            // 
            // txtTuTK
            // 
            this.txtTuTK.Location = new System.Drawing.Point(698, 27);
            this.txtTuTK.Name = "txtTuTK";
            this.txtTuTK.Size = new System.Drawing.Size(160, 26);
            this.txtTuTK.TabIndex = 8;
            // 
            // lblCot
            // 
            this.lblCot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCot.Location = new System.Drawing.Point(182, 30);
            this.lblCot.Name = "lblCot";
            this.lblCot.Size = new System.Drawing.Size(91, 19);
            this.lblCot.TabIndex = 14;
            this.lblCot.Text = "Tìm Theo:";
            // 
            // lblTuTK
            // 
            this.lblTuTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuTK.Location = new System.Drawing.Point(577, 32);
            this.lblTuTK.Name = "lblTuTK";
            this.lblTuTK.Size = new System.Drawing.Size(112, 19);
            this.lblTuTK.TabIndex = 15;
            this.lblTuTK.Text = "Từ Tìm Kiếm:";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.lblTuTK);
            this.grpTimKiem.Controls.Add(this.lblCot);
            this.grpTimKiem.Controls.Add(this.txtTuTK);
            this.grpTimKiem.Controls.Add(this.cboCotTK);
            this.grpTimKiem.Location = new System.Drawing.Point(40, 223);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(1076, 69);
            this.grpTimKiem.TabIndex = 10;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLyCuaHangNoiThat.Properties.Resources.Search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(820, 314);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 33);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmCTPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1153, 638);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.grpTTCTPNhap);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpDSCTPXuat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lblNhan);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCTPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Chi Tiết Phiếu Xuất";
            this.Load += new System.EventHandler(this.frmCTPhieuXuat_Load);
            this.grpDSCTPXuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPXuat)).EndInit();
            this.grpTTCTPNhap.ResumeLayout(false);
            this.grpTTCTPNhap.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.GroupBox grpDSCTPXuat;
        private System.Windows.Forms.DataGridView dgvDSCTPXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblDGXuat;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblMaPX;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblSLXuat;
        private System.Windows.Forms.TextBox txtDGXuat;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtSLXuat;
        private System.Windows.Forms.GroupBox grpTTCTPNhap;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cboCotTK;
        private System.Windows.Forms.TextBox txtTuTK;
        private System.Windows.Forms.Label lblCot;
        private System.Windows.Forms.Label lblTuTK;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.ComboBox cboMaPX;
    }
}