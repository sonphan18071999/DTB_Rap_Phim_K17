USE [master]
GO
/****** Object:  Database [QuanLyRapPhim]    Script Date: 11/6/2019 9:39:24 AM ******/
CREATE DATABASE [QuanLyRapPhim]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyRapPhim', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyRapPhim.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyRapPhim_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyRapPhim_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyRapPhim] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyRapPhim].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyRapPhim] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyRapPhim] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyRapPhim] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyRapPhim] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyRapPhim] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyRapPhim] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyRapPhim] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyRapPhim] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyRapPhim] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyRapPhim] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyRapPhim]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/6/2019 9:39:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
	[Luong] [int] NOT NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatVe]    Script Date: 11/6/2019 9:39:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatVe](
	[MaPhim] [nvarchar](50) NOT NULL,
	[SuatChieu] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[MaRap] [nvarchar](50) NOT NULL,
	[Day] [nvarchar](50) NOT NULL,
	[So] [int] NOT NULL,
 CONSTRAINT [PK_SuatChieu] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC,
	[MaNV] ASC,
	[MaKH] ASC,
	[MaRap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/6/2019 9:39:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[HovaLotKH] [nchar](50) NOT NULL,
	[TenKH] [nchar](10) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/6/2019 9:39:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[HovaLotNV] [nchar](50) NOT NULL,
	[TenNV] [nchar](10) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[MaCV] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien_1] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phim]    Script Date: 11/6/2019 9:39:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phim](
	[TenPhim] [nvarchar](50) NOT NULL,
	[MaPhim] [nvarchar](50) NOT NULL,
	[GiaVe] [int] NOT NULL,
	[Poster] [image] NULL,
 CONSTRAINT [PK_Phim] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rap]    Script Date: 11/6/2019 9:39:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rap](
	[MaRap] [nvarchar](50) NOT NULL,
	[SoDayGhe] [nvarchar](50) NOT NULL,
	[SoLuongGhe] [nvarchar](50) NOT NULL,
	[LoaiPhim] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Rap] PRIMARY KEY CLUSTERED 
(
	[MaRap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuatChieuPhim]    Script Date: 11/6/2019 9:39:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuatChieuPhim](
	[MaPhim] [nvarchar](50) NOT NULL,
	[SuatChieu] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DatVe]  WITH CHECK ADD  CONSTRAINT [FK_DatVe_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DatVe] CHECK CONSTRAINT [FK_DatVe_KhachHang]
GO
ALTER TABLE [dbo].[DatVe]  WITH CHECK ADD  CONSTRAINT [FK_DatVe_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DatVe] CHECK CONSTRAINT [FK_DatVe_NhanVien]
GO
ALTER TABLE [dbo].[DatVe]  WITH CHECK ADD  CONSTRAINT [FK_DatVe_Phim1] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[DatVe] CHECK CONSTRAINT [FK_DatVe_Phim1]
GO
ALTER TABLE [dbo].[DatVe]  WITH CHECK ADD  CONSTRAINT [FK_DatVe_Rap] FOREIGN KEY([MaRap])
REFERENCES [dbo].[Rap] ([MaRap])
GO
ALTER TABLE [dbo].[DatVe] CHECK CONSTRAINT [FK_DatVe_Rap]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[SuatChieuPhim]  WITH CHECK ADD  CONSTRAINT [FK_SuatChieuPhim_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[SuatChieuPhim] CHECK CONSTRAINT [FK_SuatChieuPhim_Phim]
GO
USE [master]
GO
ALTER DATABASE [QuanLyRapPhim] SET  READ_WRITE 
GO

use QuanLyRapPhim
Go

--select all
CREATE PROCEDURE SelectAllPhim 
AS
SELECT * FROM Phim 
GO

Exec SelectAllPhim
--Insert
create PROCEDURE InsertPhim
				@idphim NVARCHAR(50) NULL,
				@TenPhim nvarchar(50) NULL,
				@GiaVe int NULL,
				@Poster image null
AS
			BEGIN
			INSERT  Phim values(@TenPhim,@idphim,@GiaVe,@Poster)
			END
GO
exec InsertPhim 'Son va nhng nguoi ban','10',900000,null
exec SelectAllPhim

--Update
create PROCEDURE UpdatePhim 
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
use QuanLyRapPhim;
EXEC UpdatePhim 'Son va nhng nguoi ban','10',900000,null
exec SelectAllPhim 
select * from Phim


--Delete 
create table PhimArchive
(
TenPhim nvarchar(50) null,
MaPhim nvarchar(50) PRIMARY KEY,
GiaVe int null,
Poster image null,

)
--use QuanLyRapPhim
-- CREATE TRIGGER DeletePhim 
-- ON Phim 
-- after DELETE 
-- AS 
-- begin
-- INSERT INTO PhimArchive 
-- (TenPhim,MaPhim,GiaVe,Poster) 
-- SELECT  TenPhim,MaPhim,GiaVe,Poster
-- FROM deleted; 
-- end
-- select * from PhimArchive
