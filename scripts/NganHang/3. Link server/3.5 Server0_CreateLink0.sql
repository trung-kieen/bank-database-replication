USE [master]
GO



/****** Object:  LinkedServer [LINK0]    Script Date: 3/2/2024 10:18:43 AM ******/
-- Drop link
-- EXEC master.dbo.sp_dropserver @server=N'LINK0', @droplogins='droplogins'
-- GO

/****** Object:  LinkedServer [LINK0]    Script Date: 3/2/2024 10:18:43 AM ******/
EXEC master.dbo.sp_addlinkedserver @server = N'LINK0', @srvproduct=N'TM\NGANHANG', @provider=N'SQLNCLI', @datasrc=N'TM\NGANHANG'
 /* For security reasons the linked server remote logins password is changed with ######## */
EXEC master.dbo.sp_addlinkedsrvlogin @rmtsrvname=N'LINK0',@useself=N'False',@locallogin=NULL,@rmtuser=N'HTKN',@rmtpassword='123456'
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'collation compatible', @optvalue=N'false'
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'data access', @optvalue=N'true'
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'dist', @optvalue=N'false'
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'pub', @optvalue=N'false'
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'rpc', @optvalue=N'true'
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'rpc out', @optvalue=N'true'
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'sub', @optvalue=N'false'
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'connect timeout', @optvalue=N'0'
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'collation name', @optvalue=null
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'lazy schema validation', @optvalue=N'false'
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'query timeout', @optvalue=N'0'
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'use remote collation', @optvalue=N'true'
GO

EXEC master.dbo.sp_serveroption @server=N'LINK0', @optname=N'remote proc transaction promotion', @optvalue=N'true'
GO


