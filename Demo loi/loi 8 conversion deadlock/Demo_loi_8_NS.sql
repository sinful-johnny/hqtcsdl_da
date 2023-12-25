use QL_NHAKHOA
go

declare @tentaikhoan NVARCHAR(30) = NULL,
	@ngaysinh DATE = NULL,
	@email VARCHAR(30) = NULL

set @tentaikhoan = 'test NS updated by NS'

exec SP_NS_SUA_TTCANHAN @tentaikhoan,@ngaysinh,@email
