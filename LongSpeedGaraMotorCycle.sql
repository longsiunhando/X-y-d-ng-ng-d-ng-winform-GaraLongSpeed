create database BTL_LongSpeedGaraMotorCycle
go

use BTL_LongSpeedGaraMotorCycle
go

create table account
(
	username nvarchar(50) not null primary key,
	displayname nvarchar(100) not null default N'Biker',
	pass nvarchar(50) not null,
	email nvarchar(111) not null,
	sdt nvarchar(10) not null,
	diaChi nvarchar(111) not null,
	type int not null default 0 --1:admin; 0:staff
)
go
insert into account
values(N'1',N'1',N'1',N'1@gmail.com',N'1111111111',N'HY',0)
insert into account
values(N'2',N'2',N'2',N'2@gmail.com',N'1111111112',N'HY',0)
insert into account
values(N'3',N'3',N'3',N'3@gmail.com',N'1111111113',N'HY',0)
insert into account
values(N'4',N'4',N'4',N'4@gmail.com',N'1111111114',N'HY',0)
insert into account
values(N'5',N'5',N'5',N'5@gmail.com',N'1111111115',N'HY',0)
insert into account
values(N'6',N'6',N'6',N'6@gmail.com',N'1111111116',N'HN',0)
insert into account
values(N'7',N'7',N'7',N'7@gmail.com',N'1111111117',N'HN',0)
insert into account
values(N'8',N'8',N'8',N'8@gmail.com',N'1111111118',N'HN',0)
insert into account
values(N'9',N'9',N'9',N'9@gmail.com',N'1111111119',N'HN',0)
insert into account
values(N'10',N'10',N'10',N'10@gmail.com',N'1111111110',N'HN',0)
go

create table NV
(
	maNV nvarchar(10) not null primary key,
	tenNV nvarchar(100) not null,
	diaChi nvarchar(100) not null,
	sdt nvarchar(10) not null,
)
go

insert into NV
values(N'NV01',N'Nhân viên 1',N'HY',N'123123442')
insert into NV
values(N'NV02',N'Nhân viên 2',N'HY',N'123123442')
insert into NV
values(N'NV03',N'Nhân viên 3',N'HY',N'123123442')
insert into NV
values(N'NV04',N'Nhân viên 4',N'HY',N'123123442')
insert into NV
values(N'NV05',N'Nhân viên 5',N'HY',N'123123442')
insert into NV
values(N'NV06',N'Nhân viên 6',N'HY',N'123123442')
insert into NV
values(N'NV07',N'Nhân viên 7',N'HY',N'123123442')
insert into NV
values(N'NV08',N'Nhân viên 8',N'HY',N'123123442')
insert into NV
values(N'NV09',N'Nhân viên 9',N'HY',N'123123442')
insert into NV
values(N'NV10',N'Nhân viên 10',N'HY',N'123123442')
go

create table loaiSP
(
	maLoai nvarchar(10) not null primary key,
	tenLoai nvarchar(100) not null,
)
go
	--XM  : xe máy                     LX  : Lốp xe
	--AO  : dàn nhựa                   PGS : Phuộc
	--DL  : Đèn led                    MB  : Mâm bánh
	--BCL : Bi cầu led                 GX  : Gương
	--BL  : Bi Lazer                   XN  : Xin nhan
	--YX  : Yên xe                     CP  : Cùm côn, tay phanh
	--SPK : Sản phẩm khác
