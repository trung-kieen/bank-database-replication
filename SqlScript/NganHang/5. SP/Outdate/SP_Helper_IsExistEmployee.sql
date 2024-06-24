/*
Quy uoc gia tri tra ve 
0: khong tim thay 
1: tim thay tren site hien tai
2: tim thay tren site khac site hien tai
*/

USE NGANHANG
GO
CREATE OR ALTER PROC SP_IsExistEmployee
    @cmnd NCHAR(10)
AS
IF (exists(SELECT MANV FROM NGANHANG.dbo.NhanVien WHERE CMND = @cmnd))
BEGIN

	SELECT 1;
	RETURN  -- Tim thay tren site hien tai
END 


ELSE 
-- Tim tren chi nhanh chu
BEGIN
    IF	(EXISTS(SELECT MANV FROM LINK0.NGANHANG.dbo.NhanVien WHERE CMND = @cmnd))
	BEGIN
		SELECT 2; -- Tim thay tren site khac site hien tai
		RETURN 

    END
	ELSE 
		SELECT 0 -- Khong tim thay
		RETURN
	 
END   
