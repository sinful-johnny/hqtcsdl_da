﻿use QL_NHAKHOA
exec sp_addrole 'KHACHHANG'
go

create or alter view V_KH_TTCANHAN
as
	select *
	from TAI_KHOAN as TK
	where TK.ID_TAIKHOAN = CURRENT_USER
go

create or alter view V_KH_LICHDATKHAM
as
	select *
	from LICH_DAT_KHAM as LDK
	where	LDK.ID_KH = CURRENT_USER
go

create or alter view V_KH_LICHNHASI
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

create or alter view V_KH_BENHAN
as
	select *
	from BENH_AN
	where	ID_KH = CURRENT_USER
go

create or alter view V_KH_XEMDV
as
	select *
	from LOAI_DV
go

create or alter view V_KH_XEMDVSD
as
	select ID_DVSD,ID_LOAIDV, THANHTIEN, ID_HOADON, DICHVU_SD.ID_BA
	from DICHVU_SD , BENH_AN 
	where DICHVU_SD.ID_BA = BENH_AN.ID_BA
			and BENH_AN.ID_KH = CURRENT_USER
go

create or alter view V_KH_XEMTHUOC
as
	select ID_THUOC, TENTHUOC, CHIDINH, GIATIEN
	from THUOC
go

create or alter view V_KH_XEMDONTHUOC
as
	select ID_DONTHUOC, THANHTIEN, ID_HOADON, DON_THUOC.ID_BA
	from DON_THUOC, BENH_AN
	where	BENH_AN.ID_KH = CURRENT_USER
			and BENH_AN.ID_BA = DON_THUOC.ID_BA
go

create or alter view V_KH_THUOCSD
as
	select	ID_THUOC, SOLUONG, THUOC_SD.ID_DONTHUOC
	from THUOC_SD, DON_THUOC, BENH_AN
	where	BENH_AN.ID_KH = CURRENT_USER
			and BENH_AN.ID_BA = DON_THUOC.ID_BA
			and DON_THUOC.ID_DONTHUOC = DON_THUOC.ID_DONTHUOC
go

grant select,update on V_KH_TTCANHAN to KHACHHANG
grant select on V_KH_LICHNHASI to KHACHHANG
grant select on V_TTNHASI to KHACHHANG
grant select on V_KH_BENHAN to KHACHHANG
grant select, insert, update on V_KH_LICHDATKHAM to KHACHHANG
grant select on V_KH_XEMDV to KHACHHANG
grant select on V_KH_XEMDVSD to KHACHHANG
grant select on V_KH_XEMTHUOC to KHACHHANG
grant select on V_KH_XEMDONTHUOC to KHACHHANG
grant select on V_KH_THUOCSD to KHACHHANG
go

use QL_NHAKHOA
go
create or alter proc sp_ThemTK
		@loaitk nvarchar(20),
		@sdt varchar(11),
		@matkhau varchar(30)
as
		exec sp_addlogin @sdt, @matkhau, 'QL_NHAKHOA'
		declare @idtk varchar(255)
		select @idtk = cast(NEWID() as varchar(255))
		insert V_KH_TTCANHAN(ID_TAIKHOAN,LOAITK,SDT,MATKHAU) values (@idtk,@loaitk,@sdt,@matkhau)
		--create user [@idtk] for login [@sdt]
		declare @cmd varchar(200), @username varchar(50)

		set @cmd = ' 
		   USE QL_NHAKHOA
		   CREATE USER [' + @idtk + '] FOR LOGIN '+ '[' + @sdt + ']'
		PRINT @cmd
		EXEC (@cmd)
		exec sp_addrolemember 'KHACHHANG', @idtk
go

create or alter proc sp_KH_XemLichKham 
as
	select *
	from V_KH_LICHDATKHAM
go
grant EXECUTE ON OBJECT::sp_KH_XemLichKham
    TO KHACHHANG;  
GO

create or alter proc sp_KH_XemLichNS
as
	select *
	from V_KH_LICHNHASI
go
grant EXECUTE ON OBJECT::sp_KH_XemLichNS
    TO KHACHHANG;  
GO

create or alter proc sp_KH_XemBenhAn
as
	select *
	from V_KH_BENHAN
go
grant EXECUTE ON OBJECT::sp_KH_XemBenhAn
    TO KHACHHANG;  
GO

create or alter proc sp_KH_XemDonThuoc
	@maBenhAn varchar(255)
as
	select *
	from V_KH_XEMDONTHUOC
	where ID_BA = @maBenhAn
go
grant EXECUTE ON OBJECT::sp_KH_XemDonThuoc
    TO KHACHHANG;  
GO

create or alter proc sp_KH_XemThuocSD
	@madonthuoc varchar(255)
as
	select *
	from V_KH_THUOCSD
	where ID_DONTHUOC = @madonthuoc
go
grant EXECUTE ON OBJECT::sp_KH_XemThuocSD
    TO KHACHHANG;  
GO

create or alter proc sp_KH_XemDVSD
	@maBenhAn varchar(255)
as
	select *
	from V_KH_XEMDVSD
	where	ID_BA = @maBenhAn
go
grant EXECUTE ON OBJECT::sp_KH_XemDVSD
    TO KHACHHANG;  
GO

create or alter proc sp_KH_XemChiTietDV
	@maDVSD varchar(255)
as
	select *
	from LOAI_DV as LDV inner join DICHVU_SD as DVSD on LDV.ID_LOAIDV = DVSD.ID_LOAIDV
	where DVSD.ID_DVSD = @maDVSD
go
grant EXECUTE ON OBJECT::sp_KH_XemChiTietDV
    TO KHACHHANG;  
GO


create or alter proc sp_KH_ThemLichDatKham
	@id_llv varchar(255)
as
	begin tran
		if	exists	(
						select *
						from V_KH_LICHNHASI as LNS
						where LNS.ID_LLV = @id_llv
								and LNS.TRANGTHAI != N'Trống'
					)
		begin
			;throw 50000, 'Lịch làm việc đã được đặt', 1
			rollback tran
		end

		insert V_KH_LICHDATKHAM(ID_KH,ID_LLV)
		values (CURRENT_USER, @id_llv)

	commit tran
go
grant EXECUTE ON OBJECT::sp_KH_ThemLichDatKham 
    TO KHACHHANG;  
GO


create or alter proc sp_KH_SuaTTCaNhan
	@hoten nvarchar(30),
	@ngaysinh date,
	@email varchar(30)
as
	begin tran
		if	@hoten is null
		begin
			select @hoten = HOTEN
			from V_KH_TTCANHAN
			where ID_TAIKHOAN = CURRENT_USER
		end

		if	@ngaysinh is null
		begin
			select @ngaysinh = NGAYSINH
			from V_KH_TTCANHAN
			where ID_TAIKHOAN = CURRENT_USER
		end

		if	@email is null
		begin
			select @email = EMAIL
			from V_KH_TTCANHAN
			where ID_TAIKHOAN = CURRENT_USER
		end

		update V_KH_TTCANHAN
		set HOTEN = @hoten, NGAYSINH = @ngaysinh, EMAIL = @email
		where ID_TAIKHOAN = CURRENT_USER
	commit tran
go
grant EXECUTE ON OBJECT::sp_KH_SuaTTCaNhan 
    TO KHACHHANG;  
GO


create or alter proc sp_KH_XemTTCaNhan
as
	begin tran
		select *
		from V_KH_TTCANHAN
	commit tran
go
grant EXECUTE ON OBJECT::sp_KH_XemTTCaNhan 
    TO KHACHHANG;  
GO


