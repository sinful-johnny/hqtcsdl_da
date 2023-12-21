use QL_NHAKHOA
go

exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Nguyễn Văn A', '01234567890', '1990-01-01', 'nguyenvana@gmail.com', '12345678', 'KH'	
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Trần Thị B', '09876543210', '1985-03-15', 'tranthib@gmail.com', '12345678', 'KH'	
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Lê Văn C', '0369842157', '1992-07-22', 'levanc@gmail.com', '12345678', 'KH'		
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Phạm Thị D', '0903124578', '1988-11-10', 'phamthid@gmail.com', '12345678', 'KH'	
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Hoàng Văn E', '0778899443', '1995-05-05', 'hoangvane@gmail.com', '12345678', 'KH'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Đỗ Thị F', '0567321987', '1987-12-30', 'dothif@gmail.com', '12345678', 'KH'		
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Vũ Văn G', '0912345678', '1991-04-18', 'vuvang@gmail.com', '12345678', 'KH'		
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Lý Thị H', '0888123456', '1989-09-25', 'lythih@gmail.com', '12345678', 'KH'		
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Nguyễn Văn I', '0999223344', '1993-08-20', 'nguyenvani@gmail.com', '12345678', 'KH'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Trần Văn K', '0333666999', '1986-06-08', 'tranvank@gmail.com', '12345678', 'KH'	
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Phạm Thị L', '0777888999', '1994-02-14', 'phamthil@gmail.com', '12345678', 'KH'	
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Hoàng Văn M', '0888999111', '1990-10-02', 'hoangvanm@gmail.com', '12345678', 'KH'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Lê Thị N', '0666777888', '1984-03-27', 'lethin@gmail.com', '12345678', 'KH'		
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Vũ Thị P', '0911122334', '1996-09-15', 'vuthip@gmail.com', '12345678', 'KH'		
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Đỗ Văn Q', '0777999888', '1988-11-01', 'dovanq@gmail.com', '12345678', 'KH'		
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Nguyễn Thị R', '0999888777', '1992-06-03', 'nguyenthir@gmail.com', '12345678', 'KH'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Trần Văn S', '0333444555', '1987-07-12', 'tranvans@gmail.com', '12345678', 'KH'	
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Lý Thị T', '0888777666', '1995-04-23', 'lythit@gmail.com', '12345678', 'KH'		
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Phạm Văn U', '0911223344', '1989-12-05', 'phamvanu@gmail.com', '12345678', 'KH'	
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Hoàng Thị V', '0777888999', '1993-08-16', 'hoangthiv@gmail.com', '12345678', 'KH'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Nguyễn Văn An', '01234567891', '1992-05-20', 'nguyenvana_nv@gmail.com', '12345678','NV'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Trần Thị Bình', '09876543212', '1988-12-15', 'tranbinh_nv@gmail.com', '12345678','NV'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Lê Văn Cường', '03698421573', '1995-08-22', 'levancuong_nv@gmail.com', '12345678','NV'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Phạm Thị Dung', '09031245782', '1990-04-10', 'phamthidung_nv@gmail.com', '12345678','NV'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Hoàng Văn Dũng', '07788994437', '1987-10-05', 'hoangvandung_nv@gmail.com', '12345678','NS'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Đỗ Thị Eo', '05673219876', '1993-03-30', 'dothieo_nv@gmail.com', '12345678','NS'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Vũ Văn Giao', '09123456789', '1989-02-18', 'vuvangiao_nv@gmail.com', '12345678','NS'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Lý Thị Hằng', '08881234567', '1996-07-25', 'lythihang_nv@gmail.com', '12345678','NS'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Nguyễn Văn Hiển', '09992233445', '1986-11-20', 'nguyenvanhien_nv@gmail.com', '12345678','NS'
exec sp_THEM_TAIKHOAN_NGUOIDUNG N'Trần Văn Khoa', '03336669996', '1992-02-08', 'tranvankhoa_nv@gmail.com', '12345678','NV'
go

