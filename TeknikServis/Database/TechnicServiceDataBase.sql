USE [master]
GO
/****** Object:  Database [DbTeknikServis]    Script Date: 22.10.2021 14:24:09 ******/
CREATE DATABASE [DbTeknikServis]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbTeknikServis', FILENAME = N'C:\Users\kadir\DbTeknikServis.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbTeknikServis_log', FILENAME = N'C:\Users\kadir\DbTeknikServis_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DbTeknikServis] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbTeknikServis].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbTeknikServis] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbTeknikServis] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbTeknikServis] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbTeknikServis] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbTeknikServis] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbTeknikServis] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbTeknikServis] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbTeknikServis] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbTeknikServis] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbTeknikServis] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbTeknikServis] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbTeknikServis] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbTeknikServis] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbTeknikServis] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbTeknikServis] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbTeknikServis] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbTeknikServis] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbTeknikServis] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbTeknikServis] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbTeknikServis] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbTeknikServis] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbTeknikServis] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbTeknikServis] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbTeknikServis] SET  MULTI_USER 
GO
ALTER DATABASE [DbTeknikServis] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbTeknikServis] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbTeknikServis] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbTeknikServis] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbTeknikServis] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbTeknikServis] SET QUERY_STORE = OFF
GO
USE [DbTeknikServis]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [DbTeknikServis]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAd] [varchar](50) NULL,
	[Sifre] [varchar](50) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Araçlar]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Araçlar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](100) NULL,
 CONSTRAINT [PK_Araçlar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArizaDetay]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArizaDetay](
	[ArizaId] [int] IDENTITY(1,1) NOT NULL,
	[Islem] [int] NULL,
	[Sorun] [varchar](250) NULL,
	[Aciklama] [varchar](250) NULL,
	[Onifiyat] [decimal](18, 0) NULL,
	[NetFiyat] [decimal](18, 0) NULL,
	[Islemler] [varchar](500) NULL,
 CONSTRAINT [PK_TblArizaDetay] PRIMARY KEY CLUSTERED 
(
	[ArizaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cariler]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cariler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[Telefon] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Adres] [varchar](250) NULL,
	[Il] [varchar](50) NULL,
	[Ilce] [varchar](50) NULL,
	[Banka] [varchar](50) NULL,
	[VergiAdresi] [varchar](50) NULL,
	[VergiNo] [varchar](50) NULL,
	[Statu] [varchar](50) NULL,
 CONSTRAINT [PK_TblCariler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departman]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departman](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Aciklama] [varchar](150) NULL,
 CONSTRAINT [PK_Departman] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FaturaBilgi]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FaturaBilgi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Personel] [smallint] NULL,
	[Cari] [int] NULL,
	[Seri] [char](1) NULL,
	[SıraNo] [varchar](6) NULL,
	[Tarih] [smalldatetime] NULL,
	[Saat] [char](5) NULL,
	[VergiDaire] [varchar](50) NULL,
 CONSTRAINT [PK_FaturaBilgi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FaturaDetay]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FaturaDetay](
	[FaturaDetayId] [int] IDENTITY(1,1) NOT NULL,
	[FaturaId] [int] NOT NULL,
	[Urun] [varchar](150) NULL,
	[Adet] [smallint] NULL,
	[Fiyat] [decimal](18, 2) NULL,
	[Tutar] [decimal](18, 2) NULL,
 CONSTRAINT [PK_FaturaDetay] PRIMARY KEY CLUSTERED 
(
	[FaturaDetayId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gider]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gider](
	[GiderId] [int] NULL,
	[GiderAciklama] [varchar](50) NULL,
	[Tarih] [smalldatetime] NULL,
	[Tutar] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hakkimizda]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hakkimizda](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Metin] [varchar](500) NULL,
 CONSTRAINT [PK_Hakkımızda] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Iletisim]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Iletisim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Mesaj] [varchar](500) NULL,
 CONSTRAINT [PK_Iletisim] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategori]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategori](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](100) NULL,
 CONSTRAINT [PK_TbKategori] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notlar]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notlar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Baslik] [varchar](50) NULL,
	[Icerik] [varchar](50) NULL,
	[Durum] [bit] NULL,
	[Tarih] [smalldatetime] NULL,
 CONSTRAINT [PK_TblNotlar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[Departman] [tinyint] NULL,
	[Fotograf] [varchar](100) NULL,
	[Mail] [varchar](50) NULL,
	[Telefon] [varchar](20) NULL,
 CONSTRAINT [PK_TblPersonel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](250) NULL,
	[Marka] [varchar](50) NULL,
	[AlisFiyat] [decimal](18, 2) NULL,
	[SatisFiyat] [decimal](18, 2) NULL,
	[Stok] [smallint] NULL,
	[Kategori] [int] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_TbUrun] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunHareket]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunHareket](
	[HareketId] [int] IDENTITY(1,1) NOT NULL,
	[Urun] [int] NULL,
	[Musteri] [int] NULL,
	[Personel] [smallint] NULL,
	[Tarih] [smalldatetime] NULL,
	[Adet] [smallint] NULL,
	[Fiyat] [decimal](18, 2) NULL,
	[UrunSeriNo] [char](5) NULL,
 CONSTRAINT [PK_TblUrunHareket] PRIMARY KEY CLUSTERED 
(
	[HareketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunKabul]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunKabul](
	[IslemId] [int] IDENTITY(1,1) NOT NULL,
	[Cari] [int] NULL,
	[Personel] [smallint] NULL,
	[GelisTarihi] [smalldatetime] NULL,
	[CikisTarihi] [smalldatetime] NULL,
	[UrunSeriNo] [char](5) NULL,
 CONSTRAINT [PK_TblUrunKabul] PRIMARY KEY CLUSTERED 
(
	[IslemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunTakip]    Script Date: 22.10.2021 14:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunTakip](
	[TakipId] [int] IDENTITY(1,1) NOT NULL,
	[Aciklama] [varchar](250) NULL,
	[Tarih] [smalldatetime] NULL,
	[SeriNo] [char](5) NULL,
 CONSTRAINT [PK_UrunTakip] PRIMARY KEY CLUSTERED 
(
	[TakipId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cariler] ON 

INSERT [dbo].[Cariler] ([Id], [Ad], [Soyad], [Telefon], [Mail], [Adres], [Il], [Ilce], [Banka], [VergiAdresi], [VergiNo], [Statu]) VALUES (1, N'Kadir', N'Kaya', N'11111111111', N'kadir@kaya.com', N'istanbul', N'Istanbul', N'Esenyurt', N'Bankasya', N'esenyut', N'213213123', N'')
INSERT [dbo].[Cariler] ([Id], [Ad], [Soyad], [Telefon], [Mail], [Adres], [Il], [Ilce], [Banka], [VergiAdresi], [VergiNo], [Statu]) VALUES (2, N'Nurhat', N'Mentes', N'11111111111', N'nurhat@mentes.com', N'istanbul', N'Istanbul', N'Sultanbeyli', N'Bankasya', N'esenyut', N'21312312312312', N'')
INSERT [dbo].[Cariler] ([Id], [Ad], [Soyad], [Telefon], [Mail], [Adres], [Il], [Ilce], [Banka], [VergiAdresi], [VergiNo], [Statu]) VALUES (3, N'Engin', N'Demirog', N'11111111111', N'engin.demirog.com', N'istanbul', N'Ankara', N'Mamak', N'Bankasya', N'esenyut', N'123123132', N'')
INSERT [dbo].[Cariler] ([Id], [Ad], [Soyad], [Telefon], [Mail], [Adres], [Il], [Ilce], [Banka], [VergiAdresi], [VergiNo], [Statu]) VALUES (4, N'Fadime', N'Dadas', N'11111111111', N'fadim@dadas.com', N'istanbul', N'Erzurum', N'Gadas', N'Bankasya', N'esenyut', N'123123123', N'')
INSERT [dbo].[Cariler] ([Id], [Ad], [Soyad], [Telefon], [Mail], [Adres], [Il], [Ilce], [Banka], [VergiAdresi], [VergiNo], [Statu]) VALUES (5, N'Ayse', N'Gül', N'11111111111', N'ayse@gul.com', N'istanbul', N'Giresun', N'Yaglidere', N'Bankasya', N'esenyut', N'1231231231', N'')
INSERT [dbo].[Cariler] ([Id], [Ad], [Soyad], [Telefon], [Mail], [Adres], [Il], [Ilce], [Banka], [VergiAdresi], [VergiNo], [Statu]) VALUES (6, N'Aleyna', N'Çiçek', N'11111111111', N'aleyna@cicek.com', N'istanbul', N'Istanbul', N'Esenler', N'Bankasya', N'esenyut', N'123213213', N'')
SET IDENTITY_INSERT [dbo].[Cariler] OFF
GO
SET IDENTITY_INSERT [dbo].[Departman] ON 

INSERT [dbo].[Departman] ([Id], [Ad], [Aciklama]) VALUES (1, N'Muhasebe', N'')
INSERT [dbo].[Departman] ([Id], [Ad], [Aciklama]) VALUES (2, N'Güvenlik', N'')
INSERT [dbo].[Departman] ([Id], [Ad], [Aciklama]) VALUES (3, N'Sekreter', N'')
INSERT [dbo].[Departman] ([Id], [Ad], [Aciklama]) VALUES (4, N'Müsteri Temsilcisi', N'')
INSERT [dbo].[Departman] ([Id], [Ad], [Aciklama]) VALUES (5, N'Müdür', N'')
INSERT [dbo].[Departman] ([Id], [Ad], [Aciklama]) VALUES (6, N'Yazilim Gelistirici', N'')
SET IDENTITY_INSERT [dbo].[Departman] OFF
GO
SET IDENTITY_INSERT [dbo].[FaturaBilgi] ON 

INSERT [dbo].[FaturaBilgi] ([Id], [Personel], [Cari], [Seri], [SıraNo], [Tarih], [Saat], [VergiDaire]) VALUES (2, 3, 1, N'A', N'111', CAST(N'2021-07-23T00:00:00' AS SmallDateTime), N'     ', N'Istanbul')
SET IDENTITY_INSERT [dbo].[FaturaBilgi] OFF
GO
SET IDENTITY_INSERT [dbo].[FaturaDetay] ON 

INSERT [dbo].[FaturaDetay] ([FaturaDetayId], [FaturaId], [Urun], [Adet], [Fiyat], [Tutar]) VALUES (1, 2, N'Laptop', 1, CAST(6700.00 AS Decimal(18, 2)), CAST(6700.00 AS Decimal(18, 2)))
INSERT [dbo].[FaturaDetay] ([FaturaDetayId], [FaturaId], [Urun], [Adet], [Fiyat], [Tutar]) VALUES (2, 2, N'Su isitici', 2, CAST(100.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[FaturaDetay] OFF
GO
SET IDENTITY_INSERT [dbo].[Hakkimizda] ON 

INSERT [dbo].[Hakkimizda] ([Id], [Metin]) VALUES (1, N'bu proje yehaziran ayinda baslandi ve temmuz ayinda hala devam edilmektedir proje içerinde html5 css ve bootstrapten yaralanilmistir.')
SET IDENTITY_INSERT [dbo].[Hakkimizda] OFF
GO
SET IDENTITY_INSERT [dbo].[Iletisim] ON 

INSERT [dbo].[Iletisim] ([Id], [Ad], [Mail], [Mesaj]) VALUES (1, N'Kadir', N'kadirkaya.13@outlook.com.tr', N'Web sitenizi çok begendim')
INSERT [dbo].[Iletisim] ([Id], [Ad], [Mail], [Mesaj]) VALUES (2, N'Kadir', N'kadirkaya.13@outlook.com.tr', N'Selamlar')
INSERT [dbo].[Iletisim] ([Id], [Ad], [Mail], [Mesaj]) VALUES (3, N'Berken', N'berken@hotmail.com', N'Buzdolabim 3.kez bozuldu')
INSERT [dbo].[Iletisim] ([Id], [Ad], [Mail], [Mesaj]) VALUES (4, N'Beren', N'beren@hotmail.com', N'Kargom cok hizli sekilde geldi üründende çok memnunum tesekkürler')
INSERT [dbo].[Iletisim] ([Id], [Ad], [Mail], [Mesaj]) VALUES (5, N'Sümeyye', N'sümeyye@hotmail.com', N'telefon haklariniza telesekreter baglamanizi öneririm')
INSERT [dbo].[Iletisim] ([Id], [Ad], [Mail], [Mesaj]) VALUES (6, N'Emine', N'emine@hotmail.com', N'Hizmetinizden çok memnun kaldim')
INSERT [dbo].[Iletisim] ([Id], [Ad], [Mail], [Mesaj]) VALUES (7, N'Ismail', N'ismail@hotmail.com', N'Berbat bir hizmet sunuldu hiç memnun kalmadim')
INSERT [dbo].[Iletisim] ([Id], [Ad], [Mail], [Mesaj]) VALUES (8, N'Nurhat', N'nurhat@hotmail.com', N'Kadir diye bir yazilimcilari var mükemmel bir insan kendisine yardimlari için çok tesekkür ederim')
INSERT [dbo].[Iletisim] ([Id], [Ad], [Mail], [Mesaj]) VALUES (9, N'Berke', N'berke@hotmail.com', N'Müzik aletim geldi bekledigimden çok daha iyidi çok tesekkürler')
INSERT [dbo].[Iletisim] ([Id], [Ad], [Mail], [Mesaj]) VALUES (10, N'Yigithan', N'yigithan@gmail.com', N'Bana onu getirebilir misiniz')
SET IDENTITY_INSERT [dbo].[Iletisim] OFF
GO
SET IDENTITY_INSERT [dbo].[Kategori] ON 

INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (1, N'Bilgisayar')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (2, N'Telefon')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (3, N'Kucuk ev aleti')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (4, N'Beyaz esya')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (5, N'Tv')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (1002, N'Aksesuar')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (1004, N'Tablet')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (1005, N'Mobilya')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (1008, N'Ekran Karti')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (1009, N'Hard Disk')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (1010, N'Ses Sistemi')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (1011, N'Usb bellek')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (1012, N'Islemci')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (1013, N'Monitör')
INSERT [dbo].[Kategori] ([Id], [Ad]) VALUES (1014, N'Klavye')
SET IDENTITY_INSERT [dbo].[Kategori] OFF
GO
SET IDENTITY_INSERT [dbo].[Notlar] ON 

INSERT [dbo].[Notlar] ([Id], [Baslik], [Icerik], [Durum], [Tarih]) VALUES (1, N'maas', N'maaslar ayin 25de yatacak', 0, CAST(N'2021-07-30T00:00:00' AS SmallDateTime))
INSERT [dbo].[Notlar] ([Id], [Baslik], [Icerik], [Durum], [Tarih]) VALUES (2, N'antlasma', N'bakim antlasmasi yapilacak', 1, CAST(N'2021-07-31T00:00:00' AS SmallDateTime))
INSERT [dbo].[Notlar] ([Id], [Baslik], [Icerik], [Durum], [Tarih]) VALUES (3, N'yazilim', N'sql sorgulari yazilacak', 0, CAST(N'2021-07-31T00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Notlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [Departman], [Fotograf], [Mail], [Telefon]) VALUES (1, N'kadir', N'kaya', 1, NULL, N'kadir@kaya.com', N'11111111111')
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [Departman], [Fotograf], [Mail], [Telefon]) VALUES (2, N'nurhat', N'mentes', 2, NULL, N'nurhat@mentes.com', N'11111111111')
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [Departman], [Fotograf], [Mail], [Telefon]) VALUES (3, N'yigithan', N'coruglu', 3, NULL, N'yigit@coruglu.com', N'11111111111')
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [Departman], [Fotograf], [Mail], [Telefon]) VALUES (4, N'beren', N'kaya', 4, NULL, N'beren@kaya.com', N'11111111111')
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[Urun] ON 

INSERT [dbo].[Urun] ([Id], [Ad], [Marka], [AlisFiyat], [SatisFiyat], [Stok], [Kategori], [Durum]) VALUES (1, N'Buzdolabi ', N'Siemens', CAST(4850.00 AS Decimal(18, 2)), CAST(5200.00 AS Decimal(18, 2)), 150, 4, 0)
INSERT [dbo].[Urun] ([Id], [Ad], [Marka], [AlisFiyat], [SatisFiyat], [Stok], [Kategori], [Durum]) VALUES (2, N'Camasir Makinasi', N'Siemens', CAST(3200.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), 200, 4, 0)
INSERT [dbo].[Urun] ([Id], [Ad], [Marka], [AlisFiyat], [SatisFiyat], [Stok], [Kategori], [Durum]) VALUES (3, N'Laptop', N'Lenovo', CAST(4400.00 AS Decimal(18, 2)), CAST(5200.00 AS Decimal(18, 2)), 150, 1, 0)
INSERT [dbo].[Urun] ([Id], [Ad], [Marka], [AlisFiyat], [SatisFiyat], [Stok], [Kategori], [Durum]) VALUES (4, N'Tv', N'Lg', CAST(6800.00 AS Decimal(18, 2)), CAST(7700.00 AS Decimal(18, 2)), 60, 5, 0)
INSERT [dbo].[Urun] ([Id], [Ad], [Marka], [AlisFiyat], [SatisFiyat], [Stok], [Kategori], [Durum]) VALUES (5, N'Utu', N'Siemens', CAST(300.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)), 100, 3, 0)
INSERT [dbo].[Urun] ([Id], [Ad], [Marka], [AlisFiyat], [SatisFiyat], [Stok], [Kategori], [Durum]) VALUES (2002, N'Bulasik Makinasi', N'Arçelik', CAST(4850.00 AS Decimal(18, 2)), CAST(5200.00 AS Decimal(18, 2)), 150, 4, 0)
INSERT [dbo].[Urun] ([Id], [Ad], [Marka], [AlisFiyat], [SatisFiyat], [Stok], [Kategori], [Durum]) VALUES (3002, N'Mukfak Robotu', N'Bosch', CAST(450.00 AS Decimal(18, 2)), CAST(650.00 AS Decimal(18, 2)), 200, 4, 0)
INSERT [dbo].[Urun] ([Id], [Ad], [Marka], [AlisFiyat], [SatisFiyat], [Stok], [Kategori], [Durum]) VALUES (4002, N'Laptop', N'Lenovo', CAST(6400.00 AS Decimal(18, 2)), CAST(7200.00 AS Decimal(18, 2)), 20, 1, 0)
SET IDENTITY_INSERT [dbo].[Urun] OFF
GO
SET IDENTITY_INSERT [dbo].[UrunHareket] ON 

INSERT [dbo].[UrunHareket] ([HareketId], [Urun], [Musteri], [Personel], [Tarih], [Adet], [Fiyat], [UrunSeriNo]) VALUES (1, 1, 1, 3, CAST(N'2012-08-25T00:00:00' AS SmallDateTime), 1, CAST(4500.00 AS Decimal(18, 2)), N'BLG01')
INSERT [dbo].[UrunHareket] ([HareketId], [Urun], [Musteri], [Personel], [Tarih], [Adet], [Fiyat], [UrunSeriNo]) VALUES (2, 5, 3, 3, CAST(N'2012-08-25T00:00:00' AS SmallDateTime), 1, CAST(4500.00 AS Decimal(18, 2)), N'BLG02')
SET IDENTITY_INSERT [dbo].[UrunHareket] OFF
GO
SET IDENTITY_INSERT [dbo].[UrunKabul] ON 

INSERT [dbo].[UrunKabul] ([IslemId], [Cari], [Personel], [GelisTarihi], [CikisTarihi], [UrunSeriNo]) VALUES (1, 3, 2, CAST(N'2021-07-06T00:00:00' AS SmallDateTime), NULL, N'BLG02')
SET IDENTITY_INSERT [dbo].[UrunKabul] OFF
GO
SET IDENTITY_INSERT [dbo].[UrunTakip] ON 

INSERT [dbo].[UrunTakip] ([TakipId], [Aciklama], [Tarih], [SeriNo]) VALUES (1, N'Urun teknik servise incelemesi için verildi', CAST(N'2021-07-06T00:00:00' AS SmallDateTime), N'BLG01')
INSERT [dbo].[UrunTakip] ([TakipId], [Aciklama], [Tarih], [SeriNo]) VALUES (2, N'sogutma motorunun elektrik arizasi sebebiyle bozuldugu tespit edildi', CAST(N'2021-07-07T00:00:00' AS SmallDateTime), N'BLG01')
INSERT [dbo].[UrunTakip] ([TakipId], [Aciklama], [Tarih], [SeriNo]) VALUES (1002, N'Ürün onarim için servise Getirildi.', CAST(N'2021-07-13T00:00:00' AS SmallDateTime), N'BLG02')
SET IDENTITY_INSERT [dbo].[UrunTakip] OFF
GO
ALTER TABLE [dbo].[Notlar] ADD  CONSTRAINT [DF_TblNotlar_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[Urun] ADD  CONSTRAINT [DF_TbUrun_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[UrunKabul] ADD  CONSTRAINT [DF_TblUrunKabul_GelisTarihi]  DEFAULT (getdate()) FOR [GelisTarihi]
GO
ALTER TABLE [dbo].[FaturaBilgi]  WITH CHECK ADD  CONSTRAINT [FK_FaturaBilgi_Cariler] FOREIGN KEY([Cari])
REFERENCES [dbo].[Cariler] ([Id])
GO
ALTER TABLE [dbo].[FaturaBilgi] CHECK CONSTRAINT [FK_FaturaBilgi_Cariler]
GO
ALTER TABLE [dbo].[FaturaBilgi]  WITH CHECK ADD  CONSTRAINT [FK_FaturaBilgi_Personel] FOREIGN KEY([Personel])
REFERENCES [dbo].[Personel] ([Id])
GO
ALTER TABLE [dbo].[FaturaBilgi] CHECK CONSTRAINT [FK_FaturaBilgi_Personel]
GO
ALTER TABLE [dbo].[FaturaDetay]  WITH CHECK ADD  CONSTRAINT [FK_FaturaDetay_FaturaBilgi1] FOREIGN KEY([FaturaId])
REFERENCES [dbo].[FaturaBilgi] ([Id])
GO
ALTER TABLE [dbo].[FaturaDetay] CHECK CONSTRAINT [FK_FaturaDetay_FaturaBilgi1]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Departman] FOREIGN KEY([Departman])
REFERENCES [dbo].[Departman] ([Id])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Departman]
GO
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK_Urun_Kategori] FOREIGN KEY([Kategori])
REFERENCES [dbo].[Kategori] ([Id])
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK_Urun_Kategori]
GO
ALTER TABLE [dbo].[UrunHareket]  WITH CHECK ADD  CONSTRAINT [FK_UrunHareket_Cariler1] FOREIGN KEY([Musteri])
REFERENCES [dbo].[Cariler] ([Id])
GO
ALTER TABLE [dbo].[UrunHareket] CHECK CONSTRAINT [FK_UrunHareket_Cariler1]
GO
ALTER TABLE [dbo].[UrunHareket]  WITH CHECK ADD  CONSTRAINT [FK_UrunHareket_Personel] FOREIGN KEY([Personel])
REFERENCES [dbo].[Personel] ([Id])
GO
ALTER TABLE [dbo].[UrunHareket] CHECK CONSTRAINT [FK_UrunHareket_Personel]
GO
ALTER TABLE [dbo].[UrunHareket]  WITH CHECK ADD  CONSTRAINT [FK_UrunHareket_Urun1] FOREIGN KEY([Urun])
REFERENCES [dbo].[Urun] ([Id])
GO
ALTER TABLE [dbo].[UrunHareket] CHECK CONSTRAINT [FK_UrunHareket_Urun1]
GO
ALTER TABLE [dbo].[UrunKabul]  WITH CHECK ADD  CONSTRAINT [FK_UrunKabul_Cariler] FOREIGN KEY([Cari])
REFERENCES [dbo].[Cariler] ([Id])
GO
ALTER TABLE [dbo].[UrunKabul] CHECK CONSTRAINT [FK_UrunKabul_Cariler]
GO
ALTER TABLE [dbo].[UrunKabul]  WITH CHECK ADD  CONSTRAINT [FK_UrunKabul_Personel] FOREIGN KEY([Personel])
REFERENCES [dbo].[Personel] ([Id])
GO
ALTER TABLE [dbo].[UrunKabul] CHECK CONSTRAINT [FK_UrunKabul_Personel]
GO
/****** Object:  StoredProcedure [dbo].[urunkategori]    Script Date: 22.10.2021 14:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[urunkategori] as
select Kategori.Ad,COUNT(Urun.Id) as [Ürün Sayısı] from Urun inner join Kategori on Kategori.Id=Urun.Kategori group by Kategori.Ad
GO
USE [master]
GO
ALTER DATABASE [DbTeknikServis] SET  READ_WRITE 
GO
