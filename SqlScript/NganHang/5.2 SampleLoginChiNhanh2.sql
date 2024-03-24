/*
Du lieu mau cho cac login va user trong phan manh 2
*/
USE NGANHANG
EXEC SP_TaoLogin 'hoang2', '123' , '021', 'NganHang'
EXEC SP_TaoLogin 'huy2', '123' , '022', 'ChiNhanh'
EXEC SP_TaoLogin 'lam2', '123' , '023', 'KhachHang'