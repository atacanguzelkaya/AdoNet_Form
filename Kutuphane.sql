USE [master]
GO
/****** Object:  Database [Kutuphane]    Script Date: 24.07.2023 12:17:17 ******/
CREATE DATABASE [Kutuphane]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kutuphane', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Kutuphane.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kutuphane_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Kutuphane_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Kutuphane] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kutuphane].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kutuphane] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kutuphane] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kutuphane] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kutuphane] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kutuphane] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kutuphane] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kutuphane] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kutuphane] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kutuphane] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kutuphane] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kutuphane] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kutuphane] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kutuphane] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kutuphane] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kutuphane] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Kutuphane] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kutuphane] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kutuphane] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kutuphane] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kutuphane] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kutuphane] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kutuphane] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kutuphane] SET RECOVERY FULL 
GO
ALTER DATABASE [Kutuphane] SET  MULTI_USER 
GO
ALTER DATABASE [Kutuphane] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kutuphane] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kutuphane] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kutuphane] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kutuphane] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kutuphane] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Kutuphane', N'ON'
GO
ALTER DATABASE [Kutuphane] SET QUERY_STORE = ON
GO
ALTER DATABASE [Kutuphane] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Kutuphane]
GO
/****** Object:  Table [dbo].[Kitaplar]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitaplar](
	[KitapID] [int] IDENTITY(1,1) NOT NULL,
	[KitapAdi] [varchar](50) NULL,
	[KitapTuru] [varchar](50) NULL,
	[Yazar] [varchar](50) NULL,
	[YayinEvi] [varchar](50) NULL,
 CONSTRAINT [PK_Kitaplar] PRIMARY KEY CLUSTERED 
(
	[KitapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdSoyad] [varchar](50) NULL,
	[KullaniciTC] [varchar](11) NULL,
	[KullaniciMail] [varchar](50) NULL,
	[KullaniciTelNo] [varchar](11) NULL,
	[AlinanKitap] [varchar](50) NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAdSoyad] [varchar](50) NULL,
	[PersonelAdi] [varchar](50) NULL,
	[PersonelSifre] [varchar](50) NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kitaplar] ON 

INSERT [dbo].[Kitaplar] ([KitapID], [KitapAdi], [KitapTuru], [Yazar], [YayinEvi]) VALUES (19, N'Oz Büyücülük', N'Aksiyon', N'Frank Baum', N'İş Çocuk Klasikleri')
INSERT [dbo].[Kitaplar] ([KitapID], [KitapAdi], [KitapTuru], [Yazar], [YayinEvi]) VALUES (20, N'Sharlock Holmes', N'Polisiye', N'Arthur Conan Doyle', N'İş Çocuk Klasikleri')
INSERT [dbo].[Kitaplar] ([KitapID], [KitapAdi], [KitapTuru], [Yazar], [YayinEvi]) VALUES (21, N'Cem Yılmaz Klasikleri', N'Karikatür', N'Cem Yılmaz', N'Onbeşinci Baskı')
INSERT [dbo].[Kitaplar] ([KitapID], [KitapAdi], [KitapTuru], [Yazar], [YayinEvi]) VALUES (22, N'Varoluş ve Pskiyatri', N'Psikoloji', N'Engin Geçdan', N'Remzi Kitapevi')
INSERT [dbo].[Kitaplar] ([KitapID], [KitapAdi], [KitapTuru], [Yazar], [YayinEvi]) VALUES (24, N'Doğu Ekspresi''nde Cinayet', N'Polisiye', N'Agatha Christie', N'Altın Kitaplar')
SET IDENTITY_INSERT [dbo].[Kitaplar] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([KullaniciID], [KullaniciAdSoyad], [KullaniciTC], [KullaniciMail], [KullaniciTelNo], [AlinanKitap]) VALUES (10, N'Berke Kaan Saraç', N'123456789', N'berkemail', N'05545545541', N'Oz Büyücülük')
INSERT [dbo].[Kullanici] ([KullaniciID], [KullaniciAdSoyad], [KullaniciTC], [KullaniciMail], [KullaniciTelNo], [AlinanKitap]) VALUES (11, N'Atacan Guzelkaya', N'987654321', N'atacanmail', N'05555555555', N'Sharlock Holmes')
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([PersonelID], [PersonelAdSoyad], [PersonelAdi], [PersonelSifre]) VALUES (1, N'Admin', N'admin', N'sifre')
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
/****** Object:  StoredProcedure [dbo].[KitapKullaniciJoin]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KitapKullaniciJoin]
as begin
select * from Kitaplar left join Kullanici on Kitaplar.KitapAdi=Kullanici.AlinanKitap where Kullanici.KullaniciID is null
end
GO
/****** Object:  StoredProcedure [dbo].[OGuncelleKitap]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[OGuncelleKitap] --Kitap Guncelleme Proseduru
@KitapID int,
@KitapAdi varchar(50),
@KitapTuru varchar(50),
@Yazar varchar(50),
@YayinEvi varchar(50)
as begin
update Kitaplar set KitapAdi=@KitapAdi,KitapTuru=@KitapTuru,Yazar=@Yazar,YayinEvi=@YayinEvi where KitapID=@KitapID
end
GO
/****** Object:  StoredProcedure [dbo].[OGuncelleKullanici]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[OGuncelleKullanici] --Kullanici Guncelleme Proseduru
@KullaniciID int,
@KullaniciAdSoyad varchar(50),
@KullaniciTC varchar(11),
@KullaniciMail varchar(50),
@KullaniciTelNo varchar(11),
@AlinanKitap varchar(50)
as begin
update Kullanici set KullaniciAdSoyad=@KullaniciAdSoyad,KullaniciTC=@KullaniciTC,KullaniciMail=@KullaniciMail,KullaniciTelNo=@KullaniciTelNo,AlinanKitap=@AlinanKitap where KullaniciID=@KullaniciID
end
GO
/****** Object:  StoredProcedure [dbo].[OKaydetKitap]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OKaydetKitap] --Kitap Kaydetme Proseduru
@KitapAdi varchar(50),
@KitapTuru varchar(50),
@Yazar varchar(50),
@YayinEvi varchar(50)
as begin
insert into Kitaplar (KitapAdi,KitapTuru,Yazar,YayinEvi) 
values (@KitapAdi,@KitapTuru,@Yazar,@YayinEvi)
end
GO
/****** Object:  StoredProcedure [dbo].[OKaydetKullanici]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OKaydetKullanici] --Kullanici Kaydetme Proseduru
@KullaniciAdSoyad varchar(50),
@KullaniciTC varchar(11),
@KullaniciMail varchar(50),
@KullaniciTelNo varchar(11),
@AlinanKitap varchar(50)
as begin
insert into Kullanici (KullaniciAdSoyad,KullaniciTC,KullaniciMail,KullaniciTelNo,AlinanKitap) 
values (@KullaniciAdSoyad,@KullaniciTC,@KullaniciMail,@KullaniciTelNo,@AlinanKitap)
end
GO
/****** Object:  StoredProcedure [dbo].[OKullaniciKitapGuncelle]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OKullaniciKitapGuncelle]
@KitapID int
as begin
update Kullanici set AlinanKitap = '' where AlinanKitap=(select KitapAdi from Kitaplar where KitapID=@KitapID)
end
GO
/****** Object:  StoredProcedure [dbo].[OListeleKitaplar]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OListeleKitaplar] --Kitaplari Listeleme Proseduru
as begin
Select * from Kitaplar
end
GO
/****** Object:  StoredProcedure [dbo].[OlisteleKullanici]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OlisteleKullanici] --Kullanici Listeleme Proseduru
as begin
Select * from Kullanici
end
GO
/****** Object:  StoredProcedure [dbo].[OSilKitap]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OSilKitap]	--Kitap Silme Proseduru
@KitapID int
as begin
Delete from Kitaplar where KitapID=@KitapID
end
GO
/****** Object:  StoredProcedure [dbo].[OSilKullanici]    Script Date: 24.07.2023 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OSilKullanici]	--Kullanici Silme Proseduru
@KullaniciID int
as begin
Delete from Kullanici where KullaniciID=@KullaniciID
end
GO
USE [master]
GO
ALTER DATABASE [Kutuphane] SET  READ_WRITE 
GO