insert into loaiSP(maLoai, tenLoai)
values(N'XM', N'Xe máy')
insert into loaiSP(maLoai, tenLoai)
values(N'AO', N'Dàn áo')
insert into loaiSP(maLoai, tenLoai)
values(N'DL', N'Đèn led')
insert into loaiSP(maLoai, tenLoai)
values(N'BCL', N'BCL')
insert into loaiSP(maLoai, tenLoai)
values(N'BL', N'Bi Lazer')
insert into loaiSP(maLoai, tenLoai)
values(N'YX', N'Yên xe')
insert into loaiSP(maLoai, tenLoai)
values(N'LX', N'Lốp xe')
insert into loaiSP(maLoai, tenLoai)
values(N'MB', N'Mâm bánh')
insert into loaiSP(maLoai, tenLoai)
values(N'GX', N'Gương xe')
insert into loaiSP(maLoai, tenLoai)
values(N'PGS', N'Phuộc, Giảm xóc')
insert into loaiSP(maLoai, tenLoai)
values(N'Xn', N'Xin nhan')
insert into loaiSP(maLoai, tenLoai)
values(N'CP', N'Cùm côn, tay phanh')
insert into loaiSP(maLoai, tenLoai)
values(N'SPK', N'Linh tinh')
go

create table SP
(
	maSP nvarchar(10) not null primary key,
	tenSP nvarchar(100) not null,
	soLuong int not null,
	giaNhap float not null,
	giaBan float not null,
	maLoai nvarchar(10) not null, 
	foreign key (maLoai) references loaiSP(maLoai)
)
go

insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'1002A', N'Exciter 150', 0, 42000000, 45900000, N'XM')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'1030B', N'Exciter 155', 0, 45500000, 51300000, N'XM')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'1096A', N'Winner X V2', 0, 36500000, 3900000, N'XM')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'2795Q', N'Dán nhựa nhám Exciter 150 2019', 0, 850000, 1200000, N'AO')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'7895f', N'Đèn Led zinfat', 0, 350000, 479000, N'DL')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'5365f', N'Bi gầm M10', 0, 1700000, 2100000, N'BCL')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'7825f', N'KUS 4TH Mini lens ', 0, 2800000, 3500000, N'BL')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'7643f', N'Yên Solo X1r', 0, 350000, 400000, N'YX')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'9183N', N'Michelin 140_80', 0, 500000, 560000, N'LX')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'9364J', N'MonoShock Olinn',0 , 1000000, 1999000, N'PGS')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'8263G', N'Mâm 3 đao', 0, 350000, 500000, N'MB')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'8475D', N'Gương gù X1R', 0, 15000, 45000, N'GX')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'9273C', N'Xin nhan Spirit', 0, 57000, 80000, N'XN')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'2947H', N'Cùm phanh côn RaccingBoy', 0, 3500000, 4790000, N'CP')
insert into SP (maSP, tenSP, soLuong, giaNhap, giaBan, maLoai)
values(N'8365X', N'Ốc ti tan 7 màu', 0, 15000, 20000, N'SPK')
go

create table KH
(
	maKH nvarchar(10) not null primary key,
	tenKH nvarchar(100) not null default N'Thượng đế',
	diachi nvarchar(100) not null default N'Trống',
	sdt nvarchar(10) not null default N'Trống',
)
go


insert into KH
values(N'KH01',N'Khách hàng số 1', N'HY','123123123')
insert into KH
values(N'KH02',N'Khách hàng số 2', N'HY','123321321')
insert into KH
values(N'KH03',N'Khách hàng số 3', N'HY','123245453')
insert into KH
values(N'KH04',N'Khách hàng số 4', N'HY','123145353')
insert into KH
values(N'KH05',N'Khách hàng số 5', N'HY','123122352')
insert into KH
values(N'KH06',N'Khách hàng số 6', N'HN','123125673')
insert into KH
values(N'KH07',N'Khách hàng số 7', N'HN','123123463')
insert into KH
values(N'KH08',N'Khách hàng số 8', N'HN','123234793')
insert into KH
values(N'KH09',N'Khách hàng số 9', N'HN','123867523')
insert into KH
values(N'KH10',N'Khách hàng số 10', N'HN','123123823')
go

