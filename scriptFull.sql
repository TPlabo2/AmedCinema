USE [master]
GO
/****** Object:  Database [Cine]    Script Date: 12/11/2018 8:43:11 p. m. ******/
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
/****** Object:  Table [dbo].[Actores]    Script Date: 12/11/2018 8:43:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actores](
	[id_actor] [int] NOT NULL,
	[nombre] [varchar](70) NOT NULL,
	[apellido] [varchar](70) NOT NULL,
	[nacionalidad] [varchar](70) NULL,
	[reseña] [text] NULL,
	[fecha_nacimiento] [datetime] NULL,
 CONSTRAINT [pk_act] PRIMARY KEY CLUSTERED 
(
	[id_actor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActoresPelicula]    Script Date: 12/11/2018 8:43:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActoresPelicula](
	[id_actorPeli] [int] IDENTITY(1,1) NOT NULL,
	[id_actor] [int] NOT NULL,
	[id_pelicula] [int] NOT NULL,
 CONSTRAINT [pk_actPeli] PRIMARY KEY CLUSTERED 
(
	[id_actorPeli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Butacas]    Script Date: 12/11/2018 8:43:12 p. m. ******/
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
/****** Object:  Table [dbo].[ClasificacionesPelicula]    Script Date: 12/11/2018 8:43:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClasificacionesPelicula](
	[id_Clasificacion] [int] IDENTITY(1,1) NOT NULL,
	[clasificacion] [varchar](30) NOT NULL,
 CONSTRAINT [pk_cp] PRIMARY KEY CLUSTERED 
(
	[id_Clasificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comprobante]    Script Date: 12/11/2018 8:43:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comprobante](
	[id_Comprobante] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_formaPago] [int] NOT NULL,
	[id_formaCompra] [int] NOT NULL,
 CONSTRAINT [pk_com] PRIMARY KEY CLUSTERED 
(
	[id_Comprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Comprobantes]    Script Date: 12/11/2018 8:43:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Comprobantes](
	[id_Detalle] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [int] NULL,
	[precio] [money] NULL,
	[descuento] [money] NULL,
	[id_funcion] [int] NOT NULL,
	[id_comprobante] [int] NOT NULL,
 CONSTRAINT [pk_det] PRIMARY KEY CLUSTERED 
(
	[id_Detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Directores]    Script Date: 12/11/2018 8:43:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Directores](
	[id_director] [int] NOT NULL,
	[nombre] [varchar](70) NOT NULL,
	[apellido] [varchar](70) NOT NULL,
	[nacionalidad] [varchar](70) NULL,
	[reseña] [text] NULL,
	[fecha_nacimiento] [datetime] NULL,
 CONSTRAINT [pk_dir] PRIMARY KEY CLUSTERED 
(
	[id_director] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entradas]    Script Date: 12/11/2018 8:43:12 p. m. ******/
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
/****** Object:  Table [dbo].[formaCompras]    Script Date: 12/11/2018 8:43:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formaCompras](
	[id_formaCompra] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [pk_fc] PRIMARY KEY CLUSTERED 
(
	[id_formaCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[formaDePagos]    Script Date: 12/11/2018 8:43:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formaDePagos](
	[id_formaDePago] [int] IDENTITY(1,1) NOT NULL,
	[formaPago] [varchar](20) NOT NULL,
 CONSTRAINT [pk_fp] PRIMARY KEY CLUSTERED 
(
	[id_formaDePago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funciones]    Script Date: 12/11/2018 8:43:12 p. m. ******/
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
/****** Object:  Table [dbo].[Generos]    Script Date: 12/11/2018 8:43:12 p. m. ******/
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
/****** Object:  Table [dbo].[idiomas]    Script Date: 12/11/2018 8:43:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[idiomas](
	[id_idiomas] [int] IDENTITY(1,1) NOT NULL,
	[Idioma] [varchar](20) NOT NULL,
 CONSTRAINT [pk_id] PRIMARY KEY CLUSTERED 
(
	[id_idiomas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 12/11/2018 8:43:12 p. m. ******/
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
/****** Object:  Table [dbo].[Pelicula]    Script Date: 12/11/2018 8:43:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pelicula](
	[id_pelicula] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[duracion] [time](7) NOT NULL,
	[id_genero] [int] NOT NULL,
	[id_idioma] [int] NOT NULL,
	[id_clasificacion] [int] NULL,
	[id_subtitulos] [int] NOT NULL,
	[id_director] [int] NOT NULL,
	[id_pais] [int] NOT NULL,
 CONSTRAINT [pk_peli] PRIMARY KEY CLUSTERED 
(
	[id_pelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservasEstado]    Script Date: 12/11/2018 8:43:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservasEstado](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [pk_fr] PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalasCine]    Script Date: 12/11/2018 8:43:12 p. m. ******/
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
/****** Object:  Table [dbo].[subtitulos]    Script Date: 12/11/2018 8:43:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subtitulos](
	[id_subtitulos] [int] IDENTITY(1,1) NOT NULL,
	[idiomaSubtitulos] [varchar](20) NOT NULL,
 CONSTRAINT [pk_sub] PRIMARY KEY CLUSTERED 
(
	[id_subtitulos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDeSalas]    Script Date: 12/11/2018 8:43:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDeSalas](
	[id_tipoSalas] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](10) NOT NULL,
 CONSTRAINT [pk_ts] PRIMARY KEY CLUSTERED 
(
	[id_tipoSalas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (1, N'Cacho', N'Castaña', N'Argentina', N'Realizo la pelicula "El comienzo"', CAST(N'1942-11-06T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (2, N'Dardo', N'Molina', N'Española', N'Ganador premio metropolitano 2017', CAST(N'1945-09-18T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (3, N'Hector', N'Godin', N'Uruguaya', N'Reconocido actor de acción en su país', CAST(N'1994-12-29T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (4, N'Em', N'Rata', N'Estaunidense', N'Exitosa actriz y modelo estaunidense', CAST(N'1991-06-07T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (5, N'Florence', N'Rice', N'Estaunidense', N'Premio a mejor actriz de reparto en "Cadetes del mar"', CAST(N'1907-02-14T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (6, N'Leonardo', N'Di Caprio', N'Estaunidense', N'Es un actor y productor de cine estadounidense. Ha recibido numerosos premios por su actuación, entre los que se destacan un Óscar al mejor actor', CAST(N'1974-11-11T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (7, N'Viggo', N'Mortensen', N'Estaunidense', N'Ademas de ser actor ejerce como poeta, músico, fotógrafo y pintor.', CAST(N'1958-10-20T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (8, N'Gal', N'Godot', N'Israelí', N'Ganó el título de Miss Israel 2004 y fue representante de su país durante el concurso de Miss Universo.', CAST(N'1985-04-30T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (9, N'Jackie', N'Chan', N'Chino', N'Es un artista marcial, comediante, cantante, actor, acróbata, doble de acción, coordinador de dobles de acción, director, guionista, productor, ', CAST(N'1954-04-07T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (10, N'Scarlett', N'Johansson', N'Estaunidense', N'Alcanzó la fama con su papel en la película The Horse Whisperer.', CAST(N'1984-11-22T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (11, N'Jack', N'Nicholson', N'Estaunidense', N'Es un actor, productor, guionista y director de cine estadounidense cuya carrera se ha extendido por más de sesenta años.', CAST(N'1937-04-22T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (12, N'Michelle', N'Rodriguez', N'Mexicana', N'Actuo en la pelicula rápidos y furisoso', CAST(N'1978-07-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (13, N'Gerardo', N'Romano', N'Argentina', N'Es un abogado y actor argentino de cine, teatro y televisión.', CAST(N'1946-08-06T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (14, N'Mirtha', N'Legrand', N'Argentina', N'Durante sus 78 años de carrera, actuó en 36 películas, once obras teatrales y tres series televisivas.', CAST(N'1754-02-23T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Actores] ([id_actor], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (15, N'Ricardo', N'Darín', N'Argentina', N'Es un actor y director argentino, cuya trayectoria comenzó en la industria televisiva a fines de los años 60.', CAST(N'1957-01-16T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[ActoresPelicula] ON 
GO
INSERT [dbo].[ActoresPelicula] ([id_actorPeli], [id_actor], [id_pelicula]) VALUES (1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[ActoresPelicula] OFF
GO
SET IDENTITY_INSERT [dbo].[Butacas] ON 
GO
INSERT [dbo].[Butacas] ([id_butaca], [id_reserva], [id_funcion]) VALUES (13, 1, 1)
GO
INSERT [dbo].[Butacas] ([id_butaca], [id_reserva], [id_funcion]) VALUES (14, 3, 2)
GO
INSERT [dbo].[Butacas] ([id_butaca], [id_reserva], [id_funcion]) VALUES (15, 5, 1)
GO
INSERT [dbo].[Butacas] ([id_butaca], [id_reserva], [id_funcion]) VALUES (16, 4, 1)
GO
INSERT [dbo].[Butacas] ([id_butaca], [id_reserva], [id_funcion]) VALUES (17, 2, 2)
GO
INSERT [dbo].[Butacas] ([id_butaca], [id_reserva], [id_funcion]) VALUES (18, 4, 1)
GO
SET IDENTITY_INSERT [dbo].[Butacas] OFF
GO
SET IDENTITY_INSERT [dbo].[ClasificacionesPelicula] ON 
GO
INSERT [dbo].[ClasificacionesPelicula] ([id_Clasificacion], [clasificacion]) VALUES (1, N'ATP')
GO
INSERT [dbo].[ClasificacionesPelicula] ([id_Clasificacion], [clasificacion]) VALUES (2, N'+13')
GO
INSERT [dbo].[ClasificacionesPelicula] ([id_Clasificacion], [clasificacion]) VALUES (3, N'+16')
GO
INSERT [dbo].[ClasificacionesPelicula] ([id_Clasificacion], [clasificacion]) VALUES (4, N'+18')
GO
SET IDENTITY_INSERT [dbo].[ClasificacionesPelicula] OFF
GO
SET IDENTITY_INSERT [dbo].[Comprobante] ON 
GO
INSERT [dbo].[Comprobante] ([id_Comprobante], [fecha], [id_formaPago], [id_formaCompra]) VALUES (25, CAST(N'2018-01-01T00:00:00.000' AS DateTime), 2, 1)
GO
INSERT [dbo].[Comprobante] ([id_Comprobante], [fecha], [id_formaPago], [id_formaCompra]) VALUES (26, CAST(N'2018-07-16T00:00:00.000' AS DateTime), 1, 2)
GO
INSERT [dbo].[Comprobante] ([id_Comprobante], [fecha], [id_formaPago], [id_formaCompra]) VALUES (27, CAST(N'2018-07-12T00:00:00.000' AS DateTime), 2, 1)
GO
INSERT [dbo].[Comprobante] ([id_Comprobante], [fecha], [id_formaPago], [id_formaCompra]) VALUES (28, CAST(N'2018-07-15T00:00:00.000' AS DateTime), 2, 1)
GO
INSERT [dbo].[Comprobante] ([id_Comprobante], [fecha], [id_formaPago], [id_formaCompra]) VALUES (29, CAST(N'2018-06-08T00:00:00.000' AS DateTime), 2, 2)
GO
INSERT [dbo].[Comprobante] ([id_Comprobante], [fecha], [id_formaPago], [id_formaCompra]) VALUES (30, CAST(N'2018-08-19T00:00:00.000' AS DateTime), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Comprobante] OFF
GO
SET IDENTITY_INSERT [dbo].[Detalle_Comprobantes] ON 
GO
INSERT [dbo].[Detalle_Comprobantes] ([id_Detalle], [cantidad], [precio], [descuento], [id_funcion], [id_comprobante]) VALUES (14, 1, 280.0000, 0.0000, 1, 25)
GO
INSERT [dbo].[Detalle_Comprobantes] ([id_Detalle], [cantidad], [precio], [descuento], [id_funcion], [id_comprobante]) VALUES (15, 2, 560.0000, 0.0000, 2, 26)
GO
INSERT [dbo].[Detalle_Comprobantes] ([id_Detalle], [cantidad], [precio], [descuento], [id_funcion], [id_comprobante]) VALUES (16, 1, 280.0000, 0.0000, 1, 27)
GO
INSERT [dbo].[Detalle_Comprobantes] ([id_Detalle], [cantidad], [precio], [descuento], [id_funcion], [id_comprobante]) VALUES (17, 2, 560.0000, 0.0000, 3, 28)
GO
INSERT [dbo].[Detalle_Comprobantes] ([id_Detalle], [cantidad], [precio], [descuento], [id_funcion], [id_comprobante]) VALUES (18, 1, 280.0000, 0.0000, 4, 29)
GO
INSERT [dbo].[Detalle_Comprobantes] ([id_Detalle], [cantidad], [precio], [descuento], [id_funcion], [id_comprobante]) VALUES (19, 1, 280.0000, 0.0000, 2, 30)
GO
SET IDENTITY_INSERT [dbo].[Detalle_Comprobantes] OFF
GO
INSERT [dbo].[Directores] ([id_director], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (1, N'Paul Thomas', N'Anderson', N'Estaunidense', N'Mejor director, Mejor película y mejor guion adaptado', CAST(N'1970-06-26T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Directores] ([id_director], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (2, N'Guillermo', N'del Toro', N'Mexicano', N'En 2018 se hizo acreedor al Globo de Oro como mejor director', CAST(N'1964-10-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Directores] ([id_director], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (3, N'Christopher', N'Nolan', N'Estaunidense', N'Nominado en cinco ocasiones al Óscar. ', CAST(N'1970-07-30T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Directores] ([id_director], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (4, N'Stanley', N'Kubrick', N'Estaunidense', N'Destacó tanto por su precisión técnica como por la gran estilización de sus películas y su marcado simbolismo.?', CAST(N'1928-07-26T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Directores] ([id_director], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (5, N'Andrés', N'Muschietti', N'Argentino', N'Es conocido por su trabajo en películas de terror como Mamá y It, estrenada en septiembre de 2017', CAST(N'1973-08-23T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Directores] ([id_director], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (6, N'Roman', N'Polanski', N'Francés', N'Está reconocido como uno de los cineastas más importantes de la segunda mitad del siglo XX y principios del XXI.', CAST(N'1933-08-18T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Directores] ([id_director], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (7, N'Andréi', N'Tarkovski', N'Ruso', N'Es considerado uno de los más importantes e influyentes autores del cine ruso en tiempos de la Unión Soviética.', CAST(N'1923-04-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Directores] ([id_director], [nombre], [apellido], [nacionalidad], [reseña], [fecha_nacimiento]) VALUES (8, N'Michael', N'Bay', N'Estaunidense', N'Conocido por dirigir y producir películas de acción de gran presupuesto', CAST(N'1965-02-17T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[formaCompras] ON 
GO
INSERT [dbo].[formaCompras] ([id_formaCompra], [descripcion]) VALUES (1, N'Pagina Web')
GO
INSERT [dbo].[formaCompras] ([id_formaCompra], [descripcion]) VALUES (2, N'APP')
GO
INSERT [dbo].[formaCompras] ([id_formaCompra], [descripcion]) VALUES (3, N'En boleteria')
GO
SET IDENTITY_INSERT [dbo].[formaCompras] OFF
GO
SET IDENTITY_INSERT [dbo].[formaDePagos] ON 
GO
INSERT [dbo].[formaDePagos] ([id_formaDePago], [formaPago]) VALUES (1, N'Debito')
GO
INSERT [dbo].[formaDePagos] ([id_formaDePago], [formaPago]) VALUES (2, N'Credito')
GO
INSERT [dbo].[formaDePagos] ([id_formaDePago], [formaPago]) VALUES (3, N'Efectivo')
GO
SET IDENTITY_INSERT [dbo].[formaDePagos] OFF
GO
SET IDENTITY_INSERT [dbo].[Funciones] ON 
GO
INSERT [dbo].[Funciones] ([id_funcion], [rangoHorario], [id_pelicula], [id_sala], [precio]) VALUES (1, CAST(N'18:10:00' AS Time), 1, 1, 280.0000)
GO
INSERT [dbo].[Funciones] ([id_funcion], [rangoHorario], [id_pelicula], [id_sala], [precio]) VALUES (2, CAST(N'18:10:00' AS Time), 1, 2, 280.0000)
GO
INSERT [dbo].[Funciones] ([id_funcion], [rangoHorario], [id_pelicula], [id_sala], [precio]) VALUES (3, CAST(N'16:30:00' AS Time), 2, 1, 280.0000)
GO
INSERT [dbo].[Funciones] ([id_funcion], [rangoHorario], [id_pelicula], [id_sala], [precio]) VALUES (4, CAST(N'15:20:00' AS Time), 1, 4, 280.0000)
GO
INSERT [dbo].[Funciones] ([id_funcion], [rangoHorario], [id_pelicula], [id_sala], [precio]) VALUES (5, CAST(N'18:40:00' AS Time), 2, 3, 280.0000)
GO
INSERT [dbo].[Funciones] ([id_funcion], [rangoHorario], [id_pelicula], [id_sala], [precio]) VALUES (6, CAST(N'17:30:00' AS Time), 3, 2, 280.0000)
GO
INSERT [dbo].[Funciones] ([id_funcion], [rangoHorario], [id_pelicula], [id_sala], [precio]) VALUES (7, CAST(N'23:10:00' AS Time), 2, 3, 280.0000)
GO
INSERT [dbo].[Funciones] ([id_funcion], [rangoHorario], [id_pelicula], [id_sala], [precio]) VALUES (8, CAST(N'15:40:00' AS Time), 3, 1, 280.0000)
GO
INSERT [dbo].[Funciones] ([id_funcion], [rangoHorario], [id_pelicula], [id_sala], [precio]) VALUES (9, CAST(N'19:30:00' AS Time), 2, 4, 280.0000)
GO
INSERT [dbo].[Funciones] ([id_funcion], [rangoHorario], [id_pelicula], [id_sala], [precio]) VALUES (10, CAST(N'22:10:00' AS Time), 1, 3, 280.0000)
GO
INSERT [dbo].[Funciones] ([id_funcion], [rangoHorario], [id_pelicula], [id_sala], [precio]) VALUES (11, CAST(N'22:10:00' AS Time), 1, 2, 280.0000)
GO
INSERT [dbo].[Funciones] ([id_funcion], [rangoHorario], [id_pelicula], [id_sala], [precio]) VALUES (12, CAST(N'22:40:00' AS Time), 3, 1, 280.0000)
GO
SET IDENTITY_INSERT [dbo].[Funciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Generos] ON 
GO
INSERT [dbo].[Generos] ([id_genero], [descripcion]) VALUES (1, N'Comedia')
GO
INSERT [dbo].[Generos] ([id_genero], [descripcion]) VALUES (2, N'Drama')
GO
INSERT [dbo].[Generos] ([id_genero], [descripcion]) VALUES (3, N'Terror')
GO
INSERT [dbo].[Generos] ([id_genero], [descripcion]) VALUES (4, N'Thriller')
GO
INSERT [dbo].[Generos] ([id_genero], [descripcion]) VALUES (5, N'Thriller Psicologico')
GO
INSERT [dbo].[Generos] ([id_genero], [descripcion]) VALUES (6, N'Musical')
GO
INSERT [dbo].[Generos] ([id_genero], [descripcion]) VALUES (7, N'Ciencia Ficcion')
GO
INSERT [dbo].[Generos] ([id_genero], [descripcion]) VALUES (8, N'Belica')
GO
INSERT [dbo].[Generos] ([id_genero], [descripcion]) VALUES (9, N'Infantil')
GO
INSERT [dbo].[Generos] ([id_genero], [descripcion]) VALUES (10, N'Accion')
GO
INSERT [dbo].[Generos] ([id_genero], [descripcion]) VALUES (11, N'Fantasia')
GO
INSERT [dbo].[Generos] ([id_genero], [descripcion]) VALUES (12, N'Horror')
GO
SET IDENTITY_INSERT [dbo].[Generos] OFF
GO
SET IDENTITY_INSERT [dbo].[idiomas] ON 
GO
INSERT [dbo].[idiomas] ([id_idiomas], [Idioma]) VALUES (1, N'Español')
GO
INSERT [dbo].[idiomas] ([id_idiomas], [Idioma]) VALUES (2, N'Ingles')
GO
INSERT [dbo].[idiomas] ([id_idiomas], [Idioma]) VALUES (3, N'Frances')
GO
INSERT [dbo].[idiomas] ([id_idiomas], [Idioma]) VALUES (4, N'Portugues')
GO
INSERT [dbo].[idiomas] ([id_idiomas], [Idioma]) VALUES (5, N'Chino')
GO
SET IDENTITY_INSERT [dbo].[idiomas] OFF
GO
SET IDENTITY_INSERT [dbo].[Paises] ON 
GO
INSERT [dbo].[Paises] ([id_pais], [nombre]) VALUES (1, N'Argentina')
GO
INSERT [dbo].[Paises] ([id_pais], [nombre]) VALUES (2, N'Estados Unidos')
GO
INSERT [dbo].[Paises] ([id_pais], [nombre]) VALUES (3, N'Mexico')
GO
INSERT [dbo].[Paises] ([id_pais], [nombre]) VALUES (4, N'Francia')
GO
INSERT [dbo].[Paises] ([id_pais], [nombre]) VALUES (5, N'Inglaterra')
GO
SET IDENTITY_INSERT [dbo].[Paises] OFF
GO
INSERT [dbo].[Pelicula] ([id_pelicula], [nombre], [duracion], [id_genero], [id_idioma], [id_clasificacion], [id_subtitulos], [id_director], [id_pais]) VALUES (1, N'El hilo invisible', CAST(N'01:40:00' AS Time), 2, 1, 2, 1, 1, 2)
GO
INSERT [dbo].[Pelicula] ([id_pelicula], [nombre], [duracion], [id_genero], [id_idioma], [id_clasificacion], [id_subtitulos], [id_director], [id_pais]) VALUES (2, N'La forma del agua', CAST(N'01:55:00' AS Time), 11, 2, 2, 1, 2, 2)
GO
INSERT [dbo].[Pelicula] ([id_pelicula], [nombre], [duracion], [id_genero], [id_idioma], [id_clasificacion], [id_subtitulos], [id_director], [id_pais]) VALUES (3, N'Dunkerque', CAST(N'01:05:00' AS Time), 8, 2, 3, 1, 4, 2)
GO
INSERT [dbo].[Pelicula] ([id_pelicula], [nombre], [duracion], [id_genero], [id_idioma], [id_clasificacion], [id_subtitulos], [id_director], [id_pais]) VALUES (4, N'Godzilla', CAST(N'02:03:00' AS Time), 3, 2, 4, 1, 8, 2)
GO
INSERT [dbo].[Pelicula] ([id_pelicula], [nombre], [duracion], [id_genero], [id_idioma], [id_clasificacion], [id_subtitulos], [id_director], [id_pais]) VALUES (5, N'Mamá', CAST(N'01:40:00' AS Time), 3, 1, 4, 3, 5, 2)
GO
INSERT [dbo].[Pelicula] ([id_pelicula], [nombre], [duracion], [id_genero], [id_idioma], [id_clasificacion], [id_subtitulos], [id_director], [id_pais]) VALUES (6, N'Juego del miedo', CAST(N'01:43:00' AS Time), 12, 2, 4, 1, 3, 2)
GO
INSERT [dbo].[Pelicula] ([id_pelicula], [nombre], [duracion], [id_genero], [id_idioma], [id_clasificacion], [id_subtitulos], [id_director], [id_pais]) VALUES (7, N'El Ángel', CAST(N'02:06:00' AS Time), 10, 3, 2, 1, 7, 1)
GO
INSERT [dbo].[Pelicula] ([id_pelicula], [nombre], [duracion], [id_genero], [id_idioma], [id_clasificacion], [id_subtitulos], [id_director], [id_pais]) VALUES (8, N'Venom', CAST(N'02:20:00' AS Time), 9, 1, 1, 1, 5, 2)
GO
INSERT [dbo].[Pelicula] ([id_pelicula], [nombre], [duracion], [id_genero], [id_idioma], [id_clasificacion], [id_subtitulos], [id_director], [id_pais]) VALUES (9, N'El Potro', CAST(N'01:25:00' AS Time), 2, 1, 3, 4, 6, 1)
GO
INSERT [dbo].[Pelicula] ([id_pelicula], [nombre], [duracion], [id_genero], [id_idioma], [id_clasificacion], [id_subtitulos], [id_director], [id_pais]) VALUES (10, N'El Potro', CAST(N'01:25:00' AS Time), 2, 1, 3, 4, 6, 1)
GO
SET IDENTITY_INSERT [dbo].[reservasEstado] ON 
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (1, 0)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (2, 1)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (3, 1)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (4, 0)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (5, 1)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (6, 1)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (7, 0)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (8, 1)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (9, 0)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (10, 1)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (11, 1)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (12, 0)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (13, 1)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (14, 1)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (15, 0)
GO
INSERT [dbo].[reservasEstado] ([id_reserva], [estado]) VALUES (16, 1)
GO
SET IDENTITY_INSERT [dbo].[reservasEstado] OFF
GO
SET IDENTITY_INSERT [dbo].[SalasCine] ON 
GO
INSERT [dbo].[SalasCine] ([id_sala], [id_tipoSala]) VALUES (1, 5)
GO
INSERT [dbo].[SalasCine] ([id_sala], [id_tipoSala]) VALUES (2, 2)
GO
INSERT [dbo].[SalasCine] ([id_sala], [id_tipoSala]) VALUES (3, 1)
GO
INSERT [dbo].[SalasCine] ([id_sala], [id_tipoSala]) VALUES (4, 4)
GO
INSERT [dbo].[SalasCine] ([id_sala], [id_tipoSala]) VALUES (5, 3)
GO
INSERT [dbo].[SalasCine] ([id_sala], [id_tipoSala]) VALUES (6, 3)
GO
SET IDENTITY_INSERT [dbo].[SalasCine] OFF
GO
SET IDENTITY_INSERT [dbo].[subtitulos] ON 
GO
INSERT [dbo].[subtitulos] ([id_subtitulos], [idiomaSubtitulos]) VALUES (1, N'Español')
GO
INSERT [dbo].[subtitulos] ([id_subtitulos], [idiomaSubtitulos]) VALUES (2, N'Ingles')
GO
INSERT [dbo].[subtitulos] ([id_subtitulos], [idiomaSubtitulos]) VALUES (3, N'Frances')
GO
INSERT [dbo].[subtitulos] ([id_subtitulos], [idiomaSubtitulos]) VALUES (4, N'Portugues')
GO
INSERT [dbo].[subtitulos] ([id_subtitulos], [idiomaSubtitulos]) VALUES (5, N'Chino')
GO
SET IDENTITY_INSERT [dbo].[subtitulos] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoDeSalas] ON 
GO
INSERT [dbo].[TipoDeSalas] ([id_tipoSalas], [descripcion]) VALUES (1, N'1D')
GO
INSERT [dbo].[TipoDeSalas] ([id_tipoSalas], [descripcion]) VALUES (2, N'2D')
GO
INSERT [dbo].[TipoDeSalas] ([id_tipoSalas], [descripcion]) VALUES (3, N'3D')
GO
INSERT [dbo].[TipoDeSalas] ([id_tipoSalas], [descripcion]) VALUES (4, N'4D')
GO
INSERT [dbo].[TipoDeSalas] ([id_tipoSalas], [descripcion]) VALUES (5, N'5D')
GO
SET IDENTITY_INSERT [dbo].[TipoDeSalas] OFF
GO
ALTER TABLE [dbo].[ActoresPelicula]  WITH CHECK ADD  CONSTRAINT [fk_ap_act] FOREIGN KEY([id_actor])
REFERENCES [dbo].[Actores] ([id_actor])
GO
ALTER TABLE [dbo].[ActoresPelicula] CHECK CONSTRAINT [fk_ap_act]
GO
ALTER TABLE [dbo].[ActoresPelicula]  WITH CHECK ADD  CONSTRAINT [fk_ap_idp] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[Pelicula] ([id_pelicula])
GO
ALTER TABLE [dbo].[ActoresPelicula] CHECK CONSTRAINT [fk_ap_idp]
GO
ALTER TABLE [dbo].[Butacas]  WITH CHECK ADD  CONSTRAINT [fk_but_fun] FOREIGN KEY([id_funcion])
REFERENCES [dbo].[Funciones] ([id_funcion])
GO
ALTER TABLE [dbo].[Butacas] CHECK CONSTRAINT [fk_but_fun]
GO
ALTER TABLE [dbo].[Butacas]  WITH CHECK ADD  CONSTRAINT [fk_but_res] FOREIGN KEY([id_reserva])
REFERENCES [dbo].[reservasEstado] ([id_reserva])
GO
ALTER TABLE [dbo].[Butacas] CHECK CONSTRAINT [fk_but_res]
GO
ALTER TABLE [dbo].[Comprobante]  WITH CHECK ADD  CONSTRAINT [fk_com_fc] FOREIGN KEY([id_formaCompra])
REFERENCES [dbo].[formaCompras] ([id_formaCompra])
GO
ALTER TABLE [dbo].[Comprobante] CHECK CONSTRAINT [fk_com_fc]
GO
ALTER TABLE [dbo].[Comprobante]  WITH CHECK ADD  CONSTRAINT [fk_com_fp] FOREIGN KEY([id_formaPago])
REFERENCES [dbo].[formaDePagos] ([id_formaDePago])
GO
ALTER TABLE [dbo].[Comprobante] CHECK CONSTRAINT [fk_com_fp]
GO
ALTER TABLE [dbo].[Detalle_Comprobantes]  WITH CHECK ADD  CONSTRAINT [fk_det_comp] FOREIGN KEY([id_comprobante])
REFERENCES [dbo].[Comprobante] ([id_Comprobante])
GO
ALTER TABLE [dbo].[Detalle_Comprobantes] CHECK CONSTRAINT [fk_det_comp]
GO
ALTER TABLE [dbo].[Detalle_Comprobantes]  WITH CHECK ADD  CONSTRAINT [fk_det_fun] FOREIGN KEY([id_funcion])
REFERENCES [dbo].[Funciones] ([id_funcion])
GO
ALTER TABLE [dbo].[Detalle_Comprobantes] CHECK CONSTRAINT [fk_det_fun]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [fk_ent_but] FOREIGN KEY([id_butaca])
REFERENCES [dbo].[Butacas] ([id_butaca])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [fk_ent_but]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [fk_ent_det] FOREIGN KEY([id_detalle])
REFERENCES [dbo].[Detalle_Comprobantes] ([id_Detalle])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [fk_ent_det]
GO
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD  CONSTRAINT [fk_fun_peli] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[Pelicula] ([id_pelicula])
GO
ALTER TABLE [dbo].[Funciones] CHECK CONSTRAINT [fk_fun_peli]
GO
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD  CONSTRAINT [fk_fun_sal] FOREIGN KEY([id_sala])
REFERENCES [dbo].[SalasCine] ([id_sala])
GO
ALTER TABLE [dbo].[Funciones] CHECK CONSTRAINT [fk_fun_sal]
GO
ALTER TABLE [dbo].[Pelicula]  WITH CHECK ADD  CONSTRAINT [fk_peli_clas] FOREIGN KEY([id_clasificacion])
REFERENCES [dbo].[ClasificacionesPelicula] ([id_Clasificacion])
GO
ALTER TABLE [dbo].[Pelicula] CHECK CONSTRAINT [fk_peli_clas]
GO
ALTER TABLE [dbo].[Pelicula]  WITH CHECK ADD  CONSTRAINT [fk_peli_dir] FOREIGN KEY([id_director])
REFERENCES [dbo].[Directores] ([id_director])
GO
ALTER TABLE [dbo].[Pelicula] CHECK CONSTRAINT [fk_peli_dir]
GO
ALTER TABLE [dbo].[Pelicula]  WITH CHECK ADD  CONSTRAINT [fk_peli_gen] FOREIGN KEY([id_genero])
REFERENCES [dbo].[Generos] ([id_genero])
GO
ALTER TABLE [dbo].[Pelicula] CHECK CONSTRAINT [fk_peli_gen]
GO
ALTER TABLE [dbo].[Pelicula]  WITH CHECK ADD  CONSTRAINT [fk_peli_id] FOREIGN KEY([id_idioma])
REFERENCES [dbo].[idiomas] ([id_idiomas])
GO
ALTER TABLE [dbo].[Pelicula] CHECK CONSTRAINT [fk_peli_id]
GO
ALTER TABLE [dbo].[Pelicula]  WITH CHECK ADD  CONSTRAINT [fk_peli_pais] FOREIGN KEY([id_pais])
REFERENCES [dbo].[Paises] ([id_pais])
GO
ALTER TABLE [dbo].[Pelicula] CHECK CONSTRAINT [fk_peli_pais]
GO
ALTER TABLE [dbo].[Pelicula]  WITH CHECK ADD  CONSTRAINT [fk_peli_sub] FOREIGN KEY([id_subtitulos])
REFERENCES [dbo].[subtitulos] ([id_subtitulos])
GO
ALTER TABLE [dbo].[Pelicula] CHECK CONSTRAINT [fk_peli_sub]
GO
ALTER TABLE [dbo].[SalasCine]  WITH CHECK ADD  CONSTRAINT [fk_sal_ts] FOREIGN KEY([id_tipoSala])
REFERENCES [dbo].[TipoDeSalas] ([id_tipoSalas])
GO
ALTER TABLE [dbo].[SalasCine] CHECK CONSTRAINT [fk_sal_ts]
GO
USE [master]
GO
ALTER DATABASE [Cine] SET  READ_WRITE 
GO
