USE NGANHANG
GO 

CREATE OR ALTER PROCEDURE SP_DSTaiKhoan_ThongKeGD(
@cmnd AS NCHAR(10) = NULL -- Search for all account own by this customer
)
AS
BEGIN
	SELECT SOTK FROM NGANHANG.dbo.TaiKhoan 
	WHERE MACN =(SELECT TOP 1 MACN FROM NGANHANG.dbo.ChiNhanh)
	AND (@cmnd IS NULL OR CMND = @cmnd)

END;
GO
EXEC SP_DSTaiKhoan_ThongKeGD '00111'
