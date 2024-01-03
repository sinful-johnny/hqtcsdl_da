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
grant select on V_KH_TTNHASI to KHACHHANG
grant select on V_KH_BENHAN to KHACHHANG
grant select, insert, update on V_KH_LICHDATKHAM to KHACHHANG
grant select on V_KH_XEMDV to KHACHHANG
grant select on V_KH_XEMDVSD to KHACHHANG
grant select on V_KH_XEMTHUOC to KHACHHANG
grant select on V_KH_THUOCSD to KHACHHANG
go


