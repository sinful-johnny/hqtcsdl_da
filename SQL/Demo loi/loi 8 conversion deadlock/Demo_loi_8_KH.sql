use QL_NHAKHOA
go

--Sửa thông tin cá nhân khách hàng

declare @hoten NVARCHAR(30) = NULL,
		@ngaysinh DATE = NULL,
		@email VARCHAR(30) = NULL

set @hoten = 'test NS updated by NS'
set @ngaysinh = '2022-1-1'
set @email = 'update@gmail.com'

exec sp_KH_SuaTTCaNhan @hoten,@ngaysinh,@email
