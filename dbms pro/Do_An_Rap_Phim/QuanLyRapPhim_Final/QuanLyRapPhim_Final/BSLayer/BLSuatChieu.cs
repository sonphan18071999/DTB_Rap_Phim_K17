using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLSuatChieu
    {
        DBMain db = null;
        public BLSuatChieu()
        {
            db = new DBMain();
        }
        public DataSet LaySuatChieu()
        {
            return db.ExecuteQueryDataSet("select * from SuatChieuPhim", CommandType.Text);
        }
        public DataSet LaySuatChieuCuaPhim(string MaPhim)
        {
            return db.ExecuteQueryDataSet($"select * from SuatChieuPhim where MaPhim='{MaPhim.Trim()}'", CommandType.Text);
        }
        public bool ThemSuatChieu(string MaPhim, string SuatChieu, string MaRap,string MaSC, ref string err)
        {
            string sqlString = "Insert Into SuatChieuPhim Values(" + "'" + MaPhim + "',N'" +
                 SuatChieu + "',N'" + MaRap +  "',"+"N'"+MaSC+ "')";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaSuatChieu(ref string err, string MaSC)
        {
            string sqlString = "Delete From SuatChieuPhim Where MaSC=N'" + MaSC + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSuatChieu(string MaPhim, string SuatChieu, string MaRap,string MaSC,ref string err)
        {
            string sqlString = "Update SuatChieuPhim Set "+ "MaPhim=N'"+MaPhim + "',GioChieu=N'" + SuatChieu + "',MaRap='"+MaRap+ "' Where MaSC=N'"
                + MaSC + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
