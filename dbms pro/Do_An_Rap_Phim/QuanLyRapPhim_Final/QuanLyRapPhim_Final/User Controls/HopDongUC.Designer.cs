namespace QuanLyRapPhim_Final.User_Controls
{
    partial class HopDongUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_HopDong = new System.Windows.Forms.DataGridView();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daoDienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuatBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKyHopDongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phimHopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyRapPhimDataSet_HopDongPhim = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_HopDongPhim();
            this.maHDlbl = new System.Windows.Forms.Label();
            this.txtGiaTriHD = new System.Windows.Forms.TextBox();
            this.diaChilbl = new System.Windows.Forms.Label();
            this.txtTenDaoDien = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.hangSanXuatlbl = new System.Windows.Forms.Label();
            this.phimHopDongTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_HopDongPhimTableAdapters.PhimHopDongTableAdapter();
            this.dtpNgayXuatBan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKiHD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaPhim = new System.Windows.Forms.ComboBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimHopDongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_HopDongPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HopDong
            // 
            this.dgv_HopDong.AutoGenerateColumns = false;
            this.dgv_HopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HopDong.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.daoDienDataGridViewTextBoxColumn,
            this.giaTriHDDataGridViewTextBoxColumn,
            this.ngayXuatBanDataGridViewTextBoxColumn,
            this.ngayKyHopDongDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.maPhimDataGridViewTextBoxColumn});
            this.dgv_HopDong.DataSource = this.phimHopDongBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HopDong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_HopDong.Location = new System.Drawing.Point(113, 412);
            this.dgv_HopDong.Name = "dgv_HopDong";
            this.dgv_HopDong.RowHeadersWidth = 51;
            this.dgv_HopDong.RowTemplate.Height = 24;
            this.dgv_HopDong.Size = new System.Drawing.Size(1047, 413);
            this.dgv_HopDong.TabIndex = 0;
            this.dgv_HopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HopDong_CellClick);
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            // 
            // daoDienDataGridViewTextBoxColumn
            // 
            this.daoDienDataGridViewTextBoxColumn.DataPropertyName = "DaoDien";
            this.daoDienDataGridViewTextBoxColumn.HeaderText = "DaoDien";
            this.daoDienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daoDienDataGridViewTextBoxColumn.Name = "daoDienDataGridViewTextBoxColumn";
            // 
            // giaTriHDDataGridViewTextBoxColumn
            // 
            this.giaTriHDDataGridViewTextBoxColumn.DataPropertyName = "GiaTriHD";
            this.giaTriHDDataGridViewTextBoxColumn.HeaderText = "GiaTriHD";
            this.giaTriHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaTriHDDataGridViewTextBoxColumn.Name = "giaTriHDDataGridViewTextBoxColumn";
            // 
            // ngayXuatBanDataGridViewTextBoxColumn
            // 
            this.ngayXuatBanDataGridViewTextBoxColumn.DataPropertyName = "NgayXuatBan";
            this.ngayXuatBanDataGridViewTextBoxColumn.HeaderText = "NgayXuatBan";
            this.ngayXuatBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayXuatBanDataGridViewTextBoxColumn.Name = "ngayXuatBanDataGridViewTextBoxColumn";
            // 
            // ngayKyHopDongDataGridViewTextBoxColumn
            // 
            this.ngayKyHopDongDataGridViewTextBoxColumn.DataPropertyName = "NgayKyHopDong";
            this.ngayKyHopDongDataGridViewTextBoxColumn.HeaderText = "NgayKyHopDong";
            this.ngayKyHopDongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayKyHopDongDataGridViewTextBoxColumn.Name = "ngayKyHopDongDataGridViewTextBoxColumn";
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            // 
            // maPhimDataGridViewTextBoxColumn
            // 
            this.maPhimDataGridViewTextBoxColumn.DataPropertyName = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.HeaderText = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhimDataGridViewTextBoxColumn.Name = "maPhimDataGridViewTextBoxColumn";
            // 
            // phimHopDongBindingSource
            // 
            this.phimHopDongBindingSource.DataMember = "PhimHopDong";
            this.phimHopDongBindingSource.DataSource = this.quanLyRapPhimDataSet_HopDongPhim;
            // 
            // quanLyRapPhimDataSet_HopDongPhim
            // 
            this.quanLyRapPhimDataSet_HopDongPhim.DataSetName = "QuanLyRapPhimDataSet_HopDongPhim";
            this.quanLyRapPhimDataSet_HopDongPhim.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maHDlbl
            // 
            this.maHDlbl.AutoSize = true;
            this.maHDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maHDlbl.Location = new System.Drawing.Point(214, 179);
            this.maHDlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.maHDlbl.Name = "maHDlbl";
            this.maHDlbl.Size = new System.Drawing.Size(176, 29);
            this.maHDlbl.TabIndex = 36;
            this.maHDlbl.Text = "Ngày xuất bản :";
            // 
            // txtGiaTriHD
            // 
            this.txtGiaTriHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTriHD.Location = new System.Drawing.Point(413, 132);
            this.txtGiaTriHD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGiaTriHD.Name = "txtGiaTriHD";
            this.txtGiaTriHD.Size = new System.Drawing.Size(351, 32);
            this.txtGiaTriHD.TabIndex = 32;
            this.txtGiaTriHD.TextChanged += new System.EventHandler(this.txtGiaTriHD_TextChanged);
            // 
            // diaChilbl
            // 
            this.diaChilbl.AutoSize = true;
            this.diaChilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChilbl.Location = new System.Drawing.Point(215, 135);
            this.diaChilbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.diaChilbl.Name = "diaChilbl";
            this.diaChilbl.Size = new System.Drawing.Size(190, 29);
            this.diaChilbl.TabIndex = 31;
            this.diaChilbl.Text = "Giá trị hợp đồng:";
            // 
            // txtTenDaoDien
            // 
            this.txtTenDaoDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDaoDien.Location = new System.Drawing.Point(413, 87);
            this.txtTenDaoDien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenDaoDien.Name = "txtTenDaoDien";
            this.txtTenDaoDien.Size = new System.Drawing.Size(351, 32);
            this.txtTenDaoDien.TabIndex = 30;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(215, 90);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(162, 29);
            this.emaillbl.TabIndex = 29;
            this.emaillbl.Text = "Tên đạo diễn:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(413, 49);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(351, 32);
            this.txtMaHD.TabIndex = 28;
            // 
            // hangSanXuatlbl
            // 
            this.hangSanXuatlbl.AutoSize = true;
            this.hangSanXuatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangSanXuatlbl.Location = new System.Drawing.Point(215, 49);
            this.hangSanXuatlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hangSanXuatlbl.Name = "hangSanXuatlbl";
            this.hangSanXuatlbl.Size = new System.Drawing.Size(167, 29);
            this.hangSanXuatlbl.TabIndex = 27;
            this.hangSanXuatlbl.Text = "Mã Hợp Đồng:";
            // 
            // phimHopDongTableAdapter
            // 
            this.phimHopDongTableAdapter.ClearBeforeFill = true;
            // 
            // dtpNgayXuatBan
            // 
            this.dtpNgayXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXuatBan.Location = new System.Drawing.Point(412, 174);
            this.dtpNgayXuatBan.Name = "dtpNgayXuatBan";
            this.dtpNgayXuatBan.Size = new System.Drawing.Size(351, 32);
            this.dtpNgayXuatBan.TabIndex = 39;
            // 
            // dtpNgayKiHD
            // 
            this.dtpNgayKiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKiHD.Location = new System.Drawing.Point(412, 211);
            this.dtpNgayKiHD.Name = "dtpNgayKiHD";
            this.dtpNgayKiHD.Size = new System.Drawing.Size(351, 32);
            this.dtpNgayKiHD.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ngày kí hợp đồng :";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHetHan.Location = new System.Drawing.Point(412, 249);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(351, 32);
            this.dtpNgayHetHan.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ngày hết hạn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "Mã Phim:";
            // 
            // cbMaPhim
            // 
            this.cbMaPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaPhim.FormattingEnabled = true;
            this.cbMaPhim.Location = new System.Drawing.Point(412, 289);
            this.cbMaPhim.Name = "cbMaPhim";
            this.cbMaPhim.Size = new System.Drawing.Size(351, 34);
            this.cbMaPhim.TabIndex = 47;
            this.cbMaPhim.SelectedIndexChanged += new System.EventHandler(this.cbMaPhim_SelectedIndexChanged);
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Enabled = false;
            this.txtTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.Location = new System.Drawing.Point(412, 330);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(351, 32);
            this.txtTenPhim.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tên Phim:";
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.Image = global::QuanLyRapPhim_Final.Properties.Resources.refresh2;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(911, 259);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(101, 50);
            this.btnReload.TabIndex = 50;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyRapPhim_Final.Properties.Resources.trash2;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(799, 259);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 50);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyRapPhim_Final.Properties.Resources.tools;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(800, 149);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 50);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QuanLyRapPhim_Final.Properties.Resources.plus;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(800, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 52);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyRapPhim_Final.Properties.Resources.delete9;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(912, 149);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 50);
            this.btnHuy.TabIndex = 34;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.Image = global::QuanLyRapPhim_Final.Properties.Resources.save1;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(912, 49);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 52);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // HopDongUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.cbMaPhim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayHetHan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgayKiHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayXuatBan);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.maHDlbl);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtGiaTriHD);
            this.Controls.Add(this.diaChilbl);
            this.Controls.Add(this.txtTenDaoDien);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.hangSanXuatlbl);
            this.Controls.Add(this.dgv_HopDong);
            this.Name = "HopDongUC";
            this.Size = new System.Drawing.Size(1625, 886);
            this.Load += new System.EventHandler(this.HopDongUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimHopDongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_HopDongPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HopDong;
        private System.Windows.Forms.BindingSource phimHopDongBindingSource;
        private QuanLyRapPhimDataSet_HopDongPhim quanLyRapPhimDataSet_HopDongPhim;
        private System.Windows.Forms.Label maHDlbl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtGiaTriHD;
        private System.Windows.Forms.Label diaChilbl;
        private System.Windows.Forms.TextBox txtTenDaoDien;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label hangSanXuatlbl;
        private QuanLyRapPhimDataSet_HopDongPhimTableAdapters.PhimHopDongTableAdapter phimHopDongTableAdapter;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DateTimePicker dtpNgayXuatBan;
        private System.Windows.Forms.DateTimePicker dtpNgayKiHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbMaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daoDienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuatBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKyHopDongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReload;
    }
}
