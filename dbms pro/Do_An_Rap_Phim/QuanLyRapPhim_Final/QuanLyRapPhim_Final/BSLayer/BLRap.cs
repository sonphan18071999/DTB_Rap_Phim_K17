using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLRap
    {
        DBMain db = null;
        public BLRap()
        {
            db = new DBMain();
        }
        public DataSet LayRap()
        {
            return db.ExecuteQueryDataSet("exec RapInsertUpdateDelete null,null,null,null,'Select'",
                CommandType.Text);
        }
        public bool ThemRap(string MaRap, string SoDayGhe, 
            string SoLuongGhe,string LoaiRap, ref string err)
        {
            string sqlString = $"exec RapInsertUpdateDelete N'{MaRap}',N'{SoDayGhe}',N'{SoLuongGhe}',N'{LoaiRap}','Insert'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaRap(ref string err, string MaRap)
        {
            string sqlString = $"exec RapInsertUpdateDelete N'{MaRap}',null,null,null,'Delete'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatRap(string MaRap, string SoDayGhe,string SoLuongGhe,string LoaiPhim, ref string err)
        {
            string sqlString = $"exec RapInsertUpdateDelete N'{MaRap}',N'{SoDayGhe}',N'{SoLuongGhe}',N'{LoaiPhim}','Update'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet findRap(string MaRap)
        {
            return db.ExecuteQueryDataSet
                ($"select MaRap from Rap where MaRap='" +
                $"{MaRap.Trim()}'", CommandType.Text);
        }
        public DataSet findSoDayGhe(string MaRap)
        {
            return db.ExecuteQueryDataSet
                ($"select SoDayGhe from Rap where MaRap='" +
                $"{MaRap.Trim()}'", CommandType.Text);
        }
        public DataSet findSoLuongGhe(string MaRap)
        {
            return db.ExecuteQueryDataSet
                ($"select SoLuongGhe from Rap where MaRap='" +
                $"{MaRap.Trim()}'", CommandType.Text);
        }
    }
}