USE NGANHANG
GO
DROP PROC SP_TimNhanVien
GO
-- SP Tim nhan vien tren cac phan manh
CREATE PROC SP_TimNhanVien
    @manv CHAR(10)
AS
DECLARE @ho NVARCHAR(50),
	@ten NVARCHAR(10), 
	@macn NVARCHAR(10);

IF (exists(SELECT MANV
FROM NhanVien
WHERE MANV=@manv))
BEGIN
    -- Tim tren chi nhanh hien tai 

    SELECT HO, TEN , TENCN = (SELECT TENCN
        FROM NGANHANG.dbo.ChiNhanh)
    FROM NhanVien
    WHERE MANV LIKE @manv 
END 


ELSE 
-- Tim tren chi nhanh chu
BEGIN
    IF	(EXISTS(SELECT MANV
    FROM LINK0.NGANHANG.dbo.NhanVien
    WHERE MANV = @manv))
	BEGIN
        SELECT @ho = HO, @ten = TEN, @macn = MACN
        FROM LINK0.NGANHANG.dbo.NhanVien
        WHERE MANV LIKE @manv

        SELECT HO = @ho , TEN = @ten, TENCN 
        FROM LINK0.NGANHANG.dbo.ChiNhanh
        WHERE MACN=@macn
    END
	ELSE 
	 
		raiserror('Khong tim thay nhan vien voi ma da cho', 16, 1);
	 
END   
-- EXEC SP_TimNhanVien '0000000000'

/*
USE NGANHANG
GO
DROP PROC SP_TimNhanVien

*/

