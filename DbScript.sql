USE [master]
GO
/****** Object:  Database [TimeTable]    Script Date: 11/29/2022 1:52:55 PM ******/
CREATE DATABASE [TimeTable]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TimeTable', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\TimeTable.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TimeTable_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\TimeTable_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TimeTable] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TimeTable].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TimeTable] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TimeTable] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TimeTable] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TimeTable] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TimeTable] SET ARITHABORT OFF 
GO
ALTER DATABASE [TimeTable] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TimeTable] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TimeTable] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TimeTable] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TimeTable] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TimeTable] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TimeTable] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TimeTable] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TimeTable] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TimeTable] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TimeTable] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TimeTable] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TimeTable] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TimeTable] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TimeTable] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TimeTable] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TimeTable] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TimeTable] SET RECOVERY FULL 
GO
ALTER DATABASE [TimeTable] SET  MULTI_USER 
GO
ALTER DATABASE [TimeTable] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TimeTable] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TimeTable] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TimeTable] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TimeTable] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TimeTable] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TimeTable', N'ON'
GO
ALTER DATABASE [TimeTable] SET QUERY_STORE = ON
GO
ALTER DATABASE [TimeTable] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TimeTable]
GO
/****** Object:  Table [dbo].[ACCOUNTS]    Script Date: 11/29/2022 1:52:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNTS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEES]    Script Date: 11/29/2022 1:52:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEES](
	[EMPLOYEE_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EMPLOYEE_EGN] [varchar](10) NOT NULL,
	[EMPLOYEE_NAME] [varchar](50) NOT NULL,
	[EMPLOYEE_SURNAME] [varchar](50) NOT NULL,
	[EMPLOYEE_LASTNAME] [varchar](50) NOT NULL,
	[EMPLOYEE_POSITION] [varchar](50) NULL,
	[EMPLOYEE_HIREDATE] [date] NULL,
 CONSTRAINT [PK_EMPLOYEES] PRIMARY KEY CLUSTERED 
(
	[EMPLOYEE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROJECT]    Script Date: 11/29/2022 1:52:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROJECT](
	[PROJECT_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PROJECT_NAME] [varchar](50) NOT NULL,
	[PROJECT_BEGIN] [date] NOT NULL,
	[PROJECT_END] [date] NOT NULL,
	[PROJECT_DESCRIPTION] [varchar](400) NULL,
	[PROJECT_STATUS] [char](1) NOT NULL,
	[PROJECT_MAXHOURS] [numeric](18, 0) NULL,
 CONSTRAINT [PK_PROJECT] PRIMARY KEY CLUSTERED 
(
	[PROJECT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROJECT_HOURS]    Script Date: 11/29/2022 1:52:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROJECT_HOURS](
	[PROJECT_ID] [numeric](18, 0) NOT NULL,
	[EMPLOYEE_ID] [numeric](18, 0) NOT NULL,
	[PROJECT_TASKDATE] [date] NOT NULL,
	[PROJECT_MONTH_ID] [numeric](18, 0) NULL,
	[PROJECT_TASK] [varchar](50) NOT NULL,
	[PROJECT_HOURS] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_PROJECT_HOURS] PRIMARY KEY CLUSTERED 
(
	[PROJECT_ID] ASC,
	[EMPLOYEE_ID] ASC,
	[PROJECT_TASKDATE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROJECT_MONTHS]    Script Date: 11/29/2022 1:52:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROJECT_MONTHS](
	[PROJECT_MONTH_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PROJECT_ID] [numeric](18, 0) NOT NULL,
	[PROJECT_YEAR] [numeric](18, 0) NOT NULL,
	[PROJECT_MONTH] [numeric](18, 0) NOT NULL,
	[PROJECT_MONTH_STATUS] [char](1) NOT NULL,
 CONSTRAINT [PK_PROJECT_MONTHS] PRIMARY KEY CLUSTERED 
(
	[PROJECT_MONTH_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_EMPLOYEE_UQ]    Script Date: 11/29/2022 1:52:55 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IDX_EMPLOYEE_UQ] ON [dbo].[EMPLOYEES]
(
	[EMPLOYEE_EGN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_PROJECT_UQ]    Script Date: 11/29/2022 1:52:55 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IDX_PROJECT_UQ] ON [dbo].[PROJECT]
(
	[PROJECT_NAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_PROJECT_MONTHS_UQ]    Script Date: 11/29/2022 1:52:55 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IDX_PROJECT_MONTHS_UQ] ON [dbo].[PROJECT_MONTHS]
(
	[PROJECT_ID] ASC,
	[PROJECT_YEAR] ASC,
	[PROJECT_MONTH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PROJECT_MONTHS] ADD  DEFAULT ('O') FOR [PROJECT_MONTH_STATUS]
GO
ALTER TABLE [dbo].[PROJECT_HOURS]  WITH CHECK ADD  CONSTRAINT [FK_PROJECT__REFERENCE_EMPLOYEE] FOREIGN KEY([EMPLOYEE_ID])
REFERENCES [dbo].[EMPLOYEES] ([EMPLOYEE_ID])
GO
ALTER TABLE [dbo].[PROJECT_HOURS] CHECK CONSTRAINT [FK_PROJECT__REFERENCE_EMPLOYEE]
GO
ALTER TABLE [dbo].[PROJECT_HOURS]  WITH CHECK ADD  CONSTRAINT [FK_PROJECT__REFERENCE_PROJECT_] FOREIGN KEY([PROJECT_MONTH_ID])
REFERENCES [dbo].[PROJECT_MONTHS] ([PROJECT_MONTH_ID])
GO
ALTER TABLE [dbo].[PROJECT_HOURS] CHECK CONSTRAINT [FK_PROJECT__REFERENCE_PROJECT_]
GO
ALTER TABLE [dbo].[PROJECT_HOURS]  WITH CHECK ADD  CONSTRAINT [FK_PROJECT__REFERENCE_PROJECT1] FOREIGN KEY([PROJECT_ID])
REFERENCES [dbo].[PROJECT] ([PROJECT_ID])
GO
ALTER TABLE [dbo].[PROJECT_HOURS] CHECK CONSTRAINT [FK_PROJECT__REFERENCE_PROJECT1]
GO
ALTER TABLE [dbo].[PROJECT_MONTHS]  WITH CHECK ADD  CONSTRAINT [FK_PROJECT__REFERENCE_PROJECT] FOREIGN KEY([PROJECT_ID])
REFERENCES [dbo].[PROJECT] ([PROJECT_ID])
GO
ALTER TABLE [dbo].[PROJECT_MONTHS] CHECK CONSTRAINT [FK_PROJECT__REFERENCE_PROJECT]
GO
ALTER TABLE [dbo].[ACCOUNTS]  WITH CHECK ADD  CONSTRAINT [MY_TABLE_PASSWORD_CK] CHECK  ((len([Password])>=(4)))
GO
ALTER TABLE [dbo].[ACCOUNTS] CHECK CONSTRAINT [MY_TABLE_PASSWORD_CK]
GO
ALTER TABLE [dbo].[ACCOUNTS]  WITH CHECK ADD  CONSTRAINT [MY_TABLE_USERNAME_CK] CHECK  ((len([Username])>=(4)))
GO
ALTER TABLE [dbo].[ACCOUNTS] CHECK CONSTRAINT [MY_TABLE_USERNAME_CK]
GO
ALTER TABLE [dbo].[PROJECT]  WITH CHECK ADD  CONSTRAINT [CKC_PROJECT_STATUS_PROJECT] CHECK  (([PROJECT_STATUS]='C' OR [PROJECT_STATUS]='O'))
GO
ALTER TABLE [dbo].[PROJECT] CHECK CONSTRAINT [CKC_PROJECT_STATUS_PROJECT]
GO
ALTER TABLE [dbo].[PROJECT_MONTHS]  WITH CHECK ADD  CONSTRAINT [CKC_PROJECT_MONTH_STA_PROJECT_] CHECK  (([PROJECT_MONTH_STATUS]='C' OR [PROJECT_MONTH_STATUS]='O'))
GO
ALTER TABLE [dbo].[PROJECT_MONTHS] CHECK CONSTRAINT [CKC_PROJECT_MONTH_STA_PROJECT_]
GO
USE [master]
GO
ALTER DATABASE [TimeTable] SET  READ_WRITE 
GO
