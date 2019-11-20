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
            this.txtMaRap = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgv_SUATCHIEU = new System.Windows.Forms.DataGridView();
            this.quanLyRapPhimDataSet_SuatChieuPhim = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_SuatChieuPhim();
            this.suatChieuPhimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suatChieuPhimTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_SuatChieuPhimTableAdapters.SuatChieuPhimTableAdapter();
            this.maPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maRapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSCP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SUATCHIEU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_SuatChieuPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suatChieuPhimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Suất chiếu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã rạp :";
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(316, 48);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(204, 30);
            this.txtMaPhim.TabIndex = 1;
            // 
            // txtSuatChieu
            // 
            this.txtSuatChieu.Location = new System.Drawing.Point(316, 102);
            this.txtSuatChieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuatChieu.Name = "txtSuatChieu";
            this.txtSuatChieu.Size = new System.Drawing.Size(204, 30);
            this.txtSuatChieu.TabIndex = 1;
            // 
            // txtMaRap
            // 
            this.txtMaRap.Location = new System.Drawing.Point(316, 155);
            this.txtMaRap.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaRap.Name = "txtMaRap";
            this.txtMaRap.Size = new System.Drawing.Size(204, 30);
            this.txtMaRap.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(698, 48);
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
            this.btnEdit.Location = new System.Drawing.Point(698, 100);
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
            this.btnDel.Location = new System.Drawing.Point(698, 148);
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
            this.btnSave.Location = new System.Drawing.Point(698, 198);
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
            this.btnCancel.Location = new System.Drawing.Point(698, 248);
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
            this.dgv_SUATCHIEU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SUATCHIEU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhimDataGridViewTextBoxColumn,
            this.gioChieuDataGridViewTextBoxColumn,
            this.maRapDataGridViewTextBoxColumn,
            this.maSCDataGridViewTextBoxColumn});
            this.dgv_SUATCHIEU.DataSource = this.suatChieuPhimBindingSource;
            this.dgv_SUATCHIEU.Location = new System.Drawing.Point(58, 338);
            this.dgv_SUATCHIEU.Name = "dgv_SUATCHIEU";
            this.dgv_SUATCHIEU.RowHeadersWidth = 51;
            this.dgv_SUATCHIEU.RowTemplate.Height = 24;
            this.dgv_SUATCHIEU.Size = new System.Drawing.Size(640, 150);
            this.dgv_SUATCHIEU.TabIndex = 4;
            this.dgv_SUATCHIEU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SUATCHIEU_CellClick);
            // 
            // quanLyRapPhimDataSet_SuatChieuPhim
            // 
            this.quanLyRapPhimDataSet_SuatChieuPhim.DataSetName = "QuanLyRapPhimDataSet_SuatChieuPhim";
            this.quanLyRapPhimDataSet_SuatChieuPhim.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suatChieuPhimBindingSource
            // 
            this.suatChieuPhimBindingSource.DataMember = "SuatChieuPhim";
            this.suatChieuPhimBindingSource.DataSource = this.quanLyRapPhimDataSet_SuatChieuPhim;
            // 
            // suatChieuPhimTableAdapter
            // 
            this.suatChieuPhimTableAdapter.ClearBeforeFill = true;
            // 
            // maPhimDataGridViewTextBoxColumn
            // 
            this.maPhimDataGridViewTextBoxColumn.DataPropertyName = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.HeaderText = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhimDataGridViewTextBoxColumn.Name = "maPhimDataGridViewTextBoxColumn";
            this.maPhimDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioChieuDataGridViewTextBoxColumn
            // 
            this.gioChieuDataGridViewTextBoxColumn.DataPropertyName = "GioChieu";
            this.gioChieuDataGridViewTextBoxColumn.HeaderText = "GioChieu";
            this.gioChieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioChieuDataGridViewTextBoxColumn.Name = "gioChieuDataGridViewTextBoxColumn";
            this.gioChieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // maRapDataGridViewTextBoxColumn
            // 
            this.maRapDataGridViewTextBoxColumn.DataPropertyName = "MaRap";
            this.maRapDataGridViewTextBoxColumn.HeaderText = "MaRap";
            this.maRapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maRapDataGridViewTextBoxColumn.Name = "maRapDataGridViewTextBoxColumn";
            this.maRapDataGridViewTextBoxColumn.Width = 125;
            // 
            // maSCDataGridViewTextBoxColumn
            // 
            this.maSCDataGridViewTextBoxColumn.DataPropertyName = "MaSC";
            this.maSCDataGridViewTextBoxColumn.HeaderText = "MaSC";
            this.maSCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSCDataGridViewTextBoxColumn.Name = "maSCDataGridViewTextBoxColumn";
            this.maSCDataGridViewTextBoxColumn.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Suất Chiếu Phim:";
            // 
            // txtMaSCP
            // 
            this.txtMaSCP.Location = new System.Drawing.Point(316, 201);
            this.txtMaSCP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSCP.Name = "txtMaSCP";
            this.txtMaSCP.Size = new System.Drawing.Size(204, 30);
            this.txtMaSCP.TabIndex = 6;
            // 
            // QuanLySuatChieuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMaSCP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_SUATCHIEU);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMaRap);
            this.Controls.Add(this.txtSuatChieu);
            this.Controls.Add(this.txtMaPhim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLySuatChieuUC";
            this.Size = new System.Drawing.Size(896, 1200);
            this.Load += new System.EventHandler(this.QuanLySuatChieuUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SUATCHIEU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_SuatChieuPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suatChieuPhimBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.TextBox txtSuatChieu;
        private System.Windows.Forms.TextBox txtMaRap;
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
    }
}
