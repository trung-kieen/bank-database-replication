use [NGANHANG]
GO 
-- Run this query in server 1 and server 2
-- If already have this role use ALTER instead of CREATE
CREATE ROLE ChiNhanh;
GO 
ALTER ROLE  db_owner ADD MEMBER CHINHANH;
GO

use [NganHang]
GO 
-- Run this query in server 1 and server 2
-- If already have this role use ALTER instead of CREATE
CREATE ROLE NganHang;
GO 
ALTER ROLE  db_accessadmin ADD MEMBER NganHang;
ALTER ROLE  db_securityadmin ADD MEMBER NganHang;

ALTER ROLE  db_datareader ADD MEMBER NganHang;
GO

use [NGANHANG]
GO 

-- If already have this role use ALTER instead of CREATE
-- TODO: This group allow to use sp to get report their account
CREATE ROLE KhachHang;
GO 
-- TODO: May not allow to change database 
-- ALTER ROLE  db_owner ADD MEMBER KhachHang;
GO


