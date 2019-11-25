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
    public partial class QuanLyNhanVienUC : UserControl
    {
        private string NQL;
        bool Them;
        string err;
        BLNhanVien dbNV = new BLNhanVien();
        BLChucVu dbCV = new BLChucVu();
        BLChiNhanh dbChiNhanh = new BLChiNhanh();
        DataTable dt = null;
        int month = DateTime.Now.Month;
        int day = DateTime.Now.Day;
        int nam= DateTime.Now.Year;

        public QuanLyNhanVienUC()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVienUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            // Xóa trống các đối tượng trong Panel
            txtHovalotNV.Enabled = true;
            txtHovalotNV.ResetText();
            txtMaNV.Enabled = false;
            txtMaNV.ResetText();
            txtTenNV.Enabled = true;
            txtTenNV.ResetText();
            txtMaNV.ResetText();
            txtHovalotNV.ResetText();
            txtTenNV.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnAdd.Enabled = true;
            btnEditNV.Enabled = true;
            btnDelNV.Enabled = true;
            txtChucVu.Enabled = false;
            txtLuong.Enabled = false;
            try
            {
                dt = new DataTable();
                DataSet data = dbCV.LayChucVu();
                dt.Clear();
                dt = data.Tables[0];
                this.cbbMaCV.DataSource = dt;
                this.cbbMaCV.DisplayMember = "MaCV";
                this.cbbMaCV.ValueMember = "MaCV";
                this.cbbMaCV.Refresh();

                DataSet ds = dbNV.LayNhanVien();
                dt.Clear();
                dt = ds.Tables[0];
                dgv_NHANVIEN.DataSource = dt;
                dgv_NHANVIEN.Refresh();
                //this.nhanVienTableAdapter.Fill(quanLyRapPhimDataSet_NHANVIEN.NhanVien);
                DataSet data1 = new DataSet();
                data1.Clear();
                data1 = dbNV.LayNguoiQuanLy("QL");
                dt = data1.Tables[0];
                cbMaNQL.DataSource = dt;
                //to do:
                cbMaNQL.DisplayMember = "FullName";
                cbMaNQL.ValueMember = "MaNV";
                SetupcbChiNhanh();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table ChucVu. Lỗi rồi!!!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;

            txtHovalotNV.Enabled = true;
            txtHovalotNV.ResetText();
            txtMaNV.Enabled = true;
            txtMaNV.ResetText();
            txtTenNV.Enabled = true;
            txtTenNV.ResetText();
            nmrSoGioLam.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEditNV.Enabled = false;
            btnDelNV.Enabled = false;
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            Them = false;

            dgv_NHANVIEN_CellClick(null, null);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            nmrSoGioLam.Enabled = true;
            cbChiNhanh.Enabled = true;
            btnAdd.Enabled = false;
            btnEditNV.Enabled = false;
            btnDelNV.Enabled = false;

            txtMaNV.Enabled = false;
        }
        private void SetupcbChiNhanh()
        {
            DataSet dataSet = dbChiNhanh.LayChiNanh();
            cbChiNhanh.DataSource = dataSet.Tables[0];
            cbChiNhanh.DisplayMember = "MaChiNhanh";
            cbChiNhanh.ValueMember = "MaChiNhanh";
        }
        private void dgv_NHANVIEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_NHANVIEN.CurrentCell.RowIndex;

            txtMaNV.Text = dgv_NHANVIEN.Rows[r].Cells[2].Value.ToString();
            txtHovalotNV.Text = dgv_NHANVIEN.Rows[r].Cells[0].Value.ToString();
            txtTenNV.Text = dgv_NHANVIEN.Rows[r].Cells[1].Value.ToString();
            cbbMaCV.Text= dgv_NHANVIEN.Rows[r].Cells[3].Value.ToString();
            try
            {
                nmrSoGioLam.Enabled = true;
                nmrSoGioLam.Value = decimal.Parse(dgv_NHANVIEN.Rows[r].Cells[4].Value.ToString());
                nmrSoGioLam.Enabled = false;
            }
            catch (Exception)
            {
                
            }
            if (dgv_NHANVIEN.Rows[r].Cells[5].Value.ToString()=="")
            {
                cbMaNQL.ResetText();
                cbMaNQL.Enabled = false;
            }
            else
            {
                cbMaNQL.Text = dgv_NHANVIEN.Rows[r].Cells[5].Value.ToString();
                cbMaNQL.Enabled = false;
            }
            cbChiNhanh.Text = dgv_NHANVIEN.Rows[r].Cells[6].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    
                    BLNhanVien blNV = new BLNhanVien();
                    blNV.ThemNhanVien(this.txtMaNV.Text.Trim(), this.txtHovalotNV.Text.Trim(), this.txtTenNV.Text.Trim(), cbbMaCV.Text,int.Parse(nmrSoGioLam.Value.ToString()),NQL, cbChiNhanh.SelectedValue.ToString(), ref err);
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
                BLNhanVien blNV = new BLNhanVien();
                blNV.CapNhatNhanVien( this.txtHovalotNV.Text.Trim(),this.txtTenNV.Text.Trim(),this.cbbMaCV.Text, this.txtMaNV.Text,int.Parse(nmrSoGioLam.Value.ToString()),NQL,cbChiNhanh.SelectedValue.ToString(),ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            int r = dgv_NHANVIEN.CurrentCell.RowIndex;
            string strNV = dgv_NHANVIEN.Rows[r].Cells[2].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                try
                {
                    dbNV.XoaNhanVien(ref err, strNV);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi!!! Xóa thất bại!");
                }

            }
        }

        private void cbbMaCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaCV.ValueMember == "") return;
            dt = new DataTable();
            dt.Clear();
            DataSet data = dbCV.LayChucVu();
            dt = data.Tables[0];
            txtChucVu.Text = dt.Rows[cbbMaCV.SelectedIndex].ItemArray[1].ToString();
            txtLuong.Text = dt.Rows[cbbMaCV.SelectedIndex].ItemArray[2].ToString();
            if (cbbMaCV.Text=="QL")
            {
                cbMaNQL.ResetText();
                cbMaNQL.Enabled = false;
                NQL = "null";
            }
            else
            {
                cbMaNQL.Enabled = true;
                DataSet dataSet = dbNV.LayNguoiQuanLy("QL");
                cbMaNQL.DataSource = dataSet.Tables[0];
                cbMaNQL.DisplayMember = "FullName";
                cbMaNQL.ValueMember = "MaNV";
                NQL = cbMaNQL.SelectedValue.ToString() ;
            }
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}