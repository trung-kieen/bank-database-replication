USE [NGANHANG]


DECLARE @login_name AS NVARCHAR = 'NGUYENVANB';			
DECLARE @user_id AS INT = 1;

CREATE LOGIN [@login_name] WITH PASSWORD=N'123456', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF


ALTER LOGIN [@login_name] DISABLE





ALTER SERVER ROLE [securityadmin] ADD MEMBER [@login_name]

use [NGANHANG]
ALTER ROLE [ChiNhanh] ADD MEMBER [@login_name];


-- Change 1 to it user id 
CREATE USER [@user_id] FOR LOGIN [@login_name] WITH DEFAULT_SCHEMA=[dbo]

