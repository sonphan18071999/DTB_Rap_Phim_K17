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
        BLHangSanXuat dbHSX = null;
        public QuanLyHangSanXuatUC()
        {
            InitializeComponent();
        }
    }
}
