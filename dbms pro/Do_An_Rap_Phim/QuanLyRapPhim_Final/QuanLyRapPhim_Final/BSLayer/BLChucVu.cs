using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLChucVu
    {
        DBMain db = null;
        public BLChucVu()
        {
            db = new DBMain();
        }
        public DataSet LayChucVu()
        {
            return db.ExecuteQueryDataSet("exec ChucVuInsertUpdateDelete null,null,0,'Select'",
                CommandType.Text);
        }
        public bool ThemChucVu(string MaCV, string ChucVu,
            int Luong, ref string err)
        {
            string sqlString =
                $"ChucVuInsertUpdateDelete N'{MaCV}',N'{ChucVu}',{Luong},'Insert'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaChucVu(ref string err, string MaCV)
        {
            string sqlString = $"ChucVuInsertUpdateDelete N'{MaCV}',null,0,'Delete'"; ;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatChucVu(string MaCV, string ChucVu,int Luong, ref string err)
        {
            string sqlString = $"ChucVuInsertUpdateDelete N'{MaCV}',N'{ChucVu}',{Luong},'Update'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
