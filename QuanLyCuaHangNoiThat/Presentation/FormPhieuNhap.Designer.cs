namespace QuanLyCuaHangNoiThat
{
    partial class frmPhieuNhap
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
            this.grpDSPNhap = new System.Windows.Forms.GroupBox();
            this.dgvDSPNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTTPNhap = new System.Windows.Forms.GroupBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.dtmNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.lblNgayXuat = new System.Windows.Forms.Label();
            this.lblMaNhaCC = new System.Windows.Forms.Label();
            this.lblMaPN = new System.Windows.Forms.Label();
            this.lblNhan = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.tblTuTK = new System.Windows.Forms.Label();
            this.lblCot = new System.Windows.Forms.Label();
            this.txtTuTK = new System.Windows.Forms.TextBox();
            this.cboCotTK = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpDSPNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPNhap)).BeginInit();
            this.grpTTPNhap.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDSPNhap
            // 
            this.grpDSPNhap.Controls.Add(this.dgvDSPNhap);
            this.grpDSPNhap.Location = new System.Drawing.Point(34, 315);
            this.grpDSPNhap.Margin = new System.Windows.Forms.Padding(4);
            this.grpDSPNhap.Name = "grpDSPNhap";
            this.grpDSPNhap.Padding = new System.Windows.Forms.Padding(4);
            this.grpDSPNhap.Size = new System.Drawing.Size(895, 256);
            this.grpDSPNhap.TabIndex = 0;
            this.grpDSPNhap.TabStop = false;
            this.grpDSPNhap.Text = "Danh Sách Phiếu Nhập";
            // 
            // dgvDSPNhap
            // 
            this.dgvDSPNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPNhap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSPNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDSPNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPNhap.Location = new System.Drawing.Point(4, 23);
            this.dgvDSPNhap.Name = "dgvDSPNhap";
            this.dgvDSPNhap.Size = new System.Drawing.Size(887, 229);
            this.dgvDSPNhap.TabIndex = 0;
            this.dgvDSPNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPNhap_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPN";
            this.Column1.HeaderText = "Mã Phiếu Nhập";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNV";
            this.Column2.HeaderText = "Mã Nhân Viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNCC";
            this.Column3.HeaderText = "Mã Nhà Cung Cấp";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Ngày Nhập";
            this.Column4.Name = "Column4";
            // 
            // grpTTPNhap
            // 
            this.grpTTPNhap.Controls.Add(this.cboMaNV);
            this.grpTTPNhap.Controls.Add(this.cboMaNCC);
            this.grpTTPNhap.Controls.Add(this.dtmNgayNhap);
            this.grpTTPNhap.Controls.Add(this.txtMaPN);
            this.grpTTPNhap.Controls.Add(this.lblNV);
            this.grpTTPNhap.Controls.Add(this.lblNgayXuat);
            this.grpTTPNhap.Controls.Add(this.lblMaNhaCC);
            this.grpTTPNhap.Controls.Add(this.lblMaPN);
            this.grpTTPNhap.Location = new System.Drawing.Point(34, 62);
            this.grpTTPNhap.Margin = new System.Windows.Forms.Padding(4);
            this.grpTTPNhap.Name = "grpTTPNhap";
            this.grpTTPNhap.Padding = new System.Windows.Forms.Padding(4);
            this.grpTTPNhap.Size = new System.Drawing.Size(894, 106);
            this.grpTTPNhap.TabIndex = 0;
            this.grpTTPNhap.TabStop = false;
            this.grpTTPNhap.Text = "Thông Tin Phiếu Nhập";
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(238, 64);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(117, 27);
            this.cboMaNV.TabIndex = 6;
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(573, 20);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(122, 27);
            this.cboMaNCC.TabIndex = 5;
            // 
            // dtmNgayNhap
            // 
            this.dtmNgayNhap.CustomFormat = "MM/dd/yyyy";
            this.dtmNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgayNhap.Location = new System.Drawing.Point(573, 64);
            this.dtmNgayNhap.Name = "dtmNgayNhap";
            this.dtmNgayNhap.Size = new System.Drawing.Size(122, 26);
            this.dtmNgayNhap.TabIndex = 4;
            this.dtmNgayNhap.Value = new System.DateTime(2015, 5, 14, 0, 0, 0, 0);
            // 
            // txtMaPN
            // 
            this.txtMaPN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(238, 25);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(181, 26);
            this.txtMaPN.TabIndex = 0;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNV.Location = new System.Drawing.Point(117, 67);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(112, 19);
            this.lblNV.TabIndex = 0;
            this.lblNV.Text = "Mã Nhân Viên:";
            // 
            // lblNgayXuat
            // 
            this.lblNgayXuat.AutoSize = true;
            this.lblNgayXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayXuat.Location = new System.Drawing.Point(471, 67);
            this.lblNgayXuat.Name = "lblNgayXuat";
            this.lblNgayXuat.Size = new System.Drawing.Size(90, 19);
            this.lblNgayXuat.TabIndex = 0;
            this.lblNgayXuat.Text = "Ngày Nhập:";
            // 
            // lblMaNhaCC
            // 
            this.lblMaNhaCC.AutoSize = true;
            this.lblMaNhaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhaCC.Location = new System.Drawing.Point(471, 28);
            this.lblMaNhaCC.Name = "lblMaNhaCC";
            this.lblMaNhaCC.Size = new System.Drawing.Size(96, 19);
            this.lblMaNhaCC.TabIndex = 0;
            this.lblMaNhaCC.Text = "Mã Nhà CC:";
            // 
            // lblMaPN
            // 
            this.lblMaPN.AutoSize = true;
            this.lblMaPN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPN.Location = new System.Drawing.Point(117, 28);
            this.lblMaPN.Name = "lblMaPN";
            this.lblMaPN.Size = new System.Drawing.Size(119, 19);
            this.lblMaPN.TabIndex = 0;
            this.lblMaPN.Text = "Mã Phiếu Nhập:";
            // 
            // lblNhan
            // 
            this.lblNhan.BackColor = System.Drawing.Color.Silver;
            this.lblNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNhan.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhan.Location = new System.Drawing.Point(0, 0);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(964, 48);
            this.lblNhan.TabIndex = 9;
            this.lblNhan.Text = "PHIẾU NHẬP";
            this.lblNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788743_Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(254, 274);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 33);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788884_delete_16;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(539, 274);
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
            this.btnSua.Location = new System.Drawing.Point(349, 274);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 33);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788769_Cancel__Red;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(840, 274);
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
            this.btnLamMoi.Location = new System.Drawing.Point(737, 274);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(97, 33);
            this.btnLamMoi.TabIndex = 6;
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
            this.btnLuu.Location = new System.Drawing.Point(444, 274);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 33);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.tblTuTK);
            this.grpTimKiem.Controls.Add(this.lblCot);
            this.grpTimKiem.Controls.Add(this.txtTuTK);
            this.grpTimKiem.Controls.Add(this.cboCotTK);
            this.grpTimKiem.Location = new System.Drawing.Point(34, 186);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(894, 67);
            this.grpTimKiem.TabIndex = 11;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm Kiếm";
            // 
            // tblTuTK
            // 
            this.tblTuTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTuTK.Location = new System.Drawing.Point(460, 33);
            this.tblTuTK.Name = "tblTuTK";
            this.tblTuTK.Size = new System.Drawing.Size(107, 19);
            this.tblTuTK.TabIndex = 15;
            this.tblTuTK.Text = "Từ Tìm Kiếm:";
            // 
            // lblCot
            // 
            this.lblCot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCot.Location = new System.Drawing.Point(128, 29);
            this.lblCot.Name = "lblCot";
            this.lblCot.Size = new System.Drawing.Size(91, 19);
            this.lblCot.TabIndex = 14;
            this.lblCot.Text = "Tìm Theo:";
            // 
            // txtTuTK
            // 
            this.txtTuTK.Location = new System.Drawing.Point(573, 26);
            this.txtTuTK.Name = "txtTuTK";
            this.txtTuTK.Size = new System.Drawing.Size(181, 26);
            this.txtTuTK.TabIndex = 8;
            // 
            // cboCotTK
            // 
            this.cboCotTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCotTK.FormattingEnabled = true;
            this.cboCotTK.Items.AddRange(new object[] {
            "Mã Phiếu Nhập"});
            this.cboCotTK.Location = new System.Drawing.Point(238, 26);
            this.cboCotTK.Name = "cboCotTK";
            this.cboCotTK.Size = new System.Drawing.Size(181, 27);
            this.cboCotTK.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLyCuaHangNoiThat.Properties.Resources.Search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(634, 274);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 33);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(964, 585);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lblNhan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpTTPNhap);
            this.Controls.Add(this.grpDSPNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Phiếu Nhập";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            this.grpDSPNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPNhap)).EndInit();
            this.grpTTPNhap.ResumeLayout(false);
            this.grpTTPNhap.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDSPNhap;
        private System.Windows.Forms.GroupBox grpTTPNhap;
        private System.Windows.Forms.DataGridView dgvDSPNhap;
        private System.Windows.Forms.Label lblMaPN;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.Label lblNgayXuat;
        private System.Windows.Forms.Label lblMaNhaCC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker dtmNgayNhap;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label tblTuTK;
        private System.Windows.Forms.Label lblCot;
        private System.Windows.Forms.TextBox txtTuTK;
        private System.Windows.Forms.ComboBox cboCotTK;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.ComboBox cboMaNV;
    }
}