--Demo lỗi--------------------------------------

--Phải đăng nhập bằng tài khoản khách hàng trước khi demo lỗi
declare @hoten nvarchar(30),
	@ngaysinh date,
	@email varchar(30)

set @hoten = 'dude'
set @email = 'dude@website.com'
set @ngaysinh = '2003-1-1'

exec sp_KH_SuaTTCaNhan @hoten, @ngaysinh, @email

select * from V_KH_TTCANHAN

SELECT CASE transaction_isolation_level 
    WHEN 0 THEN 'Unspecified' 
    WHEN 1 THEN 'ReadUncommitted' 
    WHEN 2 THEN 'ReadCommitted' 
    WHEN 3 THEN 'Repeatable' 
    WHEN 4 THEN 'Serializable' 
    WHEN 5 THEN 'Snapshot' END AS TRANSACTION_ISOLATION_LEVEL 
FROM sys.dm_exec_sessions 
where session_id = @@SPID