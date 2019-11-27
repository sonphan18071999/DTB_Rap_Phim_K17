using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
namespace QuanLyRapPhim_Final.BSLayer
{
    class BLDangNhap
    {
        DBMain db = null;
        public BLDangNhap()
        {
            db = new DBMain();
        }
        public DataSet XuLyDangNhap(string MaNV,string Pas,string state)
        {
            return db.ExecuteQueryDataSet($"exec DangNhapInsertUpdateDelete N'{MaNV.Trim()}',N'{Pas.Trim()}','{state.Trim()}'",
                CommandType.Text);
        }
        public DataSet FindUser(string MaNV, string Pas)
        {
            return db.ExecuteQueryDataSet($"select * from DangNhap where MaNV=N'{MaNV.Trim()}'and MatKhau=N'{Pas.Trim()}'",
                CommandType.Text);
        }
    }
}
