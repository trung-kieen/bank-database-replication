USE NGANHANG
GO
CREATE OR ALTER PROCEDURE SP_ThongKeTaiKhoan(
	-- param can set default value 
	@tungay AS DATETIME 
	,@denngay AS DATETIME 
	,@all_site BIT = 0

)
AS
BEGIN
	
	SELECT SOTK, CMND, SODU, MACN, NGAYMOTK FROM NGANHANG.dbo.TaiKhoan 
	WHERE (@all_site = 1 OR MACN = (SELECT TOP 1 MACN FROM NGANHANG.dbo.ChiNhanh))
	AND	NGAYMOTK <= @denngay AND NGAYMOTK >= @tungay
	ORDER BY MACN

END;
-- GO 
-- EXEC SP_ThongKeTaiKhoan @all_site = 1
