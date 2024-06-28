Distributed databases allow data store in many machine. Because most query is just working on group of relate data, we can split up them in the same database. By doing that, the query search and update in a smaller dataset and that make our system is more scalability. In further, distributed databases allow us use query perform over many computers at the same time so the time consumpt for query data much faster.
# Setup environment
- MS SQL Server Management Studio (SSMS) 
- 4 server SQL with name: NGANHANG, NGANHANG1, NGANHANG2, NGANHANG3 with same database name NGANHANG. All setup for replication them in `script/` folder
- Service: Sql  Server Agent (avoid use sql server edtion express which missing this feature) and Microsoft Distribute Transaction Coordinator are runnings. 
- Config file `scr/Settings.cs` (see sample file `src/Settings.example.cs`) for env variable
- Visual studio .NET and DevExpress for winforms compatible with version of visual studio
NOTE: Visual studio 2017 and DevExpress19.2.5 are used for create this project

# Feature
![chuyen-nhan-vien](assets/chuyen-nhan-vien.gif)
![tao-login_xem-sao-ke](assets/tao-login_xem-sao-ke.gif)
![tao-tk-tu-kh](assets/tao-tk-tu-kh.gif)
![them-xoa-nhanvien](assets/them-xoa-nhanvien.gif)
![thuc-hien-giao-dich](assets/thuc-hien-giao-dich.gif)
![xem-thong-ke](assets/xem-thong-ke.gif)
# Special problems
- Soft delete 
- Combine sql cursor and temporary view to calculate value share between record respectively
- Distribute transaction
- Parallel query with sql agent job
- Implement undo, redo feature via command pattern
# Acknowledgments
If you are working on this school project consider to read my notes in [wiki](https://github.com/trung-kieen/bank-replication/wiki).
