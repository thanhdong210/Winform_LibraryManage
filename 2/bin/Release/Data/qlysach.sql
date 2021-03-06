USE [master]
GO
/****** Object:  Database [t434]    Script Date: 5/6/2021 10:19:40 AM ******/
CREATE DATABASE [t434]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N't434', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\t434.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N't434_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\t434_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [t434] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [t434].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [t434] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [t434] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [t434] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [t434] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [t434] SET ARITHABORT OFF 
GO
ALTER DATABASE [t434] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [t434] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [t434] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [t434] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [t434] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [t434] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [t434] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [t434] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [t434] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [t434] SET  ENABLE_BROKER 
GO
ALTER DATABASE [t434] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [t434] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [t434] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [t434] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [t434] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [t434] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [t434] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [t434] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [t434] SET  MULTI_USER 
GO
ALTER DATABASE [t434] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [t434] SET DB_CHAINING OFF 
GO
ALTER DATABASE [t434] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [t434] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [t434] SET DELAYED_DURABILITY = DISABLED 
GO
USE [t434]
GO
/****** Object:  Table [dbo].[LICH_SU_MUON_SACH]    Script Date: 5/6/2021 10:19:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LICH_SU_MUON_SACH](
	[Masach] [int] NOT NULL,
	[Tensach] [varchar](20) NULL,
	[Mamuontra] [int] IDENTITY(1,1) NOT NULL,
	[Masinhvien] [int] NOT NULL,
	[Hoten] [varchar](20) NOT NULL,
	[Soluongmuon] [int] NOT NULL,
	[Ngaymuon] [date] NULL,
	[Hantra] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[login]    Script Date: 5/6/2021 10:19:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[login](
	[username] [varchar](20) NULL,
	[password] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 5/6/2021 10:19:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[Manxb] [int] NOT NULL,
	[TenNXB] [varchar](20) NULL,
	[Diachi_NXB] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Manxb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SACHMUON]    Script Date: 5/6/2021 10:19:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SACHMUON](
	[Masach] [int] NOT NULL,
	[Tensach] [varchar](20) NULL,
	[Mamuontra] [int] IDENTITY(1,1) NOT NULL,
	[Masinhvien] [int] NOT NULL,
	[Hoten] [varchar](20) NOT NULL,
	[Soluongmuon] [int] NOT NULL,
	[Ngaymuon] [date] NULL,
	[Hantra] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Mamuontra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SACHTRA]    Script Date: 5/6/2021 10:19:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SACHTRA](
	[Masach] [int] NOT NULL,
	[Tensach] [varchar](20) NULL,
	[Masinhvien] [int] NOT NULL,
	[Hoten] [varchar](20) NOT NULL,
	[Mamuontra] [int] NOT NULL,
	[Soluongtra] [int] NOT NULL,
	[Ngaytra] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 5/6/2021 10:19:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[Masinhvien] [int] NOT NULL,
	[Hoten] [varchar](20) NULL,
	[Quequan] [varchar](20) NULL,
	[Gioitinh] [varchar](10) NULL,
	[Sluong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Masinhvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TTPHAT]    Script Date: 5/6/2021 10:19:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TTPHAT](
	[Masinhvien] [int] NOT NULL,
	[Tensinhvien] [varchar](20) NULL,
	[Mamuontra] [int] NOT NULL,
	[Dongphat] [money] NULL,
	[Ngaytra] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TTSACH]    Script Date: 5/6/2021 10:19:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TTSACH](
	[Masach] [int] NOT NULL,
	[Tensach] [varchar](20) NULL,
	[Loaisach] [varchar](20) NULL,
	[Tentacgia] [varchar](20) NULL,
	[Namxb] [date] NULL,
	[Soluong] [int] NULL,
	[Manxb] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[login] ([username], [password]) VALUES (N'a', N'a')
INSERT [dbo].[NHAXUATBAN] ([Manxb], [TenNXB], [Diachi_NXB]) VALUES (2, N'2', N'2')
INSERT [dbo].[NHAXUATBAN] ([Manxb], [TenNXB], [Diachi_NXB]) VALUES (3, N'kim dong', N'sai gon')
INSERT [dbo].[NHAXUATBAN] ([Manxb], [TenNXB], [Diachi_NXB]) VALUES (4, N'ha loi', N'ha noi')
INSERT [dbo].[SINHVIEN] ([Masinhvien], [Hoten], [Quequan], [Gioitinh], [Sluong]) VALUES (1, N'Nguyen Nhat Tin', N'DN', N'Nam', 0)
INSERT [dbo].[SINHVIEN] ([Masinhvien], [Hoten], [Quequan], [Gioitinh], [Sluong]) VALUES (2, N'Nguyen Thanh Dong', N'DN', N'Nu', 0)
INSERT [dbo].[SINHVIEN] ([Masinhvien], [Hoten], [Quequan], [Gioitinh], [Sluong]) VALUES (3, N'Le Dang Khoa', N'DN', N'Nu', 0)
INSERT [dbo].[TTSACH] ([Masach], [Tensach], [Loaisach], [Tentacgia], [Namxb], [Soluong], [Manxb]) VALUES (10, N'DAC NHAN TAM', N'VAN HOC', N'Dale Carnegie', CAST(N'2020-05-04' AS Date), 3, 2)
INSERT [dbo].[TTSACH] ([Masach], [Tensach], [Loaisach], [Tentacgia], [Namxb], [Soluong], [Manxb]) VALUES (12, N'Nguon coi', N'Van hoc', N'Dan Brown', CAST(N'2015-04-04' AS Date), 99, 4)
INSERT [dbo].[TTSACH] ([Masach], [Tensach], [Loaisach], [Tentacgia], [Namxb], [Soluong], [Manxb]) VALUES (13, N'Bo gia', N'VAN HOC', N'Mario Puzo', CAST(N'2020-05-04' AS Date), 99, 2)
INSERT [dbo].[TTSACH] ([Masach], [Tensach], [Loaisach], [Tentacgia], [Namxb], [Soluong], [Manxb]) VALUES (14, N'Suoi nguon', N'VAN HOC', N'Ayn Rand', CAST(N'2020-05-04' AS Date), 99, 2)
INSERT [dbo].[TTSACH] ([Masach], [Tensach], [Loaisach], [Tentacgia], [Namxb], [Soluong], [Manxb]) VALUES (15, N'toan 1', N'toan', N'tin', CAST(N'2021-05-06' AS Date), 10, 4)
INSERT [dbo].[TTSACH] ([Masach], [Tensach], [Loaisach], [Tentacgia], [Namxb], [Soluong], [Manxb]) VALUES (16, N'toan 2', N'toan', N'tin', CAST(N'2021-05-06' AS Date), 19, 4)
INSERT [dbo].[TTSACH] ([Masach], [Tensach], [Loaisach], [Tentacgia], [Namxb], [Soluong], [Manxb]) VALUES (17, N'anh van', N'anh van', N'tin', CAST(N'2021-05-06' AS Date), 99, 3)
ALTER TABLE [dbo].[SACHMUON]  WITH CHECK ADD FOREIGN KEY([Masach])
REFERENCES [dbo].[TTSACH] ([Masach])
GO
ALTER TABLE [dbo].[SACHMUON]  WITH CHECK ADD FOREIGN KEY([Masinhvien])
REFERENCES [dbo].[SINHVIEN] ([Masinhvien])
GO
ALTER TABLE [dbo].[SACHTRA]  WITH CHECK ADD FOREIGN KEY([Mamuontra])
REFERENCES [dbo].[SACHMUON] ([Mamuontra])
GO
ALTER TABLE [dbo].[SACHTRA]  WITH CHECK ADD FOREIGN KEY([Masinhvien])
REFERENCES [dbo].[SINHVIEN] ([Masinhvien])
GO
ALTER TABLE [dbo].[TTPHAT]  WITH CHECK ADD FOREIGN KEY([Mamuontra])
REFERENCES [dbo].[SACHMUON] ([Mamuontra])
GO
ALTER TABLE [dbo].[TTPHAT]  WITH CHECK ADD FOREIGN KEY([Masinhvien])
REFERENCES [dbo].[SINHVIEN] ([Masinhvien])
GO
ALTER TABLE [dbo].[SACHMUON]  WITH CHECK ADD  CONSTRAINT [KT_SL2] CHECK  (([Soluongmuon]>(0)))
GO
ALTER TABLE [dbo].[SACHMUON] CHECK CONSTRAINT [KT_SL2]
GO
ALTER TABLE [dbo].[SACHTRA]  WITH CHECK ADD  CONSTRAINT [KT_SL3] CHECK  (([Soluongtra]>(0)))
GO
ALTER TABLE [dbo].[SACHTRA] CHECK CONSTRAINT [KT_SL3]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [KT_SL1] CHECK  (([Sluong]>=(0)))
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [KT_SL1]
GO
ALTER TABLE [dbo].[TTSACH]  WITH CHECK ADD CHECK  (([Soluong]>(0)))
GO
ALTER TABLE [dbo].[TTSACH]  WITH CHECK ADD  CONSTRAINT [KT_SL] CHECK  (([Soluong]>(0)))
GO
ALTER TABLE [dbo].[TTSACH] CHECK CONSTRAINT [KT_SL]
GO
USE [master]
GO
ALTER DATABASE [t434] SET  READ_WRITE 
GO
