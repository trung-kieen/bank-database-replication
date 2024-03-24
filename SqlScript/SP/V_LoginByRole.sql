USE [NGANHANG]
GO

/****** Object:  View [dbo].[uv_LoginByRole]    Script Date: 3/24/2024 3:07:27 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--SELECT * FROM sys.sysmembers;
--SELECT * FROM sys.syslogins;
--SELECT * FROM sys.sysusers;
--SELECT * FROM NGANHANG.sys.database_principals;

CREATE VIEW [dbo].[uv_LoginByRole]
AS
SELECT  
 u.name as userid , l.loginname, role.name as rolename
FROM 
	sys.syslogins l 
INNER JOIN sys.sysusers u 
        ON u.sid = l.sid 
INNER JOIN sys.sysmembers m
		ON u.uid = m.memberuid
INNER JOIN NGANHANG.sys.database_principals role
		ON role.principal_id = m.groupuid;

-- Query this view 
--SELECT * FROM login_role;
GO


