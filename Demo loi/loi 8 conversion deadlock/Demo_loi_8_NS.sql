
declare @tentaikhoan NVARCHAR(30) = NULL,
	@ngaysinh DATE = NULL,
	@email VARCHAR(30) = NULL

set @tentaikhoan = 'test NS updated by NS'
set @ngaysinh = '2022-1-1'
set @email = 'update@gmail.com'

exec SP_NS_SUA_TTCANHAN @tentaikhoan,@ngaysinh,@email



