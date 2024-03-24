USE [master]
GO

/****** Object:  Login [HTKN]    Script Date: 3/1/2024 7:10:25 PM ******/
DROP LOGIN [HTKN]
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [HTKN]    Script Date: 3/1/2024 7:10:25 PM ******/
CREATE LOGIN [HTKN] WITH PASSWORD=N'123456', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO

-- ALTER LOGIN [HTKN] DISABLE
GO
ALTER LOGIN [HTKN] ENABLE



use [NganHang]
GO
CREATE USER [HTKN] FOR LOGIN [HTKN]

ALTER ROLE  db_owner ADD MEMBER HTKN;
