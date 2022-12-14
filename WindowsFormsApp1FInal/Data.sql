USE [QLBanVe]
GO
/****** Object:  Table [dbo].[ChoNgoi]    Script Date: 10/30/2021 10:19:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChoNgoi](
	[MaCN] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ChoNgoi] PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChoNgoi_Rap]    Script Date: 10/30/2021 10:19:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChoNgoi_Rap](
	[MaSC] [nvarchar](50) NOT NULL,
	[MaCN] [nvarchar](50) NOT NULL,
	[SoTT] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ChoNgoi_Rap] PRIMARY KEY CLUSTERED 
(
	[MaSC] ASC,
	[MaCN] ASC,
	[SoTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 10/30/2021 10:19:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[Food_id] [nchar](10) NOT NULL,
	[Food_name] [nvarchar](255) NULL,
	[Description] [ntext] NULL,
	[Price] [int] NULL,
	[Food_icon] [nvarchar](50) NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[Food_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 10/30/2021 10:19:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](50) NOT NULL,
	[MaPhim] [varchar](50) NOT NULL,
	[NgayMua] [varchar](50) NOT NULL,
	[ThanhTien] [varchar](50) NOT NULL,
	[GiamGia] [varchar](50) NOT NULL,
	[TienTra] [varchar](50) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon_KhachHang]    Script Date: 10/30/2021 10:19:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon_KhachHang](
	[MaHD] [varchar](50) NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
	[MaVe] [varchar](50) NOT NULL,
	[NgayMua] [date] NOT NULL,
 CONSTRAINT [PK_HoaDon_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon_ThucAn]    Script Date: 10/30/2021 10:19:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon_ThucAn](
	[MaHD] [nchar](10) NOT NULL,
	[ThanhTien] [nchar](10) NOT NULL,
	[NgayMua] [date] NOT NULL,
 CONSTRAINT [PK_HoaDon_ThucAn] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 10/30/2021 10:19:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](max) NOT NULL,
	[DiaChiKH] [nvarchar](max) NULL,
	[SDTKH] [nvarchar](10) NOT NULL,
	[NgaySinhKH] [date] NULL,
	[GioiTinh] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[LoaiKH] [nvarchar](max) NOT NULL,
	[SoLanDoi] [int] NULL,
 CONSTRAINT [PK_KhachHang_1] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC,
	[SDTKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichChieu]    Script Date: 10/30/2021 10:19:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichChieu](
	[MaLC] [nvarchar](50) NOT NULL,
	[KhoiChieu] [date] NULL,
	[KetThucChieu] [date] NULL,
	[MaPhim] [nvarchar](50) NULL,
 CONSTRAINT [PK_LichChieu] PRIMARY KEY CLUSTERED 
(
	[MaLC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/30/2021 10:19:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](max) NOT NULL,
	[TenTK] [nvarchar](20) NOT NULL,
	[MatKhau] [nvarchar](max) NOT NULL,
	[DiaChiNV] [nvarchar](max) NOT NULL,
	[GioiTinhNV] [nvarchar](50) NOT NULL,
	[NgaySinhNV] [date] NULL,
	[SDTNV] [nvarchar](10) NOT NULL,
	[CapBac] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[TenTK] ASC,
	[SDTNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phim]    Script Date: 10/30/2021 10:19:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phim](
	[MaPhim] [nvarchar](50) NOT NULL,
	[TenPhim] [nvarchar](max) NOT NULL,
	[DaoDien] [nvarchar](50) NULL,
	[NamSX] [nvarchar](50) NULL,
	[TheLoai] [nvarchar](50) NULL,
	[ThoiLuong] [nvarchar](50) NULL,
	[MoTa] [nvarchar](max) NULL,
	[ThoiHan] [date] NULL,
	[AnhPhim] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Phim] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rap]    Script Date: 10/30/2021 10:19:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rap](
	[MaRap] [nvarchar](50) NOT NULL,
	[TenRap] [nvarchar](50) NULL,
	[SLGheDat] [nvarchar](50) NULL,
	[SLGheTrong] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rap] PRIMARY KEY CLUSTERED 
(
	[MaRap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuatChieu]    Script Date: 10/30/2021 10:19:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuatChieu](
	[MaSC] [nvarchar](50) NOT NULL,
	[BatDau] [datetime] NULL,
	[KetThuc] [datetime] NULL,
	[Gia] [nvarchar](50) NULL,
	[MaLC] [nvarchar](50) NULL,
	[MaRap] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SuatChieu] PRIMARY KEY CLUSTERED 
(
	[MaSC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuatChieu_Rap]    Script Date: 10/30/2021 10:19:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuatChieu_Rap](
	[MaSC] [nvarchar](50) NOT NULL,
	[MaRap] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SuatChieu_Rap] PRIMARY KEY CLUSTERED 
(
	[MaSC] ASC,
	[MaRap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 10/30/2021 10:19:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ve](
	[MaVe] [varchar](50) NOT NULL,
	[MaPhim] [varchar](50) NOT NULL,
	[MaSC] [varchar](50) NOT NULL,
	[Loai] [nvarchar](50) NOT NULL,
	[Gia] [varchar](50) NOT NULL,
	[MaHD] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Vé] PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'B', N'4')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'B', N'5')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'C', N'2')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'C', N'3')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'C', N'4')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'C', N'5')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'D', N'2')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'D', N'3')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'D', N'4')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'D', N'5')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'D', N'6')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'E', N'2')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'E', N'3')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'E', N'4')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'E', N'5')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'F', N'2')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'F', N'3')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'F', N'4')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'F', N'5')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'G', N'0')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'G', N'1')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'G', N'2')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'G', N'3')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'G', N'5')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'G', N'6')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'H', N'1')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'H', N'2')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'H', N'3')
INSERT [dbo].[ChoNgoi_Rap] ([MaSC], [MaCN], [SoTT]) VALUES (N'SC01', N'H', N'6')
GO
INSERT [dbo].[Food] ([Food_id], [Food_name], [Description], [Price], [Food_icon]) VALUES (N'F01       ', N'Combo Bắp Nước', N'abc', 30000, N'1.png')
INSERT [dbo].[Food] ([Food_id], [Food_name], [Description], [Price], [Food_icon]) VALUES (N'F02       ', N'Combo Bắp Nước x2', N'abc', 40000, N'2.png')
INSERT [dbo].[Food] ([Food_id], [Food_name], [Description], [Price], [Food_icon]) VALUES (N'F03       ', N'Combo Bắp Nước x3', N'abc', 45000, N'3.png')
INSERT [dbo].[Food] ([Food_id], [Food_name], [Description], [Price], [Food_icon]) VALUES (N'F04       ', N'Combo Bắp Nước x4', N'abc', 55000, N'4.png')
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaPhim], [NgayMua], [ThanhTien], [GiamGia], [TienTra], [MaNV]) VALUES (N'HD0', N'P06', N'30/10/2021', N'195000', N'0', N'195000', N'NV08')
INSERT [dbo].[HoaDon] ([MaHD], [MaPhim], [NgayMua], [ThanhTien], [GiamGia], [TienTra], [MaNV]) VALUES (N'HD1', N'P06', N'30/10/2021', N'195000', N'0', N'195000', N'NV08')
INSERT [dbo].[HoaDon] ([MaHD], [MaPhim], [NgayMua], [ThanhTien], [GiamGia], [TienTra], [MaNV]) VALUES (N'HD2', N'P10', N'30/10/2021', N'195000', N'0', N'195000', N'NV08')
INSERT [dbo].[HoaDon] ([MaHD], [MaPhim], [NgayMua], [ThanhTien], [GiamGia], [TienTra], [MaNV]) VALUES (N'HD3', N'P06', N'30/10/2021', N'130000', N'0', N'130000', N'NV08')
INSERT [dbo].[HoaDon] ([MaHD], [MaPhim], [NgayMua], [ThanhTien], [GiamGia], [TienTra], [MaNV]) VALUES (N'HD4', N'P06', N'30/10/2021', N'160000', N'0', N'160000', N'NV08')
INSERT [dbo].[HoaDon] ([MaHD], [MaPhim], [NgayMua], [ThanhTien], [GiamGia], [TienTra], [MaNV]) VALUES (N'HD5', N'P01', N'30/10/2021', N'195000', N'0', N'195000', N'NV08')
INSERT [dbo].[HoaDon] ([MaHD], [MaPhim], [NgayMua], [ThanhTien], [GiamGia], [TienTra], [MaNV]) VALUES (N'HD6', N'P01', N'30/10/2021', N'195000', N'0', N'195000', N'NV08')
INSERT [dbo].[HoaDon] ([MaHD], [MaPhim], [NgayMua], [ThanhTien], [GiamGia], [TienTra], [MaNV]) VALUES (N'HD7', N'P01', N'30/10/2021', N'195000', N'0', N'195000', N'NV08')
INSERT [dbo].[HoaDon] ([MaHD], [MaPhim], [NgayMua], [ThanhTien], [GiamGia], [TienTra], [MaNV]) VALUES (N'HD8', N'P01', N'30/10/2021', N'1300000', N'26520', N'1273480', N'NV08')
GO
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD7', N'KH01', N'VE20', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD7', N'KH01', N'VE21', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD7', N'KH01', N'VE22', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE23', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE24', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE25', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE26', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE27', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE28', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE29', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE30', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE31', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE32', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE33', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE34', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE35', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE36', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE37', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE38', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE39', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE40', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE41', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_KhachHang] ([MaHD], [MaKH], [MaVe], [NgayMua]) VALUES (N'HD8', N'KH01', N'VE42', CAST(N'2021-10-30' AS Date))
GO
INSERT [dbo].[HoaDon_ThucAn] ([MaHD], [ThanhTien], [NgayMua]) VALUES (N'HD0       ', N'160000    ', CAST(N'2021-10-30' AS Date))
INSERT [dbo].[HoaDon_ThucAn] ([MaHD], [ThanhTien], [NgayMua]) VALUES (N'HD1       ', N'190000    ', CAST(N'2021-10-30' AS Date))
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDTKH], [NgaySinhKH], [GioiTinh], [Email], [LoaiKH], [SoLanDoi]) VALUES (N'KH01', N'Bùi Minh Trong', N'Hóc Môn', N'0123456789', CAST(N'2001-02-02' AS Date), N'Nam', N'trong@gmail.com', N'Thân Thiết', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDTKH], [NgaySinhKH], [GioiTinh], [Email], [LoaiKH], [SoLanDoi]) VALUES (N'KH02', N'Đặng Minh Triều', N'371 Nguyễn Kiệm', N'0133456789', CAST(N'2001-03-12' AS Date), N'Nam', N'trieu@gmail.com', N'Thân Thiết', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDTKH], [NgaySinhKH], [GioiTinh], [Email], [LoaiKH], [SoLanDoi]) VALUES (N'KH03', N'Lâm Văn Mạnh', N'371 Nguyễn Kiệm', N'0369854236', CAST(N'2001-03-12' AS Date), N'Nam', N'manh@gmail.com', N'Thân Thiết', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDTKH], [NgaySinhKH], [GioiTinh], [Email], [LoaiKH], [SoLanDoi]) VALUES (N'KH04', N'Phùng Khánh Linh', N'Q2', N'5986312547', CAST(N'2001-02-02' AS Date), N'Nữ', N'Linh@gmail.com', N'Thân Thiết', 0)
GO
INSERT [dbo].[LichChieu] ([MaLC], [KhoiChieu], [KetThucChieu], [MaPhim]) VALUES (N'LC01', CAST(N'2021-10-12' AS Date), CAST(N'2021-10-30' AS Date), N'P01')
INSERT [dbo].[LichChieu] ([MaLC], [KhoiChieu], [KetThucChieu], [MaPhim]) VALUES (N'LC02', CAST(N'2021-11-12' AS Date), CAST(N'2022-10-30' AS Date), N'P02')
INSERT [dbo].[LichChieu] ([MaLC], [KhoiChieu], [KetThucChieu], [MaPhim]) VALUES (N'LC03', CAST(N'2021-07-12' AS Date), CAST(N'2021-09-30' AS Date), N'P03')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenTK], [MatKhau], [DiaChiNV], [GioiTinhNV], [NgaySinhNV], [SDTNV], [CapBac]) VALUES (N'NV05', N'Bùi Minh Sang', N'trong23', N'123', N'456/88', N'Nam', CAST(N'2020-07-09' AS Date), N'0339151790', N'QuanLy')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenTK], [MatKhau], [DiaChiNV], [GioiTinhNV], [NgaySinhNV], [SDTNV], [CapBac]) VALUES (N'NV06', N'Lý Nam', N'nam', N'nam123', N'34234', N'Nam', CAST(N'2021-09-08' AS Date), N'1234569875', N'QuanLy')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenTK], [MatKhau], [DiaChiNV], [GioiTinhNV], [NgaySinhNV], [SDTNV], [CapBac]) VALUES (N'NV07', N'Đặng Minh Triều', N'1', N'1', N'ssss', N'Nam', CAST(N'2021-09-11' AS Date), N'0368549852', N'QuanLy')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenTK], [MatKhau], [DiaChiNV], [GioiTinhNV], [NgaySinhNV], [SDTNV], [CapBac]) VALUES (N'NV08', N'Nguyễn Quang Hải', N'2', N'2', N'ssss', N'Nam', CAST(N'2021-09-11' AS Date), N'0368549852', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenTK], [MatKhau], [DiaChiNV], [GioiTinhNV], [NgaySinhNV], [SDTNV], [CapBac]) VALUES (N'NV09', N'Lê Thanh Long', N'3', N'2', N'ssss', N'Nam', CAST(N'2021-09-11' AS Date), N'0368549852', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenTK], [MatKhau], [DiaChiNV], [GioiTinhNV], [NgaySinhNV], [SDTNV], [CapBac]) VALUES (N'NV10', N'Bùi Minh Sang', N'trong129', N'123', N'456/88', N'Nam', CAST(N'2020-07-09' AS Date), N'0339151791', N'QuanLy')
GO
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [DaoDien], [NamSX], [TheLoai], [ThoiLuong], [MoTa], [ThoiHan], [AnhPhim]) VALUES (N'P01', N'4 năm 2 chàng một tình yêu', N'LUK VAN', N'LUK VAN', N'Tình cảm', N'90 phut', N'4 năm 2 chàng một tình yêu', CAST(N'2021-10-30' AS Date), N'4-nam-2-chang-1-tinh-yeu-gx2alz9s.jpg')
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [DaoDien], [NamSX], [TheLoai], [ThoiLuong], [MoTa], [ThoiHan], [AnhPhim]) VALUES (N'P02', N'Avatar', N'Jame', N'Jame', N'Khoa học viễn tưởng', N'200 phut', N'Khoa học viễn tưởng', CAST(N'2021-10-30' AS Date), N'avatar.jpg')
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [DaoDien], [NamSX], [TheLoai], [ThoiLuong], [MoTa], [ThoiHan], [AnhPhim]) VALUES (N'P03', N'Bố già', N'Trấn Thành', N'Trấn Thành', N'Tình cảm gia đình', N'100 phut', N'Tình cảm gia đình', CAST(N'2021-10-30' AS Date), N'bogia.jpg')
GO
INSERT [dbo].[Rap] ([MaRap], [TenRap], [SLGheDat], [SLGheTrong]) VALUES (N'R01', N'R1', N'0', N'0')
INSERT [dbo].[Rap] ([MaRap], [TenRap], [SLGheDat], [SLGheTrong]) VALUES (N'R02', N'R2', N'0', N'0')
INSERT [dbo].[Rap] ([MaRap], [TenRap], [SLGheDat], [SLGheTrong]) VALUES (N'R03', N'R3', N'0', N'0')
INSERT [dbo].[Rap] ([MaRap], [TenRap], [SLGheDat], [SLGheTrong]) VALUES (N'R04', N'R4', N'0', N'0')
INSERT [dbo].[Rap] ([MaRap], [TenRap], [SLGheDat], [SLGheTrong]) VALUES (N'R05', N'R5', N'0', N'0')
INSERT [dbo].[Rap] ([MaRap], [TenRap], [SLGheDat], [SLGheTrong]) VALUES (N'R06', N'R6', N'0', N'0')
INSERT [dbo].[Rap] ([MaRap], [TenRap], [SLGheDat], [SLGheTrong]) VALUES (N'R07', N'R7', N'0', N'0')
GO
INSERT [dbo].[SuatChieu] ([MaSC], [BatDau], [KetThuc], [Gia], [MaLC], [MaRap]) VALUES (N'SC01', CAST(N'2021-10-14T08:58:48.000' AS DateTime), CAST(N'2021-10-14T09:58:48.000' AS DateTime), N'50000', N'LC01', N'R01')
INSERT [dbo].[SuatChieu] ([MaSC], [BatDau], [KetThuc], [Gia], [MaLC], [MaRap]) VALUES (N'SC02', CAST(N'2021-11-26T10:58:48.000' AS DateTime), CAST(N'2021-11-26T11:58:48.000' AS DateTime), N'50000', N'LC02', N'R02')
INSERT [dbo].[SuatChieu] ([MaSC], [BatDau], [KetThuc], [Gia], [MaLC], [MaRap]) VALUES (N'SC03', CAST(N'2021-08-15T14:58:48.000' AS DateTime), CAST(N'2021-08-15T16:00:00.000' AS DateTime), N'50000', N'LC03', N'R02')
GO
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE1', N'P06', N'SC02', N'Sinh Viên', N'65000 d', N'HD0')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE10', N'P06', N'SC02', N'Sinh Viên', N'65000 d', N'HD3')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE11', N'P06', N'SC02', N'Sinh Viên', N'65000 d', N'HD3')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE12', N'P06', N'SC02', N'Người Lớn', N'80000 d', N'HD4')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE13', N'P06', N'SC02', N'Người Lớn', N'80000 d', N'HD4')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE14', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD5')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE15', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD5')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE16', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD5')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE17', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD6')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE18', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD6')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE19', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD6')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE2', N'P06', N'SC02', N'Sinh Viên', N'65000 d', N'HD0')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE20', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD7')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE21', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD7')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE22', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD7')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE23', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE24', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE25', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE26', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE27', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE28', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE29', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE3', N'P06', N'SC02', N'Sinh Viên', N'65000 d', N'HD0')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE30', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE31', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE32', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE33', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE34', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE35', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE36', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE37', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE38', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE39', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE4', N'P06', N'SC02', N'Sinh Viên', N'65000 d', N'HD1')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE40', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE41', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE42', N'P01', N'SC01', N'Sinh Viên', N'65000 d', N'HD8')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE5', N'P06', N'SC02', N'Sinh Viên', N'65000 d', N'HD1')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE6', N'P06', N'SC02', N'Sinh Viên', N'65000 d', N'HD1')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE7', N'P10', N'SC01', N'Sinh Viên', N'65000 d', N'HD2')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE8', N'P10', N'SC01', N'Sinh Viên', N'65000 d', N'HD2')
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [MaSC], [Loai], [Gia], [MaHD]) VALUES (N'VE9', N'P10', N'SC01', N'Sinh Viên', N'65000 d', N'HD2')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uq_NhanVien_TenTK]    Script Date: 10/30/2021 10:19:59 PM ******/
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [uq_NhanVien_TenTK] UNIQUE NONCLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChoNgoi_Rap]  WITH CHECK ADD  CONSTRAINT [FK_ChoNgoi_Rap_SuatChieu] FOREIGN KEY([MaSC])
REFERENCES [dbo].[SuatChieu] ([MaSC])
GO
ALTER TABLE [dbo].[ChoNgoi_Rap] CHECK CONSTRAINT [FK_ChoNgoi_Rap_SuatChieu]
GO
ALTER TABLE [dbo].[LichChieu]  WITH CHECK ADD  CONSTRAINT [FK_LichChieu_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[LichChieu] CHECK CONSTRAINT [FK_LichChieu_Phim]
GO
ALTER TABLE [dbo].[SuatChieu]  WITH CHECK ADD  CONSTRAINT [FK_SuatChieu_LichChieu] FOREIGN KEY([MaLC])
REFERENCES [dbo].[LichChieu] ([MaLC])
GO
ALTER TABLE [dbo].[SuatChieu] CHECK CONSTRAINT [FK_SuatChieu_LichChieu]
GO
ALTER TABLE [dbo].[SuatChieu]  WITH CHECK ADD  CONSTRAINT [FK_SuatChieu_Rap] FOREIGN KEY([MaRap])
REFERENCES [dbo].[Rap] ([MaRap])
GO
ALTER TABLE [dbo].[SuatChieu] CHECK CONSTRAINT [FK_SuatChieu_Rap]
GO
