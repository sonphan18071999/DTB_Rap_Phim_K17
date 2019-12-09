namespace QuanLyRapPhim_Final.User_Controls
{
    partial class QuanLySuatChieuUC
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
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.txtSuatChieu = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgv_SUATCHIEU = new System.Windows.Forms.DataGridView();
            this.maPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maRapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suatChieuPhimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyRapPhimDataSet_SuatChieuPhim = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_SuatChieuPhim();
            this.suatChieuPhimTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_SuatChieuPhimTableAdapters.SuatChieuPhimTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSCP = new System.Windows.Forms.TextBox();
            this.cbTenPhim = new System.Windows.Forms.ComboBox();
            this.cbTenRap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SUATCHIEU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suatChieuPhimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_SuatChieuPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Suất chiếu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã rạp :";
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(374, 85);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(115, 30);
            this.txtMaPhim.TabIndex = 1;
            // 
            // txtSuatChieu
            // 
            this.txtSuatChieu.Location = new System.Drawing.Point(374, 159);
            this.txtSuatChieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuatChieu.Name = "txtSuatChieu";
            this.txtSuatChieu.Size = new System.Drawing.Size(434, 30);
            this.txtSuatChieu.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(825, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Location = new System.Drawing.Point(825, 157);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 33);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.AutoSize = true;
            this.btnDel.Location = new System.Drawing.Point(825, 234);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 33);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(931, 88);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(931, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgv_SUATCHIEU
            // 
            this.dgv_SUATCHIEU.AutoGenerateColumns = false;
            this.dgv_SUATCHIEU.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SUATCHIEU.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_SUATCHIEU.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SUATCHIEU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SUATCHIEU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhimDataGridViewTextBoxColumn,
            this.gioChieuDataGridViewTextBoxColumn,
            this.maRapDataGridViewTextBoxColumn,
            this.maSCDataGridViewTextBoxColumn});
            this.dgv_SUATCHIEU.DataSource = this.suatChieuPhimBindingSource;
            this.dgv_SUATCHIEU.Location = new System.Drawing.Point(188, 389);
            this.dgv_SUATCHIEU.Name = "dgv_SUATCHIEU";
            this.dgv_SUATCHIEU.RowHeadersWidth = 51;
            this.dgv_SUATCHIEU.RowTemplate.Height = 24;
            this.dgv_SUATCHIEU.Size = new System.Drawing.Size(818, 207);
            this.dgv_SUATCHIEU.TabIndex = 4;
            this.dgv_SUATCHIEU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SUATCHIEU_CellClick);
            // 
            // maPhimDataGridViewTextBoxColumn
            // 
            this.maPhimDataGridViewTextBoxColumn.DataPropertyName = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.HeaderText = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhimDataGridViewTextBoxColumn.Name = "maPhimDataGridViewTextBoxColumn";
            // 
            // gioChieuDataGridViewTextBoxColumn
            // 
            this.gioChieuDataGridViewTextBoxColumn.DataPropertyName = "GioChieu";
            this.gioChieuDataGridViewTextBoxColumn.HeaderText = "GioChieu";
            this.gioChieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioChieuDataGridViewTextBoxColumn.Name = "gioChieuDataGridViewTextBoxColumn";
            // 
            // maRapDataGridViewTextBoxColumn
            // 
            this.maRapDataGridViewTextBoxColumn.DataPropertyName = "MaRap";
            this.maRapDataGridViewTextBoxColumn.HeaderText = "MaRap";
            this.maRapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maRapDataGridViewTextBoxColumn.Name = "maRapDataGridViewTextBoxColumn";
            // 
            // maSCDataGridViewTextBoxColumn
            // 
            this.maSCDataGridViewTextBoxColumn.DataPropertyName = "MaSC";
            this.maSCDataGridViewTextBoxColumn.HeaderText = "MaSC";
            this.maSCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSCDataGridViewTextBoxColumn.Name = "maSCDataGridViewTextBoxColumn";
            // 
            // suatChieuPhimBindingSource
            // 
            this.suatChieuPhimBindingSource.DataMember = "SuatChieuPhim";
            this.suatChieuPhimBindingSource.DataSource = this.quanLyRapPhimDataSet_SuatChieuPhim;
            // 
            // quanLyRapPhimDataSet_SuatChieuPhim
            // 
            this.quanLyRapPhimDataSet_SuatChieuPhim.DataSetName = "QuanLyRapPhimDataSet_SuatChieuPhim";
            this.quanLyRapPhimDataSet_SuatChieuPhim.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suatChieuPhimTableAdapter
            // 
            this.suatChieuPhimTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Suất Chiếu Phim:";
            // 
            // txtMaSCP
            // 
            this.txtMaSCP.Location = new System.Drawing.Point(374, 315);
            this.txtMaSCP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSCP.Name = "txtMaSCP";
            this.txtMaSCP.Size = new System.Drawing.Size(440, 30);
            this.txtMaSCP.TabIndex = 6;
            // 
            // cbTenPhim
            // 
            this.cbTenPhim.FormattingEnabled = true;
            this.cbTenPhim.Location = new System.Drawing.Point(598, 88);
            this.cbTenPhim.Name = "cbTenPhim";
            this.cbTenPhim.Size = new System.Drawing.Size(210, 31);
            this.cbTenPhim.TabIndex = 7;
            this.cbTenPhim.SelectedIndexChanged += new System.EventHandler(this.cbTenPhim_SelectedIndexChanged);
            // 
            // cbTenRap
            // 
            this.cbTenRap.FormattingEnabled = true;
            this.cbTenRap.Location = new System.Drawing.Point(374, 236);
            this.cbTenRap.Name = "cbTenRap";
            this.cbTenRap.Size = new System.Drawing.Size(434, 31);
            this.cbTenRap.TabIndex = 8;
            this.cbTenRap.SelectedIndexChanged += new System.EventHandler(this.cbTenRap_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên Phim:";
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.Location = new System.Drawing.Point(927, 236);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(79, 33);
            this.btnReload.TabIndex = 10;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // QuanLySuatChieuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTenRap);
            this.Controls.Add(this.cbTenPhim);
            this.Controls.Add(this.txtMaSCP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_SUATCHIEU);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSuatChieu);
            this.Controls.Add(this.txtMaPhim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLySuatChieuUC";
            this.Size = new System.Drawing.Size(1625, 886);
            this.Load += new System.EventHandler(this.QuanLySuatChieuUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SUATCHIEU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suatChieuPhimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_SuatChieuPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.TextBox txtSuatChieu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgv_SUATCHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioChieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maRapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource suatChieuPhimBindingSource;
        private QuanLyRapPhimDataSet_SuatChieuPhim quanLyRapPhimDataSet_SuatChieuPhim;
        private QuanLyRapPhimDataSet_SuatChieuPhimTableAdapters.SuatChieuPhimTableAdapter suatChieuPhimTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSCP;
        private System.Windows.Forms.ComboBox cbTenPhim;
        private System.Windows.Forms.ComboBox cbTenRap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReload;
    }
}
