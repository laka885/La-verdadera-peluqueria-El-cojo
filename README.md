# PeluqueriaElCojo
ISW-123 Programación Media
Julian Vazquez 2023-0715
Profesor: Ivan Mateo Zorrilla


El proyecto consiste en un sistema de facturacion para la PeluqueriaElCojo, El sistema es sencillo y bastante funcional.


# Conceptos implementados
Interfaces: IFacturable.

Polimorfismo: List<IFacturable>.

Reflection: PropertyInfo y GetCustomAttributes.

Atributos Personalizados: Metadatos de validación.

Generics: Colecciones List<T>.

Encapsulamiento: Propiedades y modelos de datos.

WinForms: UI responsiva con Anchors y persistencia en memoria.

#
ENLACE DE VIDEO DE YOUTUBE EXPLICANDO SU FUNCIONAMIENTO
#

=============================================
https://youtu.be/ySCGpGUNHvA
================================================


# BASE DE DATOS

USE [master]
GO
/****** Object:  Database [PeluqueriaDB]    Script Date: 12/4/2026 12:13:42 a. m. ******/
CREATE DATABASE [PeluqueriaDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PeluqueriaDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PeluqueriaDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PeluqueriaDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PeluqueriaDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PeluqueriaDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PeluqueriaDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PeluqueriaDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PeluqueriaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PeluqueriaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PeluqueriaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PeluqueriaDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET RECOVERY FULL 
GO
ALTER DATABASE [PeluqueriaDB] SET  MULTI_USER 
GO
ALTER DATABASE [PeluqueriaDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PeluqueriaDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PeluqueriaDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PeluqueriaDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PeluqueriaDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PeluqueriaDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PeluqueriaDB', N'ON'
GO
ALTER DATABASE [PeluqueriaDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [PeluqueriaDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PeluqueriaDB]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 12/4/2026 12:13:42 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Clave] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 12/4/2026 12:13:42 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cliente] [varchar](100) NULL,
	[Servicio] [varchar](100) NULL,
	[Precio] [decimal](10, 2) NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 
GO
INSERT [dbo].[Usuarios] ([ID], [Usuario], [Clave]) VALUES (1, N'julian', N'1234')
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON 
GO
INSERT [dbo].[Ventas] ([Id], [Cliente], [Servicio], [Precio], [Fecha]) VALUES (1, N'Julian', N'Servicio de Peluquería', CAST(150.00 AS Decimal(10, 2)), CAST(N'2026-04-11T21:57:17.287' AS DateTime))
GO
INSERT [dbo].[Ventas] ([Id], [Cliente], [Servicio], [Precio], [Fecha]) VALUES (2, N'Julian', N'Servicio de Peluquería', CAST(150.00 AS Decimal(10, 2)), CAST(N'2026-04-11T23:50:10.673' AS DateTime))
GO
INSERT [dbo].[Ventas] ([Id], [Cliente], [Servicio], [Precio], [Fecha]) VALUES (3, N'Consumidor Final', N'Servicio de Peluquería', CAST(150.00 AS Decimal(10, 2)), CAST(N'2026-04-11T23:51:14.220' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Ventas] OFF
GO
ALTER TABLE [dbo].[Ventas] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
USE [master]
GO
ALTER DATABASE [PeluqueriaDB] SET  READ_WRITE 
GO
