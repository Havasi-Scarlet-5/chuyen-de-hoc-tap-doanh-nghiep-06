USE [master]
GO
/****** Object:  Database [CTDT_CDKTDN]    Script Date: 14/11/2024 18:06:02 ******/
CREATE DATABASE [CTDT_CDKTDN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CTDT_CDKTDN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CTDT_CDKTDN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CTDT_CDKTDN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CTDT_CDKTDN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CTDT_CDKTDN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CTDT_CDKTDN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET ARITHABORT OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CTDT_CDKTDN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CTDT_CDKTDN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CTDT_CDKTDN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CTDT_CDKTDN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CTDT_CDKTDN] SET  MULTI_USER 
GO
ALTER DATABASE [CTDT_CDKTDN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CTDT_CDKTDN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CTDT_CDKTDN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CTDT_CDKTDN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [CTDT_CDKTDN]
GO
/****** Object:  Table [dbo].[ChiTietCTDT]    Script Date: 14/11/2024 18:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietCTDT](
	[MaCTDT] [varchar](20) NOT NULL,
	[MaMon] [varchar](20) NOT NULL,
	[HocKy] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietCTDT] PRIMARY KEY CLUSTERED 
(
	[MaCTDT] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTDT]    Script Date: 14/11/2024 18:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDT](
	[MaCTDT] [varchar](20) NOT NULL,
	[NamPhatHanh] [int] NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CTDT] PRIMARY KEY CLUSTERED 
(
	[MaCTDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KeHoachDaoTaoTheoKhoa]    Script Date: 14/11/2024 18:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KeHoachDaoTaoTheoKhoa](
	[MaCTDT] [varchar](20) NOT NULL,
	[MaMon] [varchar](20) NOT NULL,
	[Khoa] [varchar](20) NOT NULL,
	[HocKy] [int] NOT NULL,
	[NamHoc] [int] NOT NULL,
 CONSTRAINT [PK_KeHoachDaoTaoTheoKhoa] PRIMARY KEY CLUSTERED 
(
	[MaCTDT] ASC,
	[MaMon] ASC,
	[Khoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 14/11/2024 18:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [varchar](20) NOT NULL,
	[TenKhoa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 14/11/2024 18:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMon] [varchar](20) NOT NULL,
	[KieuMa] [nvarchar](50) NOT NULL,
	[LoaiMon] [nvarchar](50) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[MaNghe] [varchar](20) NOT NULL,
	[SoTinChi] [int] NOT NULL,
	[LyThuyet] [int] NOT NULL,
	[ThucHanh] [int] NOT NULL,
	[KiemTra] [int] NOT NULL,
	[ThuongXuyen] [int] NOT NULL,
	[DinhKy] [int] NOT NULL,
	[ThiHetMon] [int] NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_MonHoc_1] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nghe]    Script Date: 14/11/2024 18:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nghe](
	[MaNghe] [varchar](20) NOT NULL,
	[TenNghe] [nvarchar](50) NOT NULL,
	[MaKhoa] [varchar](20) NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Nghe_1] PRIMARY KEY CLUSTERED 
(
	[MaNghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 14/11/2024 18:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [varchar](200) NOT NULL,
	[MatKhau] [varchar](200) NOT NULL,
	[TenNguoiDung] [nvarchar](50) NOT NULL,
	[HinhAnh] [varbinary](max) NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD1_25_CTDT', N'6.11', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD1_25_CTDT', N'6.12', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD1_25_CTDT', N'6.13', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD1_25_CTDT', N'6.14', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD1_25_CTDT', N'6.15', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD1_25_CTDT', N'6.16', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD1_25_CTDT', N'6.202.80', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD1_25_CTDT', N'6.202.83', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD1_25_CTDT', N'6.202.84', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD1_25_CTDT', N'6.202.86', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.202.56', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.202.57', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.202.58', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.202.59', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.202.60', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.202.61', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.202.63', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.28', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.73', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.74', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.75', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.76', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'5.78', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'6.11', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'6.12', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'6.13', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'6.14', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'6.15', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'6.16', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'6.202.80', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'6.202.83', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'6.202.84', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'CD3_25_CTDT', N'6.202.86', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.202.56', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.202.57', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.202.58', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.202.59', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.202.60', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.202.61', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.202.63', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.28', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.73', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.74', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.75', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.76', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'5.78', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'6.11', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'6.12', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'6.13', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'6.14', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'6.15', 2)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'6.16', 1)
INSERT [dbo].[ChiTietCTDT] ([MaCTDT], [MaMon], [HocKy]) VALUES (N'TC3_25_CTDT', N'6.202.83', 2)
GO
INSERT [dbo].[CTDT] ([MaCTDT], [NamPhatHanh], [MoTa]) VALUES (N'CD1_25_CTDT', 2025, N'Chương trình đào tạo của cao đẳng 1 năm 2025')
INSERT [dbo].[CTDT] ([MaCTDT], [NamPhatHanh], [MoTa]) VALUES (N'CD3_25_CTDT', 2025, N'Chương trình đào tạo của cao đẳng 3 năm 2025')
INSERT [dbo].[CTDT] ([MaCTDT], [NamPhatHanh], [MoTa]) VALUES (N'TC3_25_CTDT', 2025, N'Chương trình đào tạo của trung cấp 3 năm 2025')
GO
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.202.56', N'K25CD3', 2, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.202.57', N'K25CD3', 1, 2026)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.202.58', N'K25CD3', 1, 2026)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.202.59', N'K25CD3', 2, 2026)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.202.60', N'K25CD3', 2, 2026)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.202.61', N'K25CD3', 2, 2026)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.202.63', N'K25CD3', 2, 2026)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.28', N'K25CD3', 2, 2026)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.70', N'K25CD3', 1, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.71', N'K25CD3', 1, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.72', N'K25CD3', 1, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.73', N'K25CD3', 1, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.74', N'K25CD3', 2, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.75', N'K25CD3', 2, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.76', N'K25CD3', 2, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'5.78', N'K25CD3', 1, 2026)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'6.11', N'K25CD3', 2, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'6.12', N'K25CD3', 2, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'6.13', N'K25CD3', 1, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'6.14', N'K25CD3', 1, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'6.15', N'K25CD3', 2, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'6.16', N'K25CD3', 1, 2025)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'6.202.80', N'K25CD3', 1, 2027)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'6.202.82', N'K25CD3', 1, 2027)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'6.202.83', N'K25CD3', 2, 2027)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'6.202.84', N'K25CD3', 2, 2027)
INSERT [dbo].[KeHoachDaoTaoTheoKhoa] ([MaCTDT], [MaMon], [Khoa], [HocKy], [NamHoc]) VALUES (N'CD3_25_CTDT', N'6.202.86', N'K25CD3', 1, 2027)
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTT', N'Công nghệ thông tin')
GO
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.202.56', N'MH', N'Môn học chuyên nghề', N'Cơ sở dữ liệu', N'6480202', 3, 40, 16, 4, 2, 2, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.202.57', N'MĐ', N'Môn học chuyên nghề', N'Quản trị CSDL với MS Access', N'6480202', 4, 45, 71, 4, 2, 2, 1, N'Mô-đun')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.202.58', N'MĐ', N'Môn học chuyên nghề', N'Lập trình hướng đối tượng', N'6480202', 3, 30, 41, 4, 2, 2, 1, N'Mô-đun')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.202.59', N'MH', N'Môn học chuyên nghề', N'Phân tích thiết kế hệ thống thông tin', N'6480202', 3, 44, 12, 4, 2, 2, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.202.60', N'MH', N'Môn học chuyên nghề', N'Quản trị CSDL với SQL Server', N'6480202', 3, 30, 56, 4, 2, 2, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.202.61', N'MĐ', N'Môn học chuyên nghề', N'Lập trình Windows', N'6480202', 4, 45, 71, 4, 2, 2, 1, N'Mô-đun')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.202.63', N'MĐ', N'Môn học chuyên nghề', N'Thiết kế website bằng WordPress', N'6480202', 3, 30, 41, 4, 2, 2, 1, N'Mô-đun')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.28', N'MH', N'Môn học cơ sở', N'Anh văn chuyên ngành', N'6480202', 3, 30, 26, 4, 2, 2, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.70', N'MĐ', N'Môn học cơ sở', N'Soạn thảo văn bản', N'6480202', 2, 15, 42, 3, 1, 1, 1, N'Mô-đun')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.71', N'MĐ', N'Môn học cơ sở', N'Lập bảng tính', N'6480202', 2, 15, 42, 3, 1, 1, 1, N'Mô-đun')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.72', N'MĐ', N'Môn học cơ sở', N'Xây dựng bài thuyết trình', N'6480202', 1, 10, 17, 3, 1, 1, 1, N'Mô-đun')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.73', N'MH', N'Môn học cơ sở', N'Lập trình căn bản', N'6480202', 3, 29, 42, 4, 2, 2, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.74', N'MĐ', N'Môn học cơ sở', N'Lắp ráp và cài đặt máy tính', N'6480202', 3, 30, 56, 4, 2, 2, 1, N'Mô-đun')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.75', N'MH', N'Môn học cơ sở', N'Mạng máy tính', N'6480202', 4, 40, 31, 4, 2, 2, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.76', N'MĐ', N'Môn học chuyên nghề', N'Xử lý ảnh', N'6480202', 3, 30, 56, 4, 2, 2, 1, N'Mô-đun')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'5.78', N'MĐ', N'Môn học chuyên nghề', N'Thiết kế trang Web', N'6480202', 4, 45, 71, 4, 2, 2, 1, N'Mô-đun')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'6.11', N'MH', N'Môn chung', N'Chính trị', N'6480202', 3, 42, 29, 4, 2, 2, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'6.12', N'MH', N'Môn chung', N'Pháp luật', N'6480202', 1, 18, 10, 2, 1, 1, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'6.13', N'MH', N'Môn chung', N'Giáo dục thể chất', N'6480202', 2, 5, 51, 4, 1, 1, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'6.14', N'MH', N'Môn chung', N'Anh văn giao tiếp', N'6480202', 5, 30, 86, 4, 3, 3, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'6.15', N'MH', N'Môn chung', N'GDQP - An ninh', N'6480202', 3, 40, 31, 4, 2, 2, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'6.16', N'MH', N'Môn chung', N'Tin học', N'6480202', 3, 15, 56, 4, 2, 2, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'6.202.80', N'MĐ', N'Môn học chuyên nghề', N'Xây dựng và quản trị website', N'6480202', 6, 75, 99, 6, 3, 4, 1, N'Mô-đun')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'6.202.82', N'MH', N'Môn học chuyên nghề', N'Kiểm thử phần mềm', N'6480202', 3, 28, 28, 4, 2, 2, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'6.202.83', N'MH', N'Môn học chuyên nghề tự chọn', N'Thực tập doanh nghiệp', N'6480202', 3, 0, 596, 4, 1, 1, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'6.202.84', N'MH', N'Môn học chuyên nghề tự chọn', N'Học tập doanh nghiệp', N'6480202', 3, 60, 187, 3, 1, 1, 1, N'')
INSERT [dbo].[MonHoc] ([MaMon], [KieuMa], [LoaiMon], [TenMon], [MaNghe], [SoTinChi], [LyThuyet], [ThucHanh], [KiemTra], [ThuongXuyen], [DinhKy], [ThiHetMon], [GhiChu]) VALUES (N'6.202.86', N'MĐ', N'Môn học chuyên nghề', N'Lập trình di dộng', N'6480202', 3, 30, 56, 4, 2, 2, 1, N'Mô-đun')
GO
INSERT [dbo].[Nghe] ([MaNghe], [TenNghe], [MaKhoa], [MoTa]) VALUES (N'6480202', N'CÔNG NGHỆ THÔNG TIN (Ứng dụng phần mềm)', N'CNTT', N'Nghề Công nghệ thông tin (CNTT) là lĩnh vực chuyên về nghiên cứu, phát triển, và ứng dụng các hệ thống phần mềm, phần cứng nhằm quản lý và xử lý thông tin. Người làm trong ngành CNTT có thể tham gia vào nhiều lĩnh vực như phát triển phần mềm, quản trị hệ thống mạng, bảo mật thông tin, phân tích dữ liệu, và phát triển các ứng dụng di động hoặc web. Đây là ngành có tính sáng tạo cao, đòi hỏi khả năng tư duy logic, kỹ năng giải quyết vấn đề, và khả năng học hỏi liên tục để theo kịp sự phát triển nhanh chóng của công nghệ.')
INSERT [dbo].[Nghe] ([MaNghe], [TenNghe], [MaKhoa], [MoTa]) VALUES (N'6480210', N'QUẢN TRỊ MẠNG MÁY TÍNH', N'CNTT', N'Nghề quản trị mạng máy tính là công việc chuyên về việc quản lý, vận hành và bảo trì các hệ thống mạng máy tính trong một tổ chức. Người làm trong ngành này chịu trách nhiệm thiết lập, cấu hình và giám sát mạng máy tính, đảm bảo hệ thống hoạt động ổn định, bảo mật và hiệu quả. Công việc của quản trị mạng bao gồm việc quản lý các thiết bị mạng (router, switch, firewall), xử lý sự cố, tối ưu hiệu suất mạng, và bảo vệ dữ liệu trước các mối đe dọa an ninh mạng. Đây là nghề yêu cầu kiến thức sâu về mạng, bảo mật và kỹ năng giải quyết vấn đề.')
GO
SET IDENTITY_INSERT [dbo].[NguoiDung] ON 

INSERT [dbo].[NguoiDung] ([ID], [TenDangNhap], [MatKhau], [TenNguoiDung], [HinhAnh]) VALUES (1, N'admin', N'123456', N'Admin', NULL)
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
GO
ALTER TABLE [dbo].[ChiTietCTDT]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietCTDT_CTDT] FOREIGN KEY([MaCTDT])
REFERENCES [dbo].[CTDT] ([MaCTDT])
GO
ALTER TABLE [dbo].[ChiTietCTDT] CHECK CONSTRAINT [FK_ChiTietCTDT_CTDT]
GO
ALTER TABLE [dbo].[ChiTietCTDT]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietCTDT_MonHoc] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonHoc] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietCTDT] CHECK CONSTRAINT [FK_ChiTietCTDT_MonHoc]
GO
ALTER TABLE [dbo].[KeHoachDaoTaoTheoKhoa]  WITH CHECK ADD  CONSTRAINT [FK_KeHoachDaoTaoTheoKhoa_CTDT] FOREIGN KEY([MaCTDT])
REFERENCES [dbo].[CTDT] ([MaCTDT])
GO
ALTER TABLE [dbo].[KeHoachDaoTaoTheoKhoa] CHECK CONSTRAINT [FK_KeHoachDaoTaoTheoKhoa_CTDT]
GO
ALTER TABLE [dbo].[KeHoachDaoTaoTheoKhoa]  WITH CHECK ADD  CONSTRAINT [FK_KeHoachDaoTaoTheoKhoa_MonHoc] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonHoc] ([MaMon])
GO
ALTER TABLE [dbo].[KeHoachDaoTaoTheoKhoa] CHECK CONSTRAINT [FK_KeHoachDaoTaoTheoKhoa_MonHoc]
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_MonHoc_Nghe] FOREIGN KEY([MaNghe])
REFERENCES [dbo].[Nghe] ([MaNghe])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [FK_MonHoc_Nghe]
GO
ALTER TABLE [dbo].[Nghe]  WITH CHECK ADD  CONSTRAINT [FK_Nghe_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[Nghe] CHECK CONSTRAINT [FK_Nghe_Khoa]
GO
USE [master]
GO
ALTER DATABASE [CTDT_CDKTDN] SET  READ_WRITE 
GO