INSERT INTO THUOC VALUES
(cast(NEWID() as varchar(255)), 'Paracetamol',			N'Đau đầu, sốt', '2024-12-31', 5000,						(select ID_TAIKHOAN from TAI_KHOAN where SDT = '01234567892')),
(cast(NEWID() as varchar(255)), 'Ibuprofen',			N'Đau nhức cơ', '2024-01-15', 7000,							(select ID_TAIKHOAN from TAI_KHOAN where SDT = '03698421574')),
(cast(NEWID() as varchar(255)), 'Amoxicillin',			N'Viêm họng', '2024-12-20', 10000,							(select ID_TAIKHOAN from TAI_KHOAN where SDT = '09031245783')),
(cast(NEWID() as varchar(255)), 'Cetirizine',			N'Dị ứng', '2024-02-01', 12000,								(select ID_TAIKHOAN from TAI_KHOAN where SDT = '09031245783')),
(cast(NEWID() as varchar(255)), 'Omeprazole',			N'Dạ dày', '2024-12-25', 15000,								(select ID_TAIKHOAN from TAI_KHOAN where SDT = '07788994438')),
(cast(NEWID() as varchar(255)), 'Aspirin',				N'Chống đông máu', '2024-01-10', 8000,						(select ID_TAIKHOAN from TAI_KHOAN where SDT = '09876543213')),
(cast(NEWID() as varchar(255)), 'Simvastatin',			N'Hạ cholesterol', '2024-12-30', 9000,						(select ID_TAIKHOAN from TAI_KHOAN where SDT = '01234567892')),
(cast(NEWID() as varchar(255)), 'Losartan',				N'Hạ huyết áp', '2024-01-05', 11000,						(select ID_TAIKHOAN from TAI_KHOAN where SDT = '03698421574')),
(cast(NEWID() as varchar(255)), 'Metformin',			N'Điều trị tiểu đường', '2024-12-28', 13000,				(select ID_TAIKHOAN from TAI_KHOAN where SDT = '09031245783')),
(cast(NEWID() as varchar(255)), 'Warfarin',				N'Chống đông máu', '2024-01-20', 16000,						(select ID_TAIKHOAN from TAI_KHOAN where SDT = '09031245783')),
(cast(NEWID() as varchar(255)), 'Lisinopril',			N'Hạ huyết áp', '2024-12-23', 9500,							(select ID_TAIKHOAN from TAI_KHOAN where SDT = '07788994438')),
(cast(NEWID() as varchar(255)), 'Atorvastatin',			N'Hạ cholesterol', '2024-01-08', 10500,						(select ID_TAIKHOAN from TAI_KHOAN where SDT = '09876543213')),
(cast(NEWID() as varchar(255)), 'Gabapentin',			N'Đau thần kinh', '2024-12-18', 12500,						(select ID_TAIKHOAN from TAI_KHOAN where SDT = '03698421574')),
(cast(NEWID() as varchar(255)), 'Amlodipine',			N'Hạ huyết áp', '2024-01-03', 14500,						(select ID_TAIKHOAN from TAI_KHOAN where SDT = '09031245783')),
(cast(NEWID() as varchar(255)), 'Metoprolol',			N'Hạ nhịp tim', '2024-12-22', 15500,						(select ID_TAIKHOAN from TAI_KHOAN where SDT = '03698421574')),
(cast(NEWID() as varchar(255)), 'Hydrochlorothiazide',	N'Điều trị tiểu đường', '2024-01-12', 10200,				(select ID_TAIKHOAN from TAI_KHOAN where SDT = '07788994438')),
(cast(NEWID() as varchar(255)), 'Prednisone',			N'Chống viêm', '2024-12-26', 13200,							(select ID_TAIKHOAN from TAI_KHOAN where SDT = '09031245783')),
(cast(NEWID() as varchar(255)), 'Diazepam',				N'Lo lắng, căng thẳng', '2024-01-18', 14200,				(select ID_TAIKHOAN from TAI_KHOAN where SDT = '07788994438')),
(cast(NEWID() as varchar(255)), 'Tramadol',				N'Đau mạch và cơ', '2024-12-29', 15200,						(select ID_TAIKHOAN from TAI_KHOAN where SDT = '09031245783')),
(cast(NEWID() as varchar(255)), 'Morphine',				N'Đau nặng', '2024-01-14', 17000,							(select ID_TAIKHOAN from TAI_KHOAN where SDT = '03698421574'));
go

