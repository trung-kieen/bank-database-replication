/*
Du lieu mau cho cac login va user trong phan manh 1
*/
USE NGANHANG
EXEC SP_TaoLogin 'hoang1', '123' , '001', 'NganHang'
EXEC SP_TaoLogin 'huy1', '123' , '002', 'ChiNhanh'
EXEC SP_TaoLogin 'lam1', '123' , '003', 'KhachHang'