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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtGiaTriHD = new System.Windows.Forms.TextBox();
            this.diaChilbl = new System.Windows.Forms.Label();
            this.txtTenDaoDien = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.hangSanXuatlbl = new System.Windows.Forms.Label();
            this.phimHopDongTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_HopDongPhimTableAdapters.PhimHopDongTableAdapter();
            this.btnSua = new System.Windows.Forms.Button();
            this.dtpNgayXuatBan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKiHD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbMaPhim = new System.Windows.Forms.ComboBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimHopDongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_HopDongPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HopDong
            // 
            this.dgv_HopDong.AutoGenerateColumns = false;
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
            this.dgv_HopDong.Location = new System.Drawing.Point(100, 334);
            this.dgv_HopDong.Name = "dgv_HopDong";
            this.dgv_HopDong.RowHeadersWidth = 51;
            this.dgv_HopDong.RowTemplate.Height = 24;
            this.dgv_HopDong.Size = new System.Drawing.Size(929, 253);
            this.dgv_HopDong.TabIndex = 0;
            this.dgv_HopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HopDong_CellClick);
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // daoDienDataGridViewTextBoxColumn
            // 
            this.daoDienDataGridViewTextBoxColumn.DataPropertyName = "DaoDien";
            this.daoDienDataGridViewTextBoxColumn.HeaderText = "DaoDien";
            this.daoDienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daoDienDataGridViewTextBoxColumn.Name = "daoDienDataGridViewTextBoxColumn";
            this.daoDienDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaTriHDDataGridViewTextBoxColumn
            // 
            this.giaTriHDDataGridViewTextBoxColumn.DataPropertyName = "GiaTriHD";
            this.giaTriHDDataGridViewTextBoxColumn.HeaderText = "GiaTriHD";
            this.giaTriHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaTriHDDataGridViewTextBoxColumn.Name = "giaTriHDDataGridViewTextBoxColumn";
            this.giaTriHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayXuatBanDataGridViewTextBoxColumn
            // 
            this.ngayXuatBanDataGridViewTextBoxColumn.DataPropertyName = "NgayXuatBan";
            this.ngayXuatBanDataGridViewTextBoxColumn.HeaderText = "NgayXuatBan";
            this.ngayXuatBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayXuatBanDataGridViewTextBoxColumn.Name = "ngayXuatBanDataGridViewTextBoxColumn";
            this.ngayXuatBanDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayKyHopDongDataGridViewTextBoxColumn
            // 
            this.ngayKyHopDongDataGridViewTextBoxColumn.DataPropertyName = "NgayKyHopDong";
            this.ngayKyHopDongDataGridViewTextBoxColumn.HeaderText = "NgayKyHopDong";
            this.ngayKyHopDongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayKyHopDongDataGridViewTextBoxColumn.Name = "ngayKyHopDongDataGridViewTextBoxColumn";
            this.ngayKyHopDongDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.Width = 125;
            // 
            // maPhimDataGridViewTextBoxColumn
            // 
            this.maPhimDataGridViewTextBoxColumn.DataPropertyName = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.HeaderText = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhimDataGridViewTextBoxColumn.Name = "maPhimDataGridViewTextBoxColumn";
            this.maPhimDataGridViewTextBoxColumn.Width = 125;
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
            this.maHDlbl.Location = new System.Drawing.Point(97, 142);
            this.maHDlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.maHDlbl.Name = "maHDlbl";
            this.maHDlbl.Size = new System.Drawing.Size(107, 17);
            this.maHDlbl.TabIndex = 36;
            this.maHDlbl.Text = "Ngày xuất bản :";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QuanLyRapPhim_Final.Properties.Resources.plus;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(652, 41);
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
            this.btnHuy.Location = new System.Drawing.Point(764, 109);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 50);
            this.btnHuy.TabIndex = 34;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.Image = global::QuanLyRapPhim_Final.Properties.Resources.save1;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(764, 41);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 52);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtGiaTriHD
            // 
            this.txtGiaTriHD.Location = new System.Drawing.Point(296, 106);
            this.txtGiaTriHD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGiaTriHD.Name = "txtGiaTriHD";
            this.txtGiaTriHD.Size = new System.Drawing.Size(351, 22);
            this.txtGiaTriHD.TabIndex = 32;
            // 
            // diaChilbl
            // 
            this.diaChilbl.AutoSize = true;
            this.diaChilbl.Location = new System.Drawing.Point(98, 109);
            this.diaChilbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.diaChilbl.Name = "diaChilbl";
            this.diaChilbl.Size = new System.Drawing.Size(114, 17);
            this.diaChilbl.TabIndex = 31;
            this.diaChilbl.Text = "Giá trị hợp đồng:";
            // 
            // txtTenDaoDien
            // 
            this.txtTenDaoDien.Location = new System.Drawing.Point(296, 78);
            this.txtTenDaoDien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenDaoDien.Name = "txtTenDaoDien";
            this.txtTenDaoDien.Size = new System.Drawing.Size(351, 22);
            this.txtTenDaoDien.TabIndex = 30;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(98, 81);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(96, 17);
            this.emaillbl.TabIndex = 29;
            this.emaillbl.Text = "Tên đạo diễn:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(296, 50);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(351, 22);
            this.txtMaHD.TabIndex = 28;
            // 
            // hangSanXuatlbl
            // 
            this.hangSanXuatlbl.AutoSize = true;
            this.hangSanXuatlbl.Location = new System.Drawing.Point(98, 50);
            this.hangSanXuatlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hangSanXuatlbl.Name = "hangSanXuatlbl";
            this.hangSanXuatlbl.Size = new System.Drawing.Size(99, 17);
            this.hangSanXuatlbl.TabIndex = 27;
            this.hangSanXuatlbl.Text = "Mã Hợp Đồng:";
            // 
            // phimHopDongTableAdapter
            // 
            this.phimHopDongTableAdapter.ClearBeforeFill = true;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyRapPhim_Final.Properties.Resources.tools;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(652, 109);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 50);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtpNgayXuatBan
            // 
            this.dtpNgayXuatBan.Location = new System.Drawing.Point(295, 137);
            this.dtpNgayXuatBan.Name = "dtpNgayXuatBan";
            this.dtpNgayXuatBan.Size = new System.Drawing.Size(351, 22);
            this.dtpNgayXuatBan.TabIndex = 39;
            // 
            // dtpNgayKiHD
            // 
            this.dtpNgayKiHD.Location = new System.Drawing.Point(295, 174);
            this.dtpNgayKiHD.Name = "dtpNgayKiHD";
            this.dtpNgayKiHD.Size = new System.Drawing.Size(351, 22);
            this.dtpNgayKiHD.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ngày kí hợp đồng :";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Location = new System.Drawing.Point(295, 212);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(351, 22);
            this.dtpNgayHetHan.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ngày hết hạn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Mã Phim:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(652, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 50);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbMaPhim
            // 
            this.cbMaPhim.FormattingEnabled = true;
            this.cbMaPhim.Location = new System.Drawing.Point(295, 250);
            this.cbMaPhim.Name = "cbMaPhim";
            this.cbMaPhim.Size = new System.Drawing.Size(351, 24);
            this.cbMaPhim.TabIndex = 47;
            this.cbMaPhim.SelectedIndexChanged += new System.EventHandler(this.cbMaPhim_SelectedIndexChanged);
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Enabled = false;
            this.txtTenPhim.Location = new System.Drawing.Point(295, 289);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(351, 22);
            this.txtTenPhim.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tên Phim:";
            // 
            // HopDongUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Size = new System.Drawing.Size(1146, 620);
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
    }
}
