using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhim_Final.User_Controls;
namespace QuanLyRapPhim_Final
{
    public partial class Form1 : Form
    {
        QuanLyHangSanXuatUC quanLyHangSanXuatUC = new QuanLyHangSanXuatUC();
        HopDongUC quanLyHopDong = new HopDongUC();
        ChiNhanhUC ChiNhanhUC = new ChiNhanhUC();
        string user;
        public Form1(string manv)
        {
            InitializeComponent();
           user = manv.Substring(0, 1).ToLower();
            this.Size=new Size(1800, 1101);
            pictureBox1.Size = new Size(1625, 133);
            // WindowState = FormWindowState.Maximized;
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnWelcome.Height;
            pnlClick.Top = btnWelcome.Top;
            welcomeUC1.BringToFront();
            lblHeader.Text = "Welcome";
            quanLyHangSanXuatUC.SendToBack();
            quanLyHopDong.SendToBack();
            ChiNhanhUC.SendToBack();

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            DialogResult flag = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (flag == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnQuanLyPhim_Click(object sender, EventArgs e)
        {

            pnlClick.Height = btnQuanLyPhim.Height;
            pnlClick.Top = btnQuanLyPhim.Top;
            phimUC1.BringToFront();
            lblHeader.Text = "Phim đang chiếu";
            quanLyHangSanXuatUC.SendToBack();
            quanLyHopDong.SendToBack();
            ChiNhanhUC.SendToBack();

        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnQuanLyKhachHang.Height;
            pnlClick.Top = btnQuanLyKhachHang.Top;
            quanLyKhachHangUC1.BringToFront();
            lblHeader.Text = "Quản lý khách hàng";
            quanLyHangSanXuatUC.SendToBack();
            quanLyHopDong.SendToBack();
            ChiNhanhUC.SendToBack();

        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnQuanLyNhanVien.Height;
            pnlClick.Top = btnQuanLyNhanVien.Top;
            quanLyNhanVienUC1.BringToFront();
            lblHeader.Text = "Quản lý nhân viên";
            quanLyHangSanXuatUC.SendToBack();
            quanLyHopDong.SendToBack();
            ChiNhanhUC.SendToBack();

        }

        private void btnQuanLyRap_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnQuanLyRap.Height;
            pnlClick.Top = btnQuanLyRap.Top;
            quanLyRapUC1.BringToFront();
            lblHeader.Text = "Quản lý rạp";
            quanLyHangSanXuatUC.SendToBack();
            quanLyHopDong.SendToBack();
            ChiNhanhUC.SendToBack();

        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnDatVe.Height;
            pnlClick.Top = btnDatVe.Top;
            datVeUC1.BringToFront();
            lblHeader.Text = "Đặt vé";
            quanLyHangSanXuatUC.SendToBack();
            quanLyHopDong.SendToBack();
            ChiNhanhUC.SendToBack();

        }

        private void btnChucVuNhanVien_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnChucVuNhanVien.Height;
            pnlClick.Top = btnChucVuNhanVien.Top;
            chucVuUC1.BringToFront();
            lblHeader.Text = "Chức vụ nhân viên";
            quanLyHangSanXuatUC.SendToBack();
            ChiNhanhUC.SendToBack();

        }

        private void btnQuanLySuatChieu_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnQuanLySuatChieu.Height;
            pnlClick.Top = btnQuanLySuatChieu.Top;
            quanLySuatChieuUC1.BringToFront();
            lblHeader.Text = "Suất chiếu";
            quanLyHangSanXuatUC.SendToBack();
            quanLyHopDong.SendToBack();
            ChiNhanhUC.SendToBack();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(quanLyHangSanXuatUC);
            Point p = new Point(230, 115);
            quanLyHangSanXuatUC.Location = p;
            quanLyHangSanXuatUC.Width = 900;
            quanLyHangSanXuatUC.Height = 754;
            quanLyHangSanXuatUC.BackColor = Color.FromArgb(255, 224, 192);
            //setup Quan lý hợp đồng
            this.Controls.Add(quanLyHopDong);
            quanLyHopDong.Location = p;
            quanLyHopDong.Width = 900;
            quanLyHopDong.Height = 754;
            quanLyHopDong.BackColor= Color.FromArgb(255, 224, 192);
            //setup chi nhánh
            this.Controls.Add(ChiNhanhUC);
            ChiNhanhUC.Location = p;
            ChiNhanhUC.Width = 900;
            ChiNhanhUC.Height = 754;
            ChiNhanhUC.BackColor = Color.FromArgb(255, 224, 192);
            //disable nhân viên 
            btnQuanLyPhim.Enabled = false;
            btnQuanLyKhachHang.Enabled = false;
            btnQuanLyNhanVien.Enabled = false;
            btnQuanLyRap.Enabled = false;
            btnChucVuNhanVien.Enabled = false;
            btnQuanLySuatChieu.Enabled = false;
            btnQuanLyHangSanXuat.Enabled = false;
            btnHopDong.Enabled = false;
            btnChiNhanh.Enabled = false;

            if (user.ToString() == "a")
            {
                btnQuanLyPhim.Enabled = true;
                btnQuanLyKhachHang.Enabled = true;
                btnQuanLyNhanVien.Enabled = true;
                btnQuanLyRap.Enabled = true;
                btnChucVuNhanVien.Enabled = true;
                btnQuanLySuatChieu.Enabled = true;
                btnQuanLyHangSanXuat.Enabled = true;
                btnHopDong.Enabled = true;
                btnChiNhanh.Enabled = true;
            }
            else if (user.ToString() == "q")
            {
                btnQuanLyPhim.Enabled = true;
                btnQuanLyKhachHang.Enabled = true;
                btnQuanLyNhanVien.Enabled = true;
                btnQuanLyRap.Enabled = true;
                btnChucVuNhanVien.Enabled = true;

            }
            else
            {
                btnQuanLyPhim.Enabled = true;
                btnQuanLyKhachHang.Enabled = true;
                //btnQuanLyNhanVien.Enabled = false;
                btnQuanLyRap.Enabled = true;
                btnQuanLySuatChieu.Enabled = true;
            }
        }

        private void btnQuanLyHangSanXuat_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnQuanLyHangSanXuat.Height;
            pnlClick.Top = btnQuanLyHangSanXuat.Top;
            pnlClick.BringToFront();
            quanLyHangSanXuatUC.BringToFront();
            quanLyHopDong.SendToBack();
            ChiNhanhUC.SendToBack();
            lblHeader.Text = "Hãng sản xuất";
            quanLyHangSanXuatUC.Size = new Size(1625, 886);
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnHopDong.Height;
            pnlClick.Top = btnHopDong.Top;
            pnlClick.BringToFront();
            quanLyHangSanXuatUC.SendToBack();
            quanLyHopDong.BringToFront();
            ChiNhanhUC.SendToBack();
            lblHeader.Text = "Bảng hợp đồng";
            quanLyHopDong.Size = new Size(1625, 886);
        }

        private void btnChiNhanh_Click(object sender, EventArgs e)
        {
            //pnlClick.Height = ChiNhanhUC.Height;
            //pnlClick.Top = ChiNhanhUC.Top;
            //pnlClick.BringToFront();
            quanLyHangSanXuatUC.SendToBack();
            quanLyHopDong.SendToBack();
            ChiNhanhUC.BringToFront();
            lblHeader.Text = "Bảng chi nhánh";
            ChiNhanhUC.Size = new Size(1625, 886);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            this.Close();
        }
    }
}