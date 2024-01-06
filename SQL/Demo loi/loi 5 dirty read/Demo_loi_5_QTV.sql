use QL_NHAKHOA
go

declare @idtaikhoan VARCHAR(255),
	@tentaikhoan NVARCHAR(30) = NULL,
	@ngaysinh DATE = NULL,
	@email VARCHAR(30) = NULL,
	@loaitaikhoan varchar(20) = NULL

select	@idtaikhoan = ID_TAIKHOAN
from TAI_KHOAN
where SDT = '0777888999'

set @tentaikhoan = 'lemao'
set @ngaysinh = '12/12/2025'
set @email = 'lemaobruh@gmail.com'


exec sp_CAPNHAT_TAIKHOAN_NGUOIDUNG @idtaikhoan, @tentaikhoan, @ngaysinh, @email, @loaitaikhoan
go

select	*
from TAI_KHOAN
where SDT = '0777888999'