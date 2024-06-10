create database QLChungCu
go 
use QLChungCu

create table CanHo(
	MaCH varchar(8) primary key,
	DienTich decimal,
	SoPhongNgu int,
	SoPhongVeSinh int,
	SoTang int,
	TinhTrang nvarchar(50),
);

create table CuDan(
	MaCD varchar(8) primary key,
	HoTen nvarchar(50),
	NgaySinh date,
	QueQuan nvarchar(100),
	SoDienThoai varchar(10),
	Email varchar(30),
	MaCH varchar(8),
	constraint fk_CuDan_CanHo foreign key (MaCH) references CanHo(MaCH)
);

create table NhanVien(
	MaNV varchar(8) primary key,
	HoTen nvarchar(50),
	NgaySinh date,
	QueQuan nvarchar(100),
	SoDienThoai varchar(10),
	Email varchar(30),
	ChucVu nvarchar(50),
);
create table ThongBao(
	MaTB varchar(8) primary key,
	TieuDe nvarchar(50),
	ThoiGian date,
	NoiDung nvarchar(500),
	TrangThai nvarchar(30)
);

create table ChiTietThongBaoCuDan(
	MaTB varchar(8),
	MaCD varchar(8),
	constraint pk_ChiTietThongBaoCuDan primary key (MaTB, MaCD),
	constraint fk_ChiTietThongBaoCuDan_ThongBao foreign key (MaTB) references ThongBao(MaTB),
	constraint fk_ChiTietThongBaoCuDan_CuDan foreign key (MaCD) references CuDan(MaCD)
);

create table ChiTietThongBaoNhanVien(
	MaTB varchar(8),
	MaNV varchar(8),
	constraint pk_ChiTietThongBaoNhanVien primary key (MaTB, MaNV),
	constraint fk_ChiTietThongBaoNhanVien_ThongBao foreign key (MaTB) references ThongBao(MaTB),
	constraint fk_ChiTietThongBaoNhanVien_NhanVien foreign key (MaNV) references NhanVien(MaNV)
);

create table CongViec(
	MaCV varchar(8) primary key,
	TenCV nvarchar(50),
	NoiDung nvarchar(100),
	NgayBatDau date,
	NgayKetThuc date
);

create table PhanCong(
	MaCV varchar(8),
	MaNV varchar(8),
	constraint pk_PhanCong primary key (MaCV, MaNV),
	constraint fk_PhanCong_CongViec foreign key (MaCV) references CongViec(MaCV),
	constraint fk_PhanCong_NhanVien foreign key (MaNV) references NhanVien(MaNV)
);
