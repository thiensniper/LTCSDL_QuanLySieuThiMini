USE [master]
GO
/****** Object:  Database [QLSieuThiMini]    Script Date: 11/09/2018 11:48:12 AM ******/
CREATE DATABASE [QLSieuThiMini]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSieuThiMini', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QLSieuThiMini.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLSieuThiMini_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QLSieuThiMini_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QLSieuThiMini] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSieuThiMini].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSieuThiMini] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSieuThiMini] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSieuThiMini] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSieuThiMini] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSieuThiMini] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET RECOVERY FULL 
GO
ALTER DATABASE [QLSieuThiMini] SET  MULTI_USER 
GO
ALTER DATABASE [QLSieuThiMini] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSieuThiMini] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSieuThiMini] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSieuThiMini] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLSieuThiMini] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLSieuThiMini', N'ON'
GO
ALTER DATABASE [QLSieuThiMini] SET QUERY_STORE = OFF
GO
USE [QLSieuThiMini]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QLSieuThiMini]
GO
/****** Object:  Table [dbo].[tbl_Admin]    Script Date: 11/09/2018 11:48:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Admin](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[NameOfAdmin] [nvarchar](100) NOT NULL,
	[TelOfAdmin] [nvarchar](10) NOT NULL,
	[UsernameOfAdmin] [nvarchar](100) NOT NULL,
	[PasswordOfAdmin] [nvarchar](100) NOT NULL,
	[AuthorizationOfAdmin] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Bill]    Script Date: 11/09/2018 11:48:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Bill](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[BilledDate] [int] NOT NULL,
	[AdminID] [int] NOT NULL,
	[CustomerID] [int] NULL,
 CONSTRAINT [PK_tbl_HoaDon] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 11/09/2018 11:48:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[NameOfCustomer] [nvarchar](100) NULL,
	[TelOfCustomer] [nvarchar](10) NULL,
	[EmailOfCustomer] [nvarchar](100) NULL,
	[AddressOfCustomer] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbl_KhachHang] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_DetailedBill]    Script Date: 11/09/2018 11:48:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DetailedBill](
	[IDBill] [int] NOT NULL,
	[IDProduct] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[UnitPrice] [int] NOT NULL,
 CONSTRAINT [PK_tbl_ChiTietHD] PRIMARY KEY CLUSTERED 
(
	[IDBill] ASC,
	[IDProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_DetailedImportedProduct]    Script Date: 11/09/2018 11:48:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DetailedImportedProduct](
	[ImportedProductID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[NumberOfImportedProduct] [int] NOT NULL,
	[PriceOfImportedProduct] [int] NOT NULL,
	[DateOfExpiration] [int] NOT NULL,
 CONSTRAINT [PK_tbl_ChiTietNhapHang] PRIMARY KEY CLUSTERED 
(
	[ImportedProductID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ImportedProduct]    Script Date: 11/09/2018 11:48:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ImportedProduct](
	[ImportedProductID] [int] IDENTITY(1,1) NOT NULL,
	[DateOfImportedProduct] [int] NOT NULL,
	[AdminID] [int] NOT NULL,
 CONSTRAINT [PK_tbl_NhapHang] PRIMARY KEY CLUSTERED 
(
	[ImportedProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Product]    Script Date: 11/09/2018 11:48:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[NameOfProduct] [nvarchar](100) NOT NULL,
	[NumberOfProduct] [int] NOT NULL,
	[ProductCategoryID] [int] NOT NULL,
	[PriceOfProduct] [int] NOT NULL,
 CONSTRAINT [PK_tbl] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ProductCategory]    Script Date: 11/09/2018 11:48:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ProductCategory](
	[ProductCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[NameOfProductCategory] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_LoaiHangHoa] PRIMARY KEY CLUSTERED 
(
	[ProductCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Admin] ON 

INSERT [dbo].[tbl_Admin] ([AdminID], [NameOfAdmin], [TelOfAdmin], [UsernameOfAdmin], [PasswordOfAdmin], [AuthorizationOfAdmin]) VALUES (1, N'Nguyễn Văn A', N'0123456789', N'admin', N'admin', N'Manager')
INSERT [dbo].[tbl_Admin] ([AdminID], [NameOfAdmin], [TelOfAdmin], [UsernameOfAdmin], [PasswordOfAdmin], [AuthorizationOfAdmin]) VALUES (3, N'Nguyễn Văn B', N'0321654987', N'admin2', N'admin2', N'Import')
INSERT [dbo].[tbl_Admin] ([AdminID], [NameOfAdmin], [TelOfAdmin], [UsernameOfAdmin], [PasswordOfAdmin], [AuthorizationOfAdmin]) VALUES (4, N'Nguyễn Văn C', N'0659873211', N'admin3', N'admin3', N'Export')
INSERT [dbo].[tbl_Admin] ([AdminID], [NameOfAdmin], [TelOfAdmin], [UsernameOfAdmin], [PasswordOfAdmin], [AuthorizationOfAdmin]) VALUES (14, N'dgd', N'dgd', N'gdgd', N'2121ssasa', N'Manager')
SET IDENTITY_INSERT [dbo].[tbl_Admin] OFF
SET IDENTITY_INSERT [dbo].[tbl_Bill] ON 

INSERT [dbo].[tbl_Bill] ([BillID], [BilledDate], [AdminID], [CustomerID]) VALUES (1, 40459, 1, NULL)
SET IDENTITY_INSERT [dbo].[tbl_Bill] OFF
SET IDENTITY_INSERT [dbo].[tbl_Customer] ON 

INSERT [dbo].[tbl_Customer] ([CustomerID], [NameOfCustomer], [TelOfCustomer], [EmailOfCustomer], [AddressOfCustomer]) VALUES (1, N'Nguyễn Văn B', N'0123456789', N'nva@gmail.com', N'123 Nguyễn Du')
INSERT [dbo].[tbl_Customer] ([CustomerID], [NameOfCustomer], [TelOfCustomer], [EmailOfCustomer], [AddressOfCustomer]) VALUES (3, N'dfs', N'fsd', N'sdf', N'fsddsfsdfds')
SET IDENTITY_INSERT [dbo].[tbl_Customer] OFF
SET IDENTITY_INSERT [dbo].[tbl_Product] ON 

INSERT [dbo].[tbl_Product] ([ProductID], [NameOfProduct], [NumberOfProduct], [ProductCategoryID], [PriceOfProduct]) VALUES (1, N'Nước tươngd', 3, 1, 20001)
INSERT [dbo].[tbl_Product] ([ProductID], [NameOfProduct], [NumberOfProduct], [ProductCategoryID], [PriceOfProduct]) VALUES (2, N'Nước mắmfdfd', 0, 2, 20033)
INSERT [dbo].[tbl_Product] ([ProductID], [NameOfProduct], [NumberOfProduct], [ProductCategoryID], [PriceOfProduct]) VALUES (3, N'df', 2, 1, 223)
INSERT [dbo].[tbl_Product] ([ProductID], [NameOfProduct], [NumberOfProduct], [ProductCategoryID], [PriceOfProduct]) VALUES (4, N'dddd', 2, 2, 23)
INSERT [dbo].[tbl_Product] ([ProductID], [NameOfProduct], [NumberOfProduct], [ProductCategoryID], [PriceOfProduct]) VALUES (10, N'sad', 0, 4, 0)
SET IDENTITY_INSERT [dbo].[tbl_Product] OFF
SET IDENTITY_INSERT [dbo].[tbl_ProductCategory] ON 

INSERT [dbo].[tbl_ProductCategory] ([ProductCategoryID], [NameOfProductCategory]) VALUES (1, N'Thức ăn nhanh')
INSERT [dbo].[tbl_ProductCategory] ([ProductCategoryID], [NameOfProductCategory]) VALUES (2, N'Gia vị')
INSERT [dbo].[tbl_ProductCategory] ([ProductCategoryID], [NameOfProductCategory]) VALUES (4, N'Thức ăn nhẹ')
SET IDENTITY_INSERT [dbo].[tbl_ProductCategory] OFF
ALTER TABLE [dbo].[tbl_Bill]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tbl_KhachHang] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tbl_Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[tbl_Bill] CHECK CONSTRAINT [FK_tbl_HoaDon_tbl_KhachHang]
GO
ALTER TABLE [dbo].[tbl_Bill]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tbl_TaiKhoan] FOREIGN KEY([AdminID])
REFERENCES [dbo].[tbl_Admin] ([AdminID])
GO
ALTER TABLE [dbo].[tbl_Bill] CHECK CONSTRAINT [FK_tbl_HoaDon_tbl_TaiKhoan]
GO
ALTER TABLE [dbo].[tbl_DetailedBill]  WITH CHECK ADD  CONSTRAINT [FK_tbl_DetailedBill_tbl_Bill] FOREIGN KEY([IDBill])
REFERENCES [dbo].[tbl_Bill] ([BillID])
GO
ALTER TABLE [dbo].[tbl_DetailedBill] CHECK CONSTRAINT [FK_tbl_DetailedBill_tbl_Bill]
GO
ALTER TABLE [dbo].[tbl_DetailedBill]  WITH CHECK ADD  CONSTRAINT [FK_tbl_DetailedBill_tbl_Product] FOREIGN KEY([IDProduct])
REFERENCES [dbo].[tbl_Product] ([ProductID])
GO
ALTER TABLE [dbo].[tbl_DetailedBill] CHECK CONSTRAINT [FK_tbl_DetailedBill_tbl_Product]
GO
ALTER TABLE [dbo].[tbl_DetailedImportedProduct]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ChiTietNhapHang_tbl_NhapHang] FOREIGN KEY([ImportedProductID])
REFERENCES [dbo].[tbl_ImportedProduct] ([ImportedProductID])
GO
ALTER TABLE [dbo].[tbl_DetailedImportedProduct] CHECK CONSTRAINT [FK_tbl_ChiTietNhapHang_tbl_NhapHang]
GO
ALTER TABLE [dbo].[tbl_DetailedImportedProduct]  WITH CHECK ADD  CONSTRAINT [FK_tbl_DetailedImportedProduct_tbl_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tbl_Product] ([ProductID])
GO
ALTER TABLE [dbo].[tbl_DetailedImportedProduct] CHECK CONSTRAINT [FK_tbl_DetailedImportedProduct_tbl_Product]
GO
ALTER TABLE [dbo].[tbl_Product]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HangHoa_tbl_LoaiHangHoa] FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[tbl_ProductCategory] ([ProductCategoryID])
GO
ALTER TABLE [dbo].[tbl_Product] CHECK CONSTRAINT [FK_tbl_HangHoa_tbl_LoaiHangHoa]
GO
USE [master]
GO
ALTER DATABASE [QLSieuThiMini] SET  READ_WRITE 
GO
