use QL_NHAKHOA
go
declare @idtaikhoan VARCHAR(255),
	@tentaikhoan NVARCHAR(30) = NULL,
	@ngaysinh DATE = NULL,
	@email VARCHAR(30) = NULL,
	@loaitaikhoan varchar(20) = NULL

select top 1 @idtaikhoan = ID_TAIKHOAN
from TAI_KHOAN
where SDT = '09123456789'

set @tentaikhoan = 'test NS updated by QTV'
set @ngaysinh = '2022-1-1'
set @email = 'update@gmail.com'


exec sp_CAPNHAT_TAIKHOAN_NGUOIDUNG @idtaikhoan,@tentaikhoan,@ngaysinh,@email,@loaitaikhoan
select * from TAI_KHOAN where SDT ='09123456789' 
--exec sp_THEM_TAIKHOAN_NGUOIDUNG 'test NS', '03626', '2003-1-1','test@gmail.com','123','NS'