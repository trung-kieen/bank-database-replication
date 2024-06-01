USE NGANHANG
GO
CREATE OR ALTER  PROC [dbo].[SP_LayThongTinNhanVien]
    @loginame NVARCHAR (50)
AS
BEGIN
DECLARE @username NVARCHAR(50),
-- Uid connect to user to trace back which group user paticipate
@uid INT,
@fullname NVARCHAR(50),
@cmnd NVARCHAR(10),
@role NVARCHAR(20);

SELECT @uid= UID, @username=NAME
FROM sys.sysusers
WHERE sid = SUSER_SID(@loginame)

-- Not allow deleted employee login to system 
IF (EXISTS(SELECT MANV
FROM NhanVien
WHERE MANV = @username AND TrangThaiXoa = 1))
	BEGIN
    RAISERROR('Nhan vien da dung hoat dong tai chi nhanh nen khong duoc phep dang nhap', 16, 1)
END

SELECT @role = NAME
FROM sys.sysusers
WHERE UID = (SELECT GROUPUID
FROM SYS.SYSMEMBERS
WHERE MEMBERUID= @uid)

IF @role = 'KhachHang'
BEGIN 
-- Convention for username start with prefix KH24959966 => remain character is pertional id
SET @cmnd =    SUBSTRING(@username, 3, (LEN(@username) - 2)) 
SELECT @fullname =   HO+ ' '+ TEN
    FROM KhachHang
	-- Remove first 2 character in username 
	WHERE CMND = @cmnd
	END 
ELSE -- Role nhan vien
BEGIN
	SELECT @fullname =   HO+ ' '+ TEN
		FROM NhanVien
		WHERE MANV = @username 
END

IF @role = 'KhachHang'
SELECT MANV = @cmnd,
    HOTEN = @fullname,
    TENNHOM= @role
ELSE
SELECT MANV = @username,
    HOTEN = @fullname,
    TENNHOM= @role
END

GO
EXEC SP_LayThongTinNhanVien 'dswe'
-- EXEC SP_LayThongTinNhanVien 'lam'

-- EXEC SP_TAOLOGIN 'PT', 'kc', '001' , 'NganHang'

 
 -- DROP PROC SP_LayThongTinNhanVien