create table HDB
(
	maHDB nvarchar(10) not null primary key,
	maKH nvarchar(10) not null ,
	maNV nvarchar(10) not null ,
	maSP nvarchar(10) not null,
	soLuong int not null,
	giaBan float not null,
	thanhTien float not null,
	thoiGianB datetime not null
	foreign key (maSP) references SP(maSP),
	foreign key (maKH) references KH(maKH),
	foreign key (maNV) references NV(maNV),
)
go
insert into HDB
values(N'1',N'KH01',N'NV01',N'1002A',N'1',N'18',N'19',2021/1/23)
insert into HDB
values(N'2',N'KH02',N'NV02',N'1002A',N'2',N'18',N'19',2021/2/23)
insert into HDB
values(N'3',N'KH03',N'NV03',N'1002A',N'3',N'18',N'19',2021/3/23)
insert into HDB
values(N'4',N'KH04',N'NV04',N'1002A',N'4',N'18',N'19',2021/4/23)
insert into HDB
values(N'5',N'KH05',N'NV05',N'1002A',N'5',N'18',N'19',2021/5/23)
insert into HDB
values(N'6',N'KH06',N'NV06',N'1002A',N'6',N'18',N'19',2021/6/23)
insert into HDB
values(N'7',N'KH07',N'NV07',N'1002A',N'7',N'18',N'19',2021/7/23)
insert into HDB
values(N'8',N'KH08',N'NV08',N'1002A',N'8',N'18',N'19',2021/8/23)
insert into HDB
values(N'9',N'KH09',N'NV09',N'1002A',N'9',N'18',N'19',2021/9/23)
insert into HDB
values(N'10',N'KH10',N'NV10',N'1002A',N'10',N'18',N'19',2021/10/23)
go

create table NCC
(
	maNCC nvarchar(10) not null primary key,
	tenNCC nvarchar(100) not null,
	diaChi nvarchar(100) not null,
	sdt nvarchar(10) not null,
)
go

insert into NCC
values(N'NCC01',N'Nhà cung cấp 1', N'HY',N'123123123')
insert into NCC
values(N'NCC02',N'Nhà cung cấp 2', N'HY',N'123423123')
insert into NCC
values(N'NCC03',N'Nhà cung cấp 3', N'HY',N'123423443')
insert into NCC
values(N'NCC04',N'Nhà cung cấp 4', N'HY',N'123735123')
insert into NCC
values(N'NCC05',N'Nhà cung cấp 5', N'HY',N'122343123')
insert into NCC
values(N'NCC06',N'Nhà cung cấp 6', N'HY',N'128456323')
insert into NCC
values(N'NCC07',N'Nhà cung cấp 7', N'HY',N'123125123')
insert into NCC
values(N'NCC08',N'Nhà cung cấp 8', N'HY',N'128354323')
insert into NCC
values(N'NCC09',N'Nhà cung cấp 9', N'HY',N'127245123')
insert into NCC
values(N'NCC10',N'Nhà cung cấp 10', N'HY',N'12353123')
go

create table HDN
(
	maHDN nvarchar(10) not null primary key,
	maNCC nvarchar(10) not null ,
	maNV nvarchar(10) not null,
	maSP nvarchar(10) not null,
	soLuong int not null,
	giaNhap float not null,
	thanhTien float,
	thoiGianN datetime,
	foreign key (maSP) references SP(maSP),
	foreign key (maNCC) references NCC(maNCC),
	foreign key (maNV) references NV(maNV),
)
go

