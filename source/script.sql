USE [master]
GO
/****** Object:  Database [QLTV]    Script Date: 5/28/2018 6:29:00 PM ******/
WHILE EXISTS(select NULL from sys.databases where name='QLTV')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLTV') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE QLTV
END
GO
/****** Object:  Database [QLTV]    Script Date: 6/27/2018 9:21:44 PM ******/
CREATE DATABASE [QLTV]
 CONTAINMENT = NONE
ALTER DATABASE [QLTV] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLTV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLTV] SET QUERY_STORE = OFF
GO
USE [QLTV]
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
USE [QLTV]
GO
/****** Object:  Table [dbo].[tblCTPhieuMuonSach]    Script Date: 6/29/2018 6:51:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTPhieuMuonSach](
	[maCTphieumuonsach] [varchar](10) NOT NULL,
	[maphieumuonsach] [varchar](10) NOT NULL,
	[masach] [varchar](10) NOT NULL,
	[ghichu] [nvarchar](10) NULL,
 CONSTRAINT [PK_tblCTPhieuMuonSach] PRIMARY KEY CLUSTERED 
(
	[maCTphieumuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDocGia]    Script Date: 6/29/2018 6:51:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDocGia](
	[madocgia] [varchar](10) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[maloaidocgia] [varchar](10) NOT NULL,
	[ngaysinh] [datetime2](7) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[ngaylapthe] [datetime2](7) NOT NULL,
	[ngayhethan] [datetime2](7) NOT NULL,
	[sosachdangmuon] [int] NOT NULL,
	[tinhtrangthe] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiDocGia]    Script Date: 6/29/2018 6:51:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiDocGia](
	[maloaidocgia] [varchar](10) NOT NULL,
	[tenloaidocgia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[maloaidocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiSach]    Script Date: 6/29/2018 6:51:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiSach](
	[maloaisach] [varchar](10) NOT NULL,
	[tenloaisach] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiSach] PRIMARY KEY CLUSTERED 
(
	[maloaisach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThuThu]    Script Date: 6/29/2018 6:51:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThuThu](
	[taikhoan] [varchar](50) NOT NULL,
	[matkhau] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblThuThu] PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhaXuatBan]    Script Date: 6/29/2018 6:51:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaXuatBan](
	[manhaxuatban] [varchar](10) NOT NULL,
	[tennhaxuatban] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblNhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[manhaxuatban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuMuonSach]    Script Date: 6/29/2018 6:51:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuMuonSach](
	[maphieumuonsach] [varchar](10) NOT NULL,
	[madocgia] [varchar](10) NOT NULL,
	[ngaymuon] [datetime2](7) NOT NULL,
	[ngaytra] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblPhieuMuonSach] PRIMARY KEY CLUSTERED 
(
	[maphieumuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblQuyDinh]    Script Date: 6/29/2018 6:51:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQuyDinh](
	[tuoitoithieu] [int] NOT NULL,
	[tuoitoida] [int] NOT NULL,
	[thoigiansudung] [int] NOT NULL,
	[khoangnamxuatban] [int] NOT NULL,
	[sosachmuontoida] [int] NOT NULL,
	[songaymuontoida] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSach]    Script Date: 6/29/2018 6:51:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSach](
	[masach] [varchar](10) NOT NULL,
	[tensach] [nvarchar](50) NOT NULL,
	[maloaisach] [varchar](10) NOT NULL,
	[matacgia] [varchar](10) NOT NULL,
	[namxuatban] [datetime2](7) NOT NULL,
	[ngaynhap] [datetime2](7) NOT NULL,
	[manhaxuatban] [varchar](10) NOT NULL,
	[trigia] [int] NOT NULL,
	[matinhtrangsach] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTacGia]    Script Date: 6/29/2018 6:51:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTacGia](
	[matacgia] [varchar](10) NOT NULL,
	[tentacgia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTacGia] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTinhTrangSach]    Script Date: 6/29/2018 6:51:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTinhTrangSach](
	[matinhtrangsach] [varchar](10) NOT NULL,
	[tentinhtrangsach] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTinhTrangSach] PRIMARY KEY CLUSTERED 
(
	[matinhtrangsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblCTPhieuMuonSach] ([maCTphieumuonsach], [maphieumuonsach], [masach], [ghichu]) VALUES (N'C18000000', N'P18000000', N'S18000003', N'Trả Trễ')
INSERT [dbo].[tblCTPhieuMuonSach] ([maCTphieumuonsach], [maphieumuonsach], [masach], [ghichu]) VALUES (N'C18000001', N'P18000000', N'S18000001', N'Trả Trễ')
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan], [sosachdangmuon], [tinhtrangthe]) VALUES (N'1', N'Khang Trương', N'1', CAST(N'1998-12-30T00:00:00.0000000' AS DateTime2), N'KTX Khu A', N'khang@gmail.com', CAST(N'2015-12-30T00:00:00.0000000' AS DateTime2), CAST(N'1998-12-30T00:00:00.0000000' AS DateTime2), 1, N'Còn hạn')
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan], [sosachdangmuon], [tinhtrangthe]) VALUES (N'2', N'Hiệp Gà', N'1', CAST(N'1998-12-30T00:00:00.0000000' AS DateTime2), N'KTX Khu N', N'cc@gmail.com', CAST(N'2015-12-30T00:00:00.0000000' AS DateTime2), CAST(N'1998-12-30T00:00:00.0000000' AS DateTime2), 0, N'Còn hạn')
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (N'1', N'X')
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (N'2', N'Y')
INSERT [dbo].[tblLoaiSach] ([maloaisach], [tenloaisach]) VALUES (N'LS001', N'A')
INSERT [dbo].[tblLoaiSach] ([maloaisach], [tenloaisach]) VALUES (N'LS002', N'B')
INSERT [dbo].[tblLoaiSach] ([maloaisach], [tenloaisach]) VALUES (N'LS003', N'C')
INSERT [dbo].[tblNhaXuatBan] ([manhaxuatban], [tennhaxuatban]) VALUES (N'NXB001', N'Kim Đồng ')
INSERT [dbo].[tblNhaXuatBan] ([manhaxuatban], [tennhaxuatban]) VALUES (N'NXB002', N'IPM')
INSERT [dbo].[tblPhieuMuonSach] ([maphieumuonsach], [madocgia], [ngaymuon], [ngaytra]) VALUES (N'P18000000', N'1', CAST(N'2018-05-28T23:23:54.7666667' AS DateTime2), CAST(N'2018-06-01T23:23:54.4100000' AS DateTime2))
INSERT [dbo].[tblPhieuMuonSach] ([maphieumuonsach], [madocgia], [ngaymuon], [ngaytra]) VALUES (N'P18000001', N'1', CAST(N'2018-06-28T23:24:34.7000000' AS DateTime2), CAST(N'2018-07-01T23:24:34.6300000' AS DateTime2))
INSERT [dbo].[tblQuyDinh] ([tuoitoithieu], [tuoitoida], [thoigiansudung], [khoangnamxuatban], [sosachmuontoida], [songaymuontoida]) VALUES (18, 55, 6, 8, 5, 4)
INSERT [dbo].[tblSach] ([masach], [tensach], [maloaisach], [matacgia], [namxuatban], [ngaynhap], [manhaxuatban], [trigia], [matinhtrangsach]) VALUES (N'S18000000', N'CTRR', N'LS001', N'TG001', CAST(N'2018-06-27T23:18:56.9400000' AS DateTime2), CAST(N'2018-06-27T23:18:56.9400000' AS DateTime2), N'NXB001', 30000, N'1')
INSERT [dbo].[tblSach] ([masach], [tensach], [maloaisach], [matacgia], [namxuatban], [ngaynhap], [manhaxuatban], [trigia], [matinhtrangsach]) VALUES (N'S18000001', N'XSTK', N'LS001', N'TG025', CAST(N'2018-06-27T23:20:13.8600000' AS DateTime2), CAST(N'2018-06-27T23:20:13.8600000' AS DateTime2), N'NXB001', 30000, N'1')
INSERT [dbo].[tblSach] ([masach], [tensach], [maloaisach], [matacgia], [namxuatban], [ngaynhap], [manhaxuatban], [trigia], [matinhtrangsach]) VALUES (N'S18000002', N'GT', N'LS001', N'TG001', CAST(N'2018-06-27T23:20:32.7000000' AS DateTime2), CAST(N'2018-06-27T23:20:32.7000000' AS DateTime2), N'NXB001', 30000, N'1')
INSERT [dbo].[tblSach] ([masach], [tensach], [maloaisach], [matacgia], [namxuatban], [ngaynhap], [manhaxuatban], [trigia], [matinhtrangsach]) VALUES (N'S18000003', N'HDH', N'LS002', N'TG025', CAST(N'2018-06-27T23:20:45.7833333' AS DateTime2), CAST(N'2018-06-27T23:20:45.7833333' AS DateTime2), N'NXB001', 30000, N'1')
INSERT [dbo].[tblSach] ([masach], [tensach], [maloaisach], [matacgia], [namxuatban], [ngaynhap], [manhaxuatban], [trigia], [matinhtrangsach]) VALUES (N'S18000004', N'CSDL', N'LS001', N'TG078', CAST(N'2018-06-27T23:21:16.9000000' AS DateTime2), CAST(N'2018-06-27T23:21:16.9000000' AS DateTime2), N'NXB001', 30000, N'1')
INSERT [dbo].[tblSach] ([masach], [tensach], [maloaisach], [matacgia], [namxuatban], [ngaynhap], [manhaxuatban], [trigia], [matinhtrangsach]) VALUES (N'S18000005', N'KTLT', N'LS002', N'TG015', CAST(N'2018-06-27T23:21:40.4400000' AS DateTime2), CAST(N'2018-06-27T23:21:40.4400000' AS DateTime2), N'NXB001', 30000, N'1')
INSERT [dbo].[tblSach] ([masach], [tensach], [maloaisach], [matacgia], [namxuatban], [ngaynhap], [manhaxuatban], [trigia], [matinhtrangsach]) VALUES (N'S18000006', N'LTTQ', N'LS003', N'TG001', CAST(N'2018-06-27T23:18:56.9400000' AS DateTime2), CAST(N'2018-06-27T23:18:56.9400000' AS DateTime2), N'NXB001', 30000, N'1')
INSERT [dbo].[tblSach] ([masach], [tensach], [maloaisach], [matacgia], [namxuatban], [ngaynhap], [manhaxuatban], [trigia], [matinhtrangsach]) VALUES (N'S18000007', N'CNPM', N'LS003', N'TG025', CAST(N'2018-06-27T23:20:13.8600000' AS DateTime2), CAST(N'2018-06-27T23:20:13.8600000' AS DateTime2), N'NXB001', 30000, N'1')
INSERT [dbo].[tblSach] ([masach], [tensach], [maloaisach], [matacgia], [namxuatban], [ngaynhap], [manhaxuatban], [trigia], [matinhtrangsach]) VALUES (N'S18000008', N'LTTQ', N'LS003', N'TG001', CAST(N'2018-06-27T23:20:32.7000000' AS DateTime2), CAST(N'2018-06-27T23:20:32.7000000' AS DateTime2), N'NXB001', 30000, N'1')
INSERT [dbo].[tblSach] ([masach], [tensach], [maloaisach], [matacgia], [namxuatban], [ngaynhap], [manhaxuatban], [trigia], [matinhtrangsach]) VALUES (N'S18000009', N'TTHCM', N'LS002', N'TG025', CAST(N'2018-06-27T23:20:45.7833333' AS DateTime2), CAST(N'2018-06-27T23:20:45.7833333' AS DateTime2), N'NXB001', 30000, N'1')
INSERT [dbo].[tblSach] ([masach], [tensach], [maloaisach], [matacgia], [namxuatban], [ngaynhap], [manhaxuatban], [trigia], [matinhtrangsach]) VALUES (N'S18000010', N'DLDCSVN', N'LS001', N'TG078', CAST(N'2018-06-27T23:21:16.9000000' AS DateTime2), CAST(N'2018-06-27T23:21:16.9000000' AS DateTime2), N'NXB001', 30000, N'1')
INSERT [dbo].[tblSach] ([masach], [tensach], [maloaisach], [matacgia], [namxuatban], [ngaynhap], [manhaxuatban], [trigia], [matinhtrangsach]) VALUES (N'S18000011', N'Pỏn', N'LS002', N'TG015', CAST(N'2018-06-27T23:21:40.4400000' AS DateTime2), CAST(N'2018-06-27T23:21:40.4400000' AS DateTime2), N'NXB001', 30000, N'1')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG001', N'Hồ Chí Minh')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG002', N'Hamlet Trương')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG003', N'Nguyễn Ngọc Thạch')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG004', N'Anh Khang')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG005', N'Hà Minh Tuân')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG006', N'Anh Khang')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG007', N'Nguyễn Thế Phương')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG008', N'Bùi Bình Thi')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG009', N'Đỗ Quang Tiến')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG010', N'Huy Phương')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG011', N'Siêu Hải')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG012', N'Xuân Sách')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG013', N'Võ Hồng')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG014', N'Nhật Tuấn')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG015', N'Nguyễn Văn Xuân')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG016', N'Nguyễn Lương Ngọc')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG017', N'Dương Kiều Minh')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG018', N'Xuân Miễn')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG019', N'Trần Quang Long')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG020', N'Lê Văn Ngăn')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG021', N'Ngô Kha')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG022', N'Guillaume Musso')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG023', N'Marc Levy')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG024', N'Thierry Cohen')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG025', N'Anna Gavalda')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG026', N'David Foenkinos')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG027', N'Eric-Emmanuel Schmitt')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG028', N'Frédéric Beigbeder')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG029', N'Didier van Cauwelaert')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG030', N'Agnès Abécassis')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG031', N'Agathe Hochberg')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG032', N'Đỗ Phủ')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG033', N'Lý Bạch')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG034', N'Bạch Cư Dị')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG035', N'Vương Bột')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG036', N'Tào Tuyết Cần')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG037', N'Tô Thức')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG038', N'Lỗ Tấn')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG039', N'Lục Du')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG040', N'Điền Hán')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG041', N'Khuất Nguyên')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG042', N'Phùng Quán')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG043', N'Phan Kế Bính')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG045', N'Đặng Thai Mai')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG046', N'Ma Văn Kháng')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG047', N'Xuân Diệu')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG048', N'Lý Lai')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG049', N'Nguyễn Nhật Ánh')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG050', N'Hoài Thanh')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG051', N'Tản Đà')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG052', N'Tú Mỡ')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG053', N'Thế Lữ')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG054', N'Nguyễn Du')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG055', N'Ngô Tất Tố')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG056', N'Kim Lân')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG057', N'Thanh Tịnh')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG058', N'Tạ Duy Anh')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG059', N'Phan Thị Thanh Nhàn')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG060', N'Nguyễn Khải')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG061', N'Nguyễn Đình Chiểu')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG062', N'Khái Hưng')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG063', N'Nhất Linh')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG064', N'Vũ Trọng Phụng')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG065', N'Đồng Hoa')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG066', N'Đinh Mặc')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG067', N'Phỉ Ngã Tư Tồn')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG068', N'Yếm Bút Tiêu Sinh')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG069', N'Nhĩ Căn')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG070', N'Thiên tàm thổ đậu')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG071', N'Thần Đông')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG072', N'Đường gia tam thiếu')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG073', N'phong lăng thiên hạ')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG074', N'Lão Ngũ')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG075', N'Cô đơn địa phi')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG076', N'phát tiêu đích oa ngưu')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG077', N'Ngã Cật Tây Hồng Thị')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG078', N'Vong Ngữ')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG079', N'Trạch Ngư')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG080', N'Tân Phong')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG081', N'Miêu Mị')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG082', N'Hồ Điệp Lam')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG083', N'Hoành tảo thiên nhai')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG084', N'Phong Lăng thiên hạ')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG085', N'Vũ Phong')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG086', N'Hắc Thạch Bộ')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG087', N'Thái Nhật Sinh Thủy')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG088', N'Eiichiro Oda')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG089', N'Akira Toriyama')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG090', N'Fujiko Fujio')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG091', N'Masashi Kishimoto')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG092', N'Naoki Urasawa')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG093', N'Takeshi Obata')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG094', N'Osamu Tezuka')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG095', N'CLAMP')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG096', N'Yoshihiro Togashi')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG097', N'Rumiko Takahashi')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG098', N'Hiro Mashima')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG099', N'Gosho Aoyama')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'TG100', N'Nobuhiro Watsuki')
INSERT [dbo].[tblTinhTrangSach] ([matinhtrangsach], [tentinhtrangsach]) VALUES (N'1', N'Co San')
INSERT [dbo].[tblTinhTrangSach] ([matinhtrangsach], [tentinhtrangsach]) VALUES (N'2', N'Khong Co San')
ALTER TABLE [dbo].[tblCTPhieuMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_tblCTPhieuMuonSach_tblPhieuMuonSach] FOREIGN KEY([maphieumuonsach])
REFERENCES [dbo].[tblPhieuMuonSach] ([maphieumuonsach])
GO
ALTER TABLE [dbo].[tblCTPhieuMuonSach] CHECK CONSTRAINT [FK_tblCTPhieuMuonSach_tblPhieuMuonSach]
GO
ALTER TABLE [dbo].[tblCTPhieuMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_tblCTPhieuMuonSach_tblSach] FOREIGN KEY([masach])
REFERENCES [dbo].[tblSach] ([masach])
GO
ALTER TABLE [dbo].[tblCTPhieuMuonSach] CHECK CONSTRAINT [FK_tblCTPhieuMuonSach_tblSach]
GO
ALTER TABLE [dbo].[tblDocGia]  WITH CHECK ADD  CONSTRAINT [FK_tblDocGia_tblLoaiDocGia] FOREIGN KEY([maloaidocgia])
REFERENCES [dbo].[tblLoaiDocGia] ([maloaidocgia])
GO
ALTER TABLE [dbo].[tblDocGia] CHECK CONSTRAINT [FK_tblDocGia_tblLoaiDocGia]
GO
ALTER TABLE [dbo].[tblPhieuMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuMuonSach_tblDocGia] FOREIGN KEY([madocgia])
REFERENCES [dbo].[tblDocGia] ([madocgia])
GO
ALTER TABLE [dbo].[tblPhieuMuonSach] CHECK CONSTRAINT [FK_tblPhieuMuonSach_tblDocGia]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_tblSach_tblLoaiSach] FOREIGN KEY([maloaisach])
REFERENCES [dbo].[tblLoaiSach] ([maloaisach])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_tblSach_tblLoaiSach]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_tblSach_tblNhaXuatBan] FOREIGN KEY([manhaxuatban])
REFERENCES [dbo].[tblNhaXuatBan] ([manhaxuatban])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_tblSach_tblNhaXuatBan]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_tblSach_tblTacGia] FOREIGN KEY([matacgia])
REFERENCES [dbo].[tblTacGia] ([matacgia])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_tblSach_tblTacGia]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_tblSach_tblTinhTrangSach] FOREIGN KEY([matinhtrangsach])
REFERENCES [dbo].[tblTinhTrangSach] ([matinhtrangsach])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_tblSach_tblTinhTrangSach]
GO
/****** Object:  StoredProcedure [dbo].[loadListSach]    Script Date: 6/29/2018 6:51:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loadListSach] 
as
begin
	select masach, tensach,tenloaisach, tennhaxuatban, tentacgia, namxuatban, ngaynhap, trigia, tentinhtrangsach
	from tblSach
	left join tblLoaiSach on tblSach.maloaisach = tblLoaiSach.maloaisach
	left join tblTacGia on tblSach.matacgia = tblTacGia.matacgia
	left join tblNhaXuatBan on tblSach.manhaxuatban = tblNhaXuatBan.manhaxuatban
	join tblTinhTrangSach on tblSach.matinhtrangsach = tblTinhTrangSach.matinhtrangsach
end
GO
/****** Object:  StoredProcedure [dbo].[loadPhieuMuonSach]    Script Date: 6/29/2018 6:51:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loadPhieuMuonSach]
as 
begin
	select tblPhieuMuonSach.maphieumuonsach, hoten, tensach, tenloaisach, tentacgia, tblPhieuMuonSach.ngaymuon, ghichu 
	from tblPhieuMuonSach
	left join tblDocGia on tblPhieuMuonSach.madocgia = tblDocGia.madocgia
	left join tblCTPhieuMuonSach on tblPhieuMuonSach.maphieumuonsach = tblCTPhieuMuonSach.maphieumuonsach
	left join tblSach on tblSach.masach = tblCTPhieuMuonSach.masach
	left join tblLoaiSach on tblSach.maloaisach = tblLoaiSach.maloaisach
	left join tblTacGia on tblSach.matacgia = tblTacGia.matacgia
end
GO
/****** Object:  StoredProcedure [dbo].[LoadSachDGDangMuon]    Script Date: 6/29/2018 6:51:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc[dbo].[LoadSachDGDangMuon]
@mdg varchar(10)
as
begin
select pms.maphieumuonsach as MaPhieuMuon,s.masach as MaSach,s.tensach as TenSach, ghichu
from tblSach s,tblCTPhieuMuonSach ctpms, tblPhieuMuonSach pms
where s.masach = ctpms.masach and ctpms.maphieumuonsach = pms.maphieumuonsach and madocgia = @mdg and ctpms.ghichu Like N'%Mượn%'
order by s.masach asc
end
GO
/****** Object:  StoredProcedure [dbo].[PMS_DGDangMuon]    Script Date: 6/29/2018 6:51:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc[dbo].[PMS_DGDangMuon]
@mdg varchar(10)
as
begin
select pms.maphieumuonsach as mapms,ngaymuon,ngaytra 
from tblPhieuMuonSach pms, tblCTPhieuMuonSach ct
where pms.maphieumuonsach = ct.maphieumuonsach and pms.madocgia = @mdg and ct.ghichu Like N'%Mượn%'
group by pms.maphieumuonsach,ngaymuon,ngaytra 
order by pms.maphieumuonsach
end

GO
/****** Object:  StoredProcedure [dbo].[spGetDataBaoCaoBaoCaoTHMSTTL]    Script Date: 6/29/2018 6:51:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[spGetDataBaoCaoBaoCaoTHMSTTL] 
@mm integer,
@yy integer
as 
Begin
	Select tenloaisach, COUNT(tblSach.masach) As demmasach , CONVERT(varchar, 100* COUNT(tblSach.masach) / (select COUNT(tblLoaiSach.maloaisach)
	From tblLoaiSach Left Join tblSach On tblLoaiSach.maloaisach = tblSach.maloaisach Left Join tblCTPhieuMuonSach on tblCTPhieuMuonSach.masach = tblSach.masach Left Join tblPhieuMuonSach on tblPhieuMuonSach.maphieumuonsach = tblCTPhieuMuonSach.maphieumuonsach 
	where Month(ngaymuon) = @mm and Year(ngaymuon) = @yy)) + '%' As tile
	From tblLoaiSach Left Join tblSach On tblLoaiSach.maloaisach = tblSach.maloaisach Left Join tblCTPhieuMuonSach on tblCTPhieuMuonSach.masach = tblSach.masach Left Join tblPhieuMuonSach on tblPhieuMuonSach.maphieumuonsach = tblCTPhieuMuonSach.maphieumuonsach 
	where Month(ngaymuon) = @mm and Year(ngaymuon) = @yy 
	group by tblLoaiSach.maloaisach, tenloaisach
End
GO
/****** Object:  StoredProcedure [dbo].[spLoadlistSachDM]    Script Date: 6/29/2018 6:51:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc[dbo].[spLoadlistSachDM]
@mdg varchar(10),
@mpm varchar(10)
as
begin
select s.masach as masach, matacgia,tensach,maloaisach,manhaxuatban,namxuatban,ngaynhap,trigia,matinhtrangsach
from tblSach s,tblCTPhieuMuonSach ctpms, tblPhieuMuonSach pms
where s.masach = ctpms.masach and ctpms.maphieumuonsach = pms.maphieumuonsach and madocgia = @mdg and pms.maphieumuonsach = @mpm and ctpms.ghichu Like N'%Mượn%'
order by s.masach asc
end
GO
/****** Object:  StoredProcedure [dbo].[spSelectAllWithFilter]    Script Date: 6/29/2018 6:51:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spSelectAllWithFilter]
( 
@col nvarchar(50),
@fil nvarchar(50)
)
as 
Begin
    if (@col ='masach')
		(SELECT masach, tensach, tenloaisach, tentacgia, tennhaxuatban, namxuatban, ngaynhap, trigia, tentinhtrangsach
		from tblSach
		left join tblLoaiSach on tblSach.maloaisach = tblLoaiSach.maloaisach
		left join tblTacGia on tblTacGia.matacgia = tblSach.matacgia
		left join tblNhaXuatBan on tblSach.manhaxuatban = tblNhaXuatBan.manhaxuatban
		left join tblTinhTrangSach on tblSach.matinhtrangsach = tblTinhTrangSach.matinhtrangsach
		where masach like @fil)
	else
	if (@col = 'tensach')
		(SELECT masach, tensach, tenloaisach, tentacgia, tennhaxuatban, namxuatban, ngaynhap, trigia, tentinhtrangsach
		from tblSach
		left join tblLoaiSach on tblSach.maloaisach = tblLoaiSach.maloaisach
		left join tblTacGia on tblTacGia.matacgia = tblSach.matacgia
		left join tblNhaXuatBan on tblSach.manhaxuatban = tblNhaXuatBan.manhaxuatban
		left join tblTinhTrangSach on tblSach.matinhtrangsach = tblTinhTrangSach.matinhtrangsach
		where tensach like @fil)
	else 
	if (@col='tenloaisach')
		(SELECT masach, tensach, tenloaisach, tentacgia, tennhaxuatban, namxuatban, ngaynhap, trigia, tentinhtrangsach
		from tblSach
		left join tblLoaiSach on tblSach.maloaisach = tblLoaiSach.maloaisach
		left join tblTacGia on tblTacGia.matacgia = tblSach.matacgia
		left join tblNhaXuatBan on tblSach.manhaxuatban = tblNhaXuatBan.manhaxuatban
		left join tblTinhTrangSach on tblSach.matinhtrangsach = tblTinhTrangSach.matinhtrangsach
		where tenloaisach like @fil)
	else
	if (@col = 'tentacgia')
		(SELECT masach, tensach, tenloaisach, tentacgia, tennhaxuatban, namxuatban, ngaynhap, trigia, tentinhtrangsach
		from tblSach
		left join tblLoaiSach on tblSach.maloaisach = tblLoaiSach.maloaisach
		left join tblTacGia on tblTacGia.matacgia = tblSach.matacgia
		left join tblNhaXuatBan on tblSach.manhaxuatban = tblNhaXuatBan.manhaxuatban
		left join tblTinhTrangSach on tblSach.matinhtrangsach = tblTinhTrangSach.matinhtrangsach
		where tentacgia like @fil)
	else 
	if (@col='year(namxuatban)')
		(SELECT masach, tensach, tenloaisach, tentacgia, tennhaxuatban, namxuatban, ngaynhap, trigia, tentinhtrangsach
		from tblSach
		left join tblLoaiSach on tblSach.maloaisach = tblLoaiSach.maloaisach
		left join tblTacGia on tblTacGia.matacgia = tblSach.matacgia
		left join tblNhaXuatBan on tblSach.manhaxuatban = tblNhaXuatBan.manhaxuatban
		left join tblTinhTrangSach on tblSach.matinhtrangsach = tblTinhTrangSach.matinhtrangsach
		where year(namxuatban) like @fil)
	else
	if (@col = 'tennhaxuatban')
		(SELECT masach, tensach, tenloaisach, tentacgia, tennhaxuatban, namxuatban, ngaynhap, trigia, tentinhtrangsach
		from tblSach
		left join tblLoaiSach on tblSach.maloaisach = tblLoaiSach.maloaisach
		left join tblTacGia on tblTacGia.matacgia = tblSach.matacgia
		left join tblNhaXuatBan on tblSach.manhaxuatban = tblNhaXuatBan.manhaxuatban
		left join tblTinhTrangSach on tblSach.matinhtrangsach = tblTinhTrangSach.matinhtrangsach
		where tennhaxuatban like @fil)
	if (@col = 'trigia')
		(SELECT masach, tensach, tenloaisach, tentacgia, tennhaxuatban, namxuatban, ngaynhap, trigia, tentinhtrangsach
		from tblSach
		left join tblLoaiSach on tblSach.maloaisach = tblLoaiSach.maloaisach
		left join tblTacGia on tblTacGia.matacgia = tblSach.matacgia
		left join tblNhaXuatBan on tblSach.manhaxuatban = tblNhaXuatBan.manhaxuatban
		left join tblTinhTrangSach on tblSach.matinhtrangsach = tblTinhTrangSach.matinhtrangsach
		where trigia like @fil)
End
GO



/****** Object:  StoredProcedure [dbo].[spTraSachUpdate]    Script Date: 6/29/2018 6:51:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc[dbo].[spTraSachUpdate]
@madocgia varchar(10),
@mpm varchar(10),
@ms varchar(10),
@gc nvarchar(50)
as
begin
	UPDATE tblCTPhieuMuonSach 
	SET ghichu = @gc
	WHERE tblCTPhieuMuonSach.maphieumuonsach = (SELECT pms.maphieumuonsach
												  FROM tblPhieuMuonSach pms
												  WHERE pms.maphieumuonsach = @mpm and pms.madocgia = @madocgia) and tblCTPhieuMuonSach.masach = @ms
end 

GO

insert into tblThuThu values ('admin','admin')


USE [master]
USE [QLTV]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO


