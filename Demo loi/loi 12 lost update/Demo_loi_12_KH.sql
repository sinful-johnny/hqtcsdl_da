--Demo lỗi--------------------------------------

--Phải đăng nhập bằng tài khoản khách hàng trước khi demo lỗi
declare @hoten nvarchar(30),
	@ngaysinh date,
	@email varchar(30)

set @hoten = 'dude'
--set @email = 'dude@website.com'
set @ngaysinh = NULL

exec sp_KH_SuaTTCaNhan @hoten, @ngaysinh, @email

select * from V_KH_TTCANHAN