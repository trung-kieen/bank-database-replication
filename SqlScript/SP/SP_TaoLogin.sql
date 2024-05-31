USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[SP_TaoLogin]    Script Date: 5/30/2024 9:56:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[SP_TaoLogin] @login_name VARCHAR(50),
    @pass VARCHAR(50),
    @username VARCHAR(50),
    @role VARCHAR(50)
AS

DECLARE @RET INT

EXEC @RET= sp_addlogin @loginame = @login_name, @passwd = @pass, @defdb = 'NGANHANG'
IF (@RET =1) -- LOGIN NAME BI TRUNG
BEGIN
    RAISERROR ( 'Tai khoan dang nhap da ton tai', 16, 1)
    RETURN
END



BEGIN TRY
EXEC sp_dropuser @username;
END TRY
BEGIN CATCH
END CATCH

IF(TRIM(@role) NOT IN ('ChiNhanh', 'NganHang', 'KhachHang'))
BEGIN
    RAISERROR ( 'Phan quyen khong ton tai', 16, 2)
    RETURN
END

EXEC @RET= sp_grantdbaccess @loginame = @login_name, @name_in_db = @username
IF (@RET =1) -- USER NAME BI TRUNG
 BEGIN
    EXEC sp_droplogin @login_name
    RAISERROR ( 'Khong the tao username', 16, 3)
    RETURN
END

	
EXEC @RET= sp_addrolemember @rolename = @role, @membername = @username
		
IF (@RET =1) 
 BEGIN
    EXEC sp_droplogin @login_name
    RAISERROR ( 'Khong the trao quyen cho username nay', 16, 4)
    RETURN
END



IF TRIM(@role) = 'NganHang' OR TRIM(@role)  = 'ChiNhanh'
BEGIN
    EXEC sp_addsrvrolemember @loginame = @login_name, @rolename = 'SecurityAdmin'
    EXEC sp_addsrvrolemember @loginame = @login_name, @rolename = 'ProcessAdmin'
    RETURN 0
-- THANH CONG

END