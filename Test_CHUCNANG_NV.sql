﻿use QL_NHAKHOA
go

exec sp_ThemTK 'lolo', '012345678', '2003/10/20', 'hhihi@gmail.com', '123', 'NV'
exec sp_ThemTK 'loKHACHHANG', '012345318', '2003/10/20', 'hhihGIi@gmail.com', '123', 'KH'
exec sp_ThemTK 'loKHACHHANG1', '012235318', '2003/10/20', 'hhihGIi@gmail.com', '123', 'KH'
go

EXEC SP_NV_THEMLICHKHAM '7EFAE05C-4993-48E7-874D-7FE5B49099A1', '06DC015C-083B-4339-B0C3-6C8D025C4F42' , '2024-01-01', '14:00:00.0000000'
EXEC SP_NV_THEMLICHKHAM 'DB8C889A-E3CF-4ADD-B749-EB404EC7E29E', '06DC015C-083B-4339-B0C3-6C8D025C4F42' , '2023-12-31', '09:00:00.0000000'
go
-- XEM LICH KHAM
EXEC SP_NV_XEMLICHKHAM
GO
-- XEM LICH LAM VIEC
EXEC SP_NV_XEMLICHLAMVIEC
GO

-- XEM HOA DON
EXEC SP_NV_XEMHOADON
GO

-- XEM TT THUOC
EXEC SP_NV_XEMTTTHUOC
GO

-- XEM THUOC SD
EXEC SP_NV_XEMDANHMUC_THUOCSD
GO
-- XEM DICH VU
EXEC SP_NV_XEMDICHVU_SD
GO

SELECT *
FROM TAI_KHOAN
WHERE LOAITK = 'NV'

SELECT *
FROM LICH_DAT_KHAM

delete 
from LICH_DAT_KHAM

UPDATE LICH_LAM_VIEC
SET TRANGTHAI = N'Trống';

SELECT *
FROM LICH_LAM_VIEC

SELECT * 
FROM TAI_KHOAN
WHERE HOTEN = 'loKHACHHANG1'

INSERT INTO LICH_LAM_VIEC(ID_LLV,NGAYKHAM,GIOKHAM,TRANGTHAI,ID_NS) VALUES
(cast(NEWID() as varchar(255)), '2023-12-31', '09:00:00', N'Trống',		(select ID_TAIKHOAN from TAI_KHOAN where SDT = '09992233445')),
(cast(NEWID() as varchar(255)), '2024-1-13', '10:30:00', N'Trống',		(select ID_TAIKHOAN from TAI_KHOAN where SDT = '07788994437')),
(cast(NEWID() as varchar(255)), '2024-1-1', '14:00:00', N'Trống',		(select ID_TAIKHOAN from TAI_KHOAN where SDT = '05673219876'));

SELECT * 
FROM LICH_DAT_KHAM