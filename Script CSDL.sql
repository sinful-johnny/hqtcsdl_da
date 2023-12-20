﻿USE MASTER
GO

IF DB_ID('QL_NHAKHOA') IS NOT NULL --KTR CSDL QLLOPHOC TỒN TẠI CHƯA
	DROP DATABASE QL_NHAKHOA --XÓA CSDL
	GO
CREATE DATABASE QL_NHAKHOA --TẠO CSDL
GO

USE QL_NHAKHOA
GO

CREATE TABLE TAI_KHOAN(
	ID_TAIKHOAN VARCHAR(255) NOT NULL,
	HOTEN NVARCHAR(30),
	SDT CHAR(11) UNIQUE,
	NGAYSINH DATE,
	EMAIL VARCHAR(30),
	MATKHAU VARCHAR(30),
	LOAITK NVARCHAR(20),
	ID_QTV VARCHAR(255),
	CONSTRAINT pk_TAI_KHOAN PRIMARY KEY(ID_TAIKHOAN),
)
GO

CREATE TABLE THUOC_SD(
	ID_BA VARCHAR(255) NOT NULL,
	ID_THUOC VARCHAR(255) NOT NULL,
	SOLUONG INT,
	CONSTRAINT pk_THUOC_SD PRIMARY KEY(ID_BA,ID_THUOC),
)
GO

CREATE TABLE THUOC(
	ID_THUOC VARCHAR(255) NOT NULL,
	TENTHUOC NVARCHAR(30),
	CHIDINH NVARCHAR(100),
	NGAYHETHAN DATE,
	GIATIEN MONEY,
	ID_QTV VARCHAR(255),
	CONSTRAINT pk_THUOC PRIMARY KEY(ID_THUOC),
)
GO

CREATE TABLE SO_LUONG_TON_KHO(
	ID_THUOC VARCHAR(255) NOT NULL,
	SOLUONG INT,
	CONSTRAINT pk_SO_LUONG_TON_KHO PRIMARY KEY(ID_THUOC),
)
GO

CREATE TABLE HOA_DON(
	ID_HOADON VARCHAR(255) NOT NULL,
	ID_NV VARCHAR(255),
	ID_BA VARCHAR(255),
	TONGTIEN MONEY,
	TONGTIENTHUOC MONEY,
	TONGTIENDV MONEY,
	CONSTRAINT pk_HOA_DON PRIMARY KEY(ID_HOADON),
)
GO

CREATE TABLE BENH_AN(
	ID_BA VARCHAR(255) NOT NULL,
	ID_KH VARCHAR(255),
	ID_NS VARCHAR(255),
	NGAYKHAM DATE,
	CONSTRAINT pk_BENH_AN PRIMARY KEY(ID_BA),
)
GO

CREATE TABLE LICH_DAT_KHAM(
	ID_LLV VARCHAR(255) NOT NULL,
	ID_KH VARCHAR(255),
	ID_NV VARCHAR(255),
	CONSTRAINT pk_LICH_DAT_KHAM PRIMARY KEY(ID_LLV,ID_KH),
)
GO

CREATE TABLE LICH_LAM_VIEC(
	ID_LLV VARCHAR(255) NOT NULL,
	NGAYKHAM DATE,
	GIOKHAM TIME,
	TRANGTHAI NVARCHAR(10),
	ID_NS VARCHAR(255),
	CONSTRAINT pk_LICH_LAM_VIEC PRIMARY KEY(ID_LLV),
)
GO

CREATE TABLE LOAI_DV(
	ID_LOAIDV VARCHAR(255) NOT NULL,
	TENDV NVARCHAR(30),
	GIATIEN MONEY,
	CONSTRAINT pk_LOAI_DV PRIMARY KEY(ID_LOAIDV),
)
GO

CREATE TABLE DICHVU_SD(
	ID_DVSD VARCHAR(255) NOT NULL,
	ID_LOAIDV VARCHAR(255),
	THANHTIEN MONEY,
	ID_HOADON VARCHAR(255),
	ID_BA VARCHAR(255),
	CONSTRAINT pk_DICHVU_SD PRIMARY KEY(ID_DVSD),
)
GO

ALTER TABLE TAI_KHOAN 
	ADD CONSTRAINT fk_TAI_KHOAN__QUAN_TRI_VIEN 
	FOREIGN KEY(ID_QTV) REFERENCES TAI_KHOAN(ID_TAIKHOAN)
	
GO

