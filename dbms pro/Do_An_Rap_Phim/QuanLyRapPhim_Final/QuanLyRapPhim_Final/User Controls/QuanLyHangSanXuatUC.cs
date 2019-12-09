using System;
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
    public partial class QuanLyHangSanXuatUC : UserControl
    {
        bool Them;
        string err;
        BLHangSanXuat dbHSX = new BLHangSanXuat();
        BLHopDong dbHopDong = new BLHopDong();
        public QuanLyHangSanXuatUC()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            txtMaHSX.ResetText();
            txtMaHSX.Enabled = false;
            txtTenHSX.ResetText();
            txtTenHSX.Enabled = false;
            txtEmailHSX.ResetText();
            txtEmailHSX.Enabled = false;
            txtDiaChiHSX.ResetText();
            txtDiaChiHSX.Enabled = false;
            // Không cho thao tác trên các nút Lưu / Hủy
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnAdd.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            Setupcb();
            try
            {
                DataSet ds = dbHSX.XuLyNhanVien("null", "null", "null", "null", "null","Select");
                dgv_HangSanXuat.DataSource = ds.Tables[0];
                dgv_HangSanXuat.Refresh();
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void Setupcb()
        {
            DataSet ds = dbHopDong.LayHopDong();
            cbMaHD.DataSource = ds.Tables[0];
            cbMaHD.DisplayMember = "MaHD";
            cbMaHD.ValueMember = "MaHD";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;

            txtMaHSX.Enabled = true;
            txtMaHSX.ResetText();
            txtTenHSX.Enabled = true;
            txtTenHSX.ResetText();
            txtEmailHSX.Enabled = true;
            txtEmailHSX.ResetText();
            txtDiaChiHSX.ResetText();
            txtDiaChiHSX.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            cbMaHD.Enabled = true;

            btnAdd.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void QuanLyHangSanXuatUC_Load(object sender, EventArgs e)
        {
            LoadData();
            this.Size = new Size(1625, 886);
        }

        private void dgv_HangSanXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_HangSanXuat.CurrentCell.RowIndex;
            txtMaHSX.Text = dgv_HangSanXuat.Rows[r].Cells[0].Value.ToString();
            txtTenHSX.Text = dgv_HangSanXuat.Rows[r].Cells[1].Value.ToString();
            txtEmailHSX.Text = dgv_HangSanXuat.Rows[r].Cells[2].Value.ToString();
            txtDiaChiHSX.Text = dgv_HangSanXuat.Rows[r].Cells[3].Value.ToString();
            cbMaHD.Text = dgv_HangSanXuat.Rows[r].Cells[4].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            dgv_HangSanXuat_CellClick(null, null);
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtTenHSX.Enabled = true;
            txtEmailHSX.Enabled = true;
            txtDiaChiHSX.Enabled = true;
            cbMaHD.Enabled = true;
            btnAdd.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaHSX.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {

                    dbHSX.XuLyNhanVien(txtMaHSX.Text.Trim(),txtTenHSX.Text.Trim(),txtEmailHSX.Text.Trim(),txtDiaChiHSX.Text.Trim(),cbMaHD.SelectedValue.ToString().Trim(),"Insert");
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
                dbHSX.XuLyNhanVien(txtMaHSX.Text.Trim(), txtTenHSX.Text.Trim(), txtEmailHSX.Text.Trim(), txtDiaChiHSX.Text.Trim(), cbMaHD.SelectedValue.ToString().Trim(),"Update");
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgv_HangSanXuat.CurrentCell.RowIndex;
            string strNV = dgv_HangSanXuat.Rows[r].Cells[2].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                try
                {
                    dbHSX.XuLyNhanVien(txtMaHSX.Text.Trim(), "", "", "", "", "Delete");
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi!!! Xóa thất bại!");
                }

            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}
