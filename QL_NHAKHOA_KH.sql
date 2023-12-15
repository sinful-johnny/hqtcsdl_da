use QL_NHAKHOA
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

create or alter view V_KH_TTNHASI
as
	select HOTEN, SDT, EMAIL, ID_TAIKHOAN
	from TAI_KHOAN
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

create or alter view V_KH_THUOCSD
as
	select	ID_THUOC, SOLUONG, THUOC_SD.ID_BA
	from THUOC_SD, BENH_AN
	where	BENH_AN.ID_KH = CURRENT_USER
			and BENH_AN.ID_BA = THUOC_SD.ID_BA
go

grant select,update on V_KH_TTCANHAN to KHACHHANG
grant select on V_KH_LICHNHASI to KHACHHANG
grant select on V_TTNHASI to KHACHHANG
grant select on V_KH_BENHAN to KHACHHANG
grant select, insert, update on V_KH_LICHDATKHAM to KHACHHANG
grant select on V_KH_XEMDV to KHACHHANG
grant select on V_KH_XEMDVSD to KHACHHANG
grant select on V_KH_XEMTHUOC to KHACHHANG
grant select on V_KH_THUOCSD to KHACHHANG
go

use QL_NHAKHOA
go
create proc sp_ThemTK
		@hoten nvarchar(30),
		@sdt varchar(11),
		@ngaysinh date,
		@email varchar(30),
		@matkhau varchar(30),
		@loaitk nvarchar(20)
as
		exec sp_addlogin @sdt, @matkhau, 'QL_NHAKHOA'
		declare @idtk varchar(255)
		select @idtk = cast(NEWID() as varchar(255))
		insert V_KH_TTCANHAN(ID_TAIKHOAN,HOTEN,SDT,NGAYSINH,EMAIL,MATKHAU,LOAITK) values (@idtk,@hoten,@sdt,@ngaysinh,@email,@matkhau,@loaitk)
		--create user [@idtk] for login [@sdt]
		declare @cmd varchar(200), @username varchar(50)

		set @cmd = ' 
		   USE QL_NHAKHOA
		   CREATE USER [' + @idtk + '] FOR LOGIN '+ '[' + @sdt + ']'
		PRINT @cmd
		EXEC (@cmd)
		exec sp_addrolemember 'KHACHHANG', @idtk
go

alter proc sp_KH_XemLichKham 
as
	select LNS.*
	from V_KH_LICHNHASI as LNS
			inner join V_KH_LICHDATKHAM as LDK on LNS.ID_LLV = LDK.ID_LLV
	where LDK.ID_KH = CURRENT_USER
go
grant EXECUTE ON OBJECT::sp_KH_XemLichKham
    TO KHACHHANG;  
GO

create proc sp_KH_XemLichNS
as
	select *
	from V_KH_LICHNHASI
	where TRANGTHAI = N'Trống'
go
grant EXECUTE ON OBJECT::sp_KH_XemLichNS
    TO KHACHHANG;  
GO

create proc sp_KH_XemBenhAn
as
	select *
	from V_KH_BENHAN
go
grant EXECUTE ON OBJECT::sp_KH_XemBenhAn
    TO KHACHHANG;  
GO

create proc sp_KH_XemThuocSD
	@idBenhAn varchar(255)
as
	select *
	from V_KH_THUOCSD
	where ID_BA = @idBenhAn
go

grant EXECUTE ON OBJECT::sp_KH_XemThuocSD
    TO KHACHHANG;  
GO

create proc sp_KH_XemDVSD
	@maBenhAn varchar(255)
as
	select *
	from V_KH_XEMDVSD
	where	ID_BA = @maBenhAn
go
grant EXECUTE ON OBJECT::sp_KH_XemDVSD
    TO KHACHHANG;  
GO

create proc sp_KH_XemChiTietDV
	@maLoaiDV varchar(255)
as
	select *
	from V_KH_XEMDV as LDV
	where LDV.ID_LOAIDV = @maLoaiDV
go
grant EXECUTE ON OBJECT::sp_KH_XemChiTietDV
    TO KHACHHANG;  
GO

create proc sp_KH_XemChiTietThuoc
	@idThuoc varchar(255)
as
	select *
	from V_KH_XEMTHUOC as XT
	where	XT.ID_THUOC = @idThuoc
go
grant EXECUTE ON OBJECT::sp_KH_XemChiTietThuoc
    TO KHACHHANG;  
GO

alter proc sp_KH_ThemLichDatKham
	@id_ns varchar(255),
	@ngaykham datetime,
	@giokham time(7)
as
	begin tran
		declare @id_llv varchar(255)

		select @id_llv = ID_LLV
		from LICH_LAM_VIEC
		where	ID_NS = @id_ns
				and NGAYKHAM = @ngaykham
				and GIOKHAM = @giokham

		insert V_KH_LICHDATKHAM(ID_KH,ID_LLV)
		values (CURRENT_USER, @id_llv)

	commit tran
go
grant EXECUTE ON OBJECT::sp_KH_ThemLichDatKham 
    TO KHACHHANG;  
GO

create proc sp_KH_SuaTTCaNhan
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


create proc sp_KH_XemTTCaNhan
as
	begin tran
		select *
		from V_KH_TTCANHAN
		where ID_TAIKHOAN = CURRENT_USER
	commit tran
go
grant EXECUTE ON OBJECT::sp_KH_XemTTCaNhan 
    TO KHACHHANG;  
GO

create proc sp_KH_XemDSThuoc
as
	select *
	from V_KH_XEMTHUOC
go
grant EXECUTE ON OBJECT::sp_KH_XemDSThuoc 
    TO KHACHHANG;  
GO

create proc sp_KH_XemDSDichVu
as
	select *
	from V_KH_XEMDV
go
grant EXECUTE ON OBJECT::sp_KH_XemDSDichVu
    TO KHACHHANG;  
GO

create proc sp_KH_HoTenNSConSlot
as
	select TTNS.HOTEN as HOTEN, TTNS.ID_TAIKHOAN as ID_TAIKHOAN
	from V_KH_TTNHASI as TTNS
			inner join V_KH_LICHNHASI as LNS on TTNS.ID_TAIKHOAN = LNS.ID_NS
go
grant EXECUTE ON OBJECT::sp_KH_HoTenNSConSlot
    TO KHACHHANG;
GO

create proc sp_KH_XemLLVcuaNS 
	@idns varchar(255)
as
	select *
	from V_KH_LICHNHASI
	where ID_NS = @idns
go
grant EXECUTE ON OBJECT::sp_KH_XemLLVcuaNS 
    TO KHACHHANG;
GO

use master
exec sp_addlogin 'CHUNG', '', 'QL_NHAKHOA'
go
GRANT ALTER ANY LOGIN TO CHUNG
go
USE QL_NHAKHOA CREATE USER [CHUNG] FOR LOGIN [CHUNG]
go
--exec sp_addrolemember 'db_accessadmin', 'CHUNG'
--go
GRANT SELECT,INSERT,UPDATE,DELETE ON TAI_KHOAN TO CHUNG
go
GRANT ALTER ANY USER TO CHUNG
GRANT ALTER ON role::[KHACHHANG] TO [CHUNG]
go
create proc sp_DangKyTaiKhoan 
	@hoten nvarchar(30),
	@sdt varchar(11),
	@ngaysinh date,
	@email varchar(30),
	@matkhau varchar(30)
as
		exec sp_addlogin @sdt, @matkhau, 'QL_NHAKHOA'
		declare @idtk varchar(255)
		select @idtk = cast(NEWID() as varchar(255))
		insert V_KH_TTCANHAN(ID_TAIKHOAN,HOTEN,SDT,NGAYSINH,EMAIL,MATKHAU,LOAITK) values (@idtk,@hoten,@sdt,@ngaysinh,@email,@matkhau,'KH')
		--create user [@idtk] for login [@sdt]
		declare @cmd varchar(200), @username varchar(50)

		set @cmd = ' 
		   USE QL_NHAKHOA
		   CREATE USER [' + @idtk + '] FOR LOGIN '+ '[' + @sdt + ']'
		PRINT @cmd
		EXEC (@cmd)
		exec sp_addrolemember 'KHACHHANG', @idtk
go
grant EXECUTE ON OBJECT::sp_DangKyTaiKhoan 
    TO CHUNG;
GO


