﻿namespace QuanLyRapPhim_Final.User_Controls
{
    partial class ChiNhanhUC
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
            this.dgv_ChiNhanh = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbPhim = new System.Windows.Forms.CheckBox();
            this.ckbNgay = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPhim = new System.Windows.Forms.ComboBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenChiNhanh = new System.Windows.Forms.TextBox();
            this.txtMaChiNhanh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiNhanh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ChiNhanh
            // 
            this.dgv_ChiNhanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiNhanh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_ChiNhanh.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiNhanh.Location = new System.Drawing.Point(67, 355);
            this.dgv_ChiNhanh.Name = "dgv_ChiNhanh";
            this.dgv_ChiNhanh.RowHeadersWidth = 51;
            this.dgv_ChiNhanh.RowTemplate.Height = 24;
            this.dgv_ChiNhanh.Size = new System.Drawing.Size(1013, 279);
            this.dgv_ChiNhanh.TabIndex = 0;
            this.dgv_ChiNhanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiNhanh_CellClick);
            this.dgv_ChiNhanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiNhanh_CellContentClick);
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(976, 191);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(104, 39);
            this.btnReload.TabIndex = 16;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(856, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(976, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 39);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.AutoSize = true;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(856, 142);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(114, 39);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(976, 90);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 39);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(856, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 39);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbPhim);
            this.groupBox1.Controls.Add(this.ckbNgay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbPhim);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDoanhThu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenChiNhanh);
            this.groupBox1.Controls.Add(this.txtMaChiNhanh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 276);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin:";
            // 
            // ckbPhim
            // 
            this.ckbPhim.AutoSize = true;
            this.ckbPhim.Location = new System.Drawing.Point(624, 220);
            this.ckbPhim.Name = "ckbPhim";
            this.ckbPhim.Size = new System.Drawing.Size(132, 30);
            this.ckbPhim.TabIndex = 21;
            this.ckbPhim.Text = "Tính Phim";
            this.ckbPhim.UseVisualStyleBackColor = true;
            this.ckbPhim.CheckedChanged += new System.EventHandler(this.ckbPhim_CheckedChanged);
            // 
            // ckbNgay
            // 
            this.ckbNgay.AutoSize = true;
            this.ckbNgay.Location = new System.Drawing.Point(625, 180);
            this.ckbNgay.Name = "ckbNgay";
            this.ckbNgay.Size = new System.Drawing.Size(132, 30);
            this.ckbNgay.TabIndex = 20;
            this.ckbNgay.Text = "Tính Ngày";
            this.ckbNgay.UseVisualStyleBackColor = true;
            this.ckbNgay.CheckedChanged += new System.EventHandler(this.ckbNgay_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Phim:";
            // 
            // cbPhim
            // 
            this.cbPhim.FormattingEnabled = true;
            this.cbPhim.Location = new System.Drawing.Point(343, 217);
            this.cbPhim.Name = "cbPhim";
            this.cbPhim.Size = new System.Drawing.Size(275, 34);
            this.cbPhim.TabIndex = 18;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(343, 180);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(275, 32);
            this.dtpNgay.TabIndex = 7;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày:";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(343, 142);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(392, 32);
            this.txtDoanhThu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doanh Thu:";
            // 
            // txtTenChiNhanh
            // 
            this.txtTenChiNhanh.Location = new System.Drawing.Point(343, 94);
            this.txtTenChiNhanh.Name = "txtTenChiNhanh";
            this.txtTenChiNhanh.Size = new System.Drawing.Size(392, 32);
            this.txtTenChiNhanh.TabIndex = 3;
            // 
            // txtMaChiNhanh
            // 
            this.txtMaChiNhanh.Location = new System.Drawing.Point(343, 52);
            this.txtMaChiNhanh.Name = "txtMaChiNhanh";
            this.txtMaChiNhanh.Size = new System.Drawing.Size(392, 32);
            this.txtMaChiNhanh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Chi Nhánh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chi Nhánh:";
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(856, 244);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(224, 52);
            this.btnTinh.TabIndex = 21;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // ChiNhanhUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv_ChiNhanh);
            this.Name = "ChiNhanhUC";
            this.Size = new System.Drawing.Size(1124, 837);
            this.Load += new System.EventHandler(this.ChiNhanhUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiNhanh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ChiNhanh;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenChiNhanh;
        private System.Windows.Forms.TextBox txtMaChiNhanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPhim;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.CheckBox ckbPhim;
        private System.Windows.Forms.CheckBox ckbNgay;
    }
}
