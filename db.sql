USE [master]
GO
/****** Object:  Database [Flare]    Script Date: 2023-10-21 01:27:09 PM ******/
CREATE DATABASE [Flare]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Flare', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Flare.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Flare_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Flare_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Flare] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Flare].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Flare] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Flare] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Flare] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Flare] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Flare] SET ARITHABORT OFF 
GO
ALTER DATABASE [Flare] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Flare] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Flare] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Flare] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Flare] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Flare] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Flare] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Flare] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Flare] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Flare] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Flare] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Flare] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Flare] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Flare] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Flare] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Flare] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Flare] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Flare] SET RECOVERY FULL 
GO
ALTER DATABASE [Flare] SET  MULTI_USER 
GO
ALTER DATABASE [Flare] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Flare] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Flare] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Flare] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Flare] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Flare] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Flare', N'ON'
GO
ALTER DATABASE [Flare] SET QUERY_STORE = ON
GO
ALTER DATABASE [Flare] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Flare]
GO
/****** Object:  Table [dbo].[BookInventory]    Script Date: 2023-10-21 01:27:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookInventory](
	[ISBN] [varchar](13) NOT NULL,
	[Title] [varchar](255) NULL,
	[Author] [varchar](100) NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BookInventory] ADD  DEFAULT ((1)) FOR [Quantity]
GO
USE [master]
GO
ALTER DATABASE [Flare] SET  READ_WRITE 
GO
