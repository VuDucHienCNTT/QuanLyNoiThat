namespace QuanLyCuaHangNoiThat
{
    partial class frmCTPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNhan = new System.Windows.Forms.Label();
            this.grpDSCTPNhap = new System.Windows.Forms.GroupBox();
            this.dgvDSCTPNhap = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTTCTPNhap = new System.Windows.Forms.GroupBox();
            this.cboMaPN = new System.Windows.Forms.ComboBox();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDGNhap = new System.Windows.Forms.TextBox();
            this.lblSLNhap = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblMaPN = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblDGNhap = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTuTK = new System.Windows.Forms.Label();
            this.lblCot = new System.Windows.Forms.Label();
            this.txtTuTK = new System.Windows.Forms.TextBox();
            this.cboCotTK = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpDSCTPNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPNhap)).BeginInit();
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
            this.lblNhan.Size = new System.Drawing.Size(1154, 48);
            this.lblNhan.TabIndex = 0;
            this.lblNhan.Text = "CHI TIẾT PHIẾU NHẬP";
            this.lblNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDSCTPNhap
            // 
            this.grpDSCTPNhap.Controls.Add(this.dgvDSCTPNhap);
            this.grpDSCTPNhap.Location = new System.Drawing.Point(39, 355);
            this.grpDSCTPNhap.Name = "grpDSCTPNhap";
            this.grpDSCTPNhap.Size = new System.Drawing.Size(1084, 266);
            this.grpDSCTPNhap.TabIndex = 1;
            this.grpDSCTPNhap.TabStop = false;
            this.grpDSCTPNhap.Text = "Chi Tiết Phiếu Nhập";
            // 
            // dgvDSCTPNhap
            // 
            this.dgvDSCTPNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCTPNhap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSCTPNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTPNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvDSCTPNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSCTPNhap.Location = new System.Drawing.Point(3, 22);
            this.dgvDSCTPNhap.Name = "dgvDSCTPNhap";
            this.dgvDSCTPNhap.Size = new System.Drawing.Size(1078, 241);
            this.dgvDSCTPNhap.TabIndex = 0;
            this.dgvDSCTPNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCTPNhap_CellClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MaPN";
            this.Column2.HeaderText = "Mã Phiếu Nhập";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MaSP";
            this.Column3.HeaderText = "Mã Sản Phẩm";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "SoLuongNhap";
            this.Column4.HeaderText = "Số Lượng Nhập";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "DonGiaNhap";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Đơn Giá Nhập";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column6.HeaderText = "Thành Tiền";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "DonViTinh";
            this.Column7.HeaderText = "Đơn Vị Tính";
            this.Column7.Name = "Column7";
            // 
            // grpTTCTPNhap
            // 
            this.grpTTCTPNhap.Controls.Add(this.cboMaPN);
            this.grpTTCTPNhap.Controls.Add(this.cboMaSP);
            this.grpTTCTPNhap.Controls.Add(this.txtSLNhap);
            this.grpTTCTPNhap.Controls.Add(this.txtDonViTinh);
            this.grpTTCTPNhap.Controls.Add(this.txtThanhTien);
            this.grpTTCTPNhap.Controls.Add(this.txtDGNhap);
            this.grpTTCTPNhap.Controls.Add(this.lblSLNhap);
            this.grpTTCTPNhap.Controls.Add(this.lblMaSP);
            this.grpTTCTPNhap.Controls.Add(this.lblTongTien);
            this.grpTTCTPNhap.Controls.Add(this.lblMaPN);
            this.grpTTCTPNhap.Controls.Add(this.lblDonViTinh);
            this.grpTTCTPNhap.Controls.Add(this.lblDGNhap);
            this.grpTTCTPNhap.Location = new System.Drawing.Point(39, 66);
            this.grpTTCTPNhap.Name = "grpTTCTPNhap";
            this.grpTTCTPNhap.Size = new System.Drawing.Size(1084, 143);
            this.grpTTCTPNhap.TabIndex = 0;
            this.grpTTCTPNhap.TabStop = false;
            this.grpTTCTPNhap.Text = "Thông Tin Chi Tiết Phiếu Nhập";
            // 
            // cboMaPN
            // 
            this.cboMaPN.FormattingEnabled = true;
            this.cboMaPN.Location = new System.Drawing.Point(352, 24);
            this.cboMaPN.Name = "cboMaPN";
            this.cboMaPN.Size = new System.Drawing.Size(122, 27);
            this.cboMaPN.TabIndex = 7;
            // 
            // cboMaSP
            // 
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(352, 61);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(122, 27);
            this.cboMaSP.TabIndex = 6;
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Location = new System.Drawing.Point(352, 98);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(181, 26);
            this.txtSLNhap.TabIndex = 2;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(721, 98);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(181, 26);
            this.txtDonViTinh.TabIndex = 5;
            this.txtDonViTinh.Text = "VND";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(721, 61);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(181, 26);
            this.txtThanhTien.TabIndex = 4;
            // 
            // txtDGNhap
            // 
            this.txtDGNhap.Location = new System.Drawing.Point(721, 24);
            this.txtDGNhap.Name = "txtDGNhap";
            this.txtDGNhap.Size = new System.Drawing.Size(181, 26);
            this.txtDGNhap.TabIndex = 3;
            // 
            // lblSLNhap
            // 
            this.lblSLNhap.AutoSize = true;
            this.lblSLNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLNhap.Location = new System.Drawing.Point(202, 101);
            this.lblSLNhap.Name = "lblSLNhap";
            this.lblSLNhap.Size = new System.Drawing.Size(120, 19);
            this.lblSLNhap.TabIndex = 0;
            this.lblSLNhap.Text = "Số Lượng Nhập:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(202, 64);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(108, 19);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã Sản Phẩm:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(600, 64);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(90, 19);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Thành Tiền:";
            // 
            // lblMaPN
            // 
            this.lblMaPN.AutoSize = true;
            this.lblMaPN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPN.Location = new System.Drawing.Point(202, 27);
            this.lblMaPN.Name = "lblMaPN";
            this.lblMaPN.Size = new System.Drawing.Size(119, 19);
            this.lblMaPN.TabIndex = 0;
            this.lblMaPN.Text = "Mã Phiếu Nhập:";
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTinh.Location = new System.Drawing.Point(600, 102);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(96, 19);
            this.lblDonViTinh.TabIndex = 0;
            this.lblDonViTinh.Text = "Đơn Vị Tính:";
            // 
            // lblDGNhap
            // 
            this.lblDGNhap.AutoSize = true;
            this.lblDGNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGNhap.Location = new System.Drawing.Point(600, 27);
            this.lblDGNhap.Name = "lblDGNhap";
            this.lblDGNhap.Size = new System.Drawing.Size(111, 19);
            this.lblDGNhap.TabIndex = 0;
            this.lblDGNhap.Text = "Đơn Giá Nhập:";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788743_Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(441, 311);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 33);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788884_delete_16;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(727, 311);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 33);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788917_Wrench;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(536, 311);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 33);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788769_Cancel__Red;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(1034, 311);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 33);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1429364447_gtk_refresh;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(928, 311);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(97, 33);
            this.btnLamMoi.TabIndex = 5;
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
            this.btnLuu.Location = new System.Drawing.Point(631, 311);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 33);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.lblTuTK);
            this.grpTimKiem.Controls.Add(this.lblCot);
            this.grpTimKiem.Controls.Add(this.txtTuTK);
            this.grpTimKiem.Controls.Add(this.cboCotTK);
            this.grpTimKiem.Location = new System.Drawing.Point(39, 224);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(1084, 69);
            this.grpTimKiem.TabIndex = 9;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm Kiếm";
            // 
            // lblTuTK
            // 
            this.lblTuTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuTK.Location = new System.Drawing.Point(595, 28);
            this.lblTuTK.Name = "lblTuTK";
            this.lblTuTK.Size = new System.Drawing.Size(112, 19);
            this.lblTuTK.TabIndex = 15;
            this.lblTuTK.Text = "Từ Tìm Kiếm:";
            // 
            // lblCot
            // 
            this.lblCot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCot.Location = new System.Drawing.Point(202, 28);
            this.lblCot.Name = "lblCot";
            this.lblCot.Size = new System.Drawing.Size(91, 19);
            this.lblCot.TabIndex = 14;
            this.lblCot.Text = "Tìm Theo:";
            // 
            // txtTuTK
            // 
            this.txtTuTK.Location = new System.Drawing.Point(721, 25);
            this.txtTuTK.Name = "txtTuTK";
            this.txtTuTK.Size = new System.Drawing.Size(160, 26);
            this.txtTuTK.TabIndex = 8;
            // 
            // cboCotTK
            // 
            this.cboCotTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCotTK.FormattingEnabled = true;
            this.cboCotTK.Items.AddRange(new object[] {
            "Mã Phiếu Nhập"});
            this.cboCotTK.Location = new System.Drawing.Point(352, 20);
            this.cboCotTK.Name = "cboCotTK";
            this.cboCotTK.Size = new System.Drawing.Size(136, 27);
            this.cboCotTK.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLyCuaHangNoiThat.Properties.Resources.Search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(824, 311);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 33);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmCTPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1154, 635);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpTTCTPNhap);
            this.Controls.Add(this.grpDSCTPNhap);
            this.Controls.Add(this.lblNhan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCTPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Chi Tiết Phiếu Nhập";
            this.Load += new System.EventHandler(this.frmCTPhieuNhap_Load);
            this.grpDSCTPNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPNhap)).EndInit();
            this.grpTTCTPNhap.ResumeLayout(false);
            this.grpTTCTPNhap.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.GroupBox grpDSCTPNhap;
        private System.Windows.Forms.DataGridView dgvDSCTPNhap;
        private System.Windows.Forms.GroupBox grpTTCTPNhap;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblMaPN;
        private System.Windows.Forms.Label lblSLNhap;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblDGNhap;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDGNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTuTK;
        private System.Windows.Forms.Label lblCot;
        private System.Windows.Forms.TextBox txtTuTK;
        private System.Windows.Forms.ComboBox cboCotTK;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.ComboBox cboMaPN;
    }
}