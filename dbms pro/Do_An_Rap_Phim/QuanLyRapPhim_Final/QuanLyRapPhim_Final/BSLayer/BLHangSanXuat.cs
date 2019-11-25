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
        public DataSet XuLyNhanVien(string MaHSX,string TenHSX,string Mail,string DiaChi,string MaHD,string State)
        {
            return db.ExecuteQueryDataSet($"exec HangSanXuatInsertUpdateDelete N'{MaHSX}',N'{TenHSX}',N'{Mail}',N'{DiaChi}',N'{MaHD}','{State}'", CommandType.Text);
        }
    }
}
