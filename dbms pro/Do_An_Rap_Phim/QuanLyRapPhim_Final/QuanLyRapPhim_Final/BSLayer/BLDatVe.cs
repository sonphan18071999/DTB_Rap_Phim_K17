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
            return db.ExecuteQueryDataSet("exec DatVeInsertUpdateDelete null,null,null,null,null,null,null,null,'Select'",
                CommandType.Text);
        }

        public System.Data.Linq.Table<DatVe> LayThongTinVe1()
        {
            DataSet ds = new DataSet();
            QuanLyRapPhimDataClassesDataContext qlrp = new QuanLyRapPhimDataClassesDataContext();
            return qlrp.DatVes;
        }
        public DataSet GetBookedSeat(string MaPhim,string MaRap,string tgChieu)
        {
            string sqlString = $"select Day,So from (select MaSC from SuatChieuPhim where MaPhim = N'{MaPhim}' and MaRap = N'{MaRap}' and GioChieu=N'{tgChieu}') as a inner join DatVe as b on a.MaSC = b.MaSC";
            return db.ExecuteQueryDataSet(sqlString,
                CommandType.Text);
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
        public DataSet LayMaVe()
        {
            string sqlString = "select MAX(MaVe) from DatVe";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public DataSet XuLyVe(string MaVe,string MaNV,string MaKH,string Day,DateTime Ngay,int So,string MaSC,string GioKetThuc,float Gia,string GhiChu,string State)
        {
            return db.ExecuteQueryDataSet($"exec DatVeInsertUpdateDelete N'{MaVe.Trim()}',N'{MaNV.Trim()}',N'{MaKH.Trim()}','{Day.Trim()}','{Ngay}',{So},N'{MaSC.Trim()}','{GioKetThuc.Trim()}',{Gia},N'{GhiChu}','Insert'", CommandType.Text);
        }
        public DataSet TinhTienVe(float TienVe,float KhuyenMai)
        {
            return db.ExecuteQueryDataSet($"select [dbo].TinhTienVe({TienVe},{KhuyenMai})", CommandType.Text);

        }
        public string TangMaVe()
        {
            string result =  db.ExecuteQueryDataSet($"select MAX(MaVe) from DatVe ", CommandType.Text).Tables[0].Rows[0].ItemArray[0].ToString();
            if (result =="")
            {
                return "1";
            }
            else
            {
                int convertedResult = Convert.ToInt32(result)+1;
                return convertedResult.ToString();
            }
        }
    }
}
