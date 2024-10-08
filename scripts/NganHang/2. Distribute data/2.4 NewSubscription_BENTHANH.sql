-----------------BEGIN: Script to be run at Publisher 'TM\NGANHANG'-----------------
-- NOTE: what require to make this script work for other use case
-- Change publication_name NGANHANG_BENTHANH, and servername=TM\NGANHANG2
-- Change login='sa' and password='kc'
-- After run script got to replication > local publication -> Right click NGANHANG_BENTHANH -> View snapshot agent -> Start

use [NGANHANG]
exec sp_addmergesubscription @publication = N'NGANHANG_BENTHANH', @subscriber = N'TM\NGANHANG1', @subscriber_db = N'NGANHANG', @subscription_type = N'Push', @sync_type = N'Automatic', @subscriber_type = N'Global', @subscription_priority = 75, @description = null, @use_interactive_resolver = N'False'
exec sp_addmergepushsubscription_agent @publication = N'NGANHANG_BENTHANH', @subscriber = N'TM\NGANHANG1', @subscriber_db = N'NGANHANG', @job_login = null, @job_password = null, @subscriber_security_mode = 0, @subscriber_login = N'sa', @subscriber_password = N'kc', @publisher_security_mode = 1, @frequency_type = 64, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 20240222, @active_end_date = 99991231, @enabled_for_syncmgr = N'False'
GO
-----------------END: Script to be run at Publisher 'TM\NGANHANG'-----------------

