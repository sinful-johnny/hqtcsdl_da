--Demo lỗi---------------------------------------------------
declare @idtaikhoan VARCHAR(255),
	@tentaikhoan NVARCHAR(30) = NULL,
	@ngaysinh DATE = NULL,
	@email VARCHAR(30) = NULL,
	@loaitaikhoan varchar(20) = NULL

select @idtaikhoan = ID_TAIKHOAN
from TAI_KHOAN
where SDT = '0369842157'
set @tentaikhoan = 'guy'
set @ngaysinh = '2022-1-1'
set @email = 'sieudeptrai@game.com'

exec sp_CAPNHAT_TAIKHOAN_NGUOIDUNG @idtaikhoan, @tentaikhoan, @ngaysinh, @email, @loaitaikhoan
go
select * from TAI_KHOAN where SDT = '0369842157'

SELECT CASE transaction_isolation_level 
    WHEN 0 THEN 'Unspecified' 
    WHEN 1 THEN 'ReadUncommitted' 
    WHEN 2 THEN 'ReadCommitted' 
    WHEN 3 THEN 'Repeatable' 
    WHEN 4 THEN 'Serializable' 
    WHEN 5 THEN 'Snapshot' END AS TRANSACTION_ISOLATION_LEVEL 
FROM sys.dm_exec_sessions 
where session_id = @@SPID