INSERT INTO SO_LUONG_TON_KHO VALUES
((select ID_THUOC from THUOC where TENTHUOC = 'Paracetamol'			), 100),
((select ID_THUOC from THUOC where TENTHUOC = 'Ibuprofen'			), 150),
((select ID_THUOC from THUOC where TENTHUOC = 'Amoxicillin'			), 200),
((select ID_THUOC from THUOC where TENTHUOC = 'Cetirizine'			), 80),
((select ID_THUOC from THUOC where TENTHUOC = 'Omeprazole'			), 120),
((select ID_THUOC from THUOC where TENTHUOC = 'Aspirin'				), 90),
((select ID_THUOC from THUOC where TENTHUOC = 'Simvastatin'			), 110),
((select ID_THUOC from THUOC where TENTHUOC = 'Losartan'			), 160),
((select ID_THUOC from THUOC where TENTHUOC = 'Metformin'			), 130),
((select ID_THUOC from THUOC where TENTHUOC = 'Warfarin'			), 75),
((select ID_THUOC from THUOC where TENTHUOC = 'Lisinopril'			), 105),
((select ID_THUOC from THUOC where TENTHUOC = 'Atorvastatin'		), 140),
((select ID_THUOC from THUOC where TENTHUOC = 'Gabapentin'			), 180),
((select ID_THUOC from THUOC where TENTHUOC = 'Amlodipine'			), 95),
((select ID_THUOC from THUOC where TENTHUOC = 'Metoprolol'			), 200),
((select ID_THUOC from THUOC where TENTHUOC = 'Hydrochlorothiazide'	), 120),
((select ID_THUOC from THUOC where TENTHUOC = 'Prednisone'			), 150),
((select ID_THUOC from THUOC where TENTHUOC = 'Diazepam'			), 100),
((select ID_THUOC from THUOC where TENTHUOC = 'Tramadol'			), 170),
((select ID_THUOC from THUOC where TENTHUOC = 'Morphine'			), 110);
go

insert BENH_AN(ID_BA,ID_KH,ID_NS,NGAYKHAM)
values
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '01234567890'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '09992233445'), '2024-01-10'),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '09876543210'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '07788994437'), '2024-02-15'),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0369842157'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '05673219876'), '2024-03-22'),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0903124578'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '09123456789'), '2024-04-10'),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0778899443'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '08881234567'), '2024-05-05'),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0567321987'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '09992233445'), '2024-06-30'),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0912345678'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '07788994437'), '2024-07-18'),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0888123456'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '05673219876'), '2024-08-25'),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0999223344'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '09123456789'), '2024-09-20'),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0333666999'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '08881234567'), '2024-10-08');
go

INSERT INTO THUOC_SD(ID_BA,ID_THUOC,SOLUONG) VALUES
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0369842157'), (select ID_THUOC from THUOC where TENTHUOC = 'Morphine'), 5),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0903124578'), (select ID_THUOC from THUOC where TENTHUOC = 'Aspirin'), 10),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0888123456'), (select ID_THUOC from THUOC where TENTHUOC = 'Metoprolol'), 15),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0567321987'), (select ID_THUOC from THUOC where TENTHUOC = 'Simvastatin'), 3),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0778899443'), (select ID_THUOC from THUOC where TENTHUOC = 'Gabapentin'), 12),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0912345678'), (select ID_THUOC from THUOC where TENTHUOC = 'Diazepam'), 6),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0333666999'), (select ID_THUOC from THUOC where TENTHUOC = 'Paracetamol'), 20),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '09876543210'), (select ID_THUOC from THUOC where TENTHUOC = 'Losartan'), 4),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0369842157'), (select ID_THUOC from THUOC where TENTHUOC = 'Lisinopril'), 18),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0903124578'), (select ID_THUOC from THUOC where TENTHUOC = 'Ibuprofen'), 7),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '01234567890'), (select ID_THUOC from THUOC where TENTHUOC = 'Tramadol'), 14),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0888123456 '), (select ID_THUOC from THUOC where TENTHUOC = 'Metformin'), 9),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0567321987'), (select ID_THUOC from THUOC where TENTHUOC = 'Warfarin'), 16),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0778899443'), (select ID_THUOC from THUOC where TENTHUOC = 'Amoxicillin'), 2),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0912345678'), (select ID_THUOC from THUOC where TENTHUOC = 'Amlodipine'), 11),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0333666999'), (select ID_THUOC from THUOC where TENTHUOC = 'Prednisone'), 13),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '09876543210'), (select ID_THUOC from THUOC where TENTHUOC = 'Omeprazole'), 19),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0999223344'), (select ID_THUOC from THUOC where TENTHUOC = 'Atorvastatin'), 1),
((select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0369842157'), (select ID_THUOC from THUOC where TENTHUOC = 'Cetirizine'), 17);
go

INSERT INTO HOA_DON(ID_HOADON,ID_NV,ID_BA,TONGTIEN) VALUES
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '01234567891'), (select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0369842157 '), 500000),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '03336669996'), (select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0903124578 '), 750000),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '09876543212'), (select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '01234567890'), 600000),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '09031245782'), (select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0888123456 '), 900000),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '03698421573'), (select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0567321987 '), 800000),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '01234567891'), (select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0778899443 '), 550000),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '03336669996'), (select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0912345678 '), 700000),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '09876543212'), (select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0333666999 '), 650000),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '09031245782'), (select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '09876543210'), 720000),
(cast(NEWID() as varchar(255)), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '03698421573'), (select BN.ID_BA from BENH_AN as BN inner join TAI_KHOAN as TK on BN.ID_KH= TK.ID_TAIKHOAN where TK.SDT = '0999223344 '), 850000);
go

