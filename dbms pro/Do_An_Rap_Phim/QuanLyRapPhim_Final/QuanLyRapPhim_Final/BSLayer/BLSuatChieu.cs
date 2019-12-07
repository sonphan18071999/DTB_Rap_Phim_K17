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
            return db.ExecuteQueryDataSet("exec SuatChieuPhimInsertUpdateDelete null,null,null,null,'Select'", CommandType.Text);
        }
        public DataSet LaySuatChieuCuaPhim(string MaPhim)
        {
            return db.ExecuteQueryDataSet($"select * from SuatChieuPhim where MaPhim='{MaPhim.Trim()}'", CommandType.Text);
        }
        public bool ThemSuatChieu(string MaPhim, string SuatChieu, string MaRap,string MaSC, ref string err)
        {
            string sqlString = $"exec SuatChieuPhimInsertUpdateDelete N'{MaPhim}',N'{SuatChieu}',N'{MaRap}',N'{MaSC}','Insert'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaSuatChieu(ref string err, string MaSC)
        {
            string sqlString = $"exec SuatChieuPhimInsertUpdateDelete null,null,null,N'{MaSC}','Delete'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSuatChieu(string MaPhim, string SuatChieu, string MaRap,string MaSC,ref string err)
        {
            string sqlString = $"exec SuatChieuPhimInsertUpdateDelete N'{MaPhim}',N'{SuatChieu}',N'{MaRap}',N'{MaSC}','Update'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
