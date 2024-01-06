use QL_NHAKHOA
go

--Sửa thông tin tài khoản quản trị viên
declare @idtaikhoan VARCHAR(255),
		@tentaikhoan NVARCHAR(30) = NULL,
		@ngaysinh DATE = NULL,
		@email VARCHAR(30) = NULL,
		@loaitaikhoan varchar(20) = NULL

select top 1 @idtaikhoan = ID_TAIKHOAN
from TAI_KHOAN
where SDT = '0666777888'

set @tentaikhoan = 'test KH updated by QTV'
set @ngaysinh = '2022-1-9'
set @email = 'updatehaha@gmail.com'


exec sp_CAPNHAT_TAIKHOAN_NGUOIDUNG @idtaikhoan,@tentaikhoan,@ngaysinh,@email,@loaitaikhoan
select * from TAI_KHOAN where SDT ='0666777888'