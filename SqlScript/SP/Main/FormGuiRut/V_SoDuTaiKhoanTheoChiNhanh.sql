-- Su dung trong form gui rut
USE NGANHANG
GO
CREATE OR ALTER VIEW uv_SoDuTaiKhoanTheoChiNhanh
AS
SELECT SOTK, SODU FROM NGANHANG.dbo.TaiKhoan 