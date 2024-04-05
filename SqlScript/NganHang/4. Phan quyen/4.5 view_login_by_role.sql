--SELECT * FROM sys.sysmembers;
--SELECT * FROM sys.syslogins;
--SELECT * FROM sys.sysusers;
--SELECT * FROM NGANHANG.sys.database_principals;


CREATE VIEW login_role
AS
SELECT  
 u.name as userid , l.loginname, role.name as rolename
FROM 
	sys.syslogins l 
INNER JOIN sys.sysusers u 
        ON u.sid = l.sid 
INNER JOIN sys.sysmembers m
		ON u.uid = m.memberuid
INNER JOIN NGANHANG.sys.database_principals role
		ON role.principal_id = m.groupuid;


-- Query this view 
-- SELECT * FROM login_role;