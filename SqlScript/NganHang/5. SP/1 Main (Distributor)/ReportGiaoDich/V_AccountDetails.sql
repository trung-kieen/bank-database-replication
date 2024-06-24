/*
Use for report form get all account information from current branch


*/
USE NGANHANG
GO
CREATE OR ALTER VIEW  uv_AccountDetails
AS
	SELECT
		SOTK, tk.CMND, HOTEN = HO + ' ' + TEN
	FROM
		(SELECT HO, TEN, CMND
		FROM NGANHANG.dbo.KhachHang ) kh
		INNER JOIN (SELECT SOTK, CMND
		FROM NGANHANG.dbo.TaiKhoan
		WHERE MACN = (SELECT TOP 1
			MACN
		FROM NGANHANG.dbo.ChiNhanh)

		) tk
		ON (kh.CMND = tk.CMND)




			