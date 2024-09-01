USE NGANHANG
GO
CREATE OR ALTER PROCEDURE SP_GuiRut(
	@sotk AS NCHAR(9),
	@sotien AS MONEY,
	@loaigd AS NCHAR(2),
	@manv AS NCHAR(10)
)
AS
BEGIN



IF (NOT EXISTS(SELECT  SOTK FROM NGANHANG.dbo.TaiKhoan WHERE SOTK = @sotk))
BEGIN
RAISERROR ( 'Tai khoan khong ton tai', 16, 1) 
RETURN;
END

			
SET XACT_ABORT ON;
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ

BEGIN TRANSACTION;


-- Them giao dich vao truy xuat 
-- Giam hoac them so tien

IF (@loaigd = 'GT')
BEGIN
	UPDATE NGANHANG.dbo.TaiKhoan
	SET SODU = SODU + @sotien
	WHERE SOTK = @sotk
END
ELSE IF (@loaigd = 'RT')
BEGIN
	UPDATE NGANHANG.dbo.TaiKhoan
	SET SODU = SODU - @sotien
	WHERE SOTK = @sotk
END
ELSE     
BEGIN
RAISERROR ( 'Loai giao dich khong hop le', 16, 1)
END	
  

INSERT INTO NGANHANG.dbo.GD_GOIRUT (SOTK, LOAIGD, NGAYGD, SOTIEN, MANV)
VALUES (@sotk, @loaigd, GETDATE(), @sotien, @manv);
COMMIT;

END

		