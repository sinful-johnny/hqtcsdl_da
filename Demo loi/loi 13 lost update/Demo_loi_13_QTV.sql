declare @idtaikhoan VARCHAR(255),
	@tentaikhoan NVARCHAR(30) = NULL,
	@ngaysinh DATE = NULL,
	@email VARCHAR(30) = NULL,
	@loaitaikhoan varchar(20) = NULL

select @idtaikhoan = ID_TAIKHOAN
from TAI_KHOAN
where SDT = '0911122334'

set @ngaysinh = '2022-1-1'
set @email = 'sieudeptrai@game.com'

exec sp_CAPNHAT_TAIKHOAN_NGUOIDUNG @idtaikhoan, @tentaikhoan, @ngaysinh, @email, @loaitaikhoan
