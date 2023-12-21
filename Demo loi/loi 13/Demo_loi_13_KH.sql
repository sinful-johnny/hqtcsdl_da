declare @hoten nvarchar(30),
	@ngaysinh date,
	@email varchar(30)

set @hoten = 'dude'
set @email = 'dude@website.com'
set @ngaysinh = '2003-1-1'

SET TRANSACTION ISOLATION LEVEL READ COMMITTED
exec sp_KH_SuaTTCaNhan @hoten, @ngaysinh, @email