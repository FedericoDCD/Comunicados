USE [master]
GO
/****** Object:  Database [BDComunicacion]    Script Date: 2/5/2020 4:17:01 AM ******/
CREATE DATABASE [BDComunicacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDComunicacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BDComunicacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDComunicacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BDComunicacion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BDComunicacion] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDComunicacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDComunicacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDComunicacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDComunicacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDComunicacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDComunicacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDComunicacion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDComunicacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDComunicacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDComunicacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDComunicacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDComunicacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDComunicacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDComunicacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDComunicacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDComunicacion] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDComunicacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDComunicacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDComunicacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDComunicacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDComunicacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDComunicacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDComunicacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDComunicacion] SET RECOVERY FULL 
GO
ALTER DATABASE [BDComunicacion] SET  MULTI_USER 
GO
ALTER DATABASE [BDComunicacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDComunicacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDComunicacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDComunicacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDComunicacion] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BDComunicacion', N'ON'
GO
ALTER DATABASE [BDComunicacion] SET QUERY_STORE = OFF
GO
USE [BDComunicacion]
GO
/****** Object:  Table [dbo].[Comunicados]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comunicados](
	[ID] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[Autor] [nvarchar](50) NOT NULL,
	[Mensaje] [nvarchar](1700) NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_Comunicados] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FaltaDeHoy]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FaltaDeHoy](
	[ID] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[Profesor] [nvarchar](50) NOT NULL,
	[Curso] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_FaltaDeHoy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[PRAAltaComunicado]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PRAAltaComunicado]
	@Autor nvarchar(50),
	@Mensaje nvarchar(1700),
	@Fecha Date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Comunicados(Autor,Mensaje,Fecha) VALUES (@Autor, @Mensaje,@Fecha);
END
GO
/****** Object:  StoredProcedure [dbo].[PRAAltaFaltaDeHoy]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PRAAltaFaltaDeHoy] 
	@Profesor nvarchar(50),
	@Curso nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO FaltaDeHoy (Profesor,Curso) VALUES (@Profesor, @Curso);
END
GO
/****** Object:  StoredProcedure [dbo].[PRABuscarComunicado]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PRABuscarComunicado]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	--Busco el comunicado publicado
	SELECT Autor,Mensaje, Fecha FROM Comunicados;
END
GO
/****** Object:  StoredProcedure [dbo].[PRABuscarFaltas]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PRABuscarFaltas] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Profesor, Curso FROM FaltaDeHoy;
END
GO
/****** Object:  StoredProcedure [dbo].[PRALimpiarComunicados]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PRALimpiarComunicados]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Comunicados;
END
GO
/****** Object:  StoredProcedure [dbo].[PRALimpiarFaltaDeHoy]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PRALimpiarFaltaDeHoy]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	--Busco el comunicado publicado
	DELETE FROM FaltaDeHoy;
END
GO
/****** Object:  StoredProcedure [dbo].[SqlQueryNotificationStoredProcedure-0511937b-2abd-488c-96a2-abf8e443e93c]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SqlQueryNotificationStoredProcedure-0511937b-2abd-488c-96a2-abf8e443e93c] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-0511937b-2abd-488c-96a2-abf8e443e93c]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-0511937b-2abd-488c-96a2-abf8e443e93c] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN if ((SELECT COUNT(*) FROM sys.services WHERE name = 'SqlQueryNotificationService-0511937b-2abd-488c-96a2-abf8e443e93c') > 0)   DROP SERVICE [SqlQueryNotificationService-0511937b-2abd-488c-96a2-abf8e443e93c]; if (OBJECT_ID('SqlQueryNotificationService-0511937b-2abd-488c-96a2-abf8e443e93c', 'SQ') IS NOT NULL)   DROP QUEUE [SqlQueryNotificationService-0511937b-2abd-488c-96a2-abf8e443e93c]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-0511937b-2abd-488c-96a2-abf8e443e93c]; END COMMIT TRANSACTION; END
GO
/****** Object:  StoredProcedure [dbo].[SqlQueryNotificationStoredProcedure-1dc0de37-221c-44f6-b218-f2efbcd88bad]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SqlQueryNotificationStoredProcedure-1dc0de37-221c-44f6-b218-f2efbcd88bad] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-1dc0de37-221c-44f6-b218-f2efbcd88bad]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-1dc0de37-221c-44f6-b218-f2efbcd88bad] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN if ((SELECT COUNT(*) FROM sys.services WHERE name = 'SqlQueryNotificationService-1dc0de37-221c-44f6-b218-f2efbcd88bad') > 0)   DROP SERVICE [SqlQueryNotificationService-1dc0de37-221c-44f6-b218-f2efbcd88bad]; if (OBJECT_ID('SqlQueryNotificationService-1dc0de37-221c-44f6-b218-f2efbcd88bad', 'SQ') IS NOT NULL)   DROP QUEUE [SqlQueryNotificationService-1dc0de37-221c-44f6-b218-f2efbcd88bad]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-1dc0de37-221c-44f6-b218-f2efbcd88bad]; END COMMIT TRANSACTION; END
GO
/****** Object:  StoredProcedure [dbo].[SqlQueryNotificationStoredProcedure-86866683-d71e-4090-8b00-3f8c0bedcb9b]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SqlQueryNotificationStoredProcedure-86866683-d71e-4090-8b00-3f8c0bedcb9b] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-86866683-d71e-4090-8b00-3f8c0bedcb9b]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-86866683-d71e-4090-8b00-3f8c0bedcb9b] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN if ((SELECT COUNT(*) FROM sys.services WHERE name = 'SqlQueryNotificationService-86866683-d71e-4090-8b00-3f8c0bedcb9b') > 0)   DROP SERVICE [SqlQueryNotificationService-86866683-d71e-4090-8b00-3f8c0bedcb9b]; if (OBJECT_ID('SqlQueryNotificationService-86866683-d71e-4090-8b00-3f8c0bedcb9b', 'SQ') IS NOT NULL)   DROP QUEUE [SqlQueryNotificationService-86866683-d71e-4090-8b00-3f8c0bedcb9b]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-86866683-d71e-4090-8b00-3f8c0bedcb9b]; END COMMIT TRANSACTION; END
GO
/****** Object:  StoredProcedure [dbo].[SqlQueryNotificationStoredProcedure-a39d730e-1c02-41b2-81a3-61c7c69c4e50]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SqlQueryNotificationStoredProcedure-a39d730e-1c02-41b2-81a3-61c7c69c4e50] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-a39d730e-1c02-41b2-81a3-61c7c69c4e50]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-a39d730e-1c02-41b2-81a3-61c7c69c4e50] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN if ((SELECT COUNT(*) FROM sys.services WHERE name = 'SqlQueryNotificationService-a39d730e-1c02-41b2-81a3-61c7c69c4e50') > 0)   DROP SERVICE [SqlQueryNotificationService-a39d730e-1c02-41b2-81a3-61c7c69c4e50]; if (OBJECT_ID('SqlQueryNotificationService-a39d730e-1c02-41b2-81a3-61c7c69c4e50', 'SQ') IS NOT NULL)   DROP QUEUE [SqlQueryNotificationService-a39d730e-1c02-41b2-81a3-61c7c69c4e50]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-a39d730e-1c02-41b2-81a3-61c7c69c4e50]; END COMMIT TRANSACTION; END
GO
/****** Object:  StoredProcedure [dbo].[SqlQueryNotificationStoredProcedure-cf28fdb2-5571-410e-a293-83be54ddf6ec]    Script Date: 2/5/2020 4:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SqlQueryNotificationStoredProcedure-cf28fdb2-5571-410e-a293-83be54ddf6ec] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-cf28fdb2-5571-410e-a293-83be54ddf6ec]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-cf28fdb2-5571-410e-a293-83be54ddf6ec] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN if ((SELECT COUNT(*) FROM sys.services WHERE name = 'SqlQueryNotificationService-cf28fdb2-5571-410e-a293-83be54ddf6ec') > 0)   DROP SERVICE [SqlQueryNotificationService-cf28fdb2-5571-410e-a293-83be54ddf6ec]; if (OBJECT_ID('SqlQueryNotificationService-cf28fdb2-5571-410e-a293-83be54ddf6ec', 'SQ') IS NOT NULL)   DROP QUEUE [SqlQueryNotificationService-cf28fdb2-5571-410e-a293-83be54ddf6ec]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-cf28fdb2-5571-410e-a293-83be54ddf6ec]; END COMMIT TRANSACTION; END
GO
USE [master]
GO
ALTER DATABASE [BDComunicacion] SET  READ_WRITE 
GO
