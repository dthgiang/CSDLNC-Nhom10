
create 
--alter
proc updateThongtin 
@iddoitac char(9),
@masothue varchar(30),
@tendoitac varchar(70),
@tennguoidaidien nvarchar(40)
as 
begin tran
	begin try
		update DoiTac 
		set MaSoThue=@masothue , TenDoiTac=@tendoitac, TenNguoiDaiDien=@tennguoidaidien
		where MaDoiTac=@iddoitac
	end try
	begin catch
		rollback tran
	end catch
commit tran

go

CREATE 
--alter 
FUNCTION dbo.auto_id_chinhanh()
RETURNS char(5)
AS
BEGIN
	DECLARE @ID char(5)
	DECLARE @COUNT INT
	SELECT @COUNT = MAX(RIGHT(MaChiNhanh, 5)) FROM chinhanh
	SELECT @ID =  CONVERT(CHAR, CONVERT(INT, @COUNT) + 1)
	RETURN @ID
END
go
create 
--alter
proc themChinhanh
@madoitac char(9),
@diachi nvarchar(30),
@tennh char(9),
@stk char(9),
@tenchinhanh nvarchar(30)
as 
begin tran
	begin try
		declare @macn char(5)
		set @macn=dbo.auto_id_chinhanh()
		insert into chinhanh(machinhanh,madoitac,dcchinhanh,TenNganHang,sotaikhoan,tenchinhanh)
		values(@macn,@madoitac,@diachi,@tennh,@stk,@tenchinhanh)
	end try
	begin catch
		rollback tran
	end catch
commit tran
go
create 
--alter
proc updateMonan
@mieuta nvarchar(250),
@gia real,
@tenmon nvarchar(50),
@loaiamthuc nvarchar(20),
@id_doitac char(9),
@id_chinhanh char(5)
as
begin tran
	begin try
		update thucdon
		set tenmonan=@tenmon , mieuta=@mieuta, gia=@gia, loaiamthuc=@loaiamthuc 
		where tenmonan=@tenmon and madoitac=@id_doitac and machinhanh=@id_chinhanh
	end try
	begin catch
		rollback tran
	end catch
commit tran
go
create 
--alter
proc themMonan
@mathucdon int,
@machinhanh char(5),
@madoitac char(9),
@tenmonan nvarchar(80),
@mieuta nvarchar(256),
@gia real,
@loaiamthuc nvarchar(20)
as
begin tran
	begin try
	insert into thucdon (mathucdon, machinhanh, madoitac, tenmonan, mieuta, gia, loaiamthuc)
	values(@mathucdon, @machinhanh, @madoitac, @tenmonan, @mieuta, @gia, @loaiamthuc)
	end try
	begin catch
		rollback tran
	end catch
commit tran


go



create
--alter
proc xemThucDon
@iddt char(9),
@idcn char(5)
as 
begin 
	select mathucdon,tenmonan,mieuta,gia,ratetb,sllike,loaiamthuc,tinhtrangmon from thucdon  where machinhanh=@idcn and madoitac=@iddt
end 


go

-----------------------------------------------------------------------------------------------------------------------------------------
CREATE 
--alter 
FUNCTION dbo.auto_idkhachhang()
RETURNS char(8)
AS
BEGIN
	DECLARE @ID char(8)
	DECLARE @COUNT INT
	SELECT @COUNT = MAX(RIGHT(makhachhang, 8)) FROM khachhang
	SELECT @ID = CONVERT(CHAR, CONVERT(INT, @COUNT) + 1)
	RETURN @ID
END
go
--đăng ký
create 
--alter
proc sp_signup @tentaikhoan varchar(30), @matkhau varchar(40), @hoten nvarchar(50), @sdt char(10), @diachi varchar(100), @email varchar(100)
as
begin tran
		begin try
			declare @makh char(10)
			set @makh=dbo.auto_idkhachhang()
			insert taikhoan values (@tentaikhoan,@hoten,@matkhau,@sdt,@diachi,@email, 'Khach hang')
			insert khachhang values (@makh, @tentaikhoan)
		end try
		begin catch
			rollback tran
		end catch
commit tran
select * from taikhoan

---Chức năng đăng nhập
go

create 
--alter
proc sp_login @username nvarchar(50), @password char(20) 
as
	declare @loaitk nvarchar(50)
	set @loaitk=(select loaitaikhoan from taikhoan where taikhoan.tentaikhoan=@username and taikhoan.matkhau=@password )
	if @loaitk='Khach hang'
	begin
		select loaitaikhoan, makhachhang from taikhoan join khachhang on taikhoan.tentaikhoan=khachhang.tentaikhoankh and taikhoan.tentaikhoan=@username and taikhoan.matkhau=@password
	end
	else if @loaitk='Tai xe' 
	begin
		select loaitaikhoan, mataixe from taikhoan join taixe  on taikhoan.tentaikhoan=taixe.tentaikhoantaixe and taikhoan.tentaikhoan=@username and taikhoan.matkhau=@password
	end
	else if @loaitk='Nhan vien' 
	begin
		select loaitaikhoan, manhanvien from taikhoan join nhanvien on taikhoan.tentaikhoan=nhanvien.taikhoannv and taikhoan.tentaikhoan=@username and taikhoan.matkhau=@password
	end
	else if @loaitk='Doi tac'
	begin
		select loaitaikhoan, madoitac from taikhoan join doitac on taikhoan.tentaikhoan=doitac.tentaikhoandt and taikhoan.tentaikhoan=@username and taikhoan.matkhau=@password
	end
	---Xem danh sách quán
exec sp_login 'nv1','123'
select * from TaiKhoan
create 
--alter
proc xemdsdoitac
as  select tendoitac, ratetb from doitac
go

--tao id_donhang tu dong 
CREATE 
--alter 
FUNCTION dbo.auto_iddonhang()
RETURNS char(10)
AS
BEGIN
	DECLARE @ID char(10)
	DECLARE @COUNT INT
	SELECT @COUNT = MAX(RIGHT(MaDonHang, 10)) FROM DonHang
	SELECT @ID = CONVERT(CHAR, CONVERT(INT, @COUNT) + 1)
	RETURN @ID
END
go
-- tạo chi tiết đơn hàng tạm thời
print dbo.auto_iddonhang()
delete DonHang where MaDonHang='DH08'
create
--alter
proc taoctdonhang @mathucdon char(10), @madonhang char(10), @soluong int, @tuychon nvarchar(50)
as
	begin tran
	begin try
		insert into ChiTietDonHang(mathucdon, MaDonHang, slmon, tuychon) values (@mathucdon,@madonhang,@soluong,@tuychon)
	end try
	begin catch
		rollback tran
	end catch
commit tran
go

print dbo.auto_iddonhang()
--tao don hang tam thoi
create 
--alter
proc taodonhang @makh char(8), @madoitac char(9)
as
begin tran
	begin try
		declare @madonhang char(10)
		set @madonhang = dbo.auto_iddonhang()
		declare @ngay date
		set @ngay = CURRENT_TIMESTAMP 

		insert DonHang(MaDonHang, NgayLap ,MaKhachHang, MaDoiTac) values(@madonhang, @ngay ,@makh, @madoitac)
		select MaDonHang from DonHang where MaDonHang=@madonhang
	end try
	begin catch
		rollback tran
	end catch
commit tran
go
select * from DonHang
exec taodonhang 'kh1','dt1'

select * from DonHang
-- hủy đơn hàng tạm thời( giỏ hàng)
create 
--alter 
proc huydonhang @id_donhang char(10)
as 
	begin try
		delete DonHang where MaDonHang=@id_donhang
	end try
	begin catch
		rollback tran
	end catch 
exec huydonhang 'DH03'
go
create 
--alter
proc tinhtongdonhang @id_donhang char(10)
as
	begin
		select sum(slmon*gia) as 'Tong' from ChiTietDonHang ct join thucdon td on ct.mathucdon=td.mathucdon and MaDonHang=@id_donhang
	end
EXEC tinhtongdonhang 'DH03'
go
select * from ChiTietDonHang
create 
--alter
proc update_donhang @id_donhang char(10), @id_doitac char(9), @id_chinhanh char(5)
as
	begin try
		declare @phivanchuyen real
		set @phivanchuyen =15000

		declare @tongdonhang real 
		set @tongdonhang = (select sum(slmon*gia) as 'Tong' from ChiTietDonHang ct join thucdon td on ct.mathucdon=td.mathucdon and MaDonHang=@id_donhang)

		set @tongdonhang= @tongdonhang+@phivanchuyen 

		declare @diachinhanhang nvarchar(80)
		set @diachinhanhang= (select DCChiNhanh from ChiNhanh where MaChiNhanh=@id_chinhanh and MaDoiTac=@id_doitac)
		update DonHang 
		set PhiVanChuyen=@phivanchuyen , PhiDonHang=@tongdonhang, DCNhanHang=@diachinhanhang, MaChiNhanh=@id_chinhanh
		where MaDonHang=@id_donhang

	end try
	begin catch
		rollback tran
	end catch
select * from DonHang
go
create 
--alter
proc hoantatdonhang @id_donhang char(10), @httt nvarchar(10), @diachi nvarchar(80)
as
	begin try
		update DonHang 
		set HinhThucThanhToan=@httt, DCGiaoHang=@diachi
		where MaDonHang=@id_donhang
		insert TinhTrangDonHang values(@id_donhang, N'Chờ nhận')
	end try
	begin catch
		rollback tran
	end catch
exec hoantatdonhang '5',null,'fdfd'
select * from DonHang
create 
--alter
proc donhang_dangduocthuchien @makh char(8)
as
	select MaDonHang from DonHang where MaKhachHang=@makh and DATEDIFF(day, ngaylap, CURRENT_TIMESTAMP) <5
--truy vấn những đang hàng đang được thực hiện
create 
--alter 
proc tinhtrangdonhang_kh @id_donhang char(10)
as	
	select TinhTrangDonHang from TinhTrangDonHang where MaDonHang=@id_donhang
exec tinhtrangdonhang_kh 'dh1'

--đơn hàng vẫn còn trong thời gian được đánh giá



create 
--alter
proc lichsudonhang @makh char(8)
as
	begin try
		select MaDonHang, HinhThucThanhToan, DCGiaoHang, PhiDonHang from DonHang 
		where makhachhang=@makh  and DATEDIFF(day, ngaylap, CURRENT_TIMESTAMP) <30 
	end try
	begin catch
	end catch
-- don hang thanh cong trong bang danh gia cua khach hang
create 
--alter 
proc donhang_thanhcong @makh char(8)
as 
	select MaDonHang from DonHang dh where MaKhachHang=@makh and DATEDIFF(day, ngaylap, CURRENT_TIMESTAMP) <5 and exists (select * from TinhTrangDonHang where MaDonHang=dh.MaDonHang and TinhTrangDonHang=N'Hoàn tất')

create 
--alter
proc monantrongdonhang @iddonhang char(10)
as
	select tenmonan, convert(char,td.mathucdon)  'mathucdon' from ThucDon td join  ChiTietDonHang ct on ct.MaDonHang=@iddonhang and td.MaThucDon=ct.MaThucDon
select * from bangdanhgia
create 
--alter
proc danhgiadonhang @mathucdon int, @makh char(8),@comment nvarchar(150),@like bit, @rate int
as
	begin try
		insert BangDanhGia values (@mathucdon,@makh, @rate, @like, @comment)

		update thucdon
		set RateTB= (select avg(rate) from bangdanhgia bdg where bdg.mathucdon=@mathucdon )
		where mathucdon=@mathucdon

		if @like=1
			begin
			update thucdon
			set sllike = sllike+1
			where mathucdon=@mathucdon
			end

	end try
	begin catch
		rollback tran
	end catch
select * from bangdanhgia
exec danhgiadonhang '5','kh1',N'ferg','1','5'
delete bangdanhgia where mathucdon='2'
select * from thucdon
--chức năng: danh sách đơn hàng của 1 khu vực
create
--alter
proc dsdonhang @id_khuvuc char(4)
as
	select MaDonHang, makhachhang , hinhthucthanhtoan, phivanchuyen, PhiDonHang, 
		dcgiaohang, DCNhanHang  from DonHang where mataixe is null and makhuvuc=@id_khuvuc


create 
--alter
proc thongtinkhachhang @makh char(8)
as
		select hovaten, SoDienThoai, diachi, email from taikhoan tk join khachhang kh on kh.makhachhang=@makh and kh.tentaikhoankh = tk.tentaikhoan 


create 
--alter
proc thongtinchinhanh @iddonhang char(10)
as
	select tenchinhanh, dcchinhanh, tinhtrang from DonHang join chinhanh on MaDonHang=@iddonhang and DonHang.MaChiNhanh=chinhanh.machinhanh 
--thiếu tình trạng đon hàng
create 
--alter
proc taixe_nhandon @id_donhang char(10), @matx char(9)
as
	begin try
		update DonHang
		set MaTaiXe=@matx
		where MaDonHang=@id_donhang
		return 0
	end try
	begin catch
	end catch 

create
--alter
proc taixe_chuyentrangthai  @id_donhang char(10)
as
begin tran
	begin try
		declare @tinhtrang nvarchar(20)
		select @tinhtrang=TinhTrangDonHang from TinhTrangDonHang where MaDonHang=@id_donhang 
		if @tinhtrang = N'Chờ nhận'
		begin
			update TinhTrangDonHang 
			set TinhTrangDonHang=N'Đang chuẩn bị'
			where MaDonHang=@id_donhang
		end
		else if @tinhtrang = N'Đang chuẩn bị'
		begin
			update TinhTrangDonHang 
			set TinhTrangDonHang=N'Đang vận chuyển'
			where MaDonHang=@id_donhang
		end
		else if @tinhtrang = N'Đang vận chuyển'
		begin
			update TinhTrangDonHang 
			set TinhTrangDonHang=N'Hoàn tất'
			where MaDonHang=@id_donhang
		end
	end try
	begin catch
		rollback tran
	end catch 
commit tran




exec taixe_tuchoi 'DH05'
select * from [DON HANG]
--chức năng tài xế xem lại lịch sử đơn hàng của mình, phí vận chuyển cho đơn hàng đó
create
--alter
proc dsdonhangdanhan @matx char(10)
as
	begin try
		select MaDonHang, hinhthucthanhtoan, phivanchuyen from DonHang where mataixe=@matx and DATEDIFF(day, ngaylap, CURRENT_TIMESTAMP) <=5
	end try
	begin catch
	end catch 




--NHÂN VIÊN XEM DANH SÁCH HỢP ĐỒNG thiếu rate đối tác
create
--alter
proc dshopdong 
as
	select mahopdong, ThoiGianHieuLuc, manhanvienphutrach , phihoahong, dt.tendoitac, dt.masothue, ratetb, tennguoidaidien  from hopdong hd join doitac dt on hd.madoitac=dt.madoitac and manhanvienphutrach!=null
	order by ThoiGianHieuLuc asc
exec dshopdong
create 
--alter
proc dshopdong_chuaduyet
as
	select mahopdong,phihoahong, dt.tendoitac, dt.masothue, ratetb, tennguoidaidien  from hopdong hd join doitac dt on hd.madoitac=dt.madoitac and manhanvienphutrach=null

create 
--alter
proc duyethopdoong @id_nhanvien char(9), @id_hopdong char(9)
as
begin tran
	begin try
	update hopdong
	set manhanvienphutrach=@id_nhanvien 
	where mahopdong=@id_hopdong
	end try
	begin catch
		rollback tran
	end catch
commit tran

create 
--alter
proc giahanhopdong @id_hophong char(9), @ngayhieuluc date
as
begin tran
	begin try
	update HopDong 
	set ThoiGianHieuLuc=@ngayhieuluc
	where MaHopDong=@id_hophong
	end try
	begin catch
		rollback tran
	end catch
commit tran


create 
--alter
proc updatekhachhang @id_khachhang char(8), @hoten nvarchar(50), @sdt char(10),@diachi nvarchar(80), @email varchar(100)
as 
	begin tran
		begin try
			declare @tentk varchar(30)
			set @tentk=(select tentaikhoankh from khachhang where makhachhang=@id_khachhang)

			update taikhoan 
			set hovaten=@hoten, sodienthoai=@sdt, diachi=@diachi, Email=@email
			where tentaikhoan=@tentk
		end try
		begin catch
			rollback tran
		end catch
	commit tran
create 
--alter 
proc thongtindoitac @madt char(9)
as 
	select MaDoiTac, TenDoiTac, MaSoThue, TenNguoiDaiDien, email, SoDienThoai,DiaChi from TaiKhoan join DoiTac on TenTaiKhoanDT=TenTaiKhoan



-- xóa chi nhánh --
create
-- alter
proc xoaChiNhanh @MaChiNhanh char(5)
as
	begin tran
		begin try
			delete from ChiNhanh where MaChiNhanh = @MaChiNhanh
		end try

		begin catch
			rollback tran
		end catch
	commit tran
go

-- xem tài khoản đối tác -- 
create proc xemTK_DoiTac @MaDoiTac char(9)
as
begin tran
	begin try
		select * from TaiKhoan
		where TenTaiKhoan = (
			select TenTaiKhoanDT from DoiTac
			where MaDoiTac = @MaDoiTac
		)
	end try

	begin catch
		rollback
	end catch
	commit
go

-- cập nhật thông tin tài khoản đối tác --
create 
-- alter 
proc update_doitac @MaDoiTac char(9), @HoVaTen nvarchar(50), @email varchar(100), @DiaChi nvarchar(80), @SoDienThoai char(11)
as
begin tran
	begin try
		update TaiKhoan
		set Email = @email, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, HoVaTen = @HoVaTen
		where TenTaiKhoan = (select TenTaiKhoanDT from DoiTac where MaDoiTac = @MaDoiTac)
	end try

	begin catch
		rollback
	end catch
commit
go

-- thống kê doanh thu theo chi nhánh --
create 
--alter
proc doanhthu @madoitac char(9), @MaChiNhanh char(5), @Tungay date, @Denngay date
as
begin tran
	begin try
		select * from DoanhThuChiNhanh
		where Ngay >= @Tungay and Ngay <= @Denngay and MaChiNhanh = @MaChiNhanh and MaDoiTac=@madoitac
	end try

	begin catch
		rollback
	end catch
commit
go

create 
--alter 
proc update_chinhanh 
@madt char(9),
@machinhanh char(5),
@tenchinhanh nvarchar(30),
@tennh char(9),
@stk char(9)
as
begin tran
	begin try
		update chinhanh set tenchinhanh=@tenchinhanh, TenNganHang=@tennh, sotaikhoan=@stk
		where madoitac=@madt and machinhanh=@machinhanh
	end try
	begin catch
		rollback tran
	end catch
commit tran