insert into HDN
values(N'1',N'NCC01',N'NV01',N'1002A',N'1',N'18',N'19',2022/1/23)
insert into HDN
values(N'2',N'NCC02',N'NV02',N'1002A',N'2',N'18',N'19',2022/2/23)
insert into HDN
values(N'3',N'NCC03',N'NV03',N'1002A',N'3',N'18',N'19',2022/3/23)
insert into HDN
values(N'4',N'NCC04',N'NV04',N'1002A',N'4',N'18',N'19',2022/4/23)
insert into HDN
values(N'5',N'NCC05',N'NV05',N'1002A',N'5',N'18',N'19',2022/5/23)
insert into HDN
values(N'6',N'NCC06',N'NV06',N'1002A',N'6',N'18',N'19',2022/6/23)
insert into HDN
values(N'7',N'NCC07',N'NV07',N'1002A',N'7',N'18',N'19',2022/7/23)
insert into HDN
values(N'8',N'NCC08',N'NV08',N'1002A',N'8',N'18',N'19',2022/8/23)
insert into HDN
values(N'9',N'NCC09',N'NV09',N'1002A',N'9',N'18',N'19',2022/9/23)
insert into HDN
values(N'10',N'NCC10',N'NV10',N'1002A',N'10',N'18',N'19',2022/10/23)
go




insert into account
(
	username ,
	displayname,
	pass,
	email,
	sdt,
	diaChi,
	type
)
values
(
	N'admin',
	N'Long Chồi Non',
	N'admin',
	N'longchoinon@gmail.com',
	N'0999999999',
	N'HY',
	1
)



---- Quản lí người dùng
---- 1: Tạo login
--exec sp_addlogin quanli1,'ql1'
--exec sp_addlogin quanli2,'ql2'
--exec sp_addlogin nhanvien1,'nv1'
--exec sp_addlogin nhanvien2,'nv2'
--exec sp_addlogin  nhanvien3,'nv3'
--exec sp_addlogin nhanvien4,'nv4'

---- 2: Tạo user
--exec sp_adduser quanli1 , quanli1
--exec sp_adduser quanli2 , quanli2
--exec sp_adduser nhanvien1 , nhanvien5
--exec sp_adduser nhanvien2 , nhanvien2
--exec sp_adduser nhanvien3 ,nhanvien3
--	exec sp_adduser nhanvien4 , nhanvien4

----- Tạo nhóm
--Exec sp_addrole quanli
--exec sp_addrole nhanvien

---- Thêm các user vào role
--exec sp_addrolemember quanli, quanli1
--exec sp_addrolemember quanli , quanli2
--exec sp_addrolemember nhanvien , nhanvien2
--exec sp_addrolemember nhanvien , nhanvien3
--exec sp_addrolemember nhanvien , nhanvien4
--exec sp_addrolemember nhanvien , nhanvien5

---- Cấp quyền cho users
--grant select on Nhanvien To nhanvien5
--grant update , select on khachhang To nhanvien2
--grant select, delete on khachhang To nhanvien3
--grant select , update , delete , insert on khachhang to quanli1
--grant select on nhanvien to nhanvien4
--grant select , update , delete , insert on mathang to quanli2


----- Thu hồi quyền 

--Revoke select , update , delete , insert on khachhang to quanli2





----3. Tìm kiếm dữ liệu theo chỉ mục 
----(tối thiểu 5 chỉ mục và ứng dụng tìm kiếm theo chỉ mục đó: chỉ mục đơn, phức hợp, toàn văn)

----chỉ mục đơn tìm kiếm các HDN có giaNhap lớn hơn 13
--CREATE INDEX idx_HDN_giaNhap ON HDN (giaNhap) WHERE giaNhap > 13;


----chỉ mục đơn tìm kiếm các SP có chữ "ex" trong trường tenSP
--CREATE INDEX idx_SP_tenSP ON SP (tenSP)
--select * from SP where tenSP LIKE N'%ex%';


---- Tạo chỉ mục phức hợp trên cột 'maLoai' và 'giaBan' trong bảng 'SP'
--CREATE INDEX idx_SP_maLoai_giaBan ON SP (maLoai, giaBan);
---- Tìm kiếm các sản phẩm có maLoai = 'L1' và giaBan > 100
--SELECT * FROM SP WHERE maLoai = 'XM' AND giaBan > 45000000;


