/*
Quy uoc gia tri tra ve 
0: khong tim thay 
1: tim thay tren site hien tai
2: tim thay tren site khac site hien tai
NOTE: vi tai khoan la nhan ban => du lieu day du tren mot phan manh bat ky
*/

USE NGANHANG
GO
CREATE OR ALTER PROC SP_TimTaiKhoan
    @sotk CHAR(10)
AS
BEGIN

    IF (exists(SELECT SOTK
    FROM TaiKhoan
    WHERE SOTK=@sotk))
	BEGIN
        SELECT 1;
        RETURN 1;
    -- Tim thay tren site hien tai
    END 

END 