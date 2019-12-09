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
    public partial class QuanLyKhachHangUC : UserControl
    {
        bool Them;
        string err;
        BLKhachHang dbKH = new BLKhachHang();

        public QuanLyKhachHangUC()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // Xóa trống các đối tượng trong Panel
            txtMaKH.ResetText();
            txtHovalotKH.ResetText();
            txtTenKH.ResetText();
            txtTichDiem.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnAdd.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgv_KHACHHANG.RowTemplate.Height = 90;

            try
            {
                this.khachHangTableAdapter.Fill(this.quanLyRapPhimDataSet_KhachHang.KhachHang);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }
        private void QuanLyKhachHangUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtHovalotKH.Enabled = true;
            txtHovalotKH.ResetText();
            txtMaKH.Enabled = true;
            txtMaKH.ResetText();
            txtTenKH.Enabled = true;
            txtTenKH.ResetText();
            dtpNgaySinh.ResetText();
            txtTichDiem.ResetText();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnAdd.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            Dgv_KHACHHANG_CellClick(null, null);
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnAdd.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaKH.Enabled = false;
        }

        private void Dgv_KHACHHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgv_KHACHHANG.CurrentCell.RowIndex;

                txtMaKH.Text = dgv_KHACHHANG.Rows[r].Cells[0].Value.ToString();
                txtHovalotKH.Text = dgv_KHACHHANG.Rows[r].Cells[1].Value.ToString();
                txtTenKH.Text = dgv_KHACHHANG.Rows[r].Cells[2].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dgv_KHACHHANG.Rows[r].Cells[3].Value.ToString());
                txtTichDiem.Text = dgv_KHACHHANG.Rows[r].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                
            }

        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLKhachHang blKH = new BLKhachHang();
                    blKH.ThemKhachHang(this.txtMaKH.Text.Trim(), this.txtHovalotKH.Text.Trim(), this.txtTenKH.Text.Trim(),dtpNgaySinh.Value,Int32.Parse(txtTichDiem.Text.Trim()), ref err);
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
                BLKhachHang blKH = new BLKhachHang();
                blKH.CapNhatKhachHang(this.txtMaKH.Text.Trim(), this.txtHovalotKH.Text.Trim(), this.txtTenKH.Text.Trim(), dtpNgaySinh.Value, Int32.Parse(txtTichDiem.Text.Trim()), ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgv_KHACHHANG.CurrentCell.RowIndex;
            string strKH = dgv_KHACHHANG.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                try
                {
                    dbKH.XoaKhachHang(ref err, strKH);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi!!! Xóa thất bại!");
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Them = true;

            txtHovalotKH.Enabled = true;
            txtHovalotKH.ResetText();
            txtMaKH.Enabled = true;
            txtMaKH.ResetText();
            txtTenKH.Enabled = true;
            txtTenKH.ResetText();

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnAdd.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void ptbXoa_MouseHover(object sender, EventArgs e)
        {
           

        }

        private void ptbXoa_MouseLeave(object sender, EventArgs e)
        {
            
            //ptbXoa.Height = 55;
        }

        private void ptbXoa_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void ptbThem_DragLeave(object sender, EventArgs e)
        {

        }

        private void ptbThem_MouseLeave(object sender, EventArgs e)
        {
            
            //ptbXoa.Width = 89;
            //ptbXoa.Height = 55;
        }

        private void ptbThem_MouseMove(object sender, MouseEventArgs e)
        {

            
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Them = false;

            Dgv_KHACHHANG_CellClick(null, null);
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnAdd.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaKH.Enabled = false;
        }

        private void ptbSua_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void ptbSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.Width = btnSua.Width - 10;
            btnSua.Height = btnSua.Height - 10;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = false;

            Dgv_KHACHHANG_CellClick(null, null);
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnAdd.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaKH.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}