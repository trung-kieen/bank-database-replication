USE NGANHANG
GO 
-- Tra ve role ma mat quyen truy cap trong database  role tra ve su dung de rollback
CREATE OR ALTER PROCEDURE SP_DropEmployeeRole(
    @manv AS NCHAR(10)
)
AS
BEGIN

	-- Search for role in database 
    DECLARE @role AS NVARCHAR(50) = (SELECT NAME
    FROM sys.sysusers
    WHERE UID = (SELECT GROUPUID
    FROM SYS.SYSMEMBERS
    WHERE MEMBERUID=  (SELECT TOP 1
        uid
    FROM sys.sysusers
    WHERE name = @manv)))

	IF(@role IS NOT NULL) 
	BEGIN 
	DECLARE @RET INT 
	EXEC @RET= sp_droprolemember @rolename = @role, @membername = @manv
		 
	IF (@RET =1) 
	 BEGIN
		RAISERROR ( 'Khong the xoa quyen truy cap database cho ma nguoi dung nay', 16, 1)
		RETURN
	END	
	END 
	SELECT @role

END;