INSERT INTO LICH_LAM_VIEC(ID_LLV,NGAYKHAM,GIOKHAM,TRANGTHAI,ID_NS) VALUES
(cast(NEWID() as varchar(255)), '2024-12-15', '09:00:00', N'Trống',		(select ID_TAIKHOAN from TAI_KHOAN where SDT = '09992233445')),
(cast(NEWID() as varchar(255)), '2024-12-16', '10:30:00', N'Trống',		(select ID_TAIKHOAN from TAI_KHOAN where SDT = '07788994437')),
(cast(NEWID() as varchar(255)), '2024-12-17', '14:00:00', N'Trống',		(select ID_TAIKHOAN from TAI_KHOAN where SDT = '05673219876')),
(cast(NEWID() as varchar(255)), '2024-12-18', '15:30:00', N'Trống',		(select ID_TAIKHOAN from TAI_KHOAN where SDT = '09123456789')),
(cast(NEWID() as varchar(255)), '2024-12-19', '16:45:00', N'Trống',		(select ID_TAIKHOAN from TAI_KHOAN where SDT = '08881234567'));
go
INSERT INTO LICH_DAT_KHAM(ID_LLV,ID_KH,ID_NV) VALUES
((select ID_LLV from LICH_LAM_VIEC as LLV inner join TAI_KHOAN as TK on LLV.ID_NS = TK.ID_TAIKHOAN where TK.SDT = '09992233445' and LLV.NGAYKHAM = '2024-12-15' and LLV.GIOKHAM = '09:00:00'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0888777666 '), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '01234567891')),
((select ID_LLV from LICH_LAM_VIEC as LLV inner join TAI_KHOAN as TK on LLV.ID_NS = TK.ID_TAIKHOAN where TK.SDT = '07788994437'and LLV.NGAYKHAM = '2024-12-16' and LLV.GIOKHAM = '10:30:00'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0333666999 '), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '03336669996')),
((select ID_LLV from LICH_LAM_VIEC as LLV inner join TAI_KHOAN as TK on LLV.ID_NS = TK.ID_TAIKHOAN where TK.SDT = '05673219876'and LLV.NGAYKHAM = '2024-12-17' and LLV.GIOKHAM = '14:00:00'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0911223344 '), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '09876543212')),
((select ID_LLV from LICH_LAM_VIEC as LLV inner join TAI_KHOAN as TK on LLV.ID_NS = TK.ID_TAIKHOAN where TK.SDT = '09123456789'and LLV.NGAYKHAM = '2024-12-18' and LLV.GIOKHAM = '15:30:00'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0777888999 '), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '09031245782')),
((select ID_LLV from LICH_LAM_VIEC as LLV inner join TAI_KHOAN as TK on LLV.ID_NS = TK.ID_TAIKHOAN where TK.SDT = '08881234567'and LLV.NGAYKHAM = '2024-12-19' and LLV.GIOKHAM = '16:45:00'), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '0999223344 '), (select ID_TAIKHOAN from TAI_KHOAN where SDT = '03698421573'));
go
