/*
Tra ve cau lenh select voi 1 record voi cac cot nhu sau:
- cot thu nhat chua exists code quy uoc nhu sau: 
	+ tra ve 0 => khong tim thay
	+ tra ve 1 => tim thay tren site hien tai
	+ tra ve 2 => tim thay tren site khac site hien tai
- cot thu hai chua ma nv cua nhan vien tim thay neu co 
*/
USE NGANHANG
GO
CREATE OR ALTER PROCEDURE SP_Helper_CheckExistEmployee(
	@cmnd AS NCHAR(10)
)
AS
BEGIN
DECLARE @manv AS NCHAR(10) = NULL
DECLARE @exist_code AS INT = 0

IF (EXISTS(SELECT  MANV FROM NGANHANG.dbo.NhanVien WHERE CMND = @cmnd))
BEGIN
	SET  @manv = (SELECT TOP 1 MANV FROM NGANHANG.dbo.NhanVien WHERE CMND = @cmnd)
	SET @exist_code = 1 -- Found in current site
	goto return_select
    --insert code here
END
ELSE IF (EXISTS(SELECT  MANV FROM LINK0.NGANHANG.dbo.NhanVien WHERE CMND = @cmnd))
BEGIN
	SET  @manv = (SELECT TOP 1 MANV FROM LINK0.NGANHANG.dbo.NhanVien WHERE CMND = @cmnd)
	SET @exist_code = 2 -- Found in current site
	goto return_select
END
ELSE 
BEGIN
	goto return_select
END
		
-- Return finaly result
return_select: 
	SELECT EXIST_CODE =@exist_code, MANV = @manv
	RETURN;

END;

			