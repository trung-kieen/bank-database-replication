/*
Du lieu mau cho cac login va user trong phan manh 2
*/

USE NGANHANG
GO

EXEC sp_droplogin 'nh2'
EXEC sp_droplogin 'cn2'
EXEC sp_droplogin 'kh2'
GO
EXEC sp_dropuser '002'
EXEC sp_dropuser '006'
EXEC sp_dropuser '005'
GO
EXEC SP_TaoLogin 'nh2', '123' , '002', 'NganHang'
EXEC SP_TaoLogin 'cn2', '123' , '006', 'ChiNhanh'
EXEC SP_TaoLogin 'kh2', '123' , '005', 'KhachHang'