ALTER TABLE SO_LUONG_TON_KHO
	ADD CONSTRAINT fk_SO_LUONG_TON_KHO__THUOC 
	FOREIGN KEY(ID_THUOC) REFERENCES THUOC(ID_THUOC)
GO

ALTER TABLE THUOC
	ADD CONSTRAINT fk_THUOC__QUAN_TRI_VIEN 
	FOREIGN KEY(ID_QTV) REFERENCES TAI_KHOAN(ID_TAIKHOAN)
GO

ALTER TABLE THUOC_SD
	ADD CONSTRAINT fk_THUOC_SD__THUOC 
	FOREIGN KEY(ID_THUOC) REFERENCES THUOC(ID_THUOC)
GO

ALTER TABLE THUOC_SD
	ADD CONSTRAINT fk_THUOC_SD__DON_THUOC 
	FOREIGN KEY(ID_BA) REFERENCES BENH_AN(ID_BA)
GO

ALTER TABLE HOA_DON
	ADD CONSTRAINT fk_HOA_DON__BENH_AN
	FOREIGN KEY(ID_BA) REFERENCES BENH_AN(ID_BA)
GO

ALTER TABLE HOA_DON
	ADD CONSTRAINT fk_HOA_DON__NHAN_VIEN
	FOREIGN KEY(ID_NV) REFERENCES TAI_KHOAN(ID_TAIKHOAN)
GO

ALTER TABLE BENH_AN
	ADD CONSTRAINT fk_BENH_AN__KHACH_HANG
	FOREIGN KEY(ID_KH) REFERENCES TAI_KHOAN(ID_TAIKHOAN)
GO

ALTER TABLE BENH_AN
	ADD CONSTRAINT fk_BENH_AN__NHA_SI
	FOREIGN KEY(ID_NS) REFERENCES TAI_KHOAN(ID_TAIKHOAN)
GO

ALTER TABLE DICHVU_SD
	ADD CONSTRAINT fk_DICHVU_SD__LOAI_DV
	FOREIGN KEY(ID_LOAIDV) REFERENCES LOAI_DV(ID_LOAIDV)
GO

ALTER TABLE DICHVU_SD
	ADD CONSTRAINT fk_DICHVU_SD__BENH_AN
	FOREIGN KEY(ID_BA) REFERENCES BENH_AN(ID_BA)
GO

ALTER TABLE DICHVU_SD
	ADD CONSTRAINT fk_DICHVU_SD__HOA_DON
	FOREIGN KEY(ID_HOADON) REFERENCES HOA_DON(ID_HOADON)
GO

ALTER TABLE LICH_LAM_VIEC
	ADD CONSTRAINT fk_LICH_LAM_VIEC__NHA_SI
	FOREIGN KEY(ID_NS) REFERENCES TAI_KHOAN(ID_TAIKHOAN)
GO

ALTER TABLE LICH_DAT_KHAM
	ADD CONSTRAINT fk_LICH_DAT_KHAM__KHACH_HANG
	FOREIGN KEY(ID_KH) REFERENCES TAI_KHOAN(ID_TAIKHOAN)
GO

ALTER TABLE LICH_DAT_KHAM
	ADD CONSTRAINT fk_LICH_DAT_KHAM__NHAN_VIEN
	FOREIGN KEY(ID_NV) REFERENCES TAI_KHOAN(ID_TAIKHOAN)
GO

ALTER TABLE LICH_DAT_KHAM
	ADD CONSTRAINT fk_LICH_DAT_KHAM__LICH_LAM_VIEC
	FOREIGN KEY(ID_LLV) REFERENCES LICH_LAM_VIEC(ID_LLV)
GO

------------------------------------------
--RANG BUOC TOAN VEN
------------------------------------------
--Không cho phép thêm vào ngày khám và lịch làm việc đã có sẵn trong database
--create or alter trigger TR_0b on LICH_LAM_VIEC
--for insert
--as
--	if exists	(select*
--				from inserted I, LICH_LAM_VIEC LLV, LICH_DAT_KHAM LDK
--				where I.ID_NS = LLV.ID_NS
--					AND I.NGAYKHAM = LLV.NGAYKHAM
--					AND I.GIOKHAM = LLV.GIOKHAM)
--	begin
--		;throw 50000, N'Đã có lịch vào giờ đó', 1
--		rollback tran
--	end
--go
--drop trigger TR_0b
--Một lịch đặt hẹn phải chọn một lịch nha sĩ với điều kiện lịch nha sĩ chưa có lịch đặt hẹn và ngày phải hợp lệ (không được là ngày trước ngày hiện tại)
create or alter trigger TR_1 on LICH_DAT_KHAM for insert,update
as
	if	not exists	(
						select *
						from inserted as I, LICH_LAM_VIEC as LLV
						where	I.ID_LLV is not null
								and LLV.ID_LLV = I.ID_LLV
								and LLV.TRANGTHAI = N'Trống'
								and datediff(day,LLV.NGAYKHAM,getdate()) <= 0
					)
	begin
		;throw 50000, N'Lịch làm việc đã đặt không hợp lệ',1
		rollback tran
	end
	else
	begin
		update LICH_LAM_VIEC
		set TRANGTHAI = N'Đã Đặt'
		from inserted as I
		where LICH_LAM_VIEC.ID_LLV = I.ID_LLV
	end
