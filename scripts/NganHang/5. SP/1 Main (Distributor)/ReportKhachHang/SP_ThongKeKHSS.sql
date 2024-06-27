
USE NGANHANG
GO 
CREATE OR ALTER PROCEDURE SP_ThongKeKHSS
AS 
BEGIN
DROP TABLE IF EXISTS  ##temp
CREATE   TABLE ##temp 
(
CMND NCHAR(10), 
HO NVARCHAR(50),
TEN NVARCHAR(10),
DIACHI NVARCHAR(100),
PHAI NVARCHAR(3),
NGAYCAP DATE,
SODT NVARCHAR(15),
MACN NVARCHAR(10)
)
DECLARE @cmd AS NCHAR(4000),
  @job_name AS NVARCHAR(100) = N'Job_1',
  @custome_parameter AS CHAR(100),
  @custome_number AS INT

SET @cmd  = 'INSERT INTO ##temp EXEC SP_ThongKeKhachHang';

IF (EXISTS (SELECT job_id FROM msdb.dbo.sysjobs_view WHERE name  = @job_name))
EXEC msdb.dbo.sp_delete_job @job_name = @job_name;
EXECUTE msdb.dbo.sp_add_job @job_name = @job_name,  @start_step_id = 1
EXECUTE msdb.dbo.sp_add_jobserver @job_name = @job_name,  @server_name = @@SERVERNAME
EXECUTE msdb.dbo.sp_add_jobstep @job_name = @job_name,  @step_id = 1, @step_name = 'Update s1', @command = @cmd, @server = @@SERVERNAME, @database_name = 'NGANHANG'
EXECUTE msdb.dbo.sp_start_job @job_name = @job_name


INSERT INTO ##temp EXEC LINK1.NGANHANG.dbo.SP_ThongKeKhachHang

while (select count(*) from msdb.dbo.sysjobs_view job
         inner join msdb.dbo.sysjobactivity activity
         on (job.job_id = activity.job_id)
         where run_Requested_date is not null 
         and stop_execution_date is null
         and job.name   = @job_name)> 0
		 BEGIN 
		   WAITFOR DELAY '0:0:0.01'

		 END 
 
SELECT * FROM ##temp -- ORDER BY MACN, HO, TEN
END
GO 
EXEC SP_ThongKeKHSS