---- Tạo chỉ mục phức hợp trên cột 'maKH', 'maNV', và 'thoiGianB' trong bảng 'HDB'
--CREATE INDEX idx_HDB_maKH_maNV_thoiGianB ON HDB (maKH, maNV, thoiGianB);
---- Tìm kiếm các hóa đơn bởi khách hàng 'KH001', nhân viên 'NV001'
---- và theo thời gian từ '1899-01-01' đến '2023-06-01'
--SELECT * FROM HDB WHERE maKH = 'KH001' AND maNV = 'NV001' 
--AND thoiGianB BETWEEN '1899-01-01' AND '2023-06-01';


---- Tạo chỉ mục toàn văn trên cột 'tenSP' trong bảng 'SP'
--CREATE FULLTEXT INDEX idx_SP_tenSP ON SP (tenSP);
---- Tìm kiếm các sản phẩm có chứa từ "ex" trong trường 'tenSP'
--SELECT * FROM SP WHERE (tenSP, N'ex');




---- Tạo chỉ mục toàn văn trên cột 'displayname' trong bảng 'account'
--CREATE FULLTEXT INDEX idx_account_displayname ON account (displayname);
---- Tìm kiếm các tài khoản có chứa từ "Biker" trong trường 'displayname'
--SELECT * FROM account WHERE CONTAINS(displayname, 'Biker');


----4. Thiết kế các view (tối thiểu 5 view gồm 2 view  tạo trên 1 bảng, 3 view trên 2 -3 bảng)

---- Tạo view để lấy dữ liệu từ bảng SP
--CREATE VIEW View_SP AS
--SELECT maSP, tenSP, soLuong, giaBan
--FROM SP;
--go
--Select * from View_SP
--go


---- Tạo view để lấy dữ liệu từ bảng KH
--CREATE VIEW View_KH_HaNoi AS
--SELECT maKH, tenKH, diachi, sdt
--FROM KH
--WHERE diachi = 'HN';
--go
--Select * from View_KH_HaNoi
--go


---- Tạo view lấy dữ liệu từ 2 bảng hiển thị thông tin chi tiết về sản phẩm và loại sản phẩm
--CREATE VIEW View_SP_LoaiSP AS
--SELECT SP.maSP, SP.tenSP, SP.soLuong, SP.giaNhap, SP.giaBan, loaiSP.maLoai, loaiSP.tenLoai
--FROM SP
--INNER JOIN loaiSP ON SP.maLoai = loaiSP.maLoai;
--go
--Select * from View_SP_LoaiSP
--go


---- Tạo view lấy dữ liệu từ 2 bảng để hiển thị tổng số lượng sản phẩm theo loại trong kho
--CREATE VIEW View_SoLuongTheoLoai AS
--SELECT maLoai, SUM(soLuong) AS SoLuongTheoLoai
--FROM SP
--GROUP BY maLoai;
--go
--Select * from View_SoLuongTheoLoai
--go


---- Tạo view để lấy dữ liệu từ 3 bảng HDB, KH và NV
--CREATE VIEW View_HDB_KH_NV AS
--SELECT HDB.maHDB, KH.tenKH, NV.tenNV, HDB.thoiGianB
--FROM HDB
--INNER JOIN KH ON HDB.maKH = KH.maKH
--INNER JOIN NV ON HDB.maNV = NV.maNV;
--go
--SELECT * FROM View_HDB_KH_NV;
--go


----5.Viết được truy vấn với các toán tử nâng cao và sử dụng các cấu trúc điều khiển (tối thiểu 15 truy vấn)
----Ít nhất 1 câu truy vấn cho 1 toán tử



----	Hiển thị mã hóa đơn bán, tên khách hàng và mã nhân viên
--SELECT HDB.maHDB, KH.tenKH, NV.tenNV
--FROM HDB
--JOIN KH ON HDB.maKH = KH.maKH
--JOIN NV ON HDB.maNV = NV.maNV;





---- Hiển thị mã sản phẩm, tên sản phẩm và đánh giá đắt hay rẻ
--SELECT maSP, tenSP,
--   CASE
--      WHEN giaBan > 30000000 THEN N'Đắt'
--      WHEN giaBan > 5000000 THEN N'Vừa'
--      ELSE N'Rẻ'
--   END AS PriceCategory
--FROM SP;


