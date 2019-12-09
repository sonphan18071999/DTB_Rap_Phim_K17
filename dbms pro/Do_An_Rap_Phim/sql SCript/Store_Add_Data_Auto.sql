use QuanLyRapPhim;
go
create proc add_auto_Values
as
begin 
declare @dem int =0;
declare @alphabet  nvarchar(20)='ABCDEFGHIJKLMNOPQRSTUVWXYZ' ;
declare @tenhsx nvarchar(20) ;
declare @email nvarchar(20) ;
declare @diachi nvarchar(20) ;
declare @mahsx nvarchar(50) ;
declare @temp nvarchar(50) ;	
	while(@dem<20000)
	begin
	select @temp=
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1);
	set @tenhsx=@temp;
	set @email=@temp;
	set @diachi=@temp;
	set @mahsx=@dem;
	insert into HangSanXuat(MaHSX,TenHSX,Email,DiaChi)
	values(cast(@mahsx as nvarchar),cast(@tenhsx as nvarchar),cast(@email as nvarchar),cast(@diachi as nvarchar))
	set @dem=@dem+1;
	end;
end

--delete HangSanXuat
exec add_auto_Values
---1

create proc add_auto_Values_ChiNhanh
as
begin 
declare @dem int =0;
declare @alphabet  nvarchar(20)='ABCDEFGHIJKLMNOPQRSTUVWXYZ' ;
declare @tenchinhanh nvarchar(20) ;
declare @machinhanh nvarchar(50) ;
declare @temp nvarchar(50) ;	
	while(@dem<200)
	begin
	select @temp=
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1);
	set @tenchinhanh='Sai Gon '+@temp;
	if @dem%2=1
		begin 
		set @tenchinhanh='Ha Noi '+@temp;
		end
	set @machinhanh=@dem;
	insert into ChiNhanh(MaChiNhanh,TenChiNanh)
	values(CAST(@machinhanh as int),cast(@tenchinhanh as nvarchar))
	set @dem=@dem+1;
	end;
end

exec add_auto_Values_ChiNhanh
--delete ChiNhanh

--2
create proc add_auto_Values_ChucVu
as
begin 
declare @dem int =1;
declare @alphabet  nvarchar(20)='ABCDEFGHIJKLMNOPQRSTUVWXYZ' ;
declare @macv nvarchar(20) ;
declare @chucvu nvarchar(50) ;

declare @temp nvarchar(50) ;	
	while(@dem<=3)
	begin
	select @temp=
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1);
	if @dem%3=1
		begin 
		set @chucvu='super admin';
		end
	else if @dem%3=2
		begin 
		set @chucvu='admin';
		end
	else
		begin
			set @chucvu='employee';
		end
	set @macv=@dem;
	insert into ChucVu(MaCV,ChucVu)
	values(CAST(@macv as int),cast(@chucvu as nvarchar))
	set @dem=@dem+1;
	end;
end

exec add_auto_Values_ChucVu
--delete ChucVu



--3. Khach hàng
create proc add_auto_Values_KhachHang
as
begin 
declare @dem int =1;
declare @alphabet  nvarchar(20)='ABCDEFGHIJKLMNOPQRSTUVWXYZ' ;
declare @makh nvarchar(50) ;
declare @hovalotkh nvarchar(50) ;
declare @tenkh nvarchar(10) ;

declare @temp nvarchar(50) ;	
	while(@dem<200)
	begin
	select @temp=
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1);
	set @makh=@dem;
	set @hovalotkh=@temp;
	set @tenkh=@temp;
	insert into KhachHang(MaKH,HovaLotKH,TenKH)
	values(CAST(@makh as nvarchar),cast(@hovalotkh as nvarchar),cast(@tenkh as nvarchar))
	set @dem=@dem+1;
	end;
