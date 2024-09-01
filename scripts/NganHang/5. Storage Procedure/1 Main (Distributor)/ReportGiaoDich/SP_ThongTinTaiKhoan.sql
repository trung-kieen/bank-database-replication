/*
Use for report form get all account information from current branch


*/
USE NGANHANG
GO
CREATE OR ALTER PROCEDURE  SP_ThongTinTaiKhoan
	@sotk AS NCHAR(9)
AS
	SELECT CMND, HOTEN = HO + ' ' + TEN
	FROM LINK2.NGANHANG.dbo.KhachHang
	
	WHERE CMND = (SELECT TOP 1 CMND FROM NGANHANG.dbo.TaiKhoan WHERE SOTK = @sotk) 



			