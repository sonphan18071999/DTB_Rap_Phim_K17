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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.txtGioKetThuc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1328, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(28, 20);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // seatPanel
            // 
            this.seatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seatPanel.Location = new System.Drawing.Point(12, 241);
            this.seatPanel.Name = "seatPanel";
            this.seatPanel.Size = new System.Drawing.Size(826, 549);
            this.seatPanel.TabIndex = 1;
            this.seatPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.seatPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rạp:";
            // 
            // Phimcb
            // 
            this.Phimcb.FormattingEnabled = true;
            this.Phimcb.Location = new System.Drawing.Point(105, 22);
            this.Phimcb.Name = "Phimcb";
            this.Phimcb.Size = new System.Drawing.Size(278, 31);
            this.Phimcb.TabIndex = 4;
            this.Phimcb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phim:";
            // 
            // raptxt
            // 
            this.raptxt.Location = new System.Drawing.Point(105, 57);
            this.raptxt.Name = "raptxt";
            this.raptxt.Size = new System.Drawing.Size(100, 30);
            this.raptxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Suất chiếu:";
            // 
            // SuatChieucb
            // 
            this.SuatChieucb.FormattingEnabled = true;
            this.SuatChieucb.Location = new System.Drawing.Point(105, 91);
            this.SuatChieucb.Name = "SuatChieucb";
            this.SuatChieucb.Size = new System.Drawing.Size(278, 31);
            this.SuatChieucb.TabIndex = 8;
            this.SuatChieucb.SelectedIndexChanged += new System.EventHandler(this.SuatChieucb_SelectedIndexChanged);
            // 
            // nhanViencb
            // 
            this.nhanViencb.FormattingEnabled = true;
            this.nhanViencb.Location = new System.Drawing.Point(579, 21);
            this.nhanViencb.Name = "nhanViencb";
            this.nhanViencb.Size = new System.Drawing.Size(136, 31);
            this.nhanViencb.TabIndex = 9;
            this.nhanViencb.SelectedIndexChanged += new System.EventHandler(this.nhanViencb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhân Viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dãy";
            // 
            // Daytxt
            // 
            this.Daytxt.Location = new System.Drawing.Point(579, 61);
            this.Daytxt.Name = "Daytxt";
            this.Daytxt.Size = new System.Drawing.Size(136, 30);
            this.Daytxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ghế";
            // 
            // ghetxt
            // 
            this.ghetxt.Location = new System.Drawing.Point(579, 98);
            this.ghetxt.Name = "ghetxt";
            this.ghetxt.Size = new System.Drawing.Size(136, 30);
            this.ghetxt.TabIndex = 15;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(754, 148);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 45);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Xuất vé";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(754, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 28);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(754, 101);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 28);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(754, 64);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(84, 28);
            this.btnReload.TabIndex = 19;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // maKHcb
            // 
            this.maKHcb.FormattingEnabled = true;
            this.maKHcb.Location = new System.Drawing.Point(295, 55);
            this.maKHcb.Name = "maKHcb";
            this.maKHcb.Size = new System.Drawing.Size(88, 31);
            this.maKHcb.TabIndex = 20;
            this.maKHcb.SelectedIndexChanged += new System.EventHandler(this.maKHcb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Mã KH:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 30);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2019, 11, 20, 21, 31, 56, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ngày:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mã Vé";
            // 
            // txtMaVe
            // 
            this.txtMaVe.Location = new System.Drawing.Point(579, 135);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(136, 30);
            this.txtMaVe.TabIndex = 25;
            // 
            // txtGioKetThuc
            // 
            this.txtGioKetThuc.Location = new System.Drawing.Point(105, 164);
            this.txtGioKetThuc.Name = "txtGioKetThuc";
            this.txtGioKetThuc.Size = new System.Drawing.Size(278, 30);
            this.txtGioKetThuc.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "Kết thúc:";
            // 
            // DatVeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGioKetThuc);
            this.Controls.Add(this.txtMaVe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.seatPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatVeUC";
            this.Size = new System.Drawing.Size(1113, 1200);
            this.Load += new System.EventHandler(this.DatVeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.TextBox txtGioKetThuc;
        private System.Windows.Forms.Label label10;
    }
}