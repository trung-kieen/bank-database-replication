/*
USE NGANHANG 
GO
CREATE OR ALTER PROC SP_XoaLogin 
@LGNAME VARCHAR(50)
AS 
-- Xoa user tao theo login 
DECLARE @USERNAME VARCHAR(50)

SELECT @USERNAME = NAME FROM sys.sysusers
WHERE sid = SUSER_SID(@LGNAME)

EXEC sp_dropuser @USERNAME;
EXEC sp_droplogin @LGNAME; 
-- Xoa login

*/

USE NGANHANG
GO
CREATE OR ALTER PROCEDURE SP_XoaLogin(
	@loginame AS NCHAR(50),
	@username AS NCHAR(50)
)
AS
BEGIN
EXEC sp_dropuser @username;
EXEC sp_droplogin @loginame;	
END;
GO
 
