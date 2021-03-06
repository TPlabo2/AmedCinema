USE [master]
GO
/****** Object:  Database [Cine]    Script Date: 18/11/2018 5:49:01 p. m. ******/
CREATE DATABASE [Cine]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cine', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Cine.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cine_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Cine_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Cine] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cine].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cine] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cine] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cine] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cine] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cine] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cine] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Cine] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cine] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cine] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cine] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cine] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cine] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cine] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cine] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cine] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Cine] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cine] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cine] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cine] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cine] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cine] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cine] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cine] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Cine] SET  MULTI_USER 
GO
ALTER DATABASE [Cine] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cine] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cine] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cine] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Cine] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Cine] SET QUERY_STORE = OFF
GO
USE [Cine]
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
USE [Cine]
GO
/****** Object:  Table [dbo].[Actores]    Script Date: 18/11/2018 5:49:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actores](
	[id_actor] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nacionalidad] [varchar](50) NULL,
	[reseña] [text] NULL,
	[fecha_nacimiento] [datetime] NULL,
 CONSTRAINT [pk_act] PRIMARY KEY CLUSTERED 
(
	[id_actor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActoresPeliculas]    Script Date: 18/11/2018 5:49:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActoresPeliculas](
	[id_actorPeli] [int] IDENTITY(1,1) NOT NULL,
	[id_actor] [int] NOT NULL,
	[id_pelicula] [int] NOT NULL,
 CONSTRAINT [pk_actPeli] PRIMARY KEY CLUSTERED 
(
	[id_actorPeli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Butacas]    Script Date: 18/11/2018 5:49:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Butacas](
	[id_butaca] [int] IDENTITY(1,1) NOT NULL,
	[id_reserva] [int] NOT NULL,
	[id_funcion] [int] NOT NULL,
 CONSTRAINT [pk_but] PRIMARY KEY CLUSTERED 
(
	[id_butaca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClasificacionesPeliculas]    Script Date: 18/11/2018 5:49:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClasificacionesPeliculas](
	[id_clasificacion] [int] IDENTITY(1,1) NOT NULL,
	[clasificacion] [varchar](30) NOT NULL,
 CONSTRAINT [pk_cp] PRIMARY KEY CLUSTERED 
(
	[id_clasificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comprobantes]    Script Date: 18/11/2018 5:49:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comprobantes](
	[id_comprobante] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[id_formaPago] [int] NOT NULL,
	[id_formaCompra] [int] NOT NULL,
 CONSTRAINT [pk_com] PRIMARY KEY CLUSTERED 
(
	[id_comprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_Comprobante]    Script Date: 18/11/2018 5:49:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_Comprobante](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [int] NULL,
	[precio] [money] NULL,
	[descuento] [money] NULL,
	[id_funcion] [int] NOT NULL,
	[id_comprobante] [int] NOT NULL,
 CONSTRAINT [pk_det] PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Directores]    Script Date: 18/11/2018 5:49:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Directores](
	[id_director] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nacionalidad] [varchar](50) NULL,
	[reseña] [text] NULL,
	[fecha_nacimiento] [datetime] NULL,
 CONSTRAINT [pk_dir] PRIMARY KEY CLUSTERED 
(
	[id_director] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entradas]    Script Date: 18/11/2018 5:49:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entradas](
	[id_entrada] [int] IDENTITY(1,1) NOT NULL,
	[id_detalle] [int] NOT NULL,
	[id_butaca] [int] NOT NULL,
 CONSTRAINT [pk_ent] PRIMARY KEY CLUSTERED 
(
	[id_entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormaCompras]    Script Date: 18/11/2018 5:49:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaCompras](
	[id_formaCompra] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [pk_fc] PRIMARY KEY CLUSTERED 
(
	[id_formaCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormaDePagos]    Script Date: 18/11/2018 5:49:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaDePagos](
	[id_formaDePago] [int] IDENTITY(1,1) NOT NULL,
	[formaPago] [varchar](20) NOT NULL,
 CONSTRAINT [pk_fp] PRIMARY KEY CLUSTERED 
(
	[id_formaDePago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funciones]    Script Date: 18/11/2018 5:49:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funciones](
	[id_funcion] [int] IDENTITY(1,1) NOT NULL,
	[rangoHorario] [time](7) NULL,
	[id_pelicula] [int] NOT NULL,
	[id_sala] [int] NOT NULL,
	[precio] [money] NULL,
 CONSTRAINT [pk_fun] PRIMARY KEY CLUSTERED 
(
	[id_funcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Generos]    Script Date: 18/11/2018 5:49:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[id_genero] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [pk_ge] PRIMARY KEY CLUSTERED 
(
	[id_genero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idiomas]    Script Date: 18/11/2018 5:49:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idiomas](
	[id_idioma] [int] IDENTITY(1,1) NOT NULL,
	[Idioma] [varchar](20) NOT NULL,
 CONSTRAINT [pk_id] PRIMARY KEY CLUSTERED 
(
	[id_idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 18/11/2018 5:49:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[id_pais] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [pk_pais] PRIMARY KEY CLUSTERED 
(
	[id_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 18/11/2018 5:49:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[id_pelicula] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[duracion] [varchar](50) NOT NULL,
	[id_genero] [int] NOT NULL,
	[id_idioma] [int] NOT NULL,
	[id_clasificacion] [int] NULL,
	[id_subtitulos] [int] NOT NULL,
	[id_director] [int] NOT NULL,
	[id_pais] [int] NULL,
 CONSTRAINT [pk_peli] PRIMARY KEY CLUSTERED 
(
	[id_pelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservasEstado]    Script Date: 18/11/2018 5:49:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservasEstado](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [pk_fr] PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalasCine]    Script Date: 18/11/2018 5:49:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalasCine](
	[id_sala] [int] IDENTITY(1,1) NOT NULL,
	[id_tipoSala] [int] NOT NULL,
 CONSTRAINT [pk_sal] PRIMARY KEY CLUSTERED 
(
	[id_sala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subtitulos]    Script Date: 18/11/2018 5:49:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subtitulos](
	[id_subtitulo] [int] IDENTITY(1,1) NOT NULL,
	[idiomaSubtitulos] [varchar](20) NOT NULL,
 CONSTRAINT [pk_sub] PRIMARY KEY CLUSTERED 
(
	[id_subtitulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDeSalas]    Script Date: 18/11/2018 5:49:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDeSalas](
	[id_tipoSala] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](10) NOT NULL,
 CONSTRAINT [pk_ts] PRIMARY KEY CLUSTERED 
(
	[id_tipoSala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ActoresPeliculas]  WITH CHECK ADD  CONSTRAINT [fk_ap_act] FOREIGN KEY([id_actor])
REFERENCES [dbo].[Actores] ([id_actor])
GO
ALTER TABLE [dbo].[ActoresPeliculas] CHECK CONSTRAINT [fk_ap_act]
GO
ALTER TABLE [dbo].[ActoresPeliculas]  WITH CHECK ADD  CONSTRAINT [fk_ap_idp] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[Peliculas] ([id_pelicula])
GO
ALTER TABLE [dbo].[ActoresPeliculas] CHECK CONSTRAINT [fk_ap_idp]
GO
ALTER TABLE [dbo].[Butacas]  WITH CHECK ADD  CONSTRAINT [fk_but_fun] FOREIGN KEY([id_funcion])
REFERENCES [dbo].[Funciones] ([id_funcion])
GO
ALTER TABLE [dbo].[Butacas] CHECK CONSTRAINT [fk_but_fun]
GO
ALTER TABLE [dbo].[Butacas]  WITH CHECK ADD  CONSTRAINT [fk_but_res] FOREIGN KEY([id_reserva])
REFERENCES [dbo].[ReservasEstado] ([id_reserva])
GO
ALTER TABLE [dbo].[Butacas] CHECK CONSTRAINT [fk_but_res]
GO
ALTER TABLE [dbo].[Comprobantes]  WITH CHECK ADD  CONSTRAINT [fk_com_fc] FOREIGN KEY([id_formaCompra])
REFERENCES [dbo].[FormaCompras] ([id_formaCompra])
GO
ALTER TABLE [dbo].[Comprobantes] CHECK CONSTRAINT [fk_com_fc]
GO
ALTER TABLE [dbo].[Comprobantes]  WITH CHECK ADD  CONSTRAINT [fk_com_fp] FOREIGN KEY([id_formaPago])
REFERENCES [dbo].[FormaDePagos] ([id_formaDePago])
GO
ALTER TABLE [dbo].[Comprobantes] CHECK CONSTRAINT [fk_com_fp]
GO
ALTER TABLE [dbo].[Detalles_Comprobante]  WITH CHECK ADD  CONSTRAINT [fk_det_comp] FOREIGN KEY([id_comprobante])
REFERENCES [dbo].[Comprobantes] ([id_comprobante])
GO
ALTER TABLE [dbo].[Detalles_Comprobante] CHECK CONSTRAINT [fk_det_comp]
GO
ALTER TABLE [dbo].[Detalles_Comprobante]  WITH CHECK ADD  CONSTRAINT [fk_det_fun] FOREIGN KEY([id_funcion])
REFERENCES [dbo].[Funciones] ([id_funcion])
GO
ALTER TABLE [dbo].[Detalles_Comprobante] CHECK CONSTRAINT [fk_det_fun]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [fk_ent_but] FOREIGN KEY([id_butaca])
REFERENCES [dbo].[Butacas] ([id_butaca])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [fk_ent_but]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [fk_ent_det] FOREIGN KEY([id_detalle])
REFERENCES [dbo].[Detalles_Comprobante] ([id_detalle])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [fk_ent_det]
GO
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD  CONSTRAINT [fk_fun_peli] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[Peliculas] ([id_pelicula])
GO
ALTER TABLE [dbo].[Funciones] CHECK CONSTRAINT [fk_fun_peli]
GO
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD  CONSTRAINT [fk_fun_sal] FOREIGN KEY([id_sala])
REFERENCES [dbo].[SalasCine] ([id_sala])
GO
ALTER TABLE [dbo].[Funciones] CHECK CONSTRAINT [fk_fun_sal]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [fk_peli_clas] FOREIGN KEY([id_clasificacion])
REFERENCES [dbo].[ClasificacionesPeliculas] ([id_clasificacion])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [fk_peli_clas]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [fk_peli_dir] FOREIGN KEY([id_director])
REFERENCES [dbo].[Directores] ([id_director])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [fk_peli_dir]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [fk_peli_gen] FOREIGN KEY([id_genero])
REFERENCES [dbo].[Generos] ([id_genero])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [fk_peli_gen]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [fk_peli_id] FOREIGN KEY([id_idioma])
REFERENCES [dbo].[Idiomas] ([id_idioma])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [fk_peli_id]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [fk_peli_sub] FOREIGN KEY([id_subtitulos])
REFERENCES [dbo].[Subtitulos] ([id_subtitulo])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [fk_peli_sub]
GO
ALTER TABLE [dbo].[SalasCine]  WITH CHECK ADD  CONSTRAINT [fk_sal_ts] FOREIGN KEY([id_tipoSala])
REFERENCES [dbo].[TipoDeSalas] ([id_tipoSala])
GO
ALTER TABLE [dbo].[SalasCine] CHECK CONSTRAINT [fk_sal_ts]
GO
USE [master]
GO
ALTER DATABASE [Cine] SET  READ_WRITE 
GO
