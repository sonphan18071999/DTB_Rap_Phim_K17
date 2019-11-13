namespace QuanLyRapPhim_Final.User_Controls
{
    partial class QuanLyHangSanXuatUC
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtDiaChiHSX = new System.Windows.Forms.TextBox();
            this.diaChilbl = new System.Windows.Forms.Label();
            this.txtEmailHSX = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.txtTenHSX = new System.Windows.Forms.TextBox();
            this.hangSanXuatlbl = new System.Windows.Forms.Label();
            this.maHDlbl = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dgv_HangSanXuat = new System.Windows.Forms.DataGridView();
            this.quanLyRapPhimDataSet_HANGSANXUAT = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_HANGSANXUAT();
            this.hangSanXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangSanXuatTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_HANGSANXUATTableAdapters.HangSanXuatTableAdapter();
            this.tenHSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangSanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_HANGSANXUAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangSanXuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QuanLyRapPhim_Final.Properties.Resources.plus;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(564, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 52);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(783, 14);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 55);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.Image = global::QuanLyRapPhim_Final.Properties.Resources.save1;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(676, 15);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 52);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtDiaChiHSX
            // 
            this.txtDiaChiHSX.Location = new System.Drawing.Point(208, 113);
            this.txtDiaChiHSX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiaChiHSX.Name = "txtDiaChiHSX";
            this.txtDiaChiHSX.Size = new System.Drawing.Size(351, 22);
            this.txtDiaChiHSX.TabIndex = 21;
            // 
            // diaChilbl
            // 
            this.diaChilbl.AutoSize = true;
            this.diaChilbl.Location = new System.Drawing.Point(10, 116);
            this.diaChilbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.diaChilbl.Name = "diaChilbl";
            this.diaChilbl.Size = new System.Drawing.Size(59, 17);
            this.diaChilbl.TabIndex = 20;
            this.diaChilbl.Text = "Địa chỉ :";
            // 
            // txtEmailHSX
            // 
            this.txtEmailHSX.Location = new System.Drawing.Point(208, 69);
            this.txtEmailHSX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmailHSX.Name = "txtEmailHSX";
            this.txtEmailHSX.Size = new System.Drawing.Size(351, 22);
            this.txtEmailHSX.TabIndex = 19;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(10, 72);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(46, 17);
            this.emaillbl.TabIndex = 18;
            this.emaillbl.Text = "Email:";
            // 
            // txtTenHSX
            // 
            this.txtTenHSX.Location = new System.Drawing.Point(208, 24);
            this.txtTenHSX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenHSX.Name = "txtTenHSX";
            this.txtTenHSX.Size = new System.Drawing.Size(351, 22);
            this.txtTenHSX.TabIndex = 17;
            // 
            // hangSanXuatlbl
            // 
            this.hangSanXuatlbl.AutoSize = true;
            this.hangSanXuatlbl.Location = new System.Drawing.Point(10, 24);
            this.hangSanXuatlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hangSanXuatlbl.Name = "hangSanXuatlbl";
            this.hangSanXuatlbl.Size = new System.Drawing.Size(130, 17);
            this.hangSanXuatlbl.TabIndex = 16;
            this.hangSanXuatlbl.Text = "Tên hãng sản xuất:";
            // 
            // maHDlbl
            // 
            this.maHDlbl.AutoSize = true;
            this.maHDlbl.Location = new System.Drawing.Point(10, 151);
            this.maHDlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.maHDlbl.Name = "maHDlbl";
            this.maHDlbl.Size = new System.Drawing.Size(99, 17);
            this.maHDlbl.TabIndex = 25;
            this.maHDlbl.Text = "Mã hợp đồng :";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(208, 151);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(351, 22);
            this.txtMaHD.TabIndex = 26;
            // 
            // dgv_HangSanXuat
            // 
            this.dgv_HangSanXuat.AutoGenerateColumns = false;
            this.dgv_HangSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HangSanXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenHSXDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.maHDDataGridViewTextBoxColumn});
            this.dgv_HangSanXuat.DataSource = this.hangSanXuatBindingSource;
            this.dgv_HangSanXuat.Location = new System.Drawing.Point(13, 232);
            this.dgv_HangSanXuat.Name = "dgv_HangSanXuat";
            this.dgv_HangSanXuat.RowHeadersWidth = 51;
            this.dgv_HangSanXuat.RowTemplate.Height = 24;
            this.dgv_HangSanXuat.Size = new System.Drawing.Size(845, 160);
            this.dgv_HangSanXuat.TabIndex = 27;
            // 
            // quanLyRapPhimDataSet_HANGSANXUAT
            // 
            this.quanLyRapPhimDataSet_HANGSANXUAT.DataSetName = "QuanLyRapPhimDataSet_HANGSANXUAT";
            this.quanLyRapPhimDataSet_HANGSANXUAT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangSanXuatBindingSource
            // 
            this.hangSanXuatBindingSource.DataMember = "HangSanXuat";
            this.hangSanXuatBindingSource.DataSource = this.quanLyRapPhimDataSet_HANGSANXUAT;
            // 
            // hangSanXuatTableAdapter
            // 
            this.hangSanXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tenHSXDataGridViewTextBoxColumn
            // 
            this.tenHSXDataGridViewTextBoxColumn.DataPropertyName = "TenHSX";
            this.tenHSXDataGridViewTextBoxColumn.HeaderText = "TenHSX";
            this.tenHSXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenHSXDataGridViewTextBoxColumn.Name = "tenHSXDataGridViewTextBoxColumn";
            this.tenHSXDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // QuanLyHangSanXuatUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_HangSanXuat);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.maHDlbl);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDiaChiHSX);
            this.Controls.Add(this.diaChilbl);
            this.Controls.Add(this.txtEmailHSX);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.txtTenHSX);
            this.Controls.Add(this.hangSanXuatlbl);
            this.Name = "QuanLyHangSanXuatUC";
            this.Size = new System.Drawing.Size(890, 1200);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangSanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_HANGSANXUAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangSanXuatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtDiaChiHSX;
        private System.Windows.Forms.Label diaChilbl;
        private System.Windows.Forms.TextBox txtEmailHSX;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox txtTenHSX;
        private System.Windows.Forms.Label hangSanXuatlbl;
        private System.Windows.Forms.Label maHDlbl;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridView dgv_HangSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hangSanXuatBindingSource;
        private QuanLyRapPhimDataSet_HANGSANXUAT quanLyRapPhimDataSet_HANGSANXUAT;
        private QuanLyRapPhimDataSet_HANGSANXUATTableAdapters.HangSanXuatTableAdapter hangSanXuatTableAdapter;
    }
}
