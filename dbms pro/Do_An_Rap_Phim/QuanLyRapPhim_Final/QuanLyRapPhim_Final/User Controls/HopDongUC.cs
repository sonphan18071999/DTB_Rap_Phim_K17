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
    public partial class HopDongUC : UserControl
    {
        bool Them;
        string err;
        BLHangSanXuat BLHangSanXuat = new BLHangSanXuat();
        BLPhim BLPhim = new BLPhim();
        BLHopDong BLHopDong = new BLHopDong();
        DataTable dt = null;
        public HopDongUC()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            txtMaHD.Enabled = false;

            txtGiaTriHD.ResetText();
            txtGiaTriHD.Enabled = false;
            cbMaPhim.Enabled = false;
            txtTenDaoDien.ResetText();
            txtTenDaoDien.Enabled = false;
            SetupCbPhim();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnAdd.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            try
            {
                var context = new QuanLyRapPhimEntities();
                var dbtb = context.PhimHopDongInsertUpdateDelete(null, null, null, null, null, null, null,"Select");
                dt = new DataTable();
                dgv_HopDong.DataSource = dbtb;
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HopDong. Lỗi rồi!!!");
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void SetupCbPhim()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = BLPhim.LayPhim();
            dt = ds.Tables[0];
            cbMaPhim.DataSource = dt;
            cbMaPhim.DisplayMember = "MaPhim";
            cbMaPhim.ValueMember = "MaPhim";
            

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;

            txtMaHD.Enabled = true;
            txtMaHD.ResetText();
            txtTenDaoDien.Enabled = true;
            txtTenDaoDien.ResetText();
            txtGiaTriHD.Enabled = true;
            txtGiaTriHD.ResetText();
            cbMaPhim.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnAdd.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void HopDongUC_Load(object sender, EventArgs e)
        {
            LoadData();
            dgv_HopDong.RowTemplate.Height = 90;

        }

        private void dgv_HopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_HopDong.CurrentCell.RowIndex;
            txtMaHD.Text = dgv_HopDong.Rows[r].Cells[0].Value.ToString();
            txtTenDaoDien.Text = dgv_HopDong.Rows[r].Cells[1].Value.ToString();
            txtGiaTriHD.Text = dgv_HopDong.Rows[r].Cells[2].Value.ToString();
            dtpNgayXuatBan.Value = Convert.ToDateTime(dgv_HopDong.Rows[r].Cells[3].Value.ToString());
            dtpNgayKiHD.Value = Convert.ToDateTime(dgv_HopDong.Rows[r].Cells[4].Value.ToString());
            dtpNgayHetHan.Value = Convert.ToDateTime(dgv_HopDong.Rows[r].Cells[5].Value.ToString());
            cbMaPhim.Text= dgv_HopDong.Rows[r].Cells[6].Value.ToString();

        }

        private void cbMaPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dataSet = BLPhim.LayPhim();
            DataTable dt = dataSet.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cbMaPhim.Text== dt.Rows[i].ItemArray[1].ToString())
                {
                    txtTenPhim.Text = dt.Rows[i].ItemArray[0].ToString();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtTenDaoDien.Enabled = true;
            txtGiaTriHD.Enabled = true;
            cbMaPhim.Enabled = true;
            dgv_HopDong_CellClick(null, null);
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnAdd.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaHD.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    
                    BLHopDong.XuLyHopDong(txtMaHD.Text,txtTenDaoDien.Text,int.Parse(txtGiaTriHD.Text),dtpNgayXuatBan.Value,dtpNgayKiHD.Value,dtpNgayHetHan.Value,cbMaPhim.Text,"Insert");
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
                BLHopDong.XuLyHopDong(txtMaHD.Text, txtTenDaoDien.Text, int.Parse(txtGiaTriHD.Text), dtpNgayXuatBan.Value, dtpNgayKiHD.Value, dtpNgayHetHan.Value, cbMaPhim.Text, "Update");
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgv_HopDong.CurrentCell.RowIndex;
            string strHD = dgv_HopDong.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                MY_DB mydb = new MY_DB();
                mydb.openConnection();
                SqlTransaction objTrans = null;
                using (SqlConnection objConn = mydb.getConnection)
                {
                    objTrans = objConn.BeginTransaction();
                    SqlCommand dlHSX = new SqlCommand($"update HangSanXuat set MaHD=NULL  where MaHD=N'{txtMaHD.Text.Trim()}'", mydb.getConnection, objTrans);
                    SqlCommand dlPHD = new SqlCommand($"delete from PhimHopDong where MaHD=  N'{txtMaHD.Text.Trim()}'", mydb.getConnection, objTrans);
                    try
                    {
                        dlHSX.ExecuteNonQuery();
                        dlPHD.ExecuteNonQuery();
                        objTrans.Commit();
                        MessageBox.Show("Da xoa hop dong" + txtMaHD.Text);

                    }
                    catch (Exception ex)
                    {
                        objTrans.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                    mydb.closeConnection();
                }

            }
        }

        private void txtGiaTriHD_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaTriHD.Text.Length>10)
            {
                txtGiaTriHD.ResetText();
                MessageBox.Show("giá trị hợp đồng quá lớn!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
