SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TetkikListesi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TetkikListesi](
	[TetkikId] [int] IDENTITY(1,1) NOT NULL,
	[ReferansNo] [varchar](max) NULL,
	[TetkikAdi] [varchar](max) NULL,
	[TetkikKodu] [varchar](max) NULL,
	[GrupKodu] [varchar](max) NULL,
	[SUTTUT_NO] [varchar](max) NULL,
	[FIYATI] [money] NULL,
	[GUNCELLENME_TARIHI] [datetime] NULL,
	[AKTIF] [bit] NULL,
	[GUNCELLEME_INFO] [varchar](max) NULL,
	[ESLESME_NO] [varchar](max) NULL,
 CONSTRAINT [PK_TetkikListesi] PRIMARY KEY CLUSTERED 
(
	[TetkikId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HastaListesi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HastaListesi](
	[HASTA_KAYIT_ID] [int] IDENTITY(1,1) NOT NULL,
	[KAYIT_TARIHI] [datetime] NULL,
	[HASTA_KIMLIK_NO] [numeric](11, 0) NULL,
	[AD] [varchar](max) NULL,
	[SOYAD] [varchar](max) NULL,
	[CINSIYET_RESMI] [numeric](1, 0) NULL,
	[DOGUM_TARIHI_RESMI] [datetime] NULL,
 CONSTRAINT [PK_HastaListesi] PRIMARY KEY CLUSTERED 
(
	[HASTA_KAYIT_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tetkik_Bilgisi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tetkik_Bilgisi](
	[Tetkik_Id] [int] IDENTITY(1,1) NOT NULL,
	[Tetkik] [varchar](10) NOT NULL,
	[Tup_Barkodu] [varchar](50) NOT NULL,
	[Hasta_Kayit_Id] [int] NULL,
 CONSTRAINT [PK_Tetkik_Bilgisi] PRIMARY KEY CLUSTERED 
(
	[Tetkik_Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Tetkik_Bilgisi_HastaListesi]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tetkik_Bilgisi]'))
ALTER TABLE [dbo].[Tetkik_Bilgisi]  WITH CHECK ADD  CONSTRAINT [FK_Tetkik_Bilgisi_HastaListesi] FOREIGN KEY([Hasta_Kayit_Id])
REFERENCES [dbo].[HastaListesi] ([HASTA_KAYIT_ID])
GO
ALTER TABLE [dbo].[Tetkik_Bilgisi] CHECK CONSTRAINT [FK_Tetkik_Bilgisi_HastaListesi]
