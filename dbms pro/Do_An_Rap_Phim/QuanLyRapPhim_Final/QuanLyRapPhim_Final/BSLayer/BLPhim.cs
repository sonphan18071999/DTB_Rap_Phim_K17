﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;
using System.IO;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLPhim
    {
        DBMain db = null;
        public BLPhim()
        {
            db = new DBMain();
        }
        public DataSet LayPhim()
        {
            return db.ExecuteQueryDataSet("exec PhimInsertUpdateDelete null,null,0,null,0,'Select'", CommandType.Text);
        }
        public bool addPhim(string TenPhim, string MaPhim, int GiaVe, string Poster,float ThoiLuong, ref string err)
        {
            string sqlString = $"Insert Into Phim Values(N'{TenPhim.Trim()}','{MaPhim.Trim()}',{GiaVe}," +
                $"( select BulkColumn from Openrowset(Bulk '{Poster}', single_Blob) as image)," + $"{ThoiLuong})";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaPhim(ref string err, string MaPhim)
        {
            string sqlString = "Delete From Phim Where MaPhim='" + MaPhim + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatPhim(string MaPhim, string TenPhim,int GiaVe,string Poster,float thoiLuong, ref string err)
        {
            string sqlString = "Update Phim Set TenPhim=N'" + TenPhim + "', GiaVe=" + GiaVe + ", Poster=" + $"( select BulkColumn from Openrowset(Bulk '{Poster}', single_Blob) as image),ThoiLuong={thoiLuong}"+
                " Where MaPhim='" + MaPhim + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public virtual DataSet TimPhim(string TenPhim)
        {
            return db.ExecuteQueryDataSet($"select * from Phim where TenPhim=N'{TenPhim.Trim()}'", CommandType.Text);
        }
        public virtual DataSet TimPhim(int MaPhim)
        {
            return db.ExecuteQueryDataSet($"select * from Phim where MaPhim={MaPhim}", CommandType.Text);
        }
        public virtual DataSet SearchPhim(string TenPhim)
        {
            return db.ExecuteQueryDataSet($" SELECT * from PhimSearch(N'{TenPhim.Trim()}')", CommandType.Text);
        }
    }
}