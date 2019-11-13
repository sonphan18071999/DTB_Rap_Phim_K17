using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;
using System.Linq;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLDatVe
    {
        DBMain db = null;
        public BLDatVe()
        {
            db = new DBMain();
        }
        public DataSet LayThongTinVe()
        {
            return db.ExecuteQueryDataSet("select * from DatVe",
                CommandType.Text);
        }

        public System.Data.Linq.Table<DatVe> LayThongTinVe1()
        {
            DataSet ds = new DataSet();
            QuanLyRapPhimDataClassesDataContext qlrp = new QuanLyRapPhimDataClassesDataContext();
            return qlrp.DatVes;
        }
        public List<DatVe> findBookedSeat(string MaRap, string tgChieu)
        {
            QuanLyRapPhimDataClassesDataContext qlrp = new QuanLyRapPhimDataClassesDataContext();

            var dvqr = (from dv in qlrp.DatVes where dv.MaRap == MaRap && dv.SuatChieu == tgChieu select dv);
            return dvqr.ToList();       
        }
        public IEnumerable<DataSet> findHour(string tgChieu)
        {
            QuanLyRapPhimDataClassesDataContext qlrp = new QuanLyRapPhimDataClassesDataContext();
            var findHourqr = qlrp.ExecuteQuery<DataSet>("select A.SuatChieu,B.TenPhim,B.MaPhim from DatVe as A inner join Phim as B on A.MaPhim = B.MaPhim");
            //return db.ExecuteQueryDataSet("select A.SuatChieu,B.TenPhim,B.MaPhim from DatVe as A inner join Phim as B on A.MaPhim = B.MaPhim", CommandType.Text);
            return findHourqr;

        }
        public bool themVe(string MaPhim, string Rap, string SuatChieu, string MaNV, string MaKH, string Day, string Ghe, ref string err)
        {
            string sqlString = $"Insert Into DatVe values('{MaPhim.Trim()}','{SuatChieu.Trim()}','{MaNV.Trim()}','{MaKH.Trim()}','{Rap.Trim()}','{Day.Trim()}','{Ghe.Trim()}')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaRap(ref string err, string MaRap)
        {
            string sqlString = "Delete From DatVe Where MaRap='" + MaRap + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
