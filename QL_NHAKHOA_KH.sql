use QL_NHAKHOA
exec sp_addrole 'KHACHHANG'
go

create or alter view V_TTCANHAN
as
	select *
	from TAI_KHOAN as TK
	where TK.ID_TAIKHOAN = CURRENT_USER
go

create or alter view V_LICHDATKHAM
as
	select *
	from LICH_DAT_KHAM as LDK
	where	LDK.ID_KH = CURRENT_USER
go

create or alter view V_LICHNHASI
as
	select *
	from LICH_LAM_VIEC
go

create or alter view V_TTNHASI
as
	select HOTEN, SDT, EMAIL, ID_TAIKHOAN
	from TAI_KHOAN,BENH_AN
	where LOAITK = 'NS'
go

create or alter view V_BENHAN
as
	select *
	from BENH_AN
	where	ID_KH = CURRENT_USER
go

create or alter view V_XEMDV
as
	select *
	from LOAI_DV
go

create or alter view V_XEMDVSD
as
	select ID_DVSD,ID_LOAIDV, THANHTIEN, ID_HOADON, DICHVU_SD.ID_BA
	from DICHVU_SD , BENH_AN 
	where DICHVU_SD.ID_BA = BENH_AN.ID_BA
			and BENH_AN.ID_KH = CURRENT_USER
go

create or alter view V_XEMTHUOC
as
	select ID_THUOC, TENTHUOC, CHIDINH, GIATIEN
	from THUOC
go

create or alter view V_XEMDONTHUOC
as
	select ID_DONTHUOC, THANHTIEN, ID_HOADON, DON_THUOC.ID_BA
	from DON_THUOC, BENH_AN
	where	BENH_AN.ID_KH = CURRENT_USER
			and BENH_AN.ID_BA = DON_THUOC.ID_BA
go

create or alter view V_THUOCSD
as
	select	ID_THUOC, SOLUONG, THUOC_SD.ID_DONTHUOC
	from THUOC_SD, DON_THUOC, BENH_AN
	where	BENH_AN.ID_KH = CURRENT_USER
			and BENH_AN.ID_BA = DON_THUOC.ID_BA
			and DON_THUOC.ID_DONTHUOC = DON_THUOC.ID_DONTHUOC
go

grant select,update on V_TTCANHAN to KHACHHANG
grant select on V_LICHNHASI to KHACHHANG
grant select on V_TTNHASI to KHACHHANG
grant select on V_BENHAN to KHACHHANG
grant select, insert, update on V_LICHDATKHAM to KHACHHANG
grant select on V_XEMDV to KHACHHANG
grant select on V_XEMDVSD to KHACHHANG
grant select on V_XEMTHUOC to KHACHHANG
grant select on V_XEMDONTHUOC to KHACHHANG
grant select on V_THUOCSD to KHACHHANG
go

use QL_NHAKHOA
go
create or alter proc sp_ThemTK_KH
		@loaitk nvarchar(20),
		@sdt varchar(11),
		@matkhau varchar(30)
as
		begin tran
		exec sp_addlogin @sdt, @matkhau, 'QL_NHAKHOA'
		declare @idtk varchar(255)
		select @idtk = cast(NEWID() as varchar(255))
		insert V_TTCANHAN(ID_TAIKHOAN,LOAITK,SDT,MATKHAU) values (@idtk,@loaitk,@sdt,@matkhau)
		--create user [@idtk] for login [@sdt]
		declare @cmd varchar(200), @username varchar(50)

		set @cmd = ' 
		   USE QL_NHAKHOA
		   CREATE USER [' + @idtk + '] FOR LOGIN '+ '[' + @sdt + ']'
		PRINT @cmd
		EXEC (@cmd)
		exec sp_addrolemember 'KHACHHANG', @idtk
	commit tran
go

create or alter proc sp_XemLichKham 
as
	select *
	from V_LICHDATKHAM
go

create or alter proc sp_XemLichNS
as
	select *
	from V_LICHNHASI
go

create or alter proc sp_XemBenhAn
as
	select *
	from V_BENHAN
go

create or alter proc sp_XemDonThuoc
	@mabenhan varchar(255)
as
	select *
	from V_XEMDONTHUOC
	where ID_BA = @mabenhan
go

create or alter proc sp_XemThuocSD
	@madonthuoc varchar(255)
as
	select *
	from V_THUOCSD
	where ID_DONTHUOC = @madonthuoc
go

create or alter proc sp_XemDVSD
	@mabenhan varchar(255)
as
	select *
	from V_XEMDVSD
	where	ID_BA = @mabenhan
go