end
exec add_auto_Values_KhachHang
--delete KhachHang
use QuanLyRapPhim
--4 Nhan vien
alter proc add_auto_Values_NhanVien
as
begin 
declare @dem int =1;
declare @temp nvarchar(50) ;	
declare @alphabet  nvarchar(20)='ABCDEFGHIJKLMNOPQRSTUVWXYZ' ;
declare @hovalotnv nvarchar(50) ;
declare @tennv nvarchar(50) ;
declare @manv nvarchar(50) ;
declare @macv nvarchar(50) ;
declare @manql nvarchar(50);
declare @machinhanh nvarchar(50) ;
declare @demtemp int =1;

	while(@dem<200)
	begin
	select @temp=
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1);
	set @hovalotnv=@temp;
	set @tennv=@temp;
	set @manql=@temp;
	if @demtemp=3
		begin 
		set @demtemp=1;
		end
	set @manv=N'NV'+cast(@dem as nvarchar);
	insert into NhanVien(HovaLotNV,TenNV,MaNV)
	values(CAST(@hovalotnv as nvarchar),cast(@tennv as nvarchar),cast(@manv as nvarchar))
	update NhanVien set MaCV=ChucVu.MaCV from ChucVu where  NhanVien.MaNV=@manv and ChucVu.MaCV=@demtemp
	update NhanVien set NhanVien.MaChiNhanh=ChiNhanh.MaChiNhanh from ChiNhanh where ChiNhanh.MaChiNhanh=@dem and NhanVien.MaNV=@manv
	set @dem=@dem+1;
	set @demtemp=@demtemp+1;
	end;	
end;
exec add_auto_Values_NhanVien
--delete NhanVien
 insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Phan','Son','AD1','2',NULL,NULL,1)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Phan','Son','AD0','2',NULL,NULL,1)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Minh','Tien','AD2','2',NULL,NULL,1)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Minh','Tien','AD03','2',NULL,NULL,2)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Phan','Son','AD4','2',NULL,NULL,1)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Phan','Son','AD5','2',NULL,NULL,1)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Minh','Tien','A6','2',NULL,NULL,1)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Minh','Tien','AD7','2',NULL,NULL,2)

  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Phan','Son','QL1','3',NULL,NULL,1)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Phan','Son','QL2','3',NULL,NULL,1)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Minh','Tien','QL3','3',NULL,NULL,1)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Minh','Tien','QL4','3',NULL,NULL,2)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Phan','Son','QL5','3',NULL,NULL,1)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Phan','Son','QL6','3',NULL,NULL,1)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Minh','Tien','QL7','3',NULL,NULL,1)
  insert into NhanVien(HovaLotNV,TenNV,MaNV,MaCV,SoGioLam,MaNQL,MaChiNhanh)
 values('Minh','Tien','QL8','3',NULL,NULL,2)
--delete NhanVien
--delete DatVe


---5.Bang dang nhap
create proc add_auto_Values_DangNhap
as
begin 
declare @dem int =1;
declare @alphabet  nvarchar(20)='ABCDEFGHIJKLMNOPQRSTUVWXYZ' ;
declare @manv nvarchar(50) ;
declare @matkhau nvarchar(50) ;
declare @temp nvarchar(50) ;	
	while(@dem<200)
	begin
	select @temp=
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1) +
	substring(@alphabet, convert(int, rand()*26), 1);
	set @manv=@dem;
	set @matkhau=@temp;
	insert into DangNhap(MaNV)
	select MaNV from NhanVien where NhanVien.MaNV='NV'+cast(@dem as nvarchar) OR NhanVien.MaNV='AD'+cast(@dem as nvarchar)
	
	update DangNhap set MatKhau=cast( @temp as nvarchar) where DangNhap.MaNV='NV'+cast(@dem as nvarchar)OR DangNhap.MaNV='AD'+cast(@dem as nvarchar)
	set @dem=@dem+1;
	end;
end
exec add_auto_Values_DangNhap
--delete DangNhap

select * from NhanVien where MaNV like 'A%'

select * from KhachHang
select * from DangNhap

exec hash_Passwords 'hash','AD1'