use QL_NHAKHOA
go

exec sp_ThemTK 'kyle', '0919547701', '2003/11/28', 'ha@gmail.com', '123', 'QTV'
go
declare @idtaikhoan varchar(255)
set @idtaikhoan = (	select ID_TAIKHOAN
					from TAI_KHOAN
					where HOTEN = 'kyle'
						and SDT = '0919547701')

EXEC sp_addrolemember 'QUAN_TRI_VIEN', @idtaikhoan
EXEC sp_addrolemember N'db_owner', @idtaikhoan

ALTER SERVER ROLE [##MS_LoginManager##] ADD MEMBER [0919547701]
GO