USE [master]
GO
/****** Object:  Database [BaseSoporte]    Script Date: 9/12/2021 19:59:11 ******/
CREATE DATABASE [BaseSoporte]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BaseSoporte', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BaseSoporte.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BaseSoporte_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BaseSoporte_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BaseSoporte] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BaseSoporte].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BaseSoporte] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BaseSoporte] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BaseSoporte] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BaseSoporte] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BaseSoporte] SET ARITHABORT OFF 
GO
ALTER DATABASE [BaseSoporte] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BaseSoporte] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BaseSoporte] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BaseSoporte] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BaseSoporte] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BaseSoporte] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BaseSoporte] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BaseSoporte] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BaseSoporte] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BaseSoporte] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BaseSoporte] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BaseSoporte] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BaseSoporte] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BaseSoporte] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BaseSoporte] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BaseSoporte] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BaseSoporte] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BaseSoporte] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BaseSoporte] SET  MULTI_USER 
GO
ALTER DATABASE [BaseSoporte] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BaseSoporte] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BaseSoporte] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BaseSoporte] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BaseSoporte] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BaseSoporte] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BaseSoporte] SET QUERY_STORE = OFF
GO
USE [BaseSoporte]
GO
/****** Object:  Table [dbo].[Datos]    Script Date: 9/12/2021 19:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Datos](
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Correo] [varchar](100) NULL,
	[NumTicket] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](50) NULL,
	[Dispositivo] [varchar](50) NULL,
	[Descripción] [varchar](300) NULL,
 CONSTRAINT [PK_Datos] PRIMARY KEY CLUSTERED 
(
	[NumTicket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[eliminar_ticket]    Script Date: 9/12/2021 19:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminar_ticket]
@NumTicket int
as
Delete FROM Datos where NumTicket = @NumTicket;
GO
/****** Object:  StoredProcedure [dbo].[insertar_ticket]    Script Date: 9/12/2021 19:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertar_ticket]
@Nombre varchar(50),
@Apellido varchar(50),
@Correo varchar(100),
@Estado varchar(50),
@Dispositivo varchar(50),
@Descripción varchar(300)
as
Insert into Datos (Nombre, Apellido, Correo, Estado, Dispositivo, Descripción) values (@Nombre, @Apellido, @Correo, @Estado, @Dispositivo, @Descripción)
GO
/****** Object:  StoredProcedure [dbo].[insertar_ticket1]    Script Date: 9/12/2021 19:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertar_ticket1]
@Nombre varchar(50),
@Apellido varchar(50),
@Correo varchar(100),
@Dispositivo varchar(50),
@Descripción varchar(300)
as
Insert into Datos (Nombre, Apellido, Correo, Dispositivo, Descripción) values (@Nombre, @Apellido, @Correo, @Dispositivo, @Descripción)
GO
/****** Object:  StoredProcedure [dbo].[modificar_ticket]    Script Date: 9/12/2021 19:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificar_ticket]
@NumTicket int,
@Nombre varchar(50),
@Apellido varchar (50),
@Correo varchar (100),
@Descripción varchar (300),
@Estado varchar (50)
as
UPDATE Datos SET Nombre = '@Nombre',Apellido = '@Apellido',Correo = '@Correo',Descripción = '@Descripción',Estado = '@Estado' WHERE NumTicket = @NumTicket;
GO
/****** Object:  StoredProcedure [dbo].[mostrar_ticket_tabla]    Script Date: 9/12/2021 19:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[mostrar_ticket_tabla]
as 
Select Nombre, Apellido, Correo, NumTicket, Estado FROM Datos
GO
/****** Object:  StoredProcedure [dbo].[mostrar_todos]    Script Date: 9/12/2021 19:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[mostrar_todos]
as
select * from Datos
GO
USE [master]
GO
ALTER DATABASE [BaseSoporte] SET  READ_WRITE 
GO
