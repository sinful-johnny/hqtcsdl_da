USE QL_NHAKHOA
GO

EXEC sp_addrole 'NHAN_VIEN'
GO

-- th�ng tin c� nh�n ---
CREATE OR ALTER VIEW V_TKNHANVIEN
AS
	SELECT*
	FROM TAI_KHOAN TK
	WHERE TK.ID_TAIKHOAN = CURRENT_USER
GO

-- Qu?n l� l?ch ??t kh�m cho b?nh nh�n --
CREATE OR ALTER VIEW V_LICHDATKHAM_NHANVIEN 
AS
	SELECT
		LDK.ID_LLV,
		LDK.ID_KH,
		LDK.ID_NV,
		LLV.NGAYKHAM,
		LLV.GIOKHAM,
		LLV.TRANGTHAI
	FROM
		LICH_DAT_KHAM LDK
	LEFT JOIN
		LICH_LAM_VIEC LLV ON LDK.ID_LLV = LLV.ID_LLV 
	WHERE
		LDK.ID_NV = CURRENT_USER;
GO


-- Thanh to�n v� in h�a ??n cho b?nh nh�n -- 
CREATE OR ALTER VIEW V_HOADON_NHANVIEN 
AS
	SELECT
		HD.ID_HOADON, HD.ID_NV, HD.ID_BA,
		BA.ID_KH AS ID_KHACHHANG,
		KH.HOTEN AS TEN_KHACHHANG,
		HD.TONGTIEN,
		TS.ID_THUOC,
		T.TENTHUOC,
		TS.SOLUONG
	FROM
		HOA_DON HD
	JOIN
		BENH_AN BA ON HD.ID_BA = BA.ID_BA
	JOIN
		KHACH_HANG KH ON BA.ID_KH = KH.ID_KH
	JOIN
		DON_THUOC DT ON BA.ID_BA = DT.ID_BA
	JOIN
		THUOC_SD TS ON DT.ID_DONTHUOC = TS.ID_DONTHUOC
	JOIN
		THUOC T ON TS.ID_THUOC = T.ID_THUOC
	WHERE
		HD.ID_NV = CURRENT_USER;
GO

-- Xem danh m?c thu?c --
CREATE OR ALTER VIEW V_DANHMUC_THUOC 
AS
	SELECT
		T.ID_THUOC,
		T.TENTHUOC,
		T.CHIDINH,
		T.NGAYHETHAN,
		SLTK.SOLUONG AS SOLUONGTONKHO
	FROM
		THUOC T
	LEFT JOIN
		SO_LUONG_TON_KHO SLTK ON T.ID_THUOC = SLTK.ID_THUOC;
GO

GRANT SELECT, UPDATE ON V_TKNHANVIEN TO NHAN_VIEN
GRANT SELECT, UPDATE, INSERT ON V_LICHDATKHAM_NHANVIEN  TO NHAN_VIEN
GRANT SELECT, INSERT ON V_HOADON_NHANVIEN TO NHAN_VIEN
GRANT SELECT ON V_DANHMUC_THUOC TO NHAN_VIEN
GO