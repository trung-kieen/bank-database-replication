USE NGANHANG
GO 
CREATE OR ALTER VIEW uv_DanhSachKhachHang
AS
SELECT DisplayMember = HO +  ' ' + TEN  + ' - ' + CMND
, ValueMember = 'kh_' + CMND
FROM NGANHANG.dbo.KhachHang 