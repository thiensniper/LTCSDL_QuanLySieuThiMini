USE [master]
GO
/****** Object:  Database [QLSieuThiMini]    Script Date: 12/25/2018 9:11:30 AM ******/
CREATE DATABASE [QLSieuThiMini]
GO
USE [QLSieuThiMini]
GO
/****** Object:  Table [dbo].[tbl_Admin]    Script Date: 12/25/2018 9:11:30 AM ******/
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
/****** Object:  Table [dbo].[tbl_Bill]    Script Date: 12/25/2018 9:11:30 AM ******/
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
/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 12/25/2018 9:11:30 AM ******/
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
/****** Object:  Table [dbo].[tbl_DetailedBill]    Script Date: 12/25/2018 9:11:30 AM ******/
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
/****** Object:  Table [dbo].[tbl_Product]    Script Date: 12/25/2018 9:11:30 AM ******/
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
/****** Object:  Table [dbo].[tbl_ProductCategory]    Script Date: 12/25/2018 9:11:30 AM ******/
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
INSERT [dbo].[tbl_Admin] ([AdminID], [NameOfAdmin], [TelOfAdmin], [UsernameOfAdmin], [PasswordOfAdmin], [AuthorizationOfAdmin]) VALUES (3, N'Nguyễn Văn B', N'0321654987', N'admin2', N'admin2', N'Staff')
INSERT [dbo].[tbl_Admin] ([AdminID], [NameOfAdmin], [TelOfAdmin], [UsernameOfAdmin], [PasswordOfAdmin], [AuthorizationOfAdmin]) VALUES (4, N'Nguyễn Văn C', N'0659873211', N'admin3', N'admin3', N'Staff')
INSERT [dbo].[tbl_Admin] ([AdminID], [NameOfAdmin], [TelOfAdmin], [UsernameOfAdmin], [PasswordOfAdmin], [AuthorizationOfAdmin]) VALUES (14, N'dgd', N'dgd', N'gdgd', N'2121ssasa', N'Staff')
SET IDENTITY_INSERT [dbo].[tbl_Admin] OFF
SET IDENTITY_INSERT [dbo].[tbl_Bill] ON 

INSERT [dbo].[tbl_Bill] ([BillID], [BilledDate], [AdminID], [CustomerID]) VALUES (12, 20181225, 1, 2)
INSERT [dbo].[tbl_Bill] ([BillID], [BilledDate], [AdminID], [CustomerID]) VALUES (13, 20181225, 1, 1)
INSERT [dbo].[tbl_Bill] ([BillID], [BilledDate], [AdminID], [CustomerID]) VALUES (14, 20181225, 1, 1)
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
INSERT [dbo].[tbl_Product] ([ProductID], [NameOfProduct], [NumberOfProduct], [ProductCategoryID], [PriceOfProduct]) VALUES (11, N'dfs', 2, 2, 3)
SET IDENTITY_INSERT [dbo].[tbl_Product] OFF
SET IDENTITY_INSERT [dbo].[tbl_ProductCategory] ON 

INSERT [dbo].[tbl_ProductCategory] ([ProductCategoryID], [NameOfProductCategory]) VALUES (1, N'Thức ăn nhanh')
INSERT [dbo].[tbl_ProductCategory] ([ProductCategoryID], [NameOfProductCategory]) VALUES (2, N'Gia vị')
INSERT [dbo].[tbl_ProductCategory] ([ProductCategoryID], [NameOfProductCategory]) VALUES (4, N'Thức ăn nhẹ')
SET IDENTITY_INSERT [dbo].[tbl_ProductCategory] OFF
USE [master]
GO
ALTER DATABASE [QLSieuThiMini] SET  READ_WRITE 
GO