----Nối bảng nhân viên với bảng hóa đơn bán
--select  hdb.* , nvv.* from HDB as hdb inner join NV nvv on hdb.MaNV = nvv.MaNV 

----Nối bảng 3 bảng hóa đơn bán, sản phẩm và bảng khách hàng với điều kiện mua trên 8 sản phẩm
--SELECT HDB.maHDB, HDB.maKH, KH.tenKH, SP.tenSP, HDB.soLuong
--FROM HDB
--JOIN SP ON HDB.maSP = SP.maSP
--JOIN KH ON HDB.maKH = KH.maKH
--GROUP BY HDB.maHDB, HDB.maKH, KH.tenKH, SP.tenSP, HDB.soLuong
--HAVING HDB.soLuong > 8;


----Nối bảng loại hàng và bảng mặt hàng có mặt hàng tên là Xe Máy
--select lSP.maLoai, lSP.tenLoai, sp.maSP, sp.tenSP from loaiSP lSP 
--inner join SP as sp on lSP.maLoai = sp.maLoai 
--where lSP.tenLoai ='Xe Máy'

----Hiển thị top 5 mặt hàng có giá bán cao nhất xếp từ cao đến thấp
--SELECT TOP 5 maSP, tenSP, giaBan
--FROM SP
--ORDER BY giaBan DESC;


----Hiển thị 5 mặt hàng có giá bán thấp nhất xếp từ thấp đến cao
--SELECT TOP 5 maSP, tenSP, giaBan
--FROM SP
--ORDER BY giaBan ASC;

----Hiển thị mặt hàng có số lượng tồn trong kho lớn nhất
--select top(1) sp.* from SP sp order by soLuong desc

----Hiển thị mặt hàng bán và tổng tiền bán
--SELECT maHDB, maSP, SUM(soLuong) AS soLuongBan, SUM(thanhTien) AS tongTienBan
--FROM HDB
--GROUP BY maHDB, maSP



----Hiển thị nhân viên bán được hàng nhiều nhất và số lượng bán
--SELECT maNV, SUM(soLuong) AS soLuongBan
--FROM HDB
--GROUP BY maNV
--HAVING SUM(soLuong) = 
--(
--    SELECT MAX(tongSoLuongBan)
--    FROM 
--	(
--        SELECT SUM(soLuong) AS tongSoLuongBan
--        FROM HDB
--        GROUP BY maNV
--    ) AS T
--)

----Hiển thị thông tin về những nhân viên đã bán được hàng với mệnh đề EXISTS
--SELECT *
--FROM NV
--WHERE EXISTS 
--(
--    SELECT *
--    FROM HDB
--    WHERE HDB.maNV = NV.maNV
--)

----Hiển thị loại hàng Gương, Xin nhan, Cùm côn, tay phanh  dùng toán tử In
--select * from loaiSP where tenLoai  in ('Gương xe', 'Xin nhan', 'Cùm côn, tay phanh')

----Hiển thị loại hàng có mặt hàng có số lượng tồn trong khoảng từ 10 đến 20
--select * from loaiSP lSP where lSP.maLoai in (select sp.maSP from SP sp  where
--sp.soLuong between '10' and '20')

