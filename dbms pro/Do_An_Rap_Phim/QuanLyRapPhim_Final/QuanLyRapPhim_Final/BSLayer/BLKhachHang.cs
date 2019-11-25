using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLKhachHang
    {
        DBMain db = null;
        public BLKhachHang()
        {
            db = new DBMain();
        }
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet("" +
                "select * from KhachHang", 
                CommandType.Text);
        }
        public bool ThemKhachHang(string MaKH, string HovaTenLotKH, 
            string TenKH,DateTime ngaySinh,int tichDiem, ref string err)
        {
            string sqlString = $"exec KhachHangInsertUpdateDelete N'{MaKH}',N'{HovaTenLotKH}',N'{TenKH}','{ngaySinh}',{tichDiem},'Insert'";
            return db.MyExecuteNonQuery(sqlString,
                CommandType.Text, ref err);
        }
        public bool XoaKhachHang(ref string err, string MaKH)
        {
            string sqlString = $"exec KhachHangInsertUpdateDelete N'{MaKH}',null,null,null,null,'Delete'";
            return db.MyExecuteNonQuery(sqlString, 
                CommandType.Text, ref err);
        }
        public bool CapNhatKhachHang(string MaKH, string HovaTenLotKH,
            string TenKH, DateTime ngaySinh, int tichDiem, ref string err)
        {
            string sqlString = $"exec KhachHangInsertUpdateDelete N'{MaKH}',N'{HovaTenLotKH}',N'{TenKH}','{ngaySinh}',{tichDiem},'Update'"; 
            return db.MyExecuteNonQuery(sqlString, 
                CommandType.Text, ref err);
        }
    }
}