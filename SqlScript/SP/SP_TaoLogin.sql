/*
Prerequisite: create role NganHang, ChiNhanh, KhachHang on site
*/

USE NGANHANG 
GO

CREATE OR ALTER PROC [dbo].[SP_TaoLogin]
    @LGNAME VARCHAR(50),
    @PASS VARCHAR(50),
    @USERNAME VARCHAR(50),
    @ROLE VARCHAR(50)
AS

DECLARE @RET INT

EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'NGANHANG'
IF (@RET =1) -- LOGIN NAME BI TRUNG
 RETURN 1


EXEC sp_dropuser @USERNAME;
EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
IF (@RET =1) -- USER NAME BI TRUNG
 BEGIN
    EXEC SP_DROPLOGIN @LGNAME
    RETURN 2
END
EXEC sp_addrolemember @ROLE, @USERNAME
IF @ROLE= 'NganHang' 
BEGIN
	-- Quyen them login
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
    EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'

	EXEC sp_addrolemember 'NganHang', @USERNAME
	RETURN 0 -- THANH CONG

END
ELSE IF @ROLE = 'ChiNhanh' 
BEGIN
	-- Quyen them login
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
    EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'

	EXEC sp_addrolemember 'ChiNhanh', @USERNAME
	RETURN 0 -- THANH CONG

END
ELSE IF @ROLE = 'KhachHang'
BEGIN 
	EXEC sp_addrolemember 'KhachHang', @USERNAME
	RETURN 0 -- THANH CONG

END 
ELSE 
BEGIN 
	return 3 -- Role khong hop le
END

-- DROP PROC [SP_TAOLOGIN]
