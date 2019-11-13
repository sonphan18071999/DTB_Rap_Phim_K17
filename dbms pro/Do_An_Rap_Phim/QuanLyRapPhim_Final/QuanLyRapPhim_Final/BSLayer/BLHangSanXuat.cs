using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;
namespace QuanLyRapPhim_Final.BSLayer
{
    class BLHangSanXuat
    {
        DBMain db = null;
        public BLHangSanXuat()
        {
            db = new DBMain();
        }
        public DataSet LayHangSanXuat()
        {
            return db.ExecuteQueryDataSet("Select * from HangSanXuat",
                CommandType.Text);
        }
    }
}
