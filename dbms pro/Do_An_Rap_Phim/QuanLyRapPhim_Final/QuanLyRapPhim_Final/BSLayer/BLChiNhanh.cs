using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLChiNhanh
    {
        DBMain db = null;
        public BLChiNhanh()
        {
            db = new DBMain();
        }
        public DataSet LayChiNanh()
        {
            return db.ExecuteQueryDataSet("exec ChiNhanhInsertUpdateDelete null,null,'Select'",
                CommandType.Text);
        }
        public DataSet XuLyChiNhanh(string MaChiNhanh,string TenChiNhanh,string State)
        {
            return db.ExecuteQueryDataSet($"exec ChiNhanhInsertUpdateDelete N'{MaChiNhanh.Trim()}',N'{TenChiNhanh.Trim()}','{State}'",
                CommandType.Text);
        }
    }
}
