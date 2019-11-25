﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyRapPhim_Final
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyRapPhimEntities : DbContext
    {
        public QuanLyRapPhimEntities()
            : base("name=QuanLyRapPhimEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<ChiNhanhInsertUpdateDelete_Result> ChiNhanhInsertUpdateDelete(string maChiNhanh, string tenChiNanh, string statementType)
        {
            var maChiNhanhParameter = maChiNhanh != null ?
                new ObjectParameter("MaChiNhanh", maChiNhanh) :
                new ObjectParameter("MaChiNhanh", typeof(string));
    
            var tenChiNanhParameter = tenChiNanh != null ?
                new ObjectParameter("TenChiNanh", tenChiNanh) :
                new ObjectParameter("TenChiNanh", typeof(string));
    
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ChiNhanhInsertUpdateDelete_Result>("ChiNhanhInsertUpdateDelete", maChiNhanhParameter, tenChiNanhParameter, statementTypeParameter);
        }
    
        public virtual ObjectResult<ChucVuInsertUpdateDelete_Result> ChucVuInsertUpdateDelete(string maCV, string chucVu, Nullable<int> luong, string statementType)
        {
            var maCVParameter = maCV != null ?
                new ObjectParameter("MaCV", maCV) :
                new ObjectParameter("MaCV", typeof(string));
    
            var chucVuParameter = chucVu != null ?
                new ObjectParameter("ChucVu", chucVu) :
                new ObjectParameter("ChucVu", typeof(string));
    
            var luongParameter = luong.HasValue ?
                new ObjectParameter("Luong", luong) :
                new ObjectParameter("Luong", typeof(int));
    
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ChucVuInsertUpdateDelete_Result>("ChucVuInsertUpdateDelete", maCVParameter, chucVuParameter, luongParameter, statementTypeParameter);
        }
    
        public virtual ObjectResult<DangNhapInsertUpdateDelete_Result> DangNhapInsertUpdateDelete(string maNV, string matKhau, string statementType)
        {
            var maNVParameter = maNV != null ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(string));
    
            var matKhauParameter = matKhau != null ?
                new ObjectParameter("MatKhau", matKhau) :
                new ObjectParameter("MatKhau", typeof(string));
    
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DangNhapInsertUpdateDelete_Result>("DangNhapInsertUpdateDelete", maNVParameter, matKhauParameter, statementTypeParameter);
        }
    
        public virtual ObjectResult<DatVeInsertUpdateDelete_Result> DatVeInsertUpdateDelete(string maVe, string maNV, string maKH, string day, Nullable<System.DateTime> ngay, Nullable<int> so, string maSC, Nullable<System.TimeSpan> gioKetThuc, string statementType)
        {
            var maVeParameter = maVe != null ?
                new ObjectParameter("MaVe", maVe) :
                new ObjectParameter("MaVe", typeof(string));
    
            var maNVParameter = maNV != null ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(string));
    
            var maKHParameter = maKH != null ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(string));
    
            var dayParameter = day != null ?
                new ObjectParameter("Day", day) :
                new ObjectParameter("Day", typeof(string));
    
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("Ngay", ngay) :
                new ObjectParameter("Ngay", typeof(System.DateTime));
    
            var soParameter = so.HasValue ?
                new ObjectParameter("So", so) :
                new ObjectParameter("So", typeof(int));
    
            var maSCParameter = maSC != null ?
                new ObjectParameter("MaSC", maSC) :
                new ObjectParameter("MaSC", typeof(string));
    
            var gioKetThucParameter = gioKetThuc.HasValue ?
                new ObjectParameter("GioKetThuc", gioKetThuc) :
                new ObjectParameter("GioKetThuc", typeof(System.TimeSpan));
    
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DatVeInsertUpdateDelete_Result>("DatVeInsertUpdateDelete", maVeParameter, maNVParameter, maKHParameter, dayParameter, ngayParameter, soParameter, maSCParameter, gioKetThucParameter, statementTypeParameter);
        }
    
        public virtual ObjectResult<HangSanXuatInsertUpdateDelete_Result> HangSanXuatInsertUpdateDelete(string maHSX, string tenHSX, string email, string diaChi, string maHD, string statementType)
        {
            var maHSXParameter = maHSX != null ?
                new ObjectParameter("MaHSX", maHSX) :
                new ObjectParameter("MaHSX", typeof(string));
    
            var tenHSXParameter = tenHSX != null ?
                new ObjectParameter("TenHSX", tenHSX) :
                new ObjectParameter("TenHSX", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            var maHDParameter = maHD != null ?
                new ObjectParameter("MaHD", maHD) :
                new ObjectParameter("MaHD", typeof(string));
    
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HangSanXuatInsertUpdateDelete_Result>("HangSanXuatInsertUpdateDelete", maHSXParameter, tenHSXParameter, emailParameter, diaChiParameter, maHDParameter, statementTypeParameter);
        }
    
        public virtual ObjectResult<KhachHangInsertUpdateDelete_Result> KhachHangInsertUpdateDelete(string maKH, string hovaLotKH, string tenKH, Nullable<System.DateTime> ngaySinh, Nullable<int> tichDiem, string statementType)
        {
            var maKHParameter = maKH != null ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(string));
    
            var hovaLotKHParameter = hovaLotKH != null ?
                new ObjectParameter("HovaLotKH", hovaLotKH) :
                new ObjectParameter("HovaLotKH", typeof(string));
    
            var tenKHParameter = tenKH != null ?
                new ObjectParameter("TenKH", tenKH) :
                new ObjectParameter("TenKH", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("NgaySinh", ngaySinh) :
                new ObjectParameter("NgaySinh", typeof(System.DateTime));
    
            var tichDiemParameter = tichDiem.HasValue ?
                new ObjectParameter("TichDiem", tichDiem) :
                new ObjectParameter("TichDiem", typeof(int));
    
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KhachHangInsertUpdateDelete_Result>("KhachHangInsertUpdateDelete", maKHParameter, hovaLotKHParameter, tenKHParameter, ngaySinhParameter, tichDiemParameter, statementTypeParameter);
        }
    
        public virtual ObjectResult<NhanVienInsertUpdateDelete_Result> NhanVienInsertUpdateDelete(string hovaLotNV, string tenNV, string maNV, string maCV, Nullable<int> soGioLam, string maNQL, string maChiNhanh, string statementType)
        {
            var hovaLotNVParameter = hovaLotNV != null ?
                new ObjectParameter("HovaLotNV", hovaLotNV) :
                new ObjectParameter("HovaLotNV", typeof(string));
    
            var tenNVParameter = tenNV != null ?
                new ObjectParameter("TenNV", tenNV) :
                new ObjectParameter("TenNV", typeof(string));
    
            var maNVParameter = maNV != null ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(string));
    
            var maCVParameter = maCV != null ?
                new ObjectParameter("MaCV", maCV) :
                new ObjectParameter("MaCV", typeof(string));
    
            var soGioLamParameter = soGioLam.HasValue ?
                new ObjectParameter("SoGioLam", soGioLam) :
                new ObjectParameter("SoGioLam", typeof(int));
    
            var maNQLParameter = maNQL != null ?
                new ObjectParameter("MaNQL", maNQL) :
                new ObjectParameter("MaNQL", typeof(string));
    
            var maChiNhanhParameter = maChiNhanh != null ?
                new ObjectParameter("MaChiNhanh", maChiNhanh) :
                new ObjectParameter("MaChiNhanh", typeof(string));
    
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhanVienInsertUpdateDelete_Result>("NhanVienInsertUpdateDelete", hovaLotNVParameter, tenNVParameter, maNVParameter, maCVParameter, soGioLamParameter, maNQLParameter, maChiNhanhParameter, statementTypeParameter);
        }
    
        public virtual ObjectResult<PhimHopDongInsertUpdateDelete_Result> PhimHopDongInsertUpdateDelete(string maHD, string daoDien, Nullable<int> giaTriHD, Nullable<System.DateTime> ngayXuatBan, Nullable<System.DateTime> ngayKyHopDong, Nullable<System.DateTime> ngayHetHan, string maPhim, string statementType)
        {
            var maHDParameter = maHD != null ?
                new ObjectParameter("MaHD", maHD) :
                new ObjectParameter("MaHD", typeof(string));
    
            var daoDienParameter = daoDien != null ?
                new ObjectParameter("DaoDien", daoDien) :
                new ObjectParameter("DaoDien", typeof(string));
    
            var giaTriHDParameter = giaTriHD.HasValue ?
                new ObjectParameter("GiaTriHD", giaTriHD) :
                new ObjectParameter("GiaTriHD", typeof(int));
    
            var ngayXuatBanParameter = ngayXuatBan.HasValue ?
                new ObjectParameter("NgayXuatBan", ngayXuatBan) :
                new ObjectParameter("NgayXuatBan", typeof(System.DateTime));
    
            var ngayKyHopDongParameter = ngayKyHopDong.HasValue ?
                new ObjectParameter("NgayKyHopDong", ngayKyHopDong) :
                new ObjectParameter("NgayKyHopDong", typeof(System.DateTime));
    
            var ngayHetHanParameter = ngayHetHan.HasValue ?
                new ObjectParameter("NgayHetHan", ngayHetHan) :
                new ObjectParameter("NgayHetHan", typeof(System.DateTime));
    
            var maPhimParameter = maPhim != null ?
                new ObjectParameter("MaPhim", maPhim) :
                new ObjectParameter("MaPhim", typeof(string));
    
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PhimHopDongInsertUpdateDelete_Result>("PhimHopDongInsertUpdateDelete", maHDParameter, daoDienParameter, giaTriHDParameter, ngayXuatBanParameter, ngayKyHopDongParameter, ngayHetHanParameter, maPhimParameter, statementTypeParameter);
        }
    
        public virtual ObjectResult<PhimInsertUpdateDelete_Result> PhimInsertUpdateDelete(string tenPhim, string maPhim, Nullable<int> giaVe, byte[] poster, Nullable<double> thoiLuong, string statementType)
        {
            var tenPhimParameter = tenPhim != null ?
                new ObjectParameter("TenPhim", tenPhim) :
                new ObjectParameter("TenPhim", typeof(string));
    
            var maPhimParameter = maPhim != null ?
                new ObjectParameter("MaPhim", maPhim) :
                new ObjectParameter("MaPhim", typeof(string));
    
            var giaVeParameter = giaVe.HasValue ?
                new ObjectParameter("GiaVe", giaVe) :
                new ObjectParameter("GiaVe", typeof(int));
    
            var posterParameter = poster != null ?
                new ObjectParameter("Poster", poster) :
                new ObjectParameter("Poster", typeof(byte[]));
    
            var thoiLuongParameter = thoiLuong.HasValue ?
                new ObjectParameter("ThoiLuong", thoiLuong) :
                new ObjectParameter("ThoiLuong", typeof(double));
    
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PhimInsertUpdateDelete_Result>("PhimInsertUpdateDelete", tenPhimParameter, maPhimParameter, giaVeParameter, posterParameter, thoiLuongParameter, statementTypeParameter);
        }
    
        public virtual ObjectResult<RapInsertUpdateDelete_Result> RapInsertUpdateDelete(string maRap, string soDayGhe, string soLuongGhe, string loaiPhim, string statementType)
        {
            var maRapParameter = maRap != null ?
                new ObjectParameter("MaRap", maRap) :
                new ObjectParameter("MaRap", typeof(string));
    
            var soDayGheParameter = soDayGhe != null ?
                new ObjectParameter("SoDayGhe", soDayGhe) :
                new ObjectParameter("SoDayGhe", typeof(string));
    
            var soLuongGheParameter = soLuongGhe != null ?
                new ObjectParameter("SoLuongGhe", soLuongGhe) :
                new ObjectParameter("SoLuongGhe", typeof(string));
    
            var loaiPhimParameter = loaiPhim != null ?
                new ObjectParameter("LoaiPhim", loaiPhim) :
                new ObjectParameter("LoaiPhim", typeof(string));
    
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RapInsertUpdateDelete_Result>("RapInsertUpdateDelete", maRapParameter, soDayGheParameter, soLuongGheParameter, loaiPhimParameter, statementTypeParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<SuatChieuPhimInsertUpdateDelete_Result> SuatChieuPhimInsertUpdateDelete(string maPhim, string gioChieu, string maRap, string maSC, string statementType)
        {
            var maPhimParameter = maPhim != null ?
                new ObjectParameter("MaPhim", maPhim) :
                new ObjectParameter("MaPhim", typeof(string));
    
            var gioChieuParameter = gioChieu != null ?
                new ObjectParameter("GioChieu", gioChieu) :
                new ObjectParameter("GioChieu", typeof(string));
    
            var maRapParameter = maRap != null ?
                new ObjectParameter("MaRap", maRap) :
                new ObjectParameter("MaRap", typeof(string));
    
            var maSCParameter = maSC != null ?
                new ObjectParameter("MaSC", maSC) :
                new ObjectParameter("MaSC", typeof(string));
    
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SuatChieuPhimInsertUpdateDelete_Result>("SuatChieuPhimInsertUpdateDelete", maPhimParameter, gioChieuParameter, maRapParameter, maSCParameter, statementTypeParameter);
        }
    }
}