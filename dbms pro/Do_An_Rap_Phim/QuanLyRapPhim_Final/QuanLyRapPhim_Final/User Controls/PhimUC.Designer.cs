namespace QuanLyRapPhim_Final.User_Controls
{
    partial class PhimUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhimUC));
            this.dgv_PHIM = new System.Windows.Forms.DataGridView();
            this.tenPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaVeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posterDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.thoiLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyRapPhimDataSet_Phim = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_Phim();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTLP = new System.Windows.Forms.Label();
            this.txtTLP = new System.Windows.Forms.TextBox();
            this.phimTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_PhimTableAdapters.PhimTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnPhim = new System.Windows.Forms.Panel();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDelFilm = new System.Windows.Forms.Button();
            this.btnEditFilm = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PHIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_Phim)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PHIM
            // 
            this.dgv_PHIM.AllowUserToAddRows = false;
            this.dgv_PHIM.AllowUserToResizeColumns = false;
            this.dgv_PHIM.AllowUserToResizeRows = false;
            this.dgv_PHIM.AutoGenerateColumns = false;
            this.dgv_PHIM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PHIM.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_PHIM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_PHIM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PHIM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenPhimDataGridViewTextBoxColumn,
            this.maPhimDataGridViewTextBoxColumn,
            this.giaVeDataGridViewTextBoxColumn,
            this.posterDataGridViewImageColumn,
            this.thoiLuongDataGridViewTextBoxColumn});
            this.dgv_PHIM.DataSource = this.phimBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PHIM.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PHIM.Location = new System.Drawing.Point(186, 425);
            this.dgv_PHIM.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_PHIM.Name = "dgv_PHIM";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PHIM.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PHIM.RowHeadersWidth = 40;
            this.dgv_PHIM.RowTemplate.Height = 90;
            this.dgv_PHIM.Size = new System.Drawing.Size(1187, 384);
            this.dgv_PHIM.TabIndex = 4;
            this.dgv_PHIM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PHIM_CellClick);
            // 
            // tenPhimDataGridViewTextBoxColumn
            // 
            this.tenPhimDataGridViewTextBoxColumn.DataPropertyName = "TenPhim";
            this.tenPhimDataGridViewTextBoxColumn.HeaderText = "TenPhim";
            this.tenPhimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenPhimDataGridViewTextBoxColumn.Name = "tenPhimDataGridViewTextBoxColumn";
            // 
            // maPhimDataGridViewTextBoxColumn
            // 
            this.maPhimDataGridViewTextBoxColumn.DataPropertyName = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.HeaderText = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhimDataGridViewTextBoxColumn.Name = "maPhimDataGridViewTextBoxColumn";
            // 
            // giaVeDataGridViewTextBoxColumn
            // 
            this.giaVeDataGridViewTextBoxColumn.DataPropertyName = "GiaVe";
            this.giaVeDataGridViewTextBoxColumn.HeaderText = "GiaVe";
            this.giaVeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaVeDataGridViewTextBoxColumn.Name = "giaVeDataGridViewTextBoxColumn";
            // 
            // posterDataGridViewImageColumn
            // 
            this.posterDataGridViewImageColumn.DataPropertyName = "Poster";
            this.posterDataGridViewImageColumn.HeaderText = "Poster";
            this.posterDataGridViewImageColumn.MinimumWidth = 6;
            this.posterDataGridViewImageColumn.Name = "posterDataGridViewImageColumn";
            // 
            // thoiLuongDataGridViewTextBoxColumn
            // 
            this.thoiLuongDataGridViewTextBoxColumn.DataPropertyName = "ThoiLuong";
            this.thoiLuongDataGridViewTextBoxColumn.HeaderText = "ThoiLuong";
            this.thoiLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiLuongDataGridViewTextBoxColumn.Name = "thoiLuongDataGridViewTextBoxColumn";
            // 
            // phimBindingSource
            // 
            this.phimBindingSource.DataMember = "Phim";
            this.phimBindingSource.DataSource = this.quanLyRapPhimDataSet_Phim;
            // 
            // quanLyRapPhimDataSet_Phim
            // 
            this.quanLyRapPhimDataSet_Phim.DataSetName = "QuanLyRapPhimDataSet_Phim";
            this.quanLyRapPhimDataSet_Phim.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(522, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên phim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(522, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã phim :";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.Location = new System.Drawing.Point(682, 92);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(434, 32);
            this.txtTenPhim.TabIndex = 7;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhim.Location = new System.Drawing.Point(682, 154);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(434, 32);
            this.txtMaPhim.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(522, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giá vé :";
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaVe.Location = new System.Drawing.Point(682, 211);
            this.txtGiaVe.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(434, 32);
            this.txtGiaVe.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(220, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Poster ";
            // 
            // lblTLP
            // 
            this.lblTLP.AutoSize = true;
            this.lblTLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTLP.ForeColor = System.Drawing.Color.Black;
            this.lblTLP.Location = new System.Drawing.Point(520, 283);
            this.lblTLP.Name = "lblTLP";
            this.lblTLP.Size = new System.Drawing.Size(118, 26);
            this.lblTLP.TabIndex = 20;
            this.lblTLP.Text = "Thời lượng:";
            // 
            // txtTLP
            // 
            this.txtTLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTLP.Location = new System.Drawing.Point(682, 283);
            this.txtTLP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTLP.Name = "txtTLP";
            this.txtTLP.Size = new System.Drawing.Size(434, 32);
            this.txtTLP.TabIndex = 11;
            // 
            // phimTableAdapter
            // 
            this.phimTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1625, 38);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // phimToolStripMenuItem
            // 
            this.phimToolStripMenuItem.BackColor = System.Drawing.Color.Crimson;
            this.phimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtVéToolStripMenuItem,
            this.thêmPhimToolStripMenuItem});
            this.phimToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phimToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.phimToolStripMenuItem.Name = "phimToolStripMenuItem";
            this.phimToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.phimToolStripMenuItem.Text = "Phim";
            this.phimToolStripMenuItem.Click += new System.EventHandler(this.phimToolStripMenuItem_Click);
            // 
            // đặtVéToolStripMenuItem
            // 
            this.đặtVéToolStripMenuItem.Name = "đặtVéToolStripMenuItem";
            this.đặtVéToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.đặtVéToolStripMenuItem.Text = "Phim đang chiếu";
            this.đặtVéToolStripMenuItem.Click += new System.EventHandler(this.đặtVéToolStripMenuItem_Click);
            // 
            // thêmPhimToolStripMenuItem
            // 
            this.thêmPhimToolStripMenuItem.Name = "thêmPhimToolStripMenuItem";
            this.thêmPhimToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.thêmPhimToolStripMenuItem.Text = "Thêm Phim";
            this.thêmPhimToolStripMenuItem.Click += new System.EventHandler(this.thêmPhimToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tìm Phim(theo tên):";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(641, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(267, 22);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnPhim
            // 
            this.pnPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnPhim.Controls.Add(this.txtNoiDung);
            this.pnPhim.Controls.Add(this.txtTLP);
            this.pnPhim.Controls.Add(this.label7);
            this.pnPhim.Controls.Add(this.lblTLP);
            this.pnPhim.Controls.Add(this.btnBrowse);
            this.pnPhim.Controls.Add(this.btnCancel);
            this.pnPhim.Controls.Add(this.btnAdd);
            this.pnPhim.Controls.Add(this.btnReload);
            this.pnPhim.Controls.Add(this.btnDelFilm);
            this.pnPhim.Controls.Add(this.btnEditFilm);
            this.pnPhim.Controls.Add(this.btnSave);
            this.pnPhim.Controls.Add(this.pbPoster);
            this.pnPhim.Controls.Add(this.label4);
            this.pnPhim.Controls.Add(this.txtGiaVe);
            this.pnPhim.Controls.Add(this.label3);
            this.pnPhim.Controls.Add(this.txtMaPhim);
            this.pnPhim.Controls.Add(this.txtTenPhim);
            this.pnPhim.Controls.Add(this.label2);
            this.pnPhim.Controls.Add(this.label6);
            this.pnPhim.Controls.Add(this.label1);
            this.pnPhim.Location = new System.Drawing.Point(177, 41);
            this.pnPhim.Name = "pnPhim";
            this.pnPhim.Size = new System.Drawing.Size(1191, 732);
            this.pnPhim.TabIndex = 24;
            this.pnPhim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPhim_Paint);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(682, 346);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(434, 156);
            this.txtNoiDung.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(515, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mô tả nội dung";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Image = global::QuanLyRapPhim_Final.Properties.Resources.browsing;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(207, 637);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(118, 44);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = global::QuanLyRapPhim_Final.Properties.Resources.delete4;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(982, 583);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 46);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::QuanLyRapPhim_Final.Properties.Resources.plus2;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(527, 509);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 46);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Image = global::QuanLyRapPhim_Final.Properties.Resources.refresh;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(982, 509);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(130, 46);
            this.btnReload.TabIndex = 16;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDelFilm
            // 
            this.btnDelFilm.AutoSize = true;
            this.btnDelFilm.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelFilm.ForeColor = System.Drawing.Color.Black;
            this.btnDelFilm.Image = global::QuanLyRapPhim_Final.Properties.Resources.trash;
            this.btnDelFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelFilm.Location = new System.Drawing.Point(757, 583);
            this.btnDelFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelFilm.Name = "btnDelFilm";
            this.btnDelFilm.Size = new System.Drawing.Size(135, 46);
            this.btnDelFilm.TabIndex = 15;
            this.btnDelFilm.Text = "Xóa Phim";
            this.btnDelFilm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelFilm.UseVisualStyleBackColor = false;
            this.btnDelFilm.Click += new System.EventHandler(this.btnDelFilm_Click);
            // 
            // btnEditFilm
            // 
            this.btnEditFilm.AutoSize = true;
            this.btnEditFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFilm.ForeColor = System.Drawing.Color.Black;
            this.btnEditFilm.Image = global::QuanLyRapPhim_Final.Properties.Resources.tools1;
            this.btnEditFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFilm.Location = new System.Drawing.Point(527, 583);
            this.btnEditFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditFilm.Name = "btnEditFilm";
            this.btnEditFilm.Size = new System.Drawing.Size(135, 46);
            this.btnEditFilm.TabIndex = 14;
            this.btnEditFilm.Text = "Sửa";
            this.btnEditFilm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditFilm.UseVisualStyleBackColor = false;
            this.btnEditFilm.Click += new System.EventHandler(this.btnEditFilm_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::QuanLyRapPhim_Final.Properties.Resources.save2;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(757, 509);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 46);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbPoster
            // 
            this.pbPoster.BackColor = System.Drawing.Color.White;
            this.pbPoster.Image = global::QuanLyRapPhim_Final.Properties.Resources.photo_1_15458898386971044005541;
            this.pbPoster.Location = new System.Drawing.Point(63, 87);
            this.pbPoster.Margin = new System.Windows.Forms.Padding(4);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(432, 542);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPoster.TabIndex = 12;
            this.pbPoster.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(456, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "THÊM MỚI PHIM";
            // 
            // pb4
            // 
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(1135, 105);
            this.pb4.Margin = new System.Windows.Forms.Padding(4);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(233, 284);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(822, 105);
            this.pb3.Margin = new System.Windows.Forms.Padding(4);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(233, 284);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(503, 105);
            this.pb2.Margin = new System.Windows.Forms.Padding(4);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(233, 284);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(182, 105);
            this.pb1.Margin = new System.Windows.Forms.Padding(4);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(233, 284);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // PhimUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_PHIM);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnPhim);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhimUC";
            this.Size = new System.Drawing.Size(1625, 886);
            this.Load += new System.EventHandler(this.PhimUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PHIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_Phim)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnPhim.ResumeLayout(false);
            this.pnPhim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.DataGridView dgv_PHIM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblTLP;
        private System.Windows.Forms.TextBox txtTLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaVeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn posterDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource phimBindingSource;
        private QuanLyRapPhimDataSet_Phim quanLyRapPhimDataSet_Phim;
        private QuanLyRapPhimDataSet_PhimTableAdapters.PhimTableAdapter phimTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmPhimToolStripMenuItem;
        private System.Windows.Forms.Button btnDelFilm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEditFilm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnPhim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label7;
    }
}