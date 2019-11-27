using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLNhanVien
    {
        DBMain db = null;
        public BLNhanVien()
        {
            db = new DBMain();
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("exec NhanVienInsertUpdateDelete null,null,null,null,null,null,null,'Select'",
                CommandType.Text);
        }
        public bool ThemNhanVien(string MaNV, string HovaTenLotNV,
            string TenNV, string MaCV,int soGioLam,string MaNQL,string ChiNhanh,ref string err)
        {
            if (MaNQL=="")
            {
                string sqlString = $"exec NhanVienInsertUpdateDelete N'{HovaTenLotNV}',N'{TenNV}','{MaNV}','{MaCV}',{soGioLam},null,N'{ChiNhanh}','Insert'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

            }
            else
            {
                string sqlString = $"exec NhanVienInsertUpdateDelete N'{HovaTenLotNV}',N'{TenNV}','{MaNV}','{MaCV}',{soGioLam},'{MaNQL}',N'{ChiNhanh}','Insert'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            }
        }
        public bool XoaNhanVien(ref string err, string MaNV)
        {
            string sqlString = $"exec NhanVienInsertUpdateDelete null,null,N'{MaNV}',null,null,null,null,'Delete'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNhanVien( string HovaLot,string TenNV,string MaCV,string MaNV,int GioLam,string NguoiQL,string chiNhanh, ref string err)
        {
            string sqlString = $"exec NhanVienInsertUpdateDelete N'{HovaLot}',N'{TenNV}',N'{MaNV}',N'{MaCV}',{GioLam},N'{NguoiQL}',N'{chiNhanh}','Update'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet LayNguoiQuanLy(string MaCV)
        {
            return db.ExecuteQueryDataSet($"select MaNV,(HovaLotNV+' '+TenNV) as FullName from NhanVien where MaCV=N'{MaCV}'", CommandType.Text);
        }
        public virtual DataSet TimKiemNhanVien(string Ten)
        {
            return db.ExecuteQueryDataSet("select * " +
                "from NhanVien where TenNV=N'" + Ten + "'", CommandType.Text);
        }
        public DataSet LayChucVuNV(string MaNV)
        {
            return db.ExecuteQueryDataSet($"select MaCV from NhanVien where MaNV=N'{MaNV.Trim()}'", CommandType.Text);
        }
    }
}