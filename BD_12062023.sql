USE [master]
GO
/****** Object:  Database [tp_cine_grupoa_acn4av_ef]    Script Date: 12/06/2023 19:42:19 ******/
CREATE DATABASE [tp_cine_grupoa_acn4av_ef]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tp_cine_grupoa_acn4av_ef', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\tp_cine_grupoa_acn4av_ef.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tp_cine_grupoa_acn4av_ef_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\tp_cine_grupoa_acn4av_ef_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tp_cine_grupoa_acn4av_ef].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET ARITHABORT OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET  DISABLE_BROKER 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET  MULTI_USER 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET QUERY_STORE = ON
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [tp_cine_grupoa_acn4av_ef]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/06/2023 19:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funciones]    Script Date: 12/06/2023 19:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funciones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[idSala] [int] NOT NULL,
	[idPelicula] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[CantClientes] [int] NOT NULL,
	[Costo] [float] NOT NULL,
 CONSTRAINT [PK_Funciones] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 12/06/2023 19:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Sinopsis] [varchar](200) NOT NULL,
	[Duracion] [int] NOT NULL,
	[Poster] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Peliculas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 12/06/2023 19:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ubicacion] [varchar](100) NOT NULL,
	[Capacidad] [int] NOT NULL,
 CONSTRAINT [PK_Sala] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UF]    Script Date: 12/06/2023 19:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UF](
	[idUsuario] [int] NOT NULL,
	[idFuncion] [int] NOT NULL,
	[cantidadCompra] [int] NOT NULL,
 CONSTRAINT [PK_UF] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC,
	[idFuncion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 12/06/2023 19:42:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[DNI] [varchar](50) NOT NULL,
	[Mail] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[IntentosFallidos] [int] NOT NULL,
	[Bloqueado] [bit] NOT NULL,
	[Credito] [float] NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[EsAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230604205342_Initial', N'7.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230604212418_PrimerUsuario', N'7.0.5')
GO
SET IDENTITY_INSERT [dbo].[Funciones] ON 

INSERT [dbo].[Funciones] ([ID], [idSala], [idPelicula], [Fecha], [CantClientes], [Costo]) VALUES (1, 1, 1, CAST(N'2023-06-25' AS Date), 18, 1500)
INSERT [dbo].[Funciones] ([ID], [idSala], [idPelicula], [Fecha], [CantClientes], [Costo]) VALUES (3, 2, 1, CAST(N'2023-06-25' AS Date), 2, 1000)
INSERT [dbo].[Funciones] ([ID], [idSala], [idPelicula], [Fecha], [CantClientes], [Costo]) VALUES (5, 5, 4, CAST(N'2023-06-23' AS Date), 0, 1200)
INSERT [dbo].[Funciones] ([ID], [idSala], [idPelicula], [Fecha], [CantClientes], [Costo]) VALUES (6, 2, 5, CAST(N'2023-06-23' AS Date), 0, 1300)
INSERT [dbo].[Funciones] ([ID], [idSala], [idPelicula], [Fecha], [CantClientes], [Costo]) VALUES (7, 1, 6, CAST(N'2023-06-23' AS Date), 0, 1400)
INSERT [dbo].[Funciones] ([ID], [idSala], [idPelicula], [Fecha], [CantClientes], [Costo]) VALUES (8, 2, 6, CAST(N'2023-06-23' AS Date), 0, 1400)
INSERT [dbo].[Funciones] ([ID], [idSala], [idPelicula], [Fecha], [CantClientes], [Costo]) VALUES (9, 5, 6, CAST(N'2023-06-23' AS Date), 0, 1400)
INSERT [dbo].[Funciones] ([ID], [idSala], [idPelicula], [Fecha], [CantClientes], [Costo]) VALUES (10, 1, 5, CAST(N'2023-06-23' AS Date), 0, 950)
INSERT [dbo].[Funciones] ([ID], [idSala], [idPelicula], [Fecha], [CantClientes], [Costo]) VALUES (11, 5, 5, CAST(N'2023-06-23' AS Date), 0, 950)
SET IDENTITY_INSERT [dbo].[Funciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Peliculas] ON 

INSERT [dbo].[Peliculas] ([ID], [Nombre], [Sinopsis], [Duracion], [Poster]) VALUES (1, N'Jhon Wick 4', N'Un hombre duro...', 130, N'https://arepavolatil.com/wp-content/uploads/2023/02/john-wick-4-poster.jpg')
INSERT [dbo].[Peliculas] ([ID], [Nombre], [Sinopsis], [Duracion], [Poster]) VALUES (4, N'Guardianes de la Galaxia 3', N'El final de los guardianes', 125, N'https://i0.wp.com/www.universomarvel.com/wp-content/uploads/2023/02/guardians-of-the-galaxy-3-superbowl-poster.jpg?ssl=1')
INSERT [dbo].[Peliculas] ([ID], [Nombre], [Sinopsis], [Duracion], [Poster]) VALUES (5, N'El conjuro 3', N'Cagado hasta las patas', 98, N'https://www.themoviedb.org/t/p/original/79QjdRiT9zTLkrOq9FltoIxClma.jpg')
INSERT [dbo].[Peliculas] ([ID], [Nombre], [Sinopsis], [Duracion], [Poster]) VALUES (6, N'Super Mario Bros La Pelicula', N'Mario en pantalla grande', 110, N'https://www.latercera.com/resizer/JzHhj0HjOVLt-5SYbHUSz2mzNUk=/800x0/smart/cloudfront-us-east-1.images.arcpublishing.com/copesa/ZPEQXUEQKFELNAMFUTACTVA6NY.jpeg')
SET IDENTITY_INSERT [dbo].[Peliculas] OFF
GO
SET IDENTITY_INSERT [dbo].[Sala] ON 

INSERT [dbo].[Sala] ([ID], [Ubicacion], [Capacidad]) VALUES (1, N'Flores', 100)
INSERT [dbo].[Sala] ([ID], [Ubicacion], [Capacidad]) VALUES (2, N'Recoleta', 70)
INSERT [dbo].[Sala] ([ID], [Ubicacion], [Capacidad]) VALUES (5, N'Palermo', 80)
SET IDENTITY_INSERT [dbo].[Sala] OFF
GO
INSERT [dbo].[UF] ([idUsuario], [idFuncion], [cantidadCompra]) VALUES (1, 1, 3)
INSERT [dbo].[UF] ([idUsuario], [idFuncion], [cantidadCompra]) VALUES (1, 3, 2)
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID], [Nombre], [Apellido], [DNI], [Mail], [Password], [IntentosFallidos], [Bloqueado], [Credito], [FechaNacimiento], [EsAdmin]) VALUES (1, N'Obdulio R.', N'Gomez', N'45678964', N'm@mail', N'123', 0, 0, 10500, CAST(N'1974-05-07' AS Date), 1)
INSERT [dbo].[Usuarios] ([ID], [Nombre], [Apellido], [DNI], [Mail], [Password], [IntentosFallidos], [Bloqueado], [Credito], [FechaNacimiento], [EsAdmin]) VALUES (2, N'Alejandro', N'Solodujin', N'35156726', N'a@a.com', N'123', 0, 0, 0, CAST(N'2023-02-14' AS Date), 0)
INSERT [dbo].[Usuarios] ([ID], [Nombre], [Apellido], [DNI], [Mail], [Password], [IntentosFallidos], [Bloqueado], [Credito], [FechaNacimiento], [EsAdmin]) VALUES (4, N'Prueba', N'Prueba', N'25456456', N'we@a.com', N'123', 0, 0, 0, CAST(N'2023-02-14' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
/****** Object:  Index [IX_Funciones_idPelicula]    Script Date: 12/06/2023 19:42:19 ******/
CREATE NONCLUSTERED INDEX [IX_Funciones_idPelicula] ON [dbo].[Funciones]
(
	[idPelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Funciones_idSala]    Script Date: 12/06/2023 19:42:19 ******/
CREATE NONCLUSTERED INDEX [IX_Funciones_idSala] ON [dbo].[Funciones]
(
	[idSala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UF_idFuncion]    Script Date: 12/06/2023 19:42:19 ******/
CREATE NONCLUSTERED INDEX [IX_UF_idFuncion] ON [dbo].[UF]
(
	[idFuncion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD  CONSTRAINT [FK_Funciones_Peliculas_idPelicula] FOREIGN KEY([idPelicula])
REFERENCES [dbo].[Peliculas] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Funciones] CHECK CONSTRAINT [FK_Funciones_Peliculas_idPelicula]
GO
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD  CONSTRAINT [FK_Funciones_Sala_idSala] FOREIGN KEY([idSala])
REFERENCES [dbo].[Sala] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Funciones] CHECK CONSTRAINT [FK_Funciones_Sala_idSala]
GO
ALTER TABLE [dbo].[UF]  WITH CHECK ADD  CONSTRAINT [FK_UF_Funciones_idFuncion] FOREIGN KEY([idFuncion])
REFERENCES [dbo].[Funciones] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UF] CHECK CONSTRAINT [FK_UF_Funciones_idFuncion]
GO
ALTER TABLE [dbo].[UF]  WITH CHECK ADD  CONSTRAINT [FK_UF_Usuarios_idUsuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UF] CHECK CONSTRAINT [FK_UF_Usuarios_idUsuario]
GO
USE [master]
GO
ALTER DATABASE [tp_cine_grupoa_acn4av_ef] SET  READ_WRITE 
GO
