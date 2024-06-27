[Application demo](https://youtu.be/JHgNjVjq0k8?si=jQzgMX1BtWvmx111)
# Setup environment
- 4 server SQL with name: NGANHANG, NGANHANG1, NGANHANG2, NGANHANG3 with same database name NGANHANG. All setup for replication them in `script/` folder
- Service: Sql  Server Agent (avoid use sql server edtion express which missing this feature) and Microsoft Distribute Transaction Coordinator are runnings. 
- Config file `scr/Settings.cs` (see sample file `src/Settings.example.cs`) for env variable
- Visual studio .NET and DevExpress for winforms compatible with version of visual studio
