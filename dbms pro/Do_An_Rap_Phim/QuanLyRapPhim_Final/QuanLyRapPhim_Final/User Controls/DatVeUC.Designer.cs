namespace QuanLyRapPhim_Final.User_Controls
{
    partial class DatVeUC
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
            this.seatPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Phimcb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.raptxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuatChieucb = new System.Windows.Forms.ComboBox();
            this.nhanViencb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Daytxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ghetxt = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.maKHcb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.txtGioKetThuc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbGhiChu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.ckbKhuyeMai = new System.Windows.Forms.CheckBox();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnMoreSeat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // seatPanel
            // 
            this.seatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seatPanel.Location = new System.Drawing.Point(193, 349);
            this.seatPanel.Name = "seatPanel";
            this.seatPanel.Size = new System.Drawing.Size(1038, 549);
            this.seatPanel.TabIndex = 1;
            this.seatPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.seatPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rạp:";
            // 
            // Phimcb
            // 
            this.Phimcb.FormattingEnabled = true;
            this.Phimcb.Location = new System.Drawing.Point(288, 27);
            this.Phimcb.Name = "Phimcb";
            this.Phimcb.Size = new System.Drawing.Size(278, 31);
            this.Phimcb.TabIndex = 4;
            this.Phimcb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phim:";
            // 
            // raptxt
            // 
            this.raptxt.Location = new System.Drawing.Point(288, 78);
            this.raptxt.Name = "raptxt";
            this.raptxt.Size = new System.Drawing.Size(100, 30);
            this.raptxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Suất chiếu:";
            // 
            // SuatChieucb
            // 
            this.SuatChieucb.FormattingEnabled = true;
            this.SuatChieucb.Location = new System.Drawing.Point(288, 130);
            this.SuatChieucb.Name = "SuatChieucb";
            this.SuatChieucb.Size = new System.Drawing.Size(278, 31);
            this.SuatChieucb.TabIndex = 8;
            this.SuatChieucb.SelectedIndexChanged += new System.EventHandler(this.SuatChieucb_SelectedIndexChanged);
            // 
            // nhanViencb
            // 
            this.nhanViencb.FormattingEnabled = true;
            this.nhanViencb.Location = new System.Drawing.Point(689, 26);
            this.nhanViencb.Name = "nhanViencb";
            this.nhanViencb.Size = new System.Drawing.Size(207, 31);
            this.nhanViencb.TabIndex = 9;
            this.nhanViencb.SelectedIndexChanged += new System.EventHandler(this.nhanViencb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhân Viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dãy";
            // 
            // Daytxt
            // 
            this.Daytxt.Location = new System.Drawing.Point(689, 77);
            this.Daytxt.Name = "Daytxt";
            this.Daytxt.Size = new System.Drawing.Size(207, 30);
            this.Daytxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ghế";
            // 
            // ghetxt
            // 
            this.ghetxt.Location = new System.Drawing.Point(689, 129);
            this.ghetxt.Name = "ghetxt";
            this.ghetxt.Size = new System.Drawing.Size(207, 30);
            this.ghetxt.TabIndex = 15;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(996, 82);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 31);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Xuất vé";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(906, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 34);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(996, 26);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 34);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(906, 82);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(84, 31);
            this.btnReload.TabIndex = 19;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // maKHcb
            // 
            this.maKHcb.FormattingEnabled = true;
            this.maKHcb.Location = new System.Drawing.Point(478, 76);
            this.maKHcb.Name = "maKHcb";
            this.maKHcb.Size = new System.Drawing.Size(88, 31);
            this.maKHcb.TabIndex = 20;
            this.maKHcb.SelectedIndexChanged += new System.EventHandler(this.maKHcb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Mã KH:";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(288, 179);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(278, 30);
            this.dtpNgay.TabIndex = 22;
            this.dtpNgay.Value = new System.DateTime(2019, 11, 20, 21, 31, 56, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ngày:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mã Vé";
            // 
            // txtMaVe
            // 
            this.txtMaVe.Location = new System.Drawing.Point(689, 177);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(207, 30);
            this.txtMaVe.TabIndex = 25;
            // 
            // txtGioKetThuc
            // 
            this.txtGioKetThuc.Location = new System.Drawing.Point(288, 227);
            this.txtGioKetThuc.Name = "txtGioKetThuc";
            this.txtGioKetThuc.Size = new System.Drawing.Size(278, 30);
            this.txtGioKetThuc.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "Kết thúc:";
            // 
            // cbGhiChu
            // 
            this.cbGhiChu.FormattingEnabled = true;
            this.cbGhiChu.Location = new System.Drawing.Point(689, 225);
            this.cbGhiChu.Name = "cbGhiChu";
            this.cbGhiChu.Size = new System.Drawing.Size(207, 31);
            this.cbGhiChu.TabIndex = 28;
            this.cbGhiChu.SelectedIndexChanged += new System.EventHandler(this.cbGhiChu_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(580, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Loại Vé";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(191, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tổng tiền:";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(288, 273);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(218, 30);
            this.txtTien.TabIndex = 31;
            // 
            // ckbKhuyeMai
            // 
            this.ckbKhuyeMai.AutoSize = true;
            this.ckbKhuyeMai.Location = new System.Drawing.Point(584, 274);
            this.ckbKhuyeMai.Name = "ckbKhuyeMai";
            this.ckbKhuyeMai.Size = new System.Drawing.Size(131, 27);
            this.ckbKhuyeMai.TabIndex = 32;
            this.ckbKhuyeMai.Text = "Khuyến mãi";
            this.ckbKhuyeMai.UseVisualStyleBackColor = true;
            this.ckbKhuyeMai.CheckedChanged += new System.EventHandler(this.ckbKhuyeMai_CheckedChanged);
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Location = new System.Drawing.Point(723, 272);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(139, 30);
            this.txtKhuyenMai.TabIndex = 33;
            this.txtKhuyenMai.TextChanged += new System.EventHandler(this.txtKhuyenMai_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(868, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 23);
            this.label13.TabIndex = 34;
            this.label13.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(512, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 23);
            this.label14.TabIndex = 35;
            this.label14.Text = "Đồng";
            // 
            // btnMoreSeat
            // 
            this.btnMoreSeat.Location = new System.Drawing.Point(906, 124);
            this.btnMoreSeat.Name = "btnMoreSeat";
            this.btnMoreSeat.Size = new System.Drawing.Size(174, 39);
            this.btnMoreSeat.TabIndex = 36;
            this.btnMoreSeat.Text = "Đặt nhiều ghế";
            this.btnMoreSeat.UseVisualStyleBackColor = true;
            this.btnMoreSeat.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(902, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 34);
            this.button2.TabIndex = 37;
            this.button2.Text = "Load lại dữ liệu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(195, 801);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 366);
            this.panel1.TabIndex = 38;
            // 
            // DatVeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMoreSeat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtKhuyenMai);
            this.Controls.Add(this.ckbKhuyeMai);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbGhiChu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGioKetThuc);
            this.Controls.Add(this.txtMaVe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maKHcb);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.ghetxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Daytxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nhanViencb);
            this.Controls.Add(this.SuatChieucb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.raptxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Phimcb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seatPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatVeUC";
            this.Size = new System.Drawing.Size(1625, 886);
            this.Load += new System.EventHandler(this.DatVeUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel seatPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Phimcb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox raptxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SuatChieucb;
        private System.Windows.Forms.ComboBox nhanViencb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Daytxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ghetxt;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox maKHcb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.TextBox txtGioKetThuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbGhiChu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.CheckBox ckbKhuyeMai;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnMoreSeat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}