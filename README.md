<!--toc:start-->
- [What is this](#what-is-this)
- [Architecture](#architecture)
- [Features](#features)
  - [Advantage](#advantage)
  - [Downside](#downside)
- [Historical problem](#historical-problem)
- [Installation](#installation)
- [Resources](#resources)
- [License](#license)
- [Disclaimers](#disclaimers)
<!--toc:end-->

# What is this 
A simple desktop application powered by DevExpress WinForms Controls.


Database replicate with SQL Server Replication technology for improving scalability and availability
# Architecture
- Authentication and authorization: built on top of MS SQL Server login, user, server role, database role
- Database architecture: Two-Tier architecture

___
![system-design](assets/peer-to-peer.png)
![database-connection](assets/database-connetion.png)
# Features
- Distribute transaction
- Parallel Query Execution
- Undo / Redo 
___
![tao-login_xem-sao-ke](assets/tao-login_xem-sao-ke.gif)
![tao-tk-tu-kh](assets/tao-tk-tu-kh.gif)
![them-xoa-nhanvien](assets/them-xoa-nhanvien.gif)
![thuc-hien-giao-dich](assets/thuc-hien-giao-dich.gif)
![xem-thong-ke](assets/xem-thong-ke.gif)
![chuyen-nhan-vien](assets/chuyen-nhan-vien.gif)

## Advantage 
- Database system able to scaling horizontally
- Speed up query when find data from smaller database. Especially when query for local database instead of remote database server
- Parallel query able to gather data from many database, speed up query execution by optimize many computer hardware
## Downside  
- Slow data synchronize MS SQL server replication technology might allow different result from many aspect in a distribute transaction
- Hard to manager connection to many database via network
- In this project there is no strategy to handle single point of failure

# Historical problem 
- Boilerplate code on data access, handle exception
- SQL injection vulnerabilities 🫣 
- No Dockerization: binding ip address among computers are not trival when create docker compose 

# Installation

- MS SQL Server Management Studio (SSMS)
- 4 MS SQL Server with name: `NGANHANG`, `NGANHANG1`, `NGANHANG2`, `NGANHANG3` with same database name `NGANHANG`. All setup detail replication in `scripts/` folder (DDL script).
- Service: Sql Server Agent and Microsoft Distribute Transaction Coordinator to be enable
- Change sql login user `sa` and remote login password in `Program.cs` for appropriate with publisher database
- Visual studio .NET and DevExpress for winforms compatible with version of visual studio

Recommend: Visual studio 2017 developer edition and DevExpress 19.x 

# Resources
If you're interested in diving deeper into the topics related to this project, here are some useful resources:

- [SQL Server Replication - SQL Server](https://learn.microsoft.com/en-us/sql/relational-databases/replication/sql-server-replication?view=sql-server-ver16)
- [DevExpress Documentation](https://docs.devexpress.com/)



# License

All code is licensed under an MIT license. This allows you to re-use the code freely, remixed in both commercial and non-commercial projects. The only requirement is to include the same license when distributing.

# Disclaimers
For educational purposes only. Please do not submit my project, create your own instead.
