using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhim_Final.BSLayer;
namespace QuanLyRapPhim_Final
{
    public partial class Login : Form
    {
        BLDangNhap dbDangNhap = new BLDangNhap();
        BLChucVu dbChucVu = new BLChucVu();
        BLNhanVien dbNhanVien = new BLNhanVien();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button_LOGIN_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                return;
            }
            else
            {
                dbDangNhap.Decrypt(txtUsername.Text.Trim());

                DataSet ds = dbDangNhap.FindUser(txtUsername.Text, txtPassword.Text);
                dbDangNhap.Encrypt(txtUsername.Text.Trim());

                if (ds.Tables[0].Rows.Count>0)
                {
                    DataSet ds1 = dbNhanVien.LayChucVuNV(txtUsername.Text);
                    if (ds1.Tables[0].Rows.Count>0)
                    {
                        Program.ChucVuUser = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
                        Program.UserName = txtUsername.Text;
                        this.Hide();

                        User us = new User();
                        us.MaNV = txtUsername.Text.Trim();
                        Form1 mainform = new Form1(us.MaNV);
                        mainform.ShowDialog();
                        this.Close();
                        //this.ShowInTaskbar = false;
                      
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thât bại", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pnDoiMatKhau.Visible = true;
            pnDoiMatKhau.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
                {
                    return;
                }
                else
                {
                    dbDangNhap.Decrypt(txtUsername.Text.Trim());

                    DataSet ds = dbDangNhap.FindUser(txtUsername.Text, txtPassword.Text);
                    dbDangNhap.Encrypt(txtUsername.Text.Trim());
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataSet ds1 = dbNhanVien.LayChucVuNV(txtUsername.Text);
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            Program.ChucVuUser = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
                            Program.UserName = txtUsername.Text;
                            MessageBox.Show("đăng nhập thành công.", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            User us = new User();
                            us.MaNV = txtUsername.Text;
                            Form1 mainform = new Form1(us.MaNV);
                            mainform.ShowDialog();
                            this.Close();
                            //this.ShowInTaskbar = false;

                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thât bại", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }
                }
            }
        }
    }

}
