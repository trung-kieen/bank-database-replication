USE NGANHANG
GO
CREATE OR ALTER  PROC [dbo].[SP_LayThongTinNhanVien]
    @TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50), @UID INT;

SELECT @UID= UID, @TENUSER=NAME
FROM sys.sysusers
WHERE sid = SUSER_SID(@TENLOGIN)

-- Not allow deleted employee login to system 
IF (EXISTS(SELECT MANV
FROM NhanVien
WHERE MANV = @TENUSER AND TrangThaiXoa = 1))
	BEGIN
    RAISERROR('Nhan vien da dung hoat dong tai chi nhanh nen khong duoc phep dang nhap', 16, 1)
END
SELECT MANV = @TENUSER,
    HOTEN = (SELECT HO+ ' '+ TEN
    FROM NhanVien
    WHERE MANV = @TENUSER ),
    TENNHOM= NAME
FROM sys.sysusers
WHERE UID = (SELECT GROUPUID
FROM SYS.SYSMEMBERS
WHERE MEMBERUID= @UID)


-- EXEC SP_LayThongTinNhanVien 'lam'

-- EXEC SP_TAOLOGIN 'PT', 'kc', '001' , 'NganHang'

 
 -- DROP PROC SP_LayThongTinNhanVien