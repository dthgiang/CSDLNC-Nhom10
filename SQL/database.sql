use master
go
IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'CSDLNC2')
BEGIN
	drop DATABASE CSDLNC2 
end
GO

CREATE DATABASE CSDLNC2 
go

use CSDLNC2
go

create table TaiKhoan (
	TenTaiKhoan		varchar(30) not null ,
	HoVaTen			nvarchar(50),
	MatKhau			varchar(40),
	SoDienThoai		char(10) unique,
	DiaChi			nvarchar(80),
	Email			varchar(100) unique,
	LoaiTaiKhoan	varchar(11)

	constraint "PK_TaiKhoan" primary key (TenTaiKhoan)
) 
go

create table NhanVien (
	MaNhanVien		char(9)		not null,
	TaiKhoanNV	varchar(30)	unique		not null,
	ChucVu			nvarchar(20)	not null,		

   	constraint "PK_NHAN VIEN" primary key (MaNhanVien)


)
go
create table DoiTac (
	MaDoiTac		char(9)		not null,
	TenDoiTac		varchar(70)	not null,
	TenTaiKhoanDT	varchar(30) unique,
	DoanhThuThang	real				,
	MaSoThue		varchar(13)	not null unique	,
	RateTB		real,
	TenNguoiDaiDien nvarchar(50) not null

   	constraint "PK_DOI TAC" primary key (MaDoiTac),

	constraint chk_doitac check(DoanhThuThang>=0)
)
go

create table ChiNhanh (
    MaChiNhanh	char(5)			not null,
	MaDoiTac	char(9)			not null,
	DCChiNhanh	nvarchar(80)			not null,
	DoanhThuThang	real				,
	TenNganHang	varchar(20)			not null	,
	SoTaiKhoan	varchar(15)			not null	,
	TenChiNhanh	nvarchar(30)				not null,
	TinhTrang	bit					,
	ThoiGianDoiTen	date			

   	constraint "PK_CHI NHANH" primary key (MaChiNhanh, MaDoiTac),



	constraint check_chinhanh check(DoanhThuThang>=0)

)
go


create table KhachHang (
	MaKhachHang		char(8)		not null,
	TenTaiKhoanKH	varchar(30)	not null		
   constraint "PK_KHACH HANG" primary key(MaKhachHang)


)
go

create table LoaiAmThuc (
	MaDoiTac		char(9) not null,
	TenLoaiAmThuc	nvarchar(20)		not null

   	constraint "PK_LOAI AM THUC" primary key (TenLoaiAmThuc, MaDoiTac)

	constraint "FK_LoaiAmThuc_MaDoiTac"
	foreign key (MaDoiTac)
	references "DoiTac" (MaDoiTac)
)
go



--Thuc Don
create table ThucDon (
	MaThucDon		int			IDENTITY(1,1),
	MaChiNhanh		char(5)			not null,
	MaDoiTac		char(9)			not null,
	TenMonAn		nvarchar(80)	not null ,
	MieuTa			nvarchar(250)	not null,
	Gia				real			not null,
	RateTB			float			,
	SLLike			int				,
	LoaiAmThuc		nvarchar(20)	not null,
	TenDoiTac		nvarchar(70)	not null,
	TinhTrangMon	nvarchar(20),

	constraint "PK_ThucDon" primary key (MaThucDon),
	CONSTRAINT FK_mainTD UNIQUE (MaDoiTac, MaChiNhanh, TenMonAn)

)
go

--Chi tiet don hang
create table ChiTietDonHang (
	MaCTDH			int IDENTITY(1,1),
	MaThucDon		int			not null,
	MaDonHang		char(10)		not null,
	SLMon			int				not null,
	TuyChon			nvarchar(50)			,

	constraint "PK_ChiTietDonHang" primary key (MaCTDH),

	
	CONSTRAINT FK_main UNIQUE (MaThucDon, MaDonHang),


	constraint chk_doanhthuchinhanh check(SLMon>0)

)
go

--Khu vuc
create table KhuVuc
(
	MaKhuVuc char(4) ,
	TenKhuVuc nvarchar(30) not null,
	constraint "PK_KhuVuc" primary key (MaKhuVuc)
)
go

--Tai xe
create table TaiXe(
	MaTaiXe				char(9)			,
	BienSoXe			char(10)		not null unique,
	CMND				char(12)		not null unique,
	DoanhThuThang		real			not null,
	PhiThueChan			real			not null,
	NhanVienQuanLy		char(9)			not null,
	MaKhuVuc			char(4)			not null,
	TenNganHang			varchar(20)		not null,
	SoTaiKhoan			varchar(15)		not null,
	TenTaiKhoanTaiXe	varchar(30)		not null unique,
	constraint "PK_TaiXe" primary key (MaTaiXe)

)
go
--Hop dong
create table HopDong(
	MaHopDong			char(9)		not null,
	ThoiGianHieuLuc		date		not null,
	PhanTramHoaHong		real		not null,
	NgayKy				date		not null,
	PhiKichHoat			real		not null,
	MaNhanVienPhuTrach	char(9)		,
	MaDoiTac			char(9)		not null,
	constraint "PK_HOPDONG" primary key (MaHopDong),


	constraint chk_hopdong check(NgayKy<ThoiGianHieuLuc)
)
go

--Doanh thu chi nhanh
create table DoanhThuChiNhanh(
	Ngay date,
	MaChiNhanh char(5) not null,
	MaDoiTac char(9) not null,
	DoanhThu real ,
	SLDon int ,
	constraint "PK_DoanhThuChiNhanh" primary key (Ngay, MaChiNhanh, MaDoiTac),


	constraint check_doanhthuchinhanh check(DoanhThu>=0 and SLDon>=0)

)
go


--Don hang
create table DonHang (
	MaDonHang			char(10)		not null,
	PhiDonHang			real			,
	HinhThucThanhToan	nvarchar(10)	,
	DCGiaoHang			nvarchar(80)	,
	PhiVanChuyen		real			,
	NgayLap				date			not null        ,
	MaTaiXe				char(9)			,
	MaKhachHang			char(8)			not null,
	MaKhuVuc			char(4)			,
	MaDoiTac			char(9),
	MaChiNhanh			char(5),
	TenDoiTac	        nvarchar(80)
	constraint "PK_DonHang" primary key (MaDonHang)


	
)
go
create table TinhTrangDonHang(
	MaDonHang			char(10)		not null unique,
	TinhTrangDonHang	nvarchar(20)	not null,
)
--Bang danh gia
create table BangDanhGia(
	MaThucDon		int			not null,
	MaKhachHang		char(8)		not null,
	Rate			int						,
	"Like"			bit						,
	Comment			nvarchar(150)			,

	constraint "PK_BangDanhGia" primary key (MaThucDon, MaKhachHang),

	constraint "FK_BANGDANHGIA_KHACHHANG"
	foreign key (MaKhachHang)
	references KhachHang(MaKhachHang) on delete cascade,

	constraint "FK_BANGDANHGIA_THUCDON"
	foreign key (MaThucDon)
	references ThucDon(MaThucDon) on delete cascade
)
GO

-- constraint fk
------------------->>



ALTER TABLE NHANVIEN
	ADD constraint "FK_NhanVien_TaiKhoan"
	foreign key (TaiKhoanNV)
	references TaiKhoan (TenTaiKhoan) on delete cascade
GO

ALTER TABLE DOITAC
 ADD constraint "FK_DoiTac_TaiKhoan"
	foreign key (TenTaiKhoanDT)
	references TaiKhoan (TenTaiKhoan) on delete cascade
GO

ALTER TABLE KHACHHANG
   ADD	constraint "FK_KhachHang_TaiKhoan"
	foreign key (TenTaiKhoanKH)
	references TaiKhoan (TenTaiKhoan) on delete cascade
GO
ALTER TABLE CHINHANH
	ADD 	constraint "FK_ChiNhanh_DoiTac"
	foreign key (MaDoiTac)
	references "DoiTac" (MaDoiTac)
GO

ALTER TABLE CHITIETDONHANG
	ADD constraint "FK_CHITIETDONHANG_THUCDON"
	foreign key (MaThucDon)
	references ThucDon(MaThucDon),

	constraint "FK_CHITIETDONHANG_DONHANG"
	foreign key (MaDonHang)
	references DonHang(MaDonHang)
GO

ALTER TABLE TAIXE
 ADD 
	constraint "FK_TAIXE_NHANVIEN"
	foreign key (NhanVienQuanLy)
	references NhanVien(MaNhanVien),

constraint "FK_TAIXE_KHUVUC"
	foreign key (MaKhuVuc)
	references KhuVuc(MaKhuVuc),

constraint "FK_TAIXE_TAIKHOAN"
	foreign key (TenTaiKhoanTaiXe)
	references TaiKhoan(TenTaiKhoan)
GO

ALTER TABLE dbo.HopDong
ADD 	constraint "FK_HOPDONG_NHANVIEN"
	foreign key (MaNhanVienPhuTrach)
	references NhanVien(MaNhanVien),

	constraint "FK_HOPDONG_DOITAC"
	foreign key (MaDoiTac)
	references DoiTac(MaDoiTac)
GO

ALTER TABLE dbo.DoanhThuChiNhanh
ADD 
	constraint "FK_DoanhThuChiNhanh_ChiNhanh"
	foreign key (MaChiNhanh, MaDoiTac)
	references ChiNhanh(MaChiNhanh, MaDoiTac)
GO

ALTER TABLE dbo.DonHang
ADD 	constraint "FK_DONHANG_TAIXE"
	foreign key (MaTaiXe)
	references TaiXe(MaTaiXe),

	constraint "FK_DONHANG_KHACHHANG"
	foreign key (MaKhachHang)
	references KhachHang(MaKhachHang),

	constraint "FK_DONHANG_KHUVUC"
	foreign key (MaKhuVuc)
	references KhuVuc(MaKhuVuc),

	constraint "FK_DONHANG_CHINHANH"
	foreign key (MaChiNhanh,MaDoiTac)
	references ChiNhanh(MaChiNhanh,MaDoiTac)
GO

ALTER TABLE dbo.ThucDon
ADD 	constraint "FK_TD_TX"
	foreign key (MaChiNhanh, MaDoiTac)
	references dbo.ChiNhanh(MaChiNhanh, MaDoiTac)
GO
