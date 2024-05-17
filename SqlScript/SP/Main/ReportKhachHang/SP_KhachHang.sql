CREATE TABLE #temp_kh (
	[CMND] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[PHAI] [nvarchar](3) NULL,
	[NGAYCAP] [date] NOT NULL,
	[SODT] [nvarchar](15) NOT NULL,
	[MACN] [nchar](10) NULL,
);


DECLARE @cmd AS NCHAR(4000),
  @job_name AS NVARCHAR(100) = N'Job_1',
  @custome_parameter AS CHAR(100),
  @custome_number AS INT
SET @cmd  = 'INSERT INTO #temp_kh SELECT CMND, HO, TEN,DIACHI, PHAI,NGAYCAP,SODT ,MACN FROM  LINK1.NGANHANG.dbo.KhachHang ';

IF (NOT EXISTS (SELECT job_id FROM msdb.dbo.sysjobs_view WHERE name  = @job_name))
BEGIN 
EXECUTE msdb.dbo.sp_add_job @job_name = @job_name,  @start_step_id = 1
EXECUTE msdb.dbo.sp_add_jobserver @job_name = @job_name,  @server_name = @@SERVERNAME
EXECUTE msdb.dbo.sp_add_jobstep @job_name = @job_name,  @step_id = 1, @step_name = 'Update s1', @command = @cmd, @server = @@SERVERNAME, @database_name = 'NGANHANG'
END 
  --EXEC msdb.dbo.sp_delete_job @job_name = @job_name;
EXECUTE msdb.dbo.sp_start_job @job_name = @job_name

INSERT INTO #temp_kh SELECT CMND, HO, TEN,DIACHI, PHAI,NGAYCAP,SODT ,MACN FROM  NGANHANG.dbo.KhachHang 
/*
while exists (SELECT * FROM msdb.dbo.sysjobactivity WHERE job_id =
(SELECT job_id FROM msdb.dbo.sysjobs WHERE name = @job_name) 
AND start_execution_date is not null and stop_execution_date is null
)  
begin
    WAITFOR DELAY '00:00:01';   
end
*/
WAITFOR DELAY '00:00:01';   

SELECT * FROM #temp_kh ORDER BY MACN, HO , TEN 
