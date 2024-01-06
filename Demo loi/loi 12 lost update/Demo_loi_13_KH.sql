--Code Proc bị lỗi
alter proc sp_KH_SuaTTCaNhan
	@hoten nvarchar(30),
	@ngaysinh date,
	@email varchar(30)
as
	begin tran
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		if	@hoten is null
		begin
			select @hoten = HOTEN
			from V_KH_TTCANHAN
			where ID_TAIKHOAN = CURRENT_USER
		end

		if	@ngaysinh is null
		begin
			select @ngaysinh = NGAYSINH
			from V_KH_TTCANHAN
			where ID_TAIKHOAN = CURRENT_USER
		end

		if	@email is null
		begin
			select @email = EMAIL
			from V_KH_TTCANHAN
			where ID_TAIKHOAN = CURRENT_USER
		end
		WAITFOR DELAY '00:00:10'
		update V_KH_TTCANHAN
		set HOTEN = @hoten, NGAYSINH = @ngaysinh, EMAIL = @email
		where ID_TAIKHOAN = CURRENT_USER
	commit tran
go

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