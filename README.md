# Installation
- MS SQL Server Management Studio (SSMS)
- 4 server SQL with name: NGANHANG, NGANHANG1, NGANHANG2, NGANHANG3 with same database name NGANHANG. All setup for replication them in `scripts/` folder
- Service: Sql  Server Agent (avoid use sql server edtion express which missing this feature) and Microsoft Distribute Transaction Coordinator are runnings.
- Change sa and remote login password in `Program.cs`
- Visual studio .NET and DevExpress for winforms compatible with version of visual studio
NOTE: Visual studio 2017 and DevExpress19.2.5 are used for create this project
# Features
- Distribute transaction
- Parallel query with sql agent job
- Implement undo, redo feature via command pattern
![tao-login_xem-sao-ke](assets/tao-login_xem-sao-ke.gif)
![tao-tk-tu-kh](assets/tao-tk-tu-kh.gif)
![them-xoa-nhanvien](assets/them-xoa-nhanvien.gif)
![thuc-hien-giao-dich](assets/thuc-hien-giao-dich.gif)
![xem-thong-ke](assets/xem-thong-ke.gif)
Slow data synchronize of mssql server replication technology make different result from many perspective -.- especially in distribute transaction
![chuyen-nhan-vien](assets/chuyen-nhan-vien.gif)
