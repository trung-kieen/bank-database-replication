/*
Quy uoc gia tri tra ve 
0: khong tim thay 
1: tim thay tren site hien tai
2: tim thay tren site khac site hien tai
*/

USE NGANHANG
GO
CREATE OR ALTER PROC SP_TimNhanVien
    @manv CHAR(10)
AS
BEGIN

    IF (exists(SELECT MANV
    FROM NhanVien
    WHERE MANV=@manv))
	BEGIN
        SELECT 1;
        RETURN 1;
    -- Tim thay tren site hien tai
    END 
ELSE 
	BEGIN
        IF	(EXISTS(SELECT MANV
        FROM LINK0.NGANHANG.dbo.NhanVien
        WHERE MANV = @manv))
		BEGIN
            SELECT 2;
            -- Tim thay tren site khac site hien tai
            RETURN 2;
        END
	ELSE 
		SELECT 0
        -- Khong tim thay
        RETURN 0;

    END

END 