 

CREATE DATABASE QLVDV
GO
USE QLVDV
GO
-- Tạo các TABLE

-- Drop Table tlbThanhvien
CREATE TABLE tlbThanhvien
	( 
		MaThanhVien		nvarchar(15) not null Primary key,
		HoTen		nvarchar(255) not null,
		NgaySinh    date not null,
		GioiTinh    nvarchar(10) not null,
		DonVi       nvarchar(20) ,
		SoThich     nvarchar(100) not null,
		DiaChi		nvarchar(255) not null,
		DienThoai	nvarchar(15) ,
		QuyenHan	nvarchar(15)
	)
GO  

-- Drop Table tlbHoatDong
CREATE TABLE tlbHoatDong
	( 
		MaHoatDong	nvarchar(15) not null Primary key,
		TenHoatDong	nvarchar(255) not null,
		NoiDung		nvarchar(255) not null,
		ThoiGian    text,
		KinhPhi     decimal(18,0)
	)
GO  

-- Drop Table tlbPhieu
CREATE TABLE tlbPhieu	
(
	Mahoatdong	NVARCHAR(15) Foreign key references tlbHoatDong(MaHoatDong)
											ON DELETE CASCADE
											ON UPDATE CASCADE,  
	Mathanhvien NVARCHAR(15) Foreign key references tlbThanhvien(MaThanhVien)
											ON DELETE CASCADE
											ON UPDATE CASCADE, 
	ThoigianBD	date,
	ThoigianKT  date,
	Danhgia     text
)
GO   

 
 
--------------------  NHAP DU LIEU MAU ------------------------------------------------------------
INSERT INTO tlbThanhvien VALUES('TV01',N'Nguyen Huu Tuan',N'12/03/1999',N'Nam',N'PNV',N'Da bong',N'Da Nang',N'0909990909','1') --1
INSERT INTO tlbThanhvien VALUES('TV02',N'Nguyen Huu Long',N'11/03/1999',N'Nu',N'PNV',N'Nhay Day',N'Da Nang',N'0123456789','2') --2
INSERT INTO tlbThanhvien VALUES('TV03',N'Nguyen Van Quan',N'01/10/1999',N'Nam',N'PNV',N'Da bong',N'Da Nang',N'0122742455','1') --3
GO
-- Select * From tlbThanhvien ;   

INSERT INTO tlbHoatDong VALUES('DB',N'Da Bong',N'Cac thanh vien se duoc tham gia hoat dong da bong hang tuan',N'1 thang','500000'); -- 1
INSERT INTO tlbHoatDong VALUES('DS',N'Doc Sach',N'Cac thanh vien se duoc tham gia hoat dong doc sach hang tuan',N'1 thang','800000'); -- 1
Go

 -- Select * From tlbHoatDong


INSERT INTO tlbPhieu VALUES('DB',N'TV01',N'12/05/2019',N'12/06/2019','Tot'); -- 1
INSERT INTO tlbPhieu VALUES('DB',N'TV02',N'12/05/2019',N'01/06/2019','Tot'); -- 2
INSERT INTO tlbPhieu VALUES('DS',N'TV03',N'6/05/2019',N'7/06/2019','Tot'); -- 3
 Go
 -- Select * From tlbPhieu