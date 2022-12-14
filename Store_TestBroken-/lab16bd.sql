USE [master]
GO
/****** Object:  Database [bdLab16]    Script Date: 02/02/2018 15:10:12 ******/
CREATE DATABASE [bdLab16]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bdLab16', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\bdLab16.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bdLab16_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\bdLab16_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [bdLab16] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bdLab16].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bdLab16] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bdLab16] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bdLab16] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bdLab16] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bdLab16] SET ARITHABORT OFF 
GO
ALTER DATABASE [bdLab16] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bdLab16] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bdLab16] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bdLab16] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bdLab16] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bdLab16] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bdLab16] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bdLab16] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bdLab16] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bdLab16] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bdLab16] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bdLab16] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bdLab16] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bdLab16] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bdLab16] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bdLab16] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bdLab16] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bdLab16] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bdLab16] SET  MULTI_USER 
GO
ALTER DATABASE [bdLab16] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bdLab16] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bdLab16] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bdLab16] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bdLab16] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bdLab16] SET QUERY_STORE = OFF
GO
USE [bdLab16]
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
USE [bdLab16]
GO
/****** Object:  Table [dbo].[areas]    Script Date: 02/02/2018 22:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[areas](
	[areCodigo] [varchar](100) NOT NULL,
	[areNombre] [varchar](100) NOT NULL,
	[areTiempo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_areas_1] PRIMARY KEY CLUSTERED 
(
	[areNombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detallePrestamos]    Script Date: 02/02/2018 22:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detallePrestamos](
	[dtpPrestamos] [varchar](10) NOT NULL,
	[dtpLibro] [varchar](100) NOT NULL,
	[dtpCantidad] [varchar](10) NOT NULL,
	[dtpFechaFin] [varchar](100) NOT NULL,
	[dtpFechaDevolucion] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[libros]    Script Date: 02/02/2018 22:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[libros](
	[libCodigo] [varchar](100) NOT NULL,
	[libNombre] [varchar](100) NOT NULL,
	[libNumeroPagina] [varchar](10) NOT NULL,
	[libAutor] [varchar](100) NOT NULL,
	[libEditorial] [varchar](100) NOT NULL,
	[libArea] [varchar](100) NOT NULL,
 CONSTRAINT [PK_libros] PRIMARY KEY CLUSTERED 
(
	[libNombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prestamos]    Script Date: 02/02/2018 22:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prestamos](
	[preCodigo] [varchar](10) NOT NULL,
	[preFecha] [varchar](100) NOT NULL,
	[preUsuario] [varchar](100) NOT NULL,
 CONSTRAINT [PK_prestamos] PRIMARY KEY CLUSTERED 
(
	[preCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sanciones]    Script Date: 02/02/2018 22:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sanciones](
	[sanCodigo] [varchar](10) NOT NULL,
	[sanPrestamo] [varchar](10) NOT NULL,
	[sanDiasSancion] [varchar](10) NOT NULL,
	[sanFechaInicio] [varchar](100) NOT NULL,
	[sanFechaFin] [varchar](100) NOT NULL,
 CONSTRAINT [PK_sanciones] PRIMARY KEY CLUSTERED 
(
	[sanCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 02/02/2018 22:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[usuDocumento] [varchar](100) NOT NULL,
	[usuNombre] [varchar](100) NOT NULL,
	[usuDireccion] [varchar](100) NOT NULL,
	[usuTelefono] [varchar](50) NOT NULL,
	[usuCorreo] [varchar](100) NULL,
	[usuEstado] [varchar](10) NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[usuNombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[areas] ([areCodigo], [areNombre], [areTiempo]) VALUES (N'2', N'LITERATURA', N'02/02/2018')
INSERT [dbo].[areas] ([areCodigo], [areNombre], [areTiempo]) VALUES (N'1', N'MATEMATICAS', N'02/02/2018')
INSERT [dbo].[detallePrestamos] ([dtpPrestamos], [dtpLibro], [dtpCantidad], [dtpFechaFin], [dtpFechaDevolucion]) VALUES (N'3', N'CALCULO II', N'2', N'02/02/2018', N'02/02/2018')
INSERT [dbo].[libros] ([libCodigo], [libNombre], [libNumeroPagina], [libAutor], [libEditorial], [libArea]) VALUES (N'1', N'CALCULO II', N'350', N'COL LIBROS', N'EDITORIALES ESP', N'MATEMATICAS')
INSERT [dbo].[libros] ([libCodigo], [libNombre], [libNumeroPagina], [libAutor], [libEditorial], [libArea]) VALUES (N'2', N'SANTILLANA DE INFORMATICA', N'910', N'JULIETA NOGUEZ', N'EDITORIAL SANTILLANA 2016', N'LITERATURA')
INSERT [dbo].[prestamos] ([preCodigo], [preFecha], [preUsuario]) VALUES (N'1', N'02/02/2018', N'JAIRO ALEXIS CARDENAS VALENCIA')
INSERT [dbo].[prestamos] ([preCodigo], [preFecha], [preUsuario]) VALUES (N'3', 02/02/2018', N'JAIRO ALEXIS CARDENAS VALENCIA')
INSERT [dbo].[usuarios] ([usuDocumento], [usuNombre], [usuDireccion], [usuTelefono], [usuCorreo], [usuEstado]) VALUES (N'80656737', N'DIEGO SOLANO ', N'BOGOTA', N'457824658', N'DIEGO-SOL@HOTMAIL.COM', N'ACTIVO')
INSERT [dbo].[usuarios] ([usuDocumento], [usuNombre], [usuDireccion], [usuTelefono], [usuCorreo], [usuEstado]) VALUES (N'72231429', N'HERNAN PIÑERO', N'BARRANQUILLA', N'254678', N'HERNAN3018@HOTMAIL.COM', N'INACTIVO')
ALTER TABLE [dbo].[detallePrestamos]  WITH CHECK ADD  CONSTRAINT [FK_detallePrestamos_libros] FOREIGN KEY([dtpLibro])
REFERENCES [dbo].[libros] ([libNombre])
GO
ALTER TABLE [dbo].[detallePrestamos] CHECK CONSTRAINT [FK_detallePrestamos_libros]
GO
ALTER TABLE [dbo].[detallePrestamos]  WITH CHECK ADD  CONSTRAINT [FK_detallePrestamos_prestamos1] FOREIGN KEY([dtpPrestamos])
REFERENCES [dbo].[prestamos] ([preCodigo])
GO
ALTER TABLE [dbo].[detallePrestamos] CHECK CONSTRAINT [FK_detallePrestamos_prestamos1]
GO
ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_libros_areas1] FOREIGN KEY([libArea])
REFERENCES [dbo].[areas] ([areNombre])
GO
ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_libros_areas1]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [FK_prestamos_usuarios1] FOREIGN KEY([preUsuario])
REFERENCES [dbo].[usuarios] ([usuNombre])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [FK_prestamos_usuarios1]
GO
ALTER TABLE [dbo].[sanciones]  WITH CHECK ADD  CONSTRAINT [FK_sanciones_prestamos] FOREIGN KEY([sanPrestamo])
REFERENCES [dbo].[prestamos] ([preCodigo])
GO
ALTER TABLE [dbo].[sanciones] CHECK CONSTRAINT [FK_sanciones_prestamos]
GO
USE [master]
GO
ALTER DATABASE [bdLab16] SET  READ_WRITE 
GO
