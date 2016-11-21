namespace QuanLyCuaHangNoiThat
{
    partial class frmNhaCC
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
            this.dgvDSNhaCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDSNhaCC = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenNhaCC = new System.Windows.Forms.Label();
            this.lblMaNhaCC = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhaCC)).BeginInit();
            this.grpDSNhaCC.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSNhaCC
            // 
            this.dgvDSNhaCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNhaCC.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDSNhaCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNhaCC.Location = new System.Drawing.Point(3, 22);
            this.dgvDSNhaCC.Name = "dgvDSNhaCC";
            this.dgvDSNhaCC.Size = new System.Drawing.Size(912, 236);
            this.dgvDSNhaCC.TabIndex = 0;
            this.dgvDSNhaCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNhaCC_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "MaNCC";
            this.Column1.HeaderText = "Mã Nhà Cung Cấp";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNCC";
            this.Column2.HeaderText = "Tên Nhà Cung Cấp";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "DienThoai";
            this.Column4.HeaderText = "Số Điện Thoại";
            this.Column4.Name = "Column4";
            this.Column4.Width = 160;
            // 
            // grpDSNhaCC
            // 
            this.grpDSNhaCC.BackColor = System.Drawing.Color.CornflowerBlue;
            this.grpDSNhaCC.Controls.Add(this.dgvDSNhaCC);
            this.grpDSNhaCC.Location = new System.Drawing.Point(35, 323);
            this.grpDSNhaCC.Name = "grpDSNhaCC";
            this.grpDSNhaCC.Size = new System.Drawing.Size(918, 261);
            this.grpDSNhaCC.TabIndex = 1;
            this.grpDSNhaCC.TabStop = false;
            this.grpDSNhaCC.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.lblTenNhaCC);
            this.groupBox1.Controls.Add(this.lblMaNhaCC);
            this.groupBox1.Location = new System.Drawing.Point(35, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(591, 68);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(181, 26);
            this.txtSDT.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(591, 30);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(181, 26);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(216, 27);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(181, 26);
            this.txtMaNCC.TabIndex = 0;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(216, 65);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(181, 26);
            this.txtTenNCC.TabIndex = 1;
            // 
            // lblSDT
            // 
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(493, 71);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(67, 19);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(493, 33);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(67, 19);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblTenNhaCC
            // 
            this.lblTenNhaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhaCC.Location = new System.Drawing.Point(114, 68);
            this.lblTenNhaCC.Name = "lblTenNhaCC";
            this.lblTenNhaCC.Size = new System.Drawing.Size(99, 19);
            this.lblTenNhaCC.TabIndex = 0;
            this.lblTenNhaCC.Text = "Tên Nhà CC:";
            // 
            // lblMaNhaCC
            // 
            this.lblMaNhaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhaCC.Location = new System.Drawing.Point(114, 30);
            this.lblMaNhaCC.Name = "lblMaNhaCC";
            this.lblMaNhaCC.Size = new System.Drawing.Size(99, 19);
            this.lblMaNhaCC.TabIndex = 0;
            this.lblMaNhaCC.Text = "Mã Nhà CC:\r\n";
            // 
            // lblNhan
            // 
            this.lblNhan.BackColor = System.Drawing.Color.Silver;
            this.lblNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNhan.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhan.Location = new System.Drawing.Point(0, 0);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(992, 48);
            this.lblNhan.TabIndex = 9;
            this.lblNhan.Text = "NHÀ CUNG CẤP";
            this.lblNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788743_Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(276, 277);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 33);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788884_delete_16;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(561, 277);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 33);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788917_Wrench;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(371, 277);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 33);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788769_Cancel__Red;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(864, 277);
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
            this.btnLamMoi.Location = new System.Drawing.Point(761, 277);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(97, 33);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = " Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426626169_Save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(466, 277);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 33);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.tblTuTK);
            this.grpTimKiem.Controls.Add(this.lblCot);
            this.grpTimKiem.Controls.Add(this.txtTuTK);
            this.grpTimKiem.Controls.Add(this.cboCotTK);
            this.grpTimKiem.Location = new System.Drawing.Point(35, 192);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(918, 67);
            this.grpTimKiem.TabIndex = 10;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm Kiếm";
            // 
            // tblTuTK
            // 
            this.tblTuTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTuTK.Location = new System.Drawing.Point(465, 28);
            this.tblTuTK.Name = "tblTuTK";
            this.tblTuTK.Size = new System.Drawing.Size(112, 19);
            this.tblTuTK.TabIndex = 15;
            this.tblTuTK.Text = "Từ Tìm Kiếm:";
            // 
            // lblCot
            // 
            this.lblCot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCot.Location = new System.Drawing.Point(100, 29);
            this.lblCot.Name = "lblCot";
            this.lblCot.Size = new System.Drawing.Size(91, 19);
            this.lblCot.TabIndex = 14;
            this.lblCot.Text = "Tìm Theo:";
            // 
            // txtTuTK
            // 
            this.txtTuTK.Location = new System.Drawing.Point(591, 25);
            this.txtTuTK.Name = "txtTuTK";
            this.txtTuTK.Size = new System.Drawing.Size(181, 26);
            this.txtTuTK.TabIndex = 8;
            // 
            // cboCotTK
            // 
            this.cboCotTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCotTK.FormattingEnabled = true;
            this.cboCotTK.Items.AddRange(new object[] {
            "Mã Nhà Cung Cấp",
            "Tên Nhà Cung Cấp"});
            this.cboCotTK.Location = new System.Drawing.Point(216, 26);
            this.cboCotTK.Name = "cboCotTK";
            this.cboCotTK.Size = new System.Drawing.Size(181, 27);
            this.cboCotTK.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLyCuaHangNoiThat.Properties.Resources.Search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(657, 277);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 33);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(992, 598);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lblNhan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grpDSNhaCC);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmNhaCC";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmNhaCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhaCC)).EndInit();
            this.grpDSNhaCC.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSNhaCC;
        private System.Windows.Forms.GroupBox grpDSNhaCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaNhaCC;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenNhaCC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label tblTuTK;
        private System.Windows.Forms.Label lblCot;
        private System.Windows.Forms.TextBox txtTuTK;
        private System.Windows.Forms.ComboBox cboCotTK;
        private System.Windows.Forms.Button btnTimKiem;
    }
}