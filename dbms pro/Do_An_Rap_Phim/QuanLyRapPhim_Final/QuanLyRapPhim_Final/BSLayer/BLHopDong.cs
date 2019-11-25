using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;
namespace QuanLyRapPhim_Final.BSLayer
{
    class BLHopDong
    {
        DBMain db = null;
        public BLHopDong()
        {
            db = new DBMain();
        }
        public DataSet LayHopDong()
        {
            return db.ExecuteQueryDataSet("exec PhimHopDongInsertUpdateDelete null,null,null,null,null,null,null,'Select'",CommandType.Text);
        }
        public DataSet XuLyHopDong(string MaHD,string DaoDien,int GiaTriHD,DateTime NgayXB,DateTime NgayKiHD,DateTime NgayHH,string MaPhim,string state)
        {
            return db.ExecuteQueryDataSet($"exec PhimHopDongInsertUpdateDelete N'{MaHD}',N'{DaoDien}',{GiaTriHD},'{NgayXB}','{NgayKiHD}','{NgayHH}',N'{MaPhim}','{state}'", CommandType.Text);
        }
    }
}
