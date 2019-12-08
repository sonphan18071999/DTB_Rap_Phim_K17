using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhim_Final.BSLayer;
using System.Data.SqlClient;

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class ChiNhanhUC : UserControl
    {
        BLChiNhanh dbChiNhanh = new BLChiNhanh();
        BLDatVe dbDatVe = new BLDatVe();
        BLSuatChieu dbSuatChieu = new BLSuatChieu();
        BLPhim dbPhim = new BLPhim();
        bool Them;
        string Phim;

        public ChiNhanhUC()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                btnTinh.Enabled = false;
                DataSet ds = dbChiNhanh.LayChiNanh();
                dgv_ChiNhanh.DataSource = ds.Tables[0];
                dgv_ChiNhanh.AutoResizeColumns();
                txtDoanhThu.Enabled = false;
                txtMaChiNhanh.ResetText();
                txtTenChiNhanh.ResetText();
                setCbPhim();
                txtMaChiNhanh.Enabled = false;
                txtTenChiNhanh.Enabled = false;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
                dtpNgay.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table chức vụ. Lỗi rồi!!!");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaChiNhanh.Enabled = true;
            txtTenChiNhanh.Enabled = true;
            txtMaChiNhanh.ResetText();
            txtTenChiNhanh.ResetText();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            txtMaChiNhanh.Focus();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChiNhanhUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_ChiNhanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_ChiNhanh.CurrentCell.RowIndex;
            txtMaChiNhanh.Text = dgv_ChiNhanh.Rows[r].Cells[0].Value.ToString();
            txtTenChiNhanh.Text = dgv_ChiNhanh.Rows[r].Cells[1].Value.ToString();
            //DataSet ds = dbChiNhanh.DoanhThu(txtMaChiNhanh.Text, dtpNgay.Value.Date);
            //txtDoanhThu.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    dbChiNhanh.XuLyChiNhanh(txtMaChiNhanh.Text,txtTenChiNhanh.Text,"Insert");
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
                try
                {
                    dbChiNhanh.XuLyChiNhanh(txtMaChiNhanh.Text, txtTenChiNhanh.Text, "Update");
                    LoadData();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Them = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            txtMaChiNhanh.Enabled = false;
            txtTenChiNhanh.Enabled = true;
            txtTenChiNhanh.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaChiNhanh.ResetText();
            txtTenChiNhanh.ResetText();
            txtMaChiNhanh.Enabled = false;
            txtTenChiNhanh.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int r = dgv_ChiNhanh.CurrentCell.RowIndex;
            string strPhim = dgv_ChiNhanh.Rows[r].Cells[1].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                try
                {
                    dbChiNhanh.XuLyChiNhanh(txtMaChiNhanh.Text, txtTenChiNhanh.Text, "Delete");
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi!!! Xóa thất bại!");
                }

            }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            DataSet ds = dbChiNhanh.DoanhThu(txtMaChiNhanh.Text, dtpNgay.Value.Date);
            txtDoanhThu.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();

        }

        private void setCbPhim()
        {
            DataSet ds = dbPhim.LayPhim();
            cbPhim.DataSource = ds.Tables[0];
            cbPhim.DisplayMember = "TenPhim";
            cbPhim.ValueMember = "MaPhim";
        }

        private void chbPhim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgv_ChiNhanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ckbNgay_CheckedChanged(object sender, EventArgs e)
        {
            btnTinh.Enabled = true;
            if (ckbNgay.CheckState == CheckState.Checked)
            {
                dtpNgay.Enabled = true;
            }
            else
            {
                dtpNgay.Enabled = false;
                if (ckbPhim.CheckState==CheckState.Unchecked)
                {
                    btnTinh.Enabled = false;
                }
            }
        }

        private void ckbPhim_CheckedChanged(object sender, EventArgs e)
        {
            btnTinh.Enabled = true;
            if (ckbPhim.CheckState==CheckState.Checked)
            {
                cbPhim.Enabled = true;
            }
            else
            {
                cbPhim.Enabled = false;
                if (ckbNgay.CheckState == CheckState.Unchecked)
                {
                    btnTinh.Enabled = false;
                }
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {

            if (ckbNgay.CheckState == CheckState.Checked)
            {
                if (ckbPhim.CheckState == CheckState.Checked)
                {
                    //tính ngày tính phim
                    DataSet ds = dbChiNhanh.DoanhThuPhim(txtMaChiNhanh.Text, dtpNgay.Value.Date, cbPhim.SelectedValue.ToString().Trim(),"");
                    txtDoanhThu.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();

                }
                else
                {
                    DataSet ds = dbChiNhanh.DoanhThu(txtMaChiNhanh.Text, dtpNgay.Value.Date);
                    txtDoanhThu.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();

                }
            }
            else
            {
                if (ckbPhim.CheckState == CheckState.Checked)
                {
                    //tính phim ko ngày
                    DataSet ds = dbChiNhanh.DoanhThuPhim(txtMaChiNhanh.Text, dtpNgay.Value.Date, cbPhim.SelectedValue.ToString().Trim(), "NULL");
                    txtDoanhThu.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();

                }
                else
                {
                    txtDoanhThu.ResetText();
                }
            }
        }
    }
}
