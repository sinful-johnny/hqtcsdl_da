SET DATEFORMAT DMY
DECLARE @ERROR nvarchar(500)
EXEC  sp_THEM_TAIKHOAN_NGUOIDUNG N'Nguyễn Gia Khánh', '03465', '28/11/2003', 'ahihi', 'ahihidongock', 'KH', @error output
GO

SET DATEFORMAT DMY
DECLARE @ERROR nvarchar(500)
EXEC sp_CAPNHAT_TAIKHOAN_NGUOIDUNG 'EE480A91-A121-48AC-BA40-97DE9845F8EB', 'BAKA', '24/09/2010', 'FHK', 'NS', @ERROR
GO

EXEC sp_KHOA_TAIKHOAN_NGUOIDUNG 'EE480A91-A121-48AC-BA40-97DE9845F8EB'

-- THÊM THÔNG TIN THUỐC
set DATEFORMAT dmy

declare @error nvarchar(500)

exec sp_THEM_TT_THUOC
	N'Thuốc đau bụng',
	N'Uống ngay sau khi bị đau bụng',
	'19/5/2029',
	'1000',
	'10',
	@error output
go

--XÓA THÔNG TIN THUỐC

declare @error nvarchar(500)
exec sp_XOA_TT_THUOC
	'88969C63-E456-4E97-8D58-003753076BD0',
	@error output
GO

--CẬP NHẬT THÔNG TIN THUỐC
set DATEFORMAT dmy
declare @error nvarchar(500)
exec sp_CAPNHAT_TT_THUOC
	'88969C63-E456-4E97-8D58-003753076BD0',
	N'thuốc đau dạ dày',
	N'uống sau khi bị đau dạ dày',
	'19/5/2025',
	'1900',
	'100',
	@error output
GO