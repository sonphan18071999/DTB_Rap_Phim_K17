USE [QuanLyRapPhim]
GO
/****** Object:  StoredProcedure [dbo].[InsertPhim]    Script Date: 11/20/2019 8:37:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[InsertPhim]
				@idphim NVARCHAR(50) NULL,
				@TenPhim nvarchar(50) NULL,
				@GiaVe int NULL,
				@Poster image null
AS
			BEGIN
			INSERT  Phim values(@TenPhim,@idphim,@GiaVe,@Poster)
			END

GO
/****** Object:  StoredProcedure [dbo].[SelectAllPhim]    Script Date: 11/20/2019 8:37:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllPhim] 
AS
SELECT * FROM Phim 

GO
/****** Object:  StoredProcedure [dbo].[spInsertChucVu]    Script Date: 11/20/2019 8:37:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[spInsertChucVu]
	
	@MACV nvarchar(50) ,
	@CHUCVU nvarchar(50),
	@LUONG INT 
AS
Begin
	Insert  ChucVu values(@MACV,@CHUCVU,@LUONG) 
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertDangNhap]    Script Date: 11/20/2019 8:37:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[spInsertDangNhap]
	
	@MANV nvarchar(50) ,
	@MATKHAU nvarchar(50)
AS
Begin
	Insert  DangNhap values(@MANV,@MATKHAU) 
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertNhanVien]    Script Date: 11/20/2019 8:37:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[spInsertNhanVien]
	@HOVATLOT nvarchar(50),
	@TENNV nvarchar(50),
	@MANV nvarchar(50),
	@MACV nvarchar(50),
	@SOGIOLAM int,
	@MANQL nvarchar(50),
	@MACHINHANH nvarchar(50)
AS
Begin
	Insert  NhanVien values(@HOVATLOT,@TENNV,@MANV,@MACV,@SOGIOLAM,@MANQL,@MACHINHANH ) 
End
GO
/****** Object:  StoredProcedure [dbo].[spListAllNhanVien]    Script Date: 11/20/2019 8:37:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[spListAllNhanVien]
AS
Begin
	Select *  from dbo.NhanVien
End
GO
/****** Object:  StoredProcedure [dbo].[spListChiNhanh]    Script Date: 11/20/2019 8:37:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[spListChiNhanh]
	
AS
Begin
	select * from ChiNhanh
End
GO
/****** Object:  StoredProcedure [dbo].[spListChucVu]    Script Date: 11/20/2019 8:37:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[spListChucVu]
	
AS
Begin
	select * from ChucVu
End
GO
/****** Object:  StoredProcedure [dbo].[spListDangNhap]    Script Date: 11/20/2019 8:37:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[spListDangNhap]
	
AS
Begin
	select * from DangNhap
End
GO
/****** Object:  StoredProcedure [dbo].[UpdatePhim]    Script Date: 11/20/2019 8:37:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdatePhim] 
				
				@idphim NVARCHAR(50) NULL,
				@TenPhim nvarchar(50) NULL,
				@GiaVe int NULL,
				@Poster image null
AS
			BEGIN
			UPDATE Phim 
			set TenPhim=@TenPhim,GiaVe=@GiaVe,Poster=@Poster
			where MaPhim=@idphim
			END

GO
