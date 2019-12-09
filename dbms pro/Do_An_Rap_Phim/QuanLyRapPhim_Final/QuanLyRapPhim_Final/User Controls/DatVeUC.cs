using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhim_Final.User_Controls;
using QuanLyRapPhim_Final.BSLayer;
using QuanLyRapPhim_Final.renderSeat;
using System.Data.SqlClient;

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class DatVeUC : UserControl
    {
        string cnstr = @"Data Source=.\SQLEXPRESS;
          Initial Catalog=QuanLyRapPhim;
          Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;


        DataTable dtRap = null;
        DataTable dtDatVe = null;
        DataTable dtPhim = null;
        DataTable dtSuatChieu = null;
        DataTable dtNhanVien = null;
        DataTable dtKH = null;

        BLNhanVien dbNhanVien = new BLNhanVien();
        BLSuatChieu dbSuatChieu = new BLSuatChieu();
        BLPhim dbPhim = new BLPhim();
        BLDatVe dbDatVe = new BLDatVe();
        BLRap dbRap = new BLRap();
        BLKhachHang dbKhachHang = new BLKhachHang();
        Graphics gp;
        private List<string> bookedSeatAlpha;
        private List<string> bookedSeatNum;
        private string globalRap;
        private string currentMaPhim;
        private string globalMaKH;
        private string storedMaKH = "";
        private string globalMaNV;
        private bool themFlag = false;
        private float TienVeLucDau = 0;
        string err;
        public DatVeUC()
        {
            InitializeComponent();
        }

        private void DatVeUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            SetupcbGhiChu();
            setNhanViencb();
            setCombobox2();
            DataSet ds = dbRap.LayRap();
            raptxt.Enabled = false;
            gp = seatPanel.CreateGraphics();
            seatPanel.Visible = false;
            SuatChieucb.Enabled = false;
            setMaKHcb();
            Phimcb.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            Daytxt.Enabled = false;
            ghetxt.Enabled = false;
            txtTien.Enabled = false;
            txtKhuyenMai.Text = "0";
            txtKhuyenMai.Enabled = false;
            txtGioKetThuc.Enabled = false;
            txtMaVe.Enabled = false;

        }
        private void setCombobox2()
        {
            DataSet ds = dbPhim.LayPhim();
            Phimcb.DataSource = ds.Tables[0];
            Phimcb.DisplayMember = "TenPhim";
            Phimcb.ValueMember = "TenPhim";
            Phimcb.SelectedIndex = 0;
        }
        private void setRaptxt(DataTable dt)
        {

            dtSuatChieu = new DataTable();
            dtSuatChieu.Clear();
            DataSet dsSuatChieu = dbSuatChieu.LaySuatChieu();
            dtSuatChieu = dsSuatChieu.Tables[0];
            for (int i = 0; i < dtPhim.Rows.Count; i++)
            {
                if (Phimcb.Text == dt.Rows[i].ItemArray[0].ToString())
                {
                    for (int j = 0; j < dtSuatChieu.Rows.Count; j++)
                    {
                        if (dt.Rows[i].ItemArray[1].ToString() == dtSuatChieu.Rows[j].ItemArray[0].ToString() && dtSuatChieu.Rows[j].ItemArray[1].ToString() == SuatChieucb.Text)
                        {
                            globalRap = dtSuatChieu.Rows[j].ItemArray[2].ToString();
                            raptxt.Enabled = true;
                            raptxt.Text = globalRap;
                            raptxt.Enabled = false;
                        }

                    }

                }
            }

        }

        private void seatPanel_Paint(object sender, PaintEventArgs e)
        {
            render matrix = new render(seatPanel.Width, seatPanel.Height);
            matrix.drawTable(gp);
        }
        private void getBookedSeat()
        {
            if (SuatChieucb.ValueMember == "") return;
            dtDatVe = new DataTable();
            dtDatVe.Clear();
            DataSet ds = dbDatVe.GetBookedSeat(currentMaPhim, globalRap, SuatChieucb.Text.Trim());       
            dtDatVe = ds.Tables[0];
            bookedSeatAlpha = new List<string>();
            bookedSeatNum = new List<string>();
            if (dtDatVe.Rows.Count != 0)
            {
                for (int i = 0; i < dtDatVe.Rows.Count; i++)   //2 cột
                {

                    bookedSeatAlpha.Add(dtDatVe.Rows[i].ItemArray[0].ToString());
                    bookedSeatNum.Add(dtDatVe.Rows[i].ItemArray[1].ToString());

                }
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            dtPhim = new DataTable();
            dtPhim.Clear();
            DataSet dsPhim = dbPhim.LayPhim();
            dtPhim = dsPhim.Tables[0];
            //gọi hàm set cb suất chiếu
            SuatChieucb.Enabled = true;
            if (Phimcb.ValueMember != "")
            {
                setCbSuatChieu(dtPhim);
            }

            //render chỗ khi change index

        }

        private void SuatChieucb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Daytxt.Text = "";
            ghetxt.Text = "";
            if (Phimcb.ValueMember.ToString() == "") return;
            if (SuatChieucb.ValueMember.ToString() == "") return;
            //string time;
            XuLyGioKetThuc();
            
            seatPanel.Visible = true;
            render seatLoader = new render();
            dtRap = new DataTable();
            dtRap.Clear();
            dtPhim = new DataTable();
            DataSet dsPhim = dbPhim.LayPhim();
            dtPhim = dsPhim.Tables[0];
            setRaptxt(dtPhim);
            if (globalRap != null)
            {
                DataSet ds = dbRap.findRap(globalRap);
                dtRap = ds.Tables[0];

                if (dtRap.Rows.Count != 0)
                {
                    ds = dbRap.findSoDayGhe(globalRap);
                    dtRap = ds.Tables[0];
                    Program.hangGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
                    ds = dbRap.findSoLuongGhe(globalRap);
                    dtRap = ds.Tables[0];
                    Program.soGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
                    seatLoader.removeSeat(ref seatPanel);
                    seatPanel.Refresh();
                    getBookedSeat();
                    seatLoader.renderSeat(ref seatPanel, bookedSeatAlpha, bookedSeatNum);
                    setBtnEven(seatLoader.btns);
                }
            }
        }
        private void setCbSuatChieu(DataTable dtPhim)
        {

            if (Phimcb.ValueMember.ToString() == "") return;
            dtSuatChieu = new DataTable();
            dtSuatChieu.Clear();

            for (int i = 0; i < dtPhim.Rows.Count; i++)
            {
                if (Phimcb.Text == dtPhim.Rows[i].ItemArray[0].ToString())
                {
                    currentMaPhim = dtPhim.Rows[i].ItemArray[1].ToString();
                }
            }
            DataSet ds = dbSuatChieu.LaySuatChieuCuaPhim(currentMaPhim);
            dtSuatChieu = ds.Tables[0];
            SuatChieucb.DataSource = dtSuatChieu;
            SuatChieucb.DisplayMember = "GioChieu";
            SuatChieucb.ValueMember = "MaSC";

        }

        private void nhanViencb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhanViencb.ValueMember == "") return;
            globalMaNV = nhanViencb.SelectedValue.ToString().Trim();
        }
        private void setNhanViencb()
        {

            DataSet ds = dbNhanVien.LayNhanVien();
            nhanViencb.DataSource = ds.Tables[0];
            nhanViencb.DisplayMember = "TenNV";
            nhanViencb.ValueMember = "MaNV";
            nhanViencb.SelectedIndex = 0;
            globalMaNV = nhanViencb.SelectedIndex.ToString();
        }
        private void setBtnEven(List<Button> btns)
        {
            for (int i = 0; i < btns.Count; i++)
            {

                btns[i].Click += btn_click;

            }
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] splitedString = btn.Text.Split('-');
            Daytxt.Text = splitedString[0];
            ghetxt.Text = splitedString[1];
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //setNhanViencb();
            //setMaKHcb();
            //setCombobox2();
            if (SuatChieucb.ValueMember.ToString() == "") return;
            render seatLoader = new render();
            if (globalRap != null)
            {
                DataSet ds = dbRap.findRap(globalRap);
                dtRap = ds.Tables[0];

                if (dtRap.Rows.Count != 0)
                {
                    ds = dbRap.findSoDayGhe(globalRap);
                    dtRap = ds.Tables[0];
                    Program.hangGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
                    ds = dbRap.findSoLuongGhe(globalRap);
                    dtRap = ds.Tables[0];
                    Program.soGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
                    seatLoader.removeSeat(ref seatPanel);
                    seatPanel.Refresh();
                    getBookedSeat();
                    seatLoader.renderSeat(ref seatPanel, bookedSeatAlpha, bookedSeatNum);
                    setBtnEven(seatLoader.btns);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themFlag = true;
            txtMaVe.Text = dbDatVe.TangMaVe();
            txtMaVe.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            Phimcb.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!raptxt.Text.Equals("") && !ghetxt.Text.Equals("") && !Daytxt.Text.Equals(""))
            {
                //bool checkKH = checkMaKH();
                //if (checkKH == false)
                //{
                //    MessageBox.Show("bạn đã đặt suất chiếu này rồi!");
                //    return;
                //}

                dtPhim = new DataTable();
                dtPhim.Clear();
                DataSet dsPhim = dbPhim.LayPhim();
                dtPhim = dsPhim.Tables[0];
                string maPhim = findMaPhim(dtPhim);
                dbDatVe = new BLDatVe();
                DataSet dsSuatChieu = dbSuatChieu.LaySuatChieuCuaPhim(maPhim);
                string MaSC = dtSuatChieu.Rows[0].ItemArray[3].ToString();
                //todo
                try
                {

                    //dbDatVe.themVe(maPhim, raptxt.Text, SuatChieucb.Text, maNV, globalMaKH, Daytxt.Text, ghetxt.Text, ref err);
                    dbDatVe.XuLyVe(txtMaVe.Text, globalMaNV, globalMaKH, Daytxt.Text, dtpNgay.Value.Date, Convert.ToInt32(ghetxt.Text), MaSC, txtGioKetThuc.Text, Convert.ToInt32(txtTien.Text.Trim()), cbGhiChu.Text, "Insert");
                    MessageBox.Show("thêm thành công!");
                    storedMaKH = globalMaKH;
                    btnReload_Click(sender,e);
                    txtMaVe.ResetText();
                }
                catch (Exception)
                {
                    MessageBox.Show("lỗi");
                }

            }
            else
            {
                MessageBox.Show("chưa hoàn thành đặt vé !");
            }
        }

        private void SetupcbGhiChu()
        {
            cbGhiChu.Items.Add("Sinh viên");
            cbGhiChu.Items.Add("Học sinh");
            cbGhiChu.Items.Add("Người lớn");
            cbGhiChu.SelectedIndex = 0;
        }
        private string findMaPhim(DataTable dt)
        {
            int i = 0;
            while (i < dt.Rows.Count && Phimcb.Text != dt.Rows[i].ItemArray[0].ToString())
            {
                i++;
            }
            return dt.Rows[i].ItemArray[1].ToString();
        }
        private void setMaKHcb()
        {
            dtKH = new DataTable();
            dtKH.Clear();
            DataSet ds = dbKhachHang.LayKhachHang();
            dtKH = ds.Tables[0];
            maKHcb.DataSource = dtKH;
            maKHcb.DisplayMember = "MaKH";
            maKHcb.ValueMember = "MaKH";
            globalMaKH = maKHcb.Text;
        }

        private void maKHcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (maKHcb.ValueMember == "") return;
            globalMaKH = maKHcb.Text;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            themFlag = false;
            Phimcb.Text = "";
            SuatChieucb.Text = "";
            maKHcb.Text = "";
            raptxt.Text = "";
            Daytxt.Text = "";
            ghetxt.Text = "";
            txtMaVe.ResetText();
            SuatChieucb.Enabled = false;
            nhanViencb.Text = "";
            Phimcb.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
        }
        private void XuLyGioKetThuc()
        {
            DataSet ds = dbPhim.TimPhim(Phimcb.Text.Trim());
            float ThoiLuong = Convert.ToInt64(ds.Tables[0].Rows[0].ItemArray[4].ToString());
            float Phut = ThoiLuong % 60;
            float Gio = ThoiLuong / 60;
            Gio = Convert.ToInt64(Math.Round(Convert.ToDouble(Gio)));
            //tách suất chiếu
            string[] container;
            string str = SuatChieucb.Text.ToString();
            container = str.ToLower().Split('h');
            foreach (var item in container)
            {
                if (item.Length<2)
                {
                    item.Insert(0,"0");
                }
            }
            //xử lí phút:
            float phutKetThuc = Phut + Convert.ToInt64(container[1]);
            float carry = 0;
            if (phutKetThuc>60)
            {
                carry = 1;
                phutKetThuc -= 60;
            }
            else if (phutKetThuc==60)
            {
                carry = 1;
                phutKetThuc = 0;
            }
            //xử lí giờ
            float gioKetThuc = Gio + Convert.ToInt64(container[0]);
            if (gioKetThuc+carry>24)
            {
                gioKetThuc = gioKetThuc - 24 + carry;
            }
            else if (gioKetThuc+carry==24)
            {
                gioKetThuc =0;
            }
            else
            {
                gioKetThuc += carry;
            }
            //join 2 vế
            
            if (phutKetThuc.ToString().Length<2)
            {
                //xử lí phút
                container[1] = phutKetThuc.ToString().Insert(0, "0");
            }
            else
            {
                container[1] = phutKetThuc.ToString();
            }
            if (gioKetThuc.ToString().Length<2)
            {
                container[0] = gioKetThuc.ToString().Insert(0, "0");
            }
            else
            {
                container[0] = gioKetThuc.ToString();
            }
            string final= string.Join(":", container);
            txtGioKetThuc.Text = final;
        }

        private void cbGhiChu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGhiChu.SelectedIndex==0)
            {
                txtTien.Text = "45000";
                TienVeLucDau = 45000;
                txtKhuyenMai.Text = "0";
            }
            else if (cbGhiChu.SelectedIndex==1)
            {
                txtTien.Text = "60000";
                TienVeLucDau = 60000;
                txtKhuyenMai.Text = "0";

            }
            else
            {
                txtTien.Text = "120000";
                TienVeLucDau = 120000;
                txtKhuyenMai.Text = "0";

            }
        }

        private void ckbKhuyeMai_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKhuyeMai.CheckState==CheckState.Checked)
            {
                txtKhuyenMai.Enabled=true;
                cbGhiChu.Enabled = false;
            }
            else
            {
                txtKhuyenMai.Enabled = false;
                cbGhiChu.Enabled = true;
            }
        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            if (txtKhuyenMai.Text!="")
            {
            txtTien.ResetText();
            DataSet ds= dbDatVe.TinhTienVe(TienVeLucDau,Convert.ToInt64(txtKhuyenMai.Text.Trim()));
            txtTien.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
