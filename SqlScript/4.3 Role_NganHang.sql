use [NganHang]
GO 
-- Run this query in server 1 and server 2
-- If already have this role use ALTER instead of CREATE
CREATE ROLE NganHang;
GO 
ALTER ROLE  db_accessadmin ADD MEMBER NganHang;
ALTER ROLE  db_datareader ADD MEMBER NganHang;
GO


