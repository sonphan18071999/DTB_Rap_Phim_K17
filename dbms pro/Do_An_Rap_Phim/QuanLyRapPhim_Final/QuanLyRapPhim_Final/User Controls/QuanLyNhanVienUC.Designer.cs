namespace QuanLyRapPhim_Final.User_Controls
{
    partial class QuanLyNhanVienUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHovalotNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dgv_NHANVIEN = new System.Windows.Forms.DataGridView();
            this.hovaLotNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGioLamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNQLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maChiNhanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyRapPhimDataSet1 = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet1();
            this.quanLyRapPhimDataSet_NHANVIEN = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_NHANVIEN();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelNV = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.cbbMaCV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.nhanVienTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_NHANVIENTableAdapters.NhanVienTableAdapter();
            this.quanLyRapPhimDataSet = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet();
            this.nhanVienTableAdapter1 = new QuanLyRapPhim_Final.QuanLyRapPhimDataSetTableAdapters.NhanVienTableAdapter();
            this.nhanVienTableAdapter2 = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet1TableAdapters.NhanVienTableAdapter();
            this.cbMaNQL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrSoGioLam = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtLuongThang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDoiPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NHANVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_NHANVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoGioLam)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và tên lót Nhân Viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Nhân Viên :";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(407, 19);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(191, 30);
            this.txtMaNV.TabIndex = 6;
            // 
            // txtHovalotNV
            // 
            this.txtHovalotNV.Location = new System.Drawing.Point(405, 61);
            this.txtHovalotNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHovalotNV.Name = "txtHovalotNV";
            this.txtHovalotNV.Size = new System.Drawing.Size(191, 30);
            this.txtHovalotNV.TabIndex = 7;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(405, 105);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(191, 30);
            this.txtTenNV.TabIndex = 8;
            // 
            // dgv_NHANVIEN
            // 
            this.dgv_NHANVIEN.AutoGenerateColumns = false;
            this.dgv_NHANVIEN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NHANVIEN.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NHANVIEN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_NHANVIEN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_NHANVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NHANVIEN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hovaLotNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.maCVDataGridViewTextBoxColumn,
            this.soGioLamDataGridViewTextBoxColumn,
            this.maNQLDataGridViewTextBoxColumn,
            this.maChiNhanhDataGridViewTextBoxColumn});
            this.dgv_NHANVIEN.DataSource = this.nhanVienBindingSource;
            this.dgv_NHANVIEN.Location = new System.Drawing.Point(153, 493);
            this.dgv_NHANVIEN.Name = "dgv_NHANVIEN";
            this.dgv_NHANVIEN.RowHeadersWidth = 51;
            this.dgv_NHANVIEN.Size = new System.Drawing.Size(905, 291);
            this.dgv_NHANVIEN.TabIndex = 9;
            this.dgv_NHANVIEN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NHANVIEN_CellClick);
            this.dgv_NHANVIEN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NHANVIEN_CellContentClick);
            // 
            // hovaLotNVDataGridViewTextBoxColumn
            // 
            this.hovaLotNVDataGridViewTextBoxColumn.DataPropertyName = "HovaLotNV";
            this.hovaLotNVDataGridViewTextBoxColumn.HeaderText = "HovaLotNV";
            this.hovaLotNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hovaLotNVDataGridViewTextBoxColumn.Name = "hovaLotNVDataGridViewTextBoxColumn";
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // maCVDataGridViewTextBoxColumn
            // 
            this.maCVDataGridViewTextBoxColumn.DataPropertyName = "MaCV";
            this.maCVDataGridViewTextBoxColumn.HeaderText = "MaCV";
            this.maCVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCVDataGridViewTextBoxColumn.Name = "maCVDataGridViewTextBoxColumn";
            // 
            // soGioLamDataGridViewTextBoxColumn
            // 
            this.soGioLamDataGridViewTextBoxColumn.DataPropertyName = "SoGioLam";
            this.soGioLamDataGridViewTextBoxColumn.HeaderText = "SoGioLam";
            this.soGioLamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soGioLamDataGridViewTextBoxColumn.Name = "soGioLamDataGridViewTextBoxColumn";
            // 
            // maNQLDataGridViewTextBoxColumn
            // 
            this.maNQLDataGridViewTextBoxColumn.DataPropertyName = "MaNQL";
            this.maNQLDataGridViewTextBoxColumn.HeaderText = "MaNQL";
            this.maNQLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNQLDataGridViewTextBoxColumn.Name = "maNQLDataGridViewTextBoxColumn";
            // 
            // maChiNhanhDataGridViewTextBoxColumn
            // 
            this.maChiNhanhDataGridViewTextBoxColumn.DataPropertyName = "MaChiNhanh";
            this.maChiNhanhDataGridViewTextBoxColumn.HeaderText = "MaChiNhanh";
            this.maChiNhanhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maChiNhanhDataGridViewTextBoxColumn.Name = "maChiNhanhDataGridViewTextBoxColumn";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyRapPhimDataSet1;
            // 
            // quanLyRapPhimDataSet1
            // 
            this.quanLyRapPhimDataSet1.DataSetName = "QuanLyRapPhimDataSet1";
            this.quanLyRapPhimDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyRapPhimDataSet_NHANVIEN
            // 
            this.quanLyRapPhimDataSet_NHANVIEN.DataSetName = "QuanLyRapPhimDataSet_NHANVIEN";
            this.quanLyRapPhimDataSet_NHANVIEN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(625, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 33);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.Location = new System.Drawing.Point(756, 23);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(97, 33);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.AutoSize = true;
            this.btnEditNV.Location = new System.Drawing.Point(625, 67);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(286, 33);
            this.btnEditNV.TabIndex = 18;
            this.btnEditNV.Text = "Sửa Thông Tin  Nhân Viên";
            this.btnEditNV.UseVisualStyleBackColor = true;
            this.btnEditNV.Click += new System.EventHandler(this.btnEditNV_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(859, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 33);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm nhân viên";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelNV
            // 
            this.btnDelNV.AutoSize = true;
            this.btnDelNV.Location = new System.Drawing.Point(625, 110);
            this.btnDelNV.Name = "btnDelNV";
            this.btnDelNV.Size = new System.Drawing.Size(424, 33);
            this.btnDelNV.TabIndex = 20;
            this.btnDelNV.Text = "Xóa Nhân Viên";
            this.btnDelNV.UseVisualStyleBackColor = true;
            this.btnDelNV.Click += new System.EventHandler(this.btnDelNV_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(917, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 33);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Chức vụ : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Lương :";
            // 
            // txtLuong
            // 
            this.txtLuong.Enabled = false;
            this.txtLuong.Location = new System.Drawing.Point(405, 249);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(191, 30);
            this.txtLuong.TabIndex = 25;
            // 
            // cbbMaCV
            // 
            this.cbbMaCV.DisplayMember = "MaCV";
            this.cbbMaCV.FormattingEnabled = true;
            this.cbbMaCV.Location = new System.Drawing.Point(405, 150);
            this.cbbMaCV.Name = "cbbMaCV";
            this.cbbMaCV.Size = new System.Drawing.Size(191, 31);
            this.cbbMaCV.TabIndex = 26;
            this.cbbMaCV.ValueMember = "MaCV";
            this.cbbMaCV.SelectedIndexChanged += new System.EventHandler(this.cbbMaCV_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Mã chức vụ :";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Enabled = false;
            this.txtChucVu.Location = new System.Drawing.Point(405, 199);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(191, 30);
            this.txtChucVu.TabIndex = 28;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyRapPhimDataSet
            // 
            this.quanLyRapPhimDataSet.DataSetName = "QuanLyRapPhimDataSet";
            this.quanLyRapPhimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter1
            // 
            this.nhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter2
            // 
            this.nhanVienTableAdapter2.ClearBeforeFill = true;
            // 
            // cbMaNQL
            // 
            this.cbMaNQL.DisplayMember = "MaCV";
            this.cbMaNQL.FormattingEnabled = true;
            this.cbMaNQL.Location = new System.Drawing.Point(405, 300);
            this.cbMaNQL.Name = "cbMaNQL";
            this.cbMaNQL.Size = new System.Drawing.Size(191, 31);
            this.cbMaNQL.TabIndex = 29;
            this.cbMaNQL.ValueMember = "MaCV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Được quản lý bởi:";
            // 
            // nmrSoGioLam
            // 
            this.nmrSoGioLam.Location = new System.Drawing.Point(405, 350);
            this.nmrSoGioLam.Maximum = new decimal(new int[] {
            744,
            0,
            0,
            0});
            this.nmrSoGioLam.Name = "nmrSoGioLam";
            this.nmrSoGioLam.Size = new System.Drawing.Size(193, 30);
            this.nmrSoGioLam.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Số Giờ Làm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "Chi nhánh:";
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.DisplayMember = "MaCV";
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(405, 393);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(191, 31);
            this.cbChiNhanh.TabIndex = 35;
            this.cbChiNhanh.ValueMember = "MaCV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTinh);
            this.groupBox1.Controls.Add(this.txtLuongThang);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(625, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 129);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lương Nhân Viên";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(118, 78);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(103, 32);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtLuongThang
            // 
            this.txtLuongThang.Location = new System.Drawing.Point(188, 27);
            this.txtLuongThang.Name = "txtLuongThang";
            this.txtLuongThang.Size = new System.Drawing.Size(197, 30);
            this.txtLuongThang.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Lương trong tháng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 445);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 23);
            this.label12.TabIndex = 40;
            this.label12.Text = "Tìm Nhân Viên:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(407, 438);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 30);
            this.txtSearch.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(625, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 101);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tài Khoản";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(267, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mật Khẩu:";
            // 
            // btnDoiPassword
            // 
            this.btnDoiPassword.Location = new System.Drawing.Point(625, 300);
            this.btnDoiPassword.Name = "btnDoiPassword";
            this.btnDoiPassword.Size = new System.Drawing.Size(424, 41);
            this.btnDoiPassword.TabIndex = 44;
            this.btnDoiPassword.Text = "Đổi mật khẩu";
            this.btnDoiPassword.UseVisualStyleBackColor = true;
            this.btnDoiPassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLyNhanVienUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnDoiPassword);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmrSoGioLam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMaNQL);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbMaCV);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelNV);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEditNV);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgv_NHANVIEN);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtHovalotNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyNhanVienUC";
            this.Size = new System.Drawing.Size(1625, 886);
            this.Load += new System.EventHandler(this.QuanLyNhanVienUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NHANVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_NHANVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoGioLam)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHovalotNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DataGridView dgv_NHANVIEN;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnEditNV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelNV;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.ComboBox cbbMaCV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChucVu;
        private QuanLyRapPhimDataSet_NHANVIEN quanLyRapPhimDataSet_NHANVIEN;
        private QuanLyRapPhimDataSet_NHANVIENTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QuanLyRapPhimDataSet quanLyRapPhimDataSet;
        private QuanLyRapPhimDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaLotNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGioLamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNQLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChiNhanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyRapPhimDataSet1 quanLyRapPhimDataSet1;
        private QuanLyRapPhimDataSet1TableAdapters.NhanVienTableAdapter nhanVienTableAdapter2;
        private System.Windows.Forms.ComboBox cbMaNQL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmrSoGioLam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLuongThang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDoiPassword;
    }
}