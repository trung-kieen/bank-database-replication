USE NGANHANG
GO 
CREATE OR ALTER VIEW uv_DanhSachKhachHang
AS
SELECT DisplayMember = HO +  ' ' + TEN  + ' - ' + CMND
, ValueMember = 'KH' + CMND
FROM NGANHANG.dbo.KhachHang 