----6. Viết được các thủ tục lưu và các hàm đáp ứng các chức năng (tối thiểu 10 thủ tục, 5 hàm)
---- Thủ tục thực hiện chức năng cập nhật, xóa, chèn dữ liệu vào bảng (số lượng: 6)
---- Thủ tục thực hiện chức năng tìm kiếm ((số lượng: 2)
---- Thủ tục thực hiện chức năng thống kê, tính toán (số lượng: 2)


----Thủ tục để chèn dữ liệu vào bảng "account":
--CREATE PROCEDURE InsertAccount
--    @username nvarchar(50),
--    @displayname nvarchar(100),
--    @pass nvarchar(50),
--    @email nvarchar(111),
--    @sdt nvarchar(10),
--    @diaChi nvarchar(111),
--    @type int
--AS
--BEGIN
--    SET NOCOUNT ON;

--    INSERT INTO account (username, displayname, pass, email, sdt, diaChi, type)
--    VALUES (@username, @displayname, @pass, @email, @sdt, @diaChi, @type);
--END;

--exec InsertAccount     
--    @username =N'11',
--    @displayname =N'11',
--    @pass = N'11',
--    @email =N'11',
--    @sdt =N'11',
--    @diaChi =N'HY',
--    @type = 0

--select * from account where username = N'11'
----Thủ tục để cập nhật dữ liệu trong bảng "account":
--CREATE PROCEDURE UpdateAccount
--    @username nvarchar(50),
--    @displayname nvarchar(100),
--    @pass nvarchar(50),
--    @email nvarchar(111),
--    @sdt nvarchar(10),
--    @diaChi nvarchar(111),
--    @type int
--AS
--BEGIN
--    SET NOCOUNT ON;

--    UPDATE account
--    SET displayname = @displayname,
--        pass = @pass,
--        email = @email,
--        sdt = @sdt,
--        diaChi = @diaChi,
--        type = @type
--    WHERE username = @username;
--End;

--exec UpdateAccount    
--    @username =N'11',
--    @displayname =N'12',
--    @pass = N'12',
--    @email =N'12',
--    @sdt =N'12',
--    @diaChi =N'HY',
--    @type = 0

----Thủ tục để xóa dữ liệu khỏi bảng "account":
--CREATE PROCEDURE DeleteAccount
--    @username nvarchar(50)
--AS
--BEGIN
--    SET NOCOUNT ON;

--    DELETE FROM account
--    WHERE username = @username;
--END;

--exec DeleteAccount
--@username = N'11'


----Thủ tục để chèn dữ liệu vào bảng "NV":
--CREATE PROCEDURE InsertNV
--    @maNV nvarchar(10),
--    @tenNV nvarchar(100),
--    @diaChi nvarchar(100),
--    @sdt nvarchar(10)
--AS
--BEGIN
--    SET NOCOUNT ON;

--    INSERT INTO NV (maNV, tenNV, diaChi, sdt)
--    VALUES (@maNV, @tenNV, @diaChi, @sdt);
--END;

--exec InsertNV
--@maNV = N'11',
--@tenNV = N'11',
--@diaChi = N'11',
--@sdt = N'HY'

--select * from NV where maNV = N'11'
----Thủ tục để cập nhật dữ liệu trong bảng "NV":
--CREATE PROCEDURE UpdateNV
--    @maNV nvarchar(10),
--    @tenNV nvarchar(100),
--    @diaChi nvarchar(100),
--    @sdt nvarchar(10)
--AS
--BEGIN
--    SET NOCOUNT ON;

--    UPDATE NV
--    SET tenNV = @tenNV,
--        diaChi = @diaChi,
--        sdt = @sdt
--    WHERE maNV = @maNV;
--END;
--exec UpdateNV
--@maNV = N'11',
--@tenNV = N'12',
--@diaChi = N'12',
--@sdt = N'HY'

----Thủ tục để xóa dữ liệu khỏi bảng "NV":
--CREATE PROCEDURE DeleteNV
--    @maNV nvarchar(10)
--AS
--BEGIN
--    SET NOCOUNT ON;

--    DELETE FROM NV
--    WHERE maNV = @maNV;
--END;

----Thủ tục hiển thị thông tin nhân viên
--CREATE PROCEDURE HienThiNV
--    @maNV nvarchar(10)
--AS
--BEGIN
--    SET NOCOUNT ON;

--    SELECT *
--    FROM NV
--    WHERE maNV = @maNV;
--END;
--go
--Exec HienThiNV N'NV01'


-----Tìm kiếm

----Thủ tục tìm kiếm thông tin nhân viên theo mã nhân viên:
--CREATE PROCEDURE SearchNVByMaNV
--    @maNV nvarchar(10)
--AS
--BEGIN
--    SET NOCOUNT ON;

--    SELECT *
--    FROM NV
--    WHERE maNV = @maNV;
--END;

--exec SearchNVByMaNV
--@maNV = N'NV01'

----Thủ tục tìm kiếm thông tin sản phẩm theo tên sản phẩm:
--CREATE PROCEDURE SearchSPByTenSP
--    @tenSP nvarchar(100)
--AS
--BEGIN
--    SET NOCOUNT ON;

--    SELECT *
--    FROM SP
--    WHERE tenSP LIKE '%' + @tenSP + '%';
--END;

--exec SearchSPByTenSP @tenSP = N'ex'


----Thủ tục để thống kê tổng số lượng sản phẩm trong mỗi loại sản phẩm:
--CREATE PROCEDURE CountProductByCategory
--AS
--BEGIN
--    SET NOCOUNT ON;

--    SELECT loaiSP.tenLoai, COUNT(SP.maSP) AS TongSoLuong
--    FROM loaiSP
--    LEFT JOIN SP ON loaiSP.maLoai = SP.maLoai
--    GROUP BY loaiSP.tenLoai;
--END;

--exec CountProductByCategory

----Thủ tục để tính tổng doanh thu của mỗi nhân viên từ bảng HDB:
--CREATE PROCEDURE CalculateRevenueByEmployee
--AS
--BEGIN
--    SET NOCOUNT ON;

--    SELECT maNV, SUM(thanhTien) AS DoanhThu
--    FROM HDB
--    GROUP BY maNV;
--END;


------Hàm
----Hàm hiển thị maNV, tenNV và số hàng lượng sản phẩm NV đó bán được
--CREATE FUNCTION SoLuongBan()
--RETURNS TABLE
--AS
--RETURN
--    SELECT NV.maNV, NV.tenNV, COUNT(HDB.maSP) AS SoLuongSanPham
--    FROM NV
--    LEFT JOIN HDB ON NV.maNV = HDB.maNV
--    GROUP BY NV.maNV, NV.tenNV;

--SELECT * FROM SoLuongBan();

----Tạo hàm Hiển thị khách có địa chỉ ở HY
--CREATE FUNCTION KH_In_HY()
--RETURNS TABLE
--AS
--RETURN
--    SELECT maKH, tenKH, diachi
--    FROM KH
--    WHERE diachi LIKE N'%HY%';

--select * from KH_In_HY();

----7. Viết được các trigger đảm bảo dữ liệu thỏa mãn thế giới thực (tối thiểu 10 trigger)
---- Trigger after (for) (số lượng: 3 ứng với 3 kiểu bẫy lỗi)
---- Trigger instead of (số lượng: 3 ứng với 3 kiểu bẫy lỗi)
---- Trigger dây truyền (số lượng: 1)
---- Trigger để tự động thực thi việc cập nhật dữ liệu (số lượng: 3)


----Viết trigger không cho phép xóa table trong database
--create trigger NoDelete_table on database
--after drop_table
--as
--begin
--print N'Không thể xóa các bảng do dùng trigger!'
--rollback
--end
----test
--create table nhanvien222(Manv nvarchar(10))
--drop table nhanvien222

----Viết trigger ko cho phép nhập cùng 1 mã loại sản phẩm
--create trigger  insert_lSP on loaiSP
--instead of insert
--as 
--begin
--if(exists(select  maLoai  from inserted where maLoai in (select maLoai from loaiSP)))
--begin
--	print N'Dữ liệu đã tồn tại'
--	rollback tran
--	end
--else
--	insert into loaiSP select * from inserted
--	end
--	go
----test
--insert into loaiSP values ('XM',N'Xe máy' )
--go
--select * from loaiSP




