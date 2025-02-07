USE [master]
GO
/****** Object:  Database [BanHangTaiQuay]    Script Date: 7/18/2024 8:05:33 PM ******/
CREATE DATABASE [BanHangTaiQuay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BanHangTaiQuay', FILENAME = N'D:\Programming\Tools\MSSQL16.SQLEXPRESS\MSSQL\DATA\BanHangTaiQuay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BanHangTaiQuay_log', FILENAME = N'D:\Programming\Tools\MSSQL16.SQLEXPRESS\MSSQL\DATA\BanHangTaiQuay_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BanHangTaiQuay] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BanHangTaiQuay].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BanHangTaiQuay] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET ARITHABORT OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BanHangTaiQuay] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BanHangTaiQuay] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BanHangTaiQuay] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BanHangTaiQuay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BanHangTaiQuay] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BanHangTaiQuay] SET  MULTI_USER 
GO
ALTER DATABASE [BanHangTaiQuay] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BanHangTaiQuay] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BanHangTaiQuay] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BanHangTaiQuay] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BanHangTaiQuay] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BanHangTaiQuay] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BanHangTaiQuay] SET QUERY_STORE = ON
GO
ALTER DATABASE [BanHangTaiQuay] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BanHangTaiQuay]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 7/18/2024 8:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [varchar](10) NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 7/18/2024 8:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [varchar](10) NOT NULL,
	[NgayTao] [date] NULL,
	[GhiChu] [nvarchar](200) NULL,
	[TrangThai] [int] NULL,
	[SDTKH] [nvarchar](15) NULL,
	[MaNhanVien] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonChiTiet]    Script Date: 7/18/2024 8:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonChiTiet](
	[MaSPCT] [varchar](10) NOT NULL,
	[MaHoaDon] [varchar](10) NOT NULL,
	[DonGia] [decimal](18, 2) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSPCT] ASC,
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/18/2024 8:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[SDTKH] [nvarchar](15) NOT NULL,
	[TenKhachHang] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[SDTKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KichCo]    Script Date: 7/18/2024 8:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KichCo](
	[MaKichCo] [varchar](10) NOT NULL,
	[TenKichCo] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKichCo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MauSac]    Script Date: 7/18/2024 8:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MauSac](
	[MaMauSac] [varchar](10) NOT NULL,
	[TenMauSac] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMauSac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 7/18/2024 8:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](10) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[TenNhanVien] [nvarchar](100) NULL,
	[SDT] [nvarchar](15) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[MaChucVu] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 7/18/2024 8:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [varchar](10) NOT NULL,
	[TenSanPham] [nvarchar](100) NULL,
	[MoTa] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPhamChiTiet]    Script Date: 7/18/2024 8:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPhamChiTiet](
	[MaSPCT] [varchar](10) NOT NULL,
	[DonGia] [decimal](18, 2) NULL,
	[SoLuong] [int] NULL,
	[MaSanPham] [varchar](10) NULL,
	[MaMauSac] [varchar](10) NULL,
	[MaKichCo] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSPCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV1', N'Admin')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV2', N'Nhân Viên')
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD1', CAST(N'2024-07-18' AS Date), NULL, 1, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD10', CAST(N'2024-07-18' AS Date), NULL, 2, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD11', CAST(N'2024-07-18' AS Date), NULL, 2, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD12', CAST(N'2024-07-18' AS Date), NULL, 2, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD13', CAST(N'2024-07-18' AS Date), NULL, 2, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD14', CAST(N'2024-07-18' AS Date), NULL, 2, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD15', CAST(N'2024-07-18' AS Date), NULL, 2, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD16', CAST(N'2024-07-18' AS Date), NULL, 2, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD17', CAST(N'2024-07-18' AS Date), NULL, 2, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD18', CAST(N'2024-07-18' AS Date), NULL, 2, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD19', CAST(N'2024-07-18' AS Date), NULL, 2, N'0123456789', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD2', CAST(N'2024-07-18' AS Date), NULL, 2, N'0123456789', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD20', CAST(N'2024-07-18' AS Date), NULL, 1, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD3', CAST(N'2024-07-18' AS Date), NULL, 2, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD4', CAST(N'2024-07-18' AS Date), NULL, 1, N'0123456789', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD5', CAST(N'2024-07-18' AS Date), NULL, 1, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD6', CAST(N'2024-07-18' AS Date), NULL, 1, N'0123456789', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD7', CAST(N'2024-07-18' AS Date), NULL, 1, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD8', CAST(N'2024-07-18' AS Date), NULL, 1, N'0', N'NV1')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [GhiChu], [TrangThai], [SDTKH], [MaNhanVien]) VALUES (N'HD9', CAST(N'2024-07-18' AS Date), NULL, 1, N'0', N'NV1')
GO
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT1', N'HD1', CAST(100.00 AS Decimal(18, 2)), 8)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT1', N'HD20', CAST(100.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT1', N'HD3', CAST(100.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT1', N'HD4', CAST(100.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT1', N'HD5', CAST(100.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT1', N'HD7', CAST(100.00 AS Decimal(18, 2)), 10)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT2', N'HD1', CAST(100.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT2', N'HD5', CAST(100.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT2', N'HD8', CAST(100.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT3', N'HD1', CAST(100.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT3', N'HD15', CAST(100.00 AS Decimal(18, 2)), 9)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT3', N'HD9', CAST(100.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT4', N'HD1', CAST(200.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT4', N'HD13', CAST(200.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT4', N'HD20', CAST(200.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT4', N'HD6', CAST(200.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT5', N'HD2', CAST(200.00 AS Decimal(18, 2)), 10)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT6', N'HD1', CAST(200.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT7', N'HD2', CAST(300.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT8', N'HD6', CAST(300.00 AS Decimal(18, 2)), 17)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT9', N'HD1', CAST(300.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[HoaDonChiTiet] ([MaSPCT], [MaHoaDon], [DonGia], [SoLuong]) VALUES (N'SPCT9', N'HD19', CAST(300.00 AS Decimal(18, 2)), 5)
GO
INSERT [dbo].[KhachHang] ([SDTKH], [TenKhachHang], [NgaySinh], [DiaChi]) VALUES (N'0', N'Khách Vãng Lai', CAST(N'0001-01-01' AS Date), N'None')
INSERT [dbo].[KhachHang] ([SDTKH], [TenKhachHang], [NgaySinh], [DiaChi]) VALUES (N'0123456789', N'Khách Hàng 1', CAST(N'1990-01-01' AS Date), N'Hà Nội')
GO
INSERT [dbo].[KichCo] ([MaKichCo], [TenKichCo]) VALUES (N'KC1', N'40')
INSERT [dbo].[KichCo] ([MaKichCo], [TenKichCo]) VALUES (N'KC2', N'41')
INSERT [dbo].[KichCo] ([MaKichCo], [TenKichCo]) VALUES (N'KC3', N'42')
GO
INSERT [dbo].[MauSac] ([MaMauSac], [TenMauSac]) VALUES (N'MS1', N'Trắng')
INSERT [dbo].[MauSac] ([MaMauSac], [TenMauSac]) VALUES (N'MS2', N'Xanh')
INSERT [dbo].[MauSac] ([MaMauSac], [TenMauSac]) VALUES (N'MS3', N'Đỏ')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [Username], [Password], [TenNhanVien], [SDT], [NgaySinh], [DiaChi], [MaChucVu]) VALUES (N'NV1', N'nv1', N'1', N'Nhân Viên 1', N'0123456789', CAST(N'2000-01-01' AS Date), N'Hà Nội', N'CV1')
GO
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa]) VALUES (N'SP1', N'Nike Invincible 3 Blueprint', N'Nike Invincible 3 Blueprint')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa]) VALUES (N'SP2', N'Nike Vaporfly 3', N'Nike Vaporfly 3')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa]) VALUES (N'SP3', N'Nike Revolution 7', N'Nike Revolution 7')
GO
INSERT [dbo].[SanPhamChiTiet] ([MaSPCT], [DonGia], [SoLuong], [MaSanPham], [MaMauSac], [MaKichCo]) VALUES (N'SPCT1', CAST(100.00 AS Decimal(18, 2)), 70, N'SP1', N'MS1', N'KC1')
INSERT [dbo].[SanPhamChiTiet] ([MaSPCT], [DonGia], [SoLuong], [MaSanPham], [MaMauSac], [MaKichCo]) VALUES (N'SPCT2', CAST(100.00 AS Decimal(18, 2)), 91, N'SP1', N'MS1', N'KC2')
INSERT [dbo].[SanPhamChiTiet] ([MaSPCT], [DonGia], [SoLuong], [MaSanPham], [MaMauSac], [MaKichCo]) VALUES (N'SPCT3', CAST(100.00 AS Decimal(18, 2)), 96, N'SP1', N'MS1', N'KC3')
INSERT [dbo].[SanPhamChiTiet] ([MaSPCT], [DonGia], [SoLuong], [MaSanPham], [MaMauSac], [MaKichCo]) VALUES (N'SPCT4', CAST(200.00 AS Decimal(18, 2)), 193, N'SP2', N'MS2', N'KC1')
INSERT [dbo].[SanPhamChiTiet] ([MaSPCT], [DonGia], [SoLuong], [MaSanPham], [MaMauSac], [MaKichCo]) VALUES (N'SPCT5', CAST(200.00 AS Decimal(18, 2)), 200, N'SP2', N'MS2', N'KC2')
INSERT [dbo].[SanPhamChiTiet] ([MaSPCT], [DonGia], [SoLuong], [MaSanPham], [MaMauSac], [MaKichCo]) VALUES (N'SPCT6', CAST(200.00 AS Decimal(18, 2)), 198, N'SP2', N'MS2', N'KC3')
INSERT [dbo].[SanPhamChiTiet] ([MaSPCT], [DonGia], [SoLuong], [MaSanPham], [MaMauSac], [MaKichCo]) VALUES (N'SPCT7', CAST(300.00 AS Decimal(18, 2)), 300, N'SP3', N'MS3', N'KC1')
INSERT [dbo].[SanPhamChiTiet] ([MaSPCT], [DonGia], [SoLuong], [MaSanPham], [MaMauSac], [MaKichCo]) VALUES (N'SPCT8', CAST(300.00 AS Decimal(18, 2)), 283, N'SP3', N'MS3', N'KC2')
INSERT [dbo].[SanPhamChiTiet] ([MaSPCT], [DonGia], [SoLuong], [MaSanPham], [MaMauSac], [MaKichCo]) VALUES (N'SPCT9', CAST(300.00 AS Decimal(18, 2)), 295, N'SP3', N'MS3', N'KC3')
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([SDTKH])
REFERENCES [dbo].[KhachHang] ([SDTKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonChiTiet_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[HoaDonChiTiet] CHECK CONSTRAINT [FK_HoaDonChiTiet_HoaDon]
GO
ALTER TABLE [dbo].[HoaDonChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonChiTiet_SanPhamChiTiet] FOREIGN KEY([MaSPCT])
REFERENCES [dbo].[SanPhamChiTiet] ([MaSPCT])
GO
ALTER TABLE [dbo].[HoaDonChiTiet] CHECK CONSTRAINT [FK_HoaDonChiTiet_SanPhamChiTiet]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[SanPhamChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_SanPhamChiTiet_KichCo] FOREIGN KEY([MaKichCo])
REFERENCES [dbo].[KichCo] ([MaKichCo])
GO
ALTER TABLE [dbo].[SanPhamChiTiet] CHECK CONSTRAINT [FK_SanPhamChiTiet_KichCo]
GO
ALTER TABLE [dbo].[SanPhamChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_SanPhamChiTiet_MauSac] FOREIGN KEY([MaMauSac])
REFERENCES [dbo].[MauSac] ([MaMauSac])
GO
ALTER TABLE [dbo].[SanPhamChiTiet] CHECK CONSTRAINT [FK_SanPhamChiTiet_MauSac]
GO
ALTER TABLE [dbo].[SanPhamChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_SanPhamChiTiet_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[SanPhamChiTiet] CHECK CONSTRAINT [FK_SanPhamChiTiet_SanPham]
GO
USE [master]
GO
ALTER DATABASE [BanHangTaiQuay] SET  READ_WRITE 
GO