go

--Ngày khám của bệnh án phải là ngày hiện tại hoặc trước đó, nếu vi phạm thì sử dụng ngày hiện tại
create or alter trigger TR_2 on BENH_AN for insert,update
as
	if exists	(
					select *
					from inserted as I
					where	datediff(day,I.NGAYKHAM, getdate()) > 0
				)
	begin
		update BENH_AN
		set NGAYKHAM = getdate()
		from inserted as I
		where BENH_AN.ID_BA = I.ID_BA
	end
go

--Khi thêm thuốc trong đơn thuốc, số lượng không được vượt quá số lượng tồn kho và chưa hết hạn sử dụng.
--Sau khi thêm thuốc vào đơn thuốc, số lượng tồn kho phải giảm theo lượng tương ứng.
create or alter trigger TR_3 on THUOC_SD for insert,update
as
	if exists	(
					select *
					from inserted as I, THUOC as T, SO_LUONG_TON_KHO as SLTK
					where	I.ID_THUOC = T.ID_THUOC
							and T.ID_THUOC = SLTK.ID_THUOC
							and (I.SOLUONG > SLTK.SOLUONG or datediff(day,T.NGAYHETHAN, getdate()) > 0) 
				)
	begin
		;throw 50001, N'Số lượng còn lại không đủ cho yêu cầu sử dụng',1
		rollback tran
	end
go

--Nha sĩ không được cập nhật sửa đổi những lịch khám đã có khách đặt
--create or alter trigger TR_4 on LICH_LAM_VIEC for delete, update
--as
--	select * from inserted
--	if exists	(
--					select *
--					from inserted as I
--					where	I.TRANGTHAI != N'Trống'
--				)
--	begin
--		;throw 50002, N'Lịch làm việc đã được đặt',1
--		rollback tran
--	end
--go

--Khi xoá một lịch đặt hẹn, trạng thái của lịch làm việc mà lịch đặt hẹn đó giữ phải được trả lại trạng thái “Trống”
create or alter trigger TR_5 on LICH_DAT_KHAM for delete, update
as
	update LICH_LAM_VIEC
	set TRANGTHAI = N'Trống'
	where ID_LLV not in (select ID_LLV from LICH_DAT_KHAM)

	if exists	(
					select *
					from deleted as D, LICH_LAM_VIEC as LLV
					where	D.ID_LLV = LLV.ID_LLV
							and LLV.TRANGTHAI != N'Trống'
				)
	begin
		update LICH_LAM_VIEC
		set TRANGTHAI = N'Trống'
		from deleted as D
		where	D.ID_LLV = LICH_LAM_VIEC.ID_LLV
	end
go

--Thuốc có ngày hết hạn hợp lệ
create or  alter trigger TR_6 on THUOC for insert,update
as
	if exists	(
					select *
					from inserted as I
					where datediff(day,I.NGAYHETHAN,getdate()) >= 0
				)
	begin
		;throw 50006, N'Không thể thêm thuốc đã hết hạn',1
		rollback tran
	end
go

--Mật khẩu không được trống và loại tài khoản phải hợp lệ
create or alter trigger TR_7 on TAI_KHOAN for insert, update
as
	if exists	(
					select *
					from inserted as I
					where	I.MATKHAU = ' '
							or I.LOAITK not in ('KH','NS','NV','QTV')
				)
	begin
		;throw 50007, N'Tài khoản không hợp lệ',1
		rollback tran
	end
go

--Ngày sinh không được là ngày sau ngày hiện tại
create or alter trigger TR_8 on TAI_KHOAN for insert,update
as
	if exists	(
					select *
					from inserted
					where datediff(day,'2023-12-30',getdate()) > 0
				)
	begin
		;throw 50008, N'Ngày sinh không hợp lệ', 1
		rollback tran
	end
go