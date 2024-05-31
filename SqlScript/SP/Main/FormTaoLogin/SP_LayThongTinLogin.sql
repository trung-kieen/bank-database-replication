USE NGANHANG
GO
/* 
Từ user name trả về tên login và nhóm của user đó
*/
CREATE OR ALTER PROCEDURE SP_LayThongTinLogin(
    @username AS NVARCHAR(50)
)
AS
BEGIN
    DECLARE @login_name AS NVARCHAR(50) = (SELECT TOP 1
        name
    FROM sys.syslogins
    WHERE sid = (SELECT TOP 1
        sid
    FROM sys.sysusers
    WHERE name = @username)
			)

    DECLARE @group_name AS NVARCHAR(50) =(SELECT NAME
    FROM sys.sysusers
    WHERE UID = (SELECT GROUPUID
    FROM SYS.SYSMEMBERS
    WHERE MEMBERUID=  (SELECT TOP 1
        uid
    FROM sys.sysusers
    WHERE name = @username)))
	IF(@login_name IS NOT NULL )
		SELECT
        TENLOGIN = @login_name ,
        TENNHOM= @group_name
END;

GO
EXEC SP_LayThongTinLogin '001'
			