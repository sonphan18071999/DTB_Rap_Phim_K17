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
            this.dgv_HangSanXuat = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHSX = new System.Windows.Forms.TextBox();
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangSanXuat)).BeginInit();
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(783, 14);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 55);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtDiaChiHSX
            // 
            this.txtDiaChiHSX.Location = new System.Drawing.Point(208, 157);
            this.txtDiaChiHSX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiaChiHSX.Name = "txtDiaChiHSX";
            this.txtDiaChiHSX.Size = new System.Drawing.Size(351, 22);
            this.txtDiaChiHSX.TabIndex = 21;
            // 
            // diaChilbl
            // 
            this.diaChilbl.AutoSize = true;
            this.diaChilbl.Location = new System.Drawing.Point(10, 160);
            this.diaChilbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.diaChilbl.Name = "diaChilbl";
            this.diaChilbl.Size = new System.Drawing.Size(59, 17);
            this.diaChilbl.TabIndex = 20;
            this.diaChilbl.Text = "Địa chỉ :";
            // 
            // txtEmailHSX
            // 
            this.txtEmailHSX.Location = new System.Drawing.Point(208, 113);
            this.txtEmailHSX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmailHSX.Name = "txtEmailHSX";
            this.txtEmailHSX.Size = new System.Drawing.Size(351, 22);
            this.txtEmailHSX.TabIndex = 19;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(10, 116);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(46, 17);
            this.emaillbl.TabIndex = 18;
            this.emaillbl.Text = "Email:";
            // 
            // txtTenHSX
            // 
            this.txtTenHSX.Location = new System.Drawing.Point(208, 68);
            this.txtTenHSX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenHSX.Name = "txtTenHSX";
            this.txtTenHSX.Size = new System.Drawing.Size(351, 22);
            this.txtTenHSX.TabIndex = 17;
            // 
            // hangSanXuatlbl
            // 
            this.hangSanXuatlbl.AutoSize = true;
            this.hangSanXuatlbl.Location = new System.Drawing.Point(10, 68);
            this.hangSanXuatlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hangSanXuatlbl.Name = "hangSanXuatlbl";
            this.hangSanXuatlbl.Size = new System.Drawing.Size(130, 17);
            this.hangSanXuatlbl.TabIndex = 16;
            this.hangSanXuatlbl.Text = "Tên hãng sản xuất:";
            // 
            // maHDlbl
            // 
            this.maHDlbl.AutoSize = true;
            this.maHDlbl.Location = new System.Drawing.Point(10, 195);
            this.maHDlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.maHDlbl.Name = "maHDlbl";
            this.maHDlbl.Size = new System.Drawing.Size(99, 17);
            this.maHDlbl.TabIndex = 25;
            this.maHDlbl.Text = "Mã hợp đồng :";
            // 
            // dgv_HangSanXuat
            // 
            this.dgv_HangSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HangSanXuat.Location = new System.Drawing.Point(13, 241);
            this.dgv_HangSanXuat.Name = "dgv_HangSanXuat";
            this.dgv_HangSanXuat.RowHeadersWidth = 51;
            this.dgv_HangSanXuat.RowTemplate.Height = 24;
            this.dgv_HangSanXuat.Size = new System.Drawing.Size(845, 160);
            this.dgv_HangSanXuat.TabIndex = 27;
            this.dgv_HangSanXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HangSanXuat_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(676, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 50);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyRapPhim_Final.Properties.Resources.tools;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(564, 73);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 50);
            this.btnSua.TabIndex = 47;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã HSX:";
            // 
            // txtMaHSX
            // 
            this.txtMaHSX.Location = new System.Drawing.Point(208, 30);
            this.txtMaHSX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaHSX.Name = "txtMaHSX";
            this.txtMaHSX.Size = new System.Drawing.Size(351, 22);
            this.txtMaHSX.TabIndex = 50;
            // 
            // cbMaHD
            // 
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(208, 192);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(351, 24);
            this.cbMaHD.TabIndex = 51;
            // 
            // QuanLyHangSanXuatUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMaHD);
            this.Controls.Add(this.txtMaHSX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgv_HangSanXuat);
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
            this.Load += new System.EventHandler(this.QuanLyHangSanXuatUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangSanXuat)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_HangSanXuat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHSX;
        private System.Windows.Forms.ComboBox cbMaHD;
    }
}
