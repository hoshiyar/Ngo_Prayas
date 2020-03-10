USE [Ngo_Prayas_DB]
GO
ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK__Users__RoleId__398D8EEE]
GO
ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK__Events__Category__3F466844]
GO
ALTER TABLE [dbo].[Event_Gallery] DROP CONSTRAINT [FK_Event_Gallery_Events]
GO
/****** Object:  Table [dbo].[Volunteers_Application]    Script Date: 3/10/2020 10:24:12 PM ******/
DROP TABLE [dbo].[Volunteers_Application]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/10/2020 10:24:12 PM ******/
DROP TABLE [dbo].[Users]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 3/10/2020 10:24:12 PM ******/
DROP TABLE [dbo].[Roles]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 3/10/2020 10:24:12 PM ******/
DROP TABLE [dbo].[Events]
GO
/****** Object:  Table [dbo].[EventCategories]    Script Date: 3/10/2020 10:24:12 PM ******/
DROP TABLE [dbo].[EventCategories]
GO
/****** Object:  Table [dbo].[Event_Gallery]    Script Date: 3/10/2020 10:24:12 PM ******/
DROP TABLE [dbo].[Event_Gallery]
GO
/****** Object:  Table [dbo].[ContactUs]    Script Date: 3/10/2020 10:24:12 PM ******/
DROP TABLE [dbo].[ContactUs]
GO
USE [master]
GO
/****** Object:  Database [Ngo_Prayas_DB]    Script Date: 3/10/2020 10:24:12 PM ******/
DROP DATABASE [Ngo_Prayas_DB]
GO
/****** Object:  Database [Ngo_Prayas_DB]    Script Date: 3/10/2020 10:24:12 PM ******/
CREATE DATABASE [Ngo_Prayas_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ngo_Prayas_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Ngo_Prayas_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ngo_Prayas_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Ngo_Prayas_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Ngo_Prayas_DB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ngo_Prayas_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ngo_Prayas_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ngo_Prayas_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ngo_Prayas_DB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ngo_Prayas_DB', N'ON'
GO
ALTER DATABASE [Ngo_Prayas_DB] SET QUERY_STORE = OFF
GO
USE [Ngo_Prayas_DB]
GO
/****** Object:  Table [dbo].[ContactUs]    Script Date: 3/10/2020 10:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactUs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[EmailId] [nvarchar](50) NOT NULL,
	[MobileNumber] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Event_Gallery]    Script Date: 3/10/2020 10:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event_Gallery](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImageName] [varchar](1000) NOT NULL,
	[EventId] [int] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsBaseImage] [bit] NULL,
 CONSTRAINT [PK__Event_Ga__3214EC0751DA0821] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventCategories]    Script Date: 3/10/2020 10:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventCategories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](260) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 3/10/2020 10:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventName] [nvarchar](250) NOT NULL,
	[EventDescription] [nvarchar](1000) NOT NULL,
	[EventDate] [datetime2](7) NOT NULL,
	[EventStartTime] [nvarchar](10) NOT NULL,
	[EventEndTime] [nvarchar](10) NOT NULL,
	[CategoryId] [int] NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[EventLocation] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK__Events__3214EC077D5D0180] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 3/10/2020 10:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/10/2020 10:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] NOT NULL,
	[EmailId] [varchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[RoleId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Volunteers_Application]    Script Date: 3/10/2020 10:24:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Volunteers_Application](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NULL,
	[Gender] [char](1) NULL,
	[City] [varchar](10) NULL,
	[MessageDescription] [varchar](3000) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Event_Gallery]  WITH CHECK ADD  CONSTRAINT [FK_Event_Gallery_Events] FOREIGN KEY([EventId])
REFERENCES [dbo].[Events] ([Id])
GO
ALTER TABLE [dbo].[Event_Gallery] CHECK CONSTRAINT [FK_Event_Gallery_Events]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK__Events__Category__3F466844] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[EventCategories] ([CategoryId])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK__Events__Category__3F466844]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
USE [master]
GO
ALTER DATABASE [Ngo_Prayas_DB] SET  READ_WRITE 
GO
