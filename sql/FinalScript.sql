USE [master]
GO
/****** Object:  Database [Alpha]    Script Date: 5/10/2020 9:44:56 PM ******/
CREATE DATABASE [Alpha]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Alpha', FILENAME = N'D:\Alpha.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Alpha_log', FILENAME = N'D:\Alpha_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Alpha] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Alpha].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Alpha] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Alpha] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Alpha] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Alpha] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Alpha] SET ARITHABORT OFF 
GO
ALTER DATABASE [Alpha] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Alpha] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Alpha] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Alpha] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Alpha] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Alpha] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Alpha] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Alpha] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Alpha] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Alpha] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Alpha] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Alpha] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Alpha] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Alpha] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Alpha] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Alpha] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Alpha] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Alpha] SET RECOVERY FULL 
GO
ALTER DATABASE [Alpha] SET  MULTI_USER 
GO
ALTER DATABASE [Alpha] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Alpha] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Alpha] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Alpha] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Alpha] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Alpha', N'ON'
GO
ALTER DATABASE [Alpha] SET QUERY_STORE = OFF
GO
USE [Alpha]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 5/10/2020 9:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[GameID] [int] NOT NULL,
	[GameName] [varchar](50) NOT NULL,
	[Platform] [char](1) NOT NULL,
	[Price] [int] NOT NULL,
	[Rating] [float] NOT NULL,
	[Picture] [image] NULL,
 CONSTRAINT [PK_Games] PRIMARY KEY CLUSTERED 
(
	[GameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quantity]    Script Date: 5/10/2020 9:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quantity](
	[QID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[GameID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Quantity] PRIMARY KEY CLUSTERED 
(
	[QID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/10/2020 9:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [char](50) NOT NULL,
	[feature] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Games] ([GameID], [GameName], [Platform], [Price], [Rating], [Picture]) VALUES (3001, N'Dota2', N'C', 1500, 8.5, NULL)
INSERT [dbo].[Games] ([GameID], [GameName], [Platform], [Price], [Rating], [Picture]) VALUES (3002, N'MW', N'P', 800, 9, NULL)
INSERT [dbo].[Games] ([GameID], [GameName], [Platform], [Price], [Rating], [Picture]) VALUES (3003, N'Halo', N'X', 3500, 83, NULL)
INSERT [dbo].[Games] ([GameID], [GameName], [Platform], [Price], [Rating], [Picture]) VALUES (3004, N'FFXV', N'P', 2000, 8, NULL)
GO
INSERT [dbo].[Quantity] ([QID], [UserID], [GameID], [Quantity]) VALUES (1, 1001, 3001, 1)
INSERT [dbo].[Quantity] ([QID], [UserID], [GameID], [Quantity]) VALUES (2, 1001, 3003, 2)
INSERT [dbo].[Quantity] ([QID], [UserID], [GameID], [Quantity]) VALUES (3, 1002, 3002, 1)
INSERT [dbo].[Quantity] ([QID], [UserID], [GameID], [Quantity]) VALUES (4, 1003, 3003, 2)
INSERT [dbo].[Quantity] ([QID], [UserID], [GameID], [Quantity]) VALUES (5, 1004, 3001, 10)
INSERT [dbo].[Quantity] ([QID], [UserID], [GameID], [Quantity]) VALUES (6, 1004, 3002, 15)
INSERT [dbo].[Quantity] ([QID], [UserID], [GameID], [Quantity]) VALUES (7, 1004, 3003, 12)
INSERT [dbo].[Quantity] ([QID], [UserID], [GameID], [Quantity]) VALUES (8, 1005, 3002, 9)
INSERT [dbo].[Quantity] ([QID], [UserID], [GameID], [Quantity]) VALUES (9, 1005, 3004, 6)
GO
INSERT [dbo].[Users] ([UserID], [Email], [UserName], [Password], [feature]) VALUES (1001, N'abc@gmail,com', N'abc', N'123                                               ', 1)
INSERT [dbo].[Users] ([UserID], [Email], [UserName], [Password], [feature]) VALUES (1002, N'def@gmail,com', N'def', N'456                                               ', 1)
INSERT [dbo].[Users] ([UserID], [Email], [UserName], [Password], [feature]) VALUES (1003, N'ghi@gmail.com', N'ghi', N'789                                               ', 1)
INSERT [dbo].[Users] ([UserID], [Email], [UserName], [Password], [feature]) VALUES (1004, N'jkl@gmail.com', N'jkl', N'101112                                            ', 0)
INSERT [dbo].[Users] ([UserID], [Email], [UserName], [Password], [feature]) VALUES (1005, N'mno@gmail.com', N'mno', N'131415                                            ', 0)
GO
USE [master]
GO
ALTER DATABASE [Alpha] SET  READ_WRITE 
GO
