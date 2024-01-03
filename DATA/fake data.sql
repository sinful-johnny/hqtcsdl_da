use QL_NHAKHOA
go

exec sp_ThemTK 'KH', '03626', '123'
exec sp_ThemTK 'NS', '02526', '123'
go

insert BENH_AN(ID_BA,ID_KH,ID_NS)
values	(cast(NEWID() as varchar(255)),(select ID_TAIKHOAN from TAI_KHOAN where SDT = '03626'),(select ID_TAIKHOAN from TAI_KHOAN where SDT = '02526'))
go

insert LOAI_DV(ID_LOAIDV, TENDV, GIATIEN)
values	(cast(NEWID() as varchar(255)),N'Trám răng',200),
		(cast(NEWID() as varchar(255)),N'Trồng răng',1000)
go

insert THUOC(ID_THUOC, TENTHUOC, GIATIEN, NGAYHETHAN)
values	(cast(NEWID() as varchar(255)),'Thuoc te',10, '12/22/2024'),
		(cast(NEWID() as varchar(255)),'Thuoc cam mau',15,'12/22/2024'),
		(cast(NEWID() as varchar(255)),'Thuoc khu trung',12,'12/22/2024')
go
insert SO_LUONG_TON_KHO(ID_THUOC,SOLUONG)
values	((select ID_THUOC from THUOC where TENTHUOC = 'Thuoc te'), 100),
		((select ID_THUOC from THUOC where TENTHUOC = 'Thuoc cam mau'), 100),
		((select ID_THUOC from THUOC where TENTHUOC = 'Thuoc khu trung'), 100)
go

insert DICHVU_SD(ID_DVSD, ID_BA, ID_LOAIDV)
values	(cast(NEWID() as varchar(255)),(select top 1 ID_BA from BENH_AN inner join TAI_KHOAN on ID_KH=ID_TAIKHOAN where SDT = '03626'),(select top 1 ID_LOAIDV from LOAI_DV where TENDV = N'Trám răng')),
		(cast(NEWID() as varchar(255)),(select top 1 ID_BA from BENH_AN inner join TAI_KHOAN on ID_KH=ID_TAIKHOAN where SDT = '03626'),(select top 1 ID_LOAIDV from LOAI_DV where TENDV = N'Trồng răng'))
go

insert THUOC_SD(ID_BA,ID_THUOC,SOLUONG)
values	((select top 1 ID_BA from BENH_AN inner join TAI_KHOAN on ID_KH=ID_TAIKHOAN where SDT = '03626'), (select top 1 ID_THUOC from THUOC where TENTHUOC = 'Thuoc khu trung'),10),
		((select top 1 ID_BA from BENH_AN inner join TAI_KHOAN on ID_KH=ID_TAIKHOAN where SDT = '03626'), (select top 1 ID_THUOC from THUOC where TENTHUOC = 'Thuoc te'),10)
go