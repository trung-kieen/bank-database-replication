/*
Vào trong chi nhánh Bến Thành thuc thực hiện chuyên chi nhánh nhân viên với mã cmnd như sau
=> Kiểm tra kết quả thông qua câu truy vấn query này xem nhân viên đã được chuyển đúng chưa
=> Do sử dụng DISTRIBUTED TRANSACTION nên dữ liệu đồng bộ thông qua app sẽ nhanh hơn còn dữ liệu
đồng bộ thay đổi của các record trên sql server sẽ chậm hơn (do chỉ là cập nhập định kỳ) nên 
có thể dữ liệu query trên ssms khác với ứng dụng trong một khoảng thời gian => Mở cửa sổ query 
mới chạy lại lệnh nhiều lần chờ kết quả thay đổi
Vì thay đổi từ hàng nhân viên gốc rồi thay đổi lên nhân viên ở chi nhánh khác nên sẽ có
khoảng thời gian câu select không trả về record nào vì mức độ ISOLATION sẽ tránh dirty read từ 
câu lệnh select khi transaction có sự thay đổi dữ liệu.
*/ 
 SELECT * FROM LINK0.NGANHANG.dbo.NhanVien WHERE CMND = '3742578568'

  SELECT * FROM LINK0.NGANHANG.dbo.NhanVien WHERE CMND =
  (SELECT CMND FROM LINK0.NGANHANG.dbo.NhanVien WHERE MANV = 'QA2XUXQO9D')


  EXEC SP_ChuyenNhanVien @ma_nv = 'NV00000099',@ma_nv_moi = 'QA2XUXQO9D', @ma_cn =  'TANDINH   ', @ma_cn_moi = 'BENTHANH  '
  