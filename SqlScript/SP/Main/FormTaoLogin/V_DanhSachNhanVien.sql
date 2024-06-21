USE NGANHANG
GO
CREATE OR ALTER VIEW uv_DanhSachNhanVien
AS 
SELECT DisplayMember =   MANV + ' - ' + HO + ' ' + TEN
, ValueMember = MANV
FROM NGANHANG.dbo.NhanVien

			