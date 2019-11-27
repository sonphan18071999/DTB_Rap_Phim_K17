﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyRapPhim_Final.BSLayer;

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class QuanLySuatChieuUC : UserControl
    {
        bool Them;
        string err;
        BLRap dbRap = new BLRap();
        BLPhim dbPhim = new BLPhim();
        BLSuatChieu dbNV = new BLSuatChieu();
        DataSet dsPhim = new DataSet();

        public QuanLySuatChieuUC()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // Xóa trống các đối tượng trong Panel
            txtMaPhim.ResetText();
            txtSuatChieu.ResetText();
            txtMaSCP.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            SetUpcbTenPhim();
            SetUpcbMaRap();
            try
            {
                this.suatChieuPhimTableAdapter.Fill(quanLyRapPhimDataSet_SuatChieuPhim.SuatChieuPhim);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table suatchieu. Lỗi rồi!!!");
            }
        }

        private void dgv_SUATCHIEU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_SUATCHIEU.CurrentCell.RowIndex;

            txtMaPhim.Text = dgv_SUATCHIEU.Rows[r].Cells[0].Value.ToString();
            txtSuatChieu.Text = dgv_SUATCHIEU.Rows[r].Cells[1].Value.ToString();
            cbTenRap.Text = dgv_SUATCHIEU.Rows[r].Cells[2].Value.ToString();
            txtMaSCP.Text = dgv_SUATCHIEU.Rows[r].Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaPhim.Enabled = false;
            txtSuatChieu.Enabled = true;
            txtSuatChieu.ResetText();
            cbTenRap.Enabled = true;
            txtMaSCP.ResetText();
            txtMaSCP.Enabled = true;
            txtMaSCP.Focus();

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Them = false;

            dgv_SUATCHIEU_CellClick(null, null);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;

            txtMaSCP.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int r = dgv_SUATCHIEU.CurrentCell.RowIndex;
            string MaSuatChieu = dgv_SUATCHIEU.Rows[r].Cells[3].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                try
                {
                    dbNV.XoaSuatChieu(ref err, MaSuatChieu);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi!!! Xóa thất bại!");
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLSuatChieu blSC = new BLSuatChieu();
                    blSC.ThemSuatChieu(this.txtMaPhim.Text.Trim(), this.txtSuatChieu.Text.Trim(), this.cbTenRap.Text.Trim(),txtMaSCP.Text.Trim(), ref err);
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                BLSuatChieu blSC = new BLSuatChieu();
                blSC.CapNhatSuatChieu(this.txtMaPhim.Text, this.txtSuatChieu.Text, this.cbTenRap.Text,txtMaSCP.Text.Trim(),ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void QuanLySuatChieuUC_Load(object sender, EventArgs e)
        {
            //this.suatChieuPhimTableAdapter.Fill(quanLyRapPhimDataSet_SuatChieuPhim.SuatChieuPhim);
            LoadData();
        }
        private void SetUpcbTenPhim()
        {
            DataSet ds = new DataSet();
            ds = dbPhim.LayPhim();
            dsPhim = ds;
            if (ds.Tables[0].Rows.Count!=0)
            {
                cbTenPhim.DataSource = ds.Tables[0];
                cbTenPhim.DisplayMember = "TenPhim";
                cbTenPhim.ValueMember = "MaPhim";
            }

        }
        private void SetUpcbMaRap()
        {
            DataSet ds = new DataSet();
            ds = dbRap.LayRap();
            dsPhim = ds;
            if (ds.Tables[0].Rows.Count != 0)
            {
                cbTenRap.DataSource = ds.Tables[0];
                cbTenRap.DisplayMember = "MaRap";
                cbTenRap.ValueMember = "MaRap";
            }
        }
        private void cbTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsPhim = dbPhim.TimPhim(cbTenPhim.Text.Trim());
            if (dsPhim.Tables[0].Rows.Count>0)
            {
                txtMaPhim.Enabled = true;
                txtMaPhim.Text = dsPhim.Tables[0].Rows[0].ItemArray[1].ToString();
                txtMaPhim.Enabled = false;
            }
        }

        private void cbTenRap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
