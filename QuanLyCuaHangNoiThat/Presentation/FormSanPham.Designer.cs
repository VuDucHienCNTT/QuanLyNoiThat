namespace QuanLyCuaHangNoiThat
{
    partial class frmSanPham
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
            this.grpDSSanPham = new System.Windows.Forms.GroupBox();
            this.dgvDSSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTTSanPham = new System.Windows.Forms.GroupBox();
            this.txtSoLuongCon = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblGiaSP = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblNhan = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.tblTuTK = new System.Windows.Forms.Label();
            this.lblCot = new System.Windows.Forms.Label();
            this.txtTuTK = new System.Windows.Forms.TextBox();
            this.cboCotTK = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpDSSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).BeginInit();
            this.grpTTSanPham.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDSSanPham
            // 
            this.grpDSSanPham.BackColor = System.Drawing.Color.CornflowerBlue;
            this.grpDSSanPham.Controls.Add(this.dgvDSSanPham);
            this.grpDSSanPham.Location = new System.Drawing.Point(40, 328);
            this.grpDSSanPham.Name = "grpDSSanPham";
            this.grpDSSanPham.Size = new System.Drawing.Size(895, 288);
            this.grpDSSanPham.TabIndex = 0;
            this.grpDSSanPham.TabStop = false;
            this.grpDSSanPham.Text = "Danh Sách Sản Phẩm";
            // 
            // dgvDSSanPham
            // 
            this.dgvDSSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSanPham.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDSSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSanPham.Location = new System.Drawing.Point(3, 22);
            this.dgvDSSanPham.Name = "dgvDSSanPham";
            this.dgvDSSanPham.Size = new System.Drawing.Size(889, 263);
            this.dgvDSSanPham.TabIndex = 0;
            this.dgvDSSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSanPham_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "MaSP";
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenSP";
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuongCon";
            this.Column3.HeaderText = "Số Lượng Còn";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonViTinh";
            this.Column4.HeaderText = "Đơn Vị Tính";
            this.Column4.Name = "Column4";
            // 
            // grpTTSanPham
            // 
            this.grpTTSanPham.BackColor = System.Drawing.Color.CornflowerBlue;
            this.grpTTSanPham.Controls.Add(this.txtSoLuongCon);
            this.grpTTSanPham.Controls.Add(this.txtDonViTinh);
            this.grpTTSanPham.Controls.Add(this.txtTenSP);
            this.grpTTSanPham.Controls.Add(this.txtMaSP);
            this.grpTTSanPham.Controls.Add(this.lblGiaSP);
            this.grpTTSanPham.Controls.Add(this.lblGhiChu);
            this.grpTTSanPham.Controls.Add(this.lblTenSP);
            this.grpTTSanPham.Controls.Add(this.lblMaSP);
            this.grpTTSanPham.Location = new System.Drawing.Point(43, 68);
            this.grpTTSanPham.Name = "grpTTSanPham";
            this.grpTTSanPham.Size = new System.Drawing.Size(892, 112);
            this.grpTTSanPham.TabIndex = 0;
            this.grpTTSanPham.TabStop = false;
            this.grpTTSanPham.Text = "Thông Tin Sản Phẩm";
            // 
            // txtSoLuongCon
            // 
            this.txtSoLuongCon.Location = new System.Drawing.Point(599, 31);
            this.txtSoLuongCon.Name = "txtSoLuongCon";
            this.txtSoLuongCon.Size = new System.Drawing.Size(181, 26);
            this.txtSoLuongCon.TabIndex = 2;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(599, 67);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(181, 26);
            this.txtDonViTinh.TabIndex = 3;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(256, 67);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(181, 26);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(256, 31);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(181, 26);
            this.txtMaSP.TabIndex = 0;
            // 
            // lblGiaSP
            // 
            this.lblGiaSP.AutoSize = true;
            this.lblGiaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaSP.Location = new System.Drawing.Point(481, 70);
            this.lblGiaSP.Name = "lblGiaSP";
            this.lblGiaSP.Size = new System.Drawing.Size(96, 19);
            this.lblGiaSP.TabIndex = 0;
            this.lblGiaSP.Text = "Đơn Vị Tính:";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(481, 34);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(111, 19);
            this.lblGhiChu.TabIndex = 0;
            this.lblGhiChu.Text = "Số Lượng Còn:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(140, 70);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(110, 19);
            this.lblTenSP.TabIndex = 0;
            this.lblTenSP.Text = "Tên Sản Phẩm:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(142, 34);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(108, 19);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã Sản Phẩm:";
            // 
            // lblNhan
            // 
            this.lblNhan.BackColor = System.Drawing.Color.Silver;
            this.lblNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNhan.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhan.Location = new System.Drawing.Point(0, 0);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(968, 48);
            this.lblNhan.TabIndex = 5;
            this.lblNhan.Text = "SẢN PHẨM";
            this.lblNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1429364447_gtk_refresh;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(741, 280);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(97, 33);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = " Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426788743_Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(257, 280);
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
            this.btnXoa.Location = new System.Drawing.Point(542, 280);
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
            this.btnSua.Location = new System.Drawing.Point(352, 280);
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
            this.btnDong.Location = new System.Drawing.Point(846, 280);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 33);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyCuaHangNoiThat.Properties.Resources._1426626169_Save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(447, 280);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 33);
            this.btnLuu.TabIndex = 2;
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
            this.grpTimKiem.Location = new System.Drawing.Point(43, 195);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(892, 67);
            this.grpTimKiem.TabIndex = 8;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm Kiếm";
            // 
            // tblTuTK
            // 
            this.tblTuTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTuTK.Location = new System.Drawing.Point(470, 29);
            this.tblTuTK.Name = "tblTuTK";
            this.tblTuTK.Size = new System.Drawing.Size(112, 19);
            this.tblTuTK.TabIndex = 15;
            this.tblTuTK.Text = "Từ Tìm Kiếm:";
            // 
            // lblCot
            // 
            this.lblCot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCot.Location = new System.Drawing.Point(142, 29);
            this.lblCot.Name = "lblCot";
            this.lblCot.Size = new System.Drawing.Size(91, 19);
            this.lblCot.TabIndex = 14;
            this.lblCot.Text = "Tìm Theo:";
            // 
            // txtTuTK
            // 
            this.txtTuTK.Location = new System.Drawing.Point(596, 26);
            this.txtTuTK.Name = "txtTuTK";
            this.txtTuTK.Size = new System.Drawing.Size(160, 26);
            this.txtTuTK.TabIndex = 8;
            // 
            // cboCotTK
            // 
            this.cboCotTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCotTK.FormattingEnabled = true;
            this.cboCotTK.Items.AddRange(new object[] {
            "Mã Sản Phẩm",
            "Tên Sản Phẩm"});
            this.cboCotTK.Location = new System.Drawing.Point(258, 26);
            this.cboCotTK.Name = "cboCotTK";
            this.cboCotTK.Size = new System.Drawing.Size(136, 27);
            this.cboCotTK.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLyCuaHangNoiThat.Properties.Resources.Search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(639, 280);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 33);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(968, 634);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblNhan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grpTTSanPham);
            this.Controls.Add(this.grpDSSanPham);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.grpDSSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).EndInit();
            this.grpTTSanPham.ResumeLayout(false);
            this.grpTTSanPham.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDSSanPham;
        private System.Windows.Forms.GroupBox grpTTSanPham;
        private System.Windows.Forms.DataGridView dgvDSSanPham;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblGiaSP;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label tblTuTK;
        private System.Windows.Forms.Label lblCot;
        private System.Windows.Forms.TextBox txtTuTK;
        private System.Windows.Forms.ComboBox cboCotTK;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtSoLuongCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}