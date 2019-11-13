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
            return db.ExecuteQueryDataSet("select * from ChiNhanh",
                CommandType.Text);
        }
    }
}
