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
        public DataSet DoanhThu(string ChiNhanh,DateTime Ngay)
        {
            return db.ExecuteQueryDataSet($"select [dbo].TinhDoanhThuTrongNgay('{Ngay}',N'{ChiNhanh.Trim()}') as [DoanhThuTrongNgay]", CommandType.Text);
        }
        public DataSet DoanhThuPhim(string ChiNhanh, DateTime Ngay,string MaPhim,string TinhNgay)
        {
            if (TinhNgay !="NULL")
            {
            return db.ExecuteQueryDataSet($"select [dbo].TinhDoanhThuTheoPhim('{Ngay}',N'{ChiNhanh.Trim()}',N'{MaPhim.Trim()}') as [DoanhThu]", CommandType.Text);
            }
            else
            {
                return db.ExecuteQueryDataSet($"select [dbo].TinhDoanhThuTheoPhim(default,N'{ChiNhanh.Trim()}',N'{MaPhim.Trim()}') as [DoanhThu]", CommandType.Text);
            }
        }
    }
}
