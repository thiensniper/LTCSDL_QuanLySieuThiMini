USE [QLSieuThiMini]
GO
/****** Object:  Table [dbo].[tbl_ChiTietHD]    Script Date: 19/10/2018 8:42:10 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChiTietHD](
	[IdHD] [int] NOT NULL,
	[IdHH] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
 CONSTRAINT [PK_tbl_ChiTietHD] PRIMARY KEY CLUSTERED 
(
	[IdHD] ASC,
	[IdHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_ChiTietNhapHang]    Script Date: 19/10/2018 8:42:10 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChiTietNhapHang](
	[IdNhapHang] [int] NOT NULL,
	[IdHH] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiaNhap] [int] NOT NULL,
	[NgayHetHan] [datetime] NOT NULL,
 CONSTRAINT [PK_tbl_ChiTietNhapHang] PRIMARY KEY CLUSTERED 
(
	[IdNhapHang] ASC,
	[IdHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_HangHoa]    Script Date: 19/10/2018 8:42:10 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HangHoa](
	[Id] [int] NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[IdLoaiHang] [int] NOT NULL,
	[GiaBan] [int] NOT NULL,
 CONSTRAINT [PK_tbl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_HoaDon]    Script Date: 19/10/2018 8:42:10 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HoaDon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[NguoiLap] [int] NOT NULL,
 CONSTRAINT [PK_tbl_HoaDon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_LoaiHangHoa]    Script Date: 19/10/2018 8:42:10 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_LoaiHangHoa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_LoaiHangHoa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_NhapHang]    Script Date: 19/10/2018 8:42:10 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NhapHang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
	[IdNguoiNhap] [int] NOT NULL,
 CONSTRAINT [PK_tbl_NhapHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_TaiKhoan]    Script Date: 19/10/2018 8:42:10 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TaiKhoan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[Sdt] [nvarchar](10) NOT NULL,
	[TenDangNhap] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](100) NOT NULL,
	[Quyen] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tbl_ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ChiTietHD_tbl_HangHoa] FOREIGN KEY([IdHH])
REFERENCES [dbo].[tbl_HangHoa] ([Id])
GO
ALTER TABLE [dbo].[tbl_ChiTietHD] CHECK CONSTRAINT [FK_tbl_ChiTietHD_tbl_HangHoa]
GO
ALTER TABLE [dbo].[tbl_ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ChiTietHD_tbl_HoaDon] FOREIGN KEY([IdHD])
REFERENCES [dbo].[tbl_HoaDon] ([Id])
GO
ALTER TABLE [dbo].[tbl_ChiTietHD] CHECK CONSTRAINT [FK_tbl_ChiTietHD_tbl_HoaDon]
GO
ALTER TABLE [dbo].[tbl_ChiTietNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ChiTietNhapHang_tbl_HangHoa] FOREIGN KEY([IdHH])
REFERENCES [dbo].[tbl_HangHoa] ([Id])
GO
ALTER TABLE [dbo].[tbl_ChiTietNhapHang] CHECK CONSTRAINT [FK_tbl_ChiTietNhapHang_tbl_HangHoa]
GO
ALTER TABLE [dbo].[tbl_ChiTietNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ChiTietNhapHang_tbl_NhapHang] FOREIGN KEY([IdNhapHang])
REFERENCES [dbo].[tbl_NhapHang] ([Id])
GO
ALTER TABLE [dbo].[tbl_ChiTietNhapHang] CHECK CONSTRAINT [FK_tbl_ChiTietNhapHang_tbl_NhapHang]
GO
ALTER TABLE [dbo].[tbl_HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HangHoa_tbl_LoaiHangHoa] FOREIGN KEY([IdLoaiHang])
REFERENCES [dbo].[tbl_LoaiHangHoa] ([Id])
GO
ALTER TABLE [dbo].[tbl_HangHoa] CHECK CONSTRAINT [FK_tbl_HangHoa_tbl_LoaiHangHoa]
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tbl_TaiKhoan] FOREIGN KEY([NguoiLap])
REFERENCES [dbo].[tbl_TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_tbl_HoaDon_tbl_TaiKhoan]
GO
ALTER TABLE [dbo].[tbl_NhapHang]  WITH CHECK ADD  CONSTRAINT [FK_tbl_NhapHang_tbl_TaiKhoan] FOREIGN KEY([IdNguoiNhap])
REFERENCES [dbo].[tbl_TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[tbl_NhapHang] CHECK CONSTRAINT [FK_tbl_NhapHang_tbl_TaiKhoan]
GO
