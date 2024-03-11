use [NGANHANG]
GO 
-- Run this query in server 1 and server 2
-- If already have this role use ALTER instead of CREATE
CREATE ROLE ChiNhanh;
GO 
ALTER ROLE  db_owner ADD MEMBER CHINHANH;
GO
