USE QL_NHAKHOA
GO

--sp_cập nhật thông tin tài khoản Quản trị viên

declare @idtaikhoan VARCHAR(255),
		@hoten NVARCHAR(30) = NULL,
		@ngaysinh DATE = NULL,
		@email VARCHAR(30) = NULL,
		@loaitaikhoan NVARCHAR(20) = NULL

set @idtaikhoan = '1D613AB7-B3B0-4AE4-8B5C-251E46D734D6'
set @ngaysinh = '2001/1/24'
set @email = 'blabla@gmail.com'
set @loaitaikhoan = 'KH'
--set @ngaysinh = '2003/11/28'
--set @email = 'haha@gmail.com'
--set @loaitaikhoan = 'NV'

exec sp_CAPNHAT_TAIKHOAN_NGUOIDUNG	@idtaikhoan, 
									@hoten, 
									@ngaysinh,
									@email,
									@loaitaikhoan
GO
