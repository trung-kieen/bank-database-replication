USE NGANHANG
GO 
CREATE OR ALTER VIEW uv_DanhSachKhachHang
AS
SELECT DisplayMember =  CMND + ' - ' + HO +  ' ' + TEN
, ValueMember = 'KH' + CMND
FROM NGANHANG.dbo.KhachHang 