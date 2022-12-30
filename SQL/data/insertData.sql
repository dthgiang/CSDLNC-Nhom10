-- truncate the table first
USE CSDLNC2
GO

delete from TaiKhoan
TRUNCATE TABLE TaiKhoan;
GO
 
-- import the file
BULK INSERT TaiKhoan
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\TaiKhoan.csv'
WITH
(
        FORMAT='CSV',
		codepage = '65001',
		ROWTERMINATOR = '0x0A',
        FIRSTROW=1
)
GO


delete from dbo.TinhTrangDonHang
TRUNCATE TABLE dbo.TinhTrangDonHang;
GO
 
-- import the file
BULK INSERT dbo.TinhTrangDonHang
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\TinhTrangDonHang.csv'
WITH
(
        FORMAT='CSV',
        FIRSTROW=1
)
GO



delete from dbo.DoiTac
TRUNCATE TABLE dbo.DoiTac;
GO
 
-- import the file
BULK INSERT dbo.DoiTac
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\DoiTac.csv'
WITH
(
        FORMAT='CSV',
		codepage = '65001',
		ROWTERMINATOR = '0x0A',
        FIRSTROW=1
)
GO

delete from dbo.ChiNhanh
TRUNCATE TABLE dbo.ChiNhanh;
GO
 
-- import the file
BULK INSERT dbo.ChiNhanh
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\ChiNhanh.csv'
WITH
(
        FORMAT='CSV',
		codepage = '65001',
		ROWTERMINATOR = '0x0A',
        FIRSTROW=1
)
GO

delete from dbo.NhanVien
TRUNCATE TABLE dbo.NhanVien;
GO
 
-- import the file
BULK INSERT dbo.NhanVien
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\NhanVien.csv'
WITH
(
        FORMAT='CSV',
		codepage = '65001',
		ROWTERMINATOR = '0x0A',
        FIRSTROW=1
)
GO

delete from dbo.KhachHang
TRUNCATE TABLE dbo.KhachHang;
GO
 
-- import the file
BULK INSERT dbo.KhachHang
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\KhachHang.csv'
WITH
(
        FORMAT='CSV',
        FIRSTROW=1
)
GO


delete from dbo.LoaiAmThuc
TRUNCATE TABLE dbo.LoaiAmThuc;
GO
 
-- import the file
BULK INSERT dbo.LoaiAmThuc
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\LoaiAmThuc.csv'
WITH
(
        FORMAT='CSV',
		codepage = '65001',
		ROWTERMINATOR = '0x0A',
        FIRSTROW=1
)
GO


delete from dbo.KhuVuc
TRUNCATE TABLE dbo.KhuVuc;
GO
 
-- import the file
BULK INSERT dbo.KhuVuc
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\KhuVuc.csv'
WITH
(
        FORMAT='CSV',
		codepage = '65001',
		ROWTERMINATOR = '0x0A',
        FIRSTROW=1
)
GO


delete from dbo.TaiXe
TRUNCATE TABLE dbo.TaiXe;
GO
 
-- import the file
BULK INSERT dbo.TaiXe
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\TaiXe.csv'
WITH
(
        FORMAT='CSV',
        FIRSTROW=1
)
GO

delete from dbo.HopDong
TRUNCATE TABLE dbo.HopDong;
GO
 
-- import the file
BULK INSERT dbo.HopDong
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\HopDong.csv'
WITH
(
        FORMAT='CSV',
        FIRSTROW=1
)
GO

delete from dbo.DonHang
TRUNCATE TABLE DonHang;
GO
 
-- import the file
BULK INSERT dbo.DonHang
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\DonHang.csv'
WITH
(
        FORMAT='CSV',
		codepage = '65001',
		ROWTERMINATOR = '0x0A',
        FIRSTROW=1
)
GO

delete from dbo.ThucDon
TRUNCATE TABLE dbo.ThucDon;
GO
 
-- import the file
BULK INSERT dbo.ThucDon
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\td1.csv'
WITH
(
        FORMAT='CSV',
		codepage = '65001',
		ROWTERMINATOR = '0x0A',
        FIRSTROW=1
)
GO
BULK INSERT dbo.ThucDon
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\td2.csv'
WITH
(
        FORMAT='CSV',
		codepage = '65001',
		ROWTERMINATOR = '0x0A',
        FIRSTROW=1
)
GO
BULK INSERT dbo.ThucDon
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\td3.csv'
WITH
(
        FORMAT='CSV',
		codepage = '65001',
		ROWTERMINATOR = '0x0A',
        FIRSTROW=1
)
GO

delete from dbo.DoanhThuChiNhanh
TRUNCATE TABLE dbo.DoanhThuChiNhanh;
GO
 
-- import the file
BULK INSERT dbo.DoanhThuChiNhanh
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\DoanhThuChiNhanh.csv'
WITH
(
        FORMAT='CSV',
        FIRSTROW=1
)
GO


delete from dbo.ChiTietDonHang
TRUNCATE TABLE dbo.ChiTietDonHang;
GO
 
-- import the file
BULK INSERT dbo.ChiTietDonHang
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\ChiTietDonHang.csv'
WITH
(
        FORMAT='CSV',
        FIRSTROW=1
)
GO
delete from dbo.BangDanhGia
TRUNCATE TABLE dbo.BangDanhGia;
GO
 
-- import the file
BULK INSERT dbo.BangDanhGia
FROM 'D:\OneDrive - VNU-HCMUS\Courses\Ky1\CSDL_Advance\data\BangDanhGia2.csv'
WITH
(
        FORMAT='CSV',
        FIRSTROW=1
)
GO