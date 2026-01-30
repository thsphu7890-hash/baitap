USE master;
GO

-- 1. KIỂM TRA VÀ TẠO DATABASE
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'EmployerDB')
BEGIN
    CREATE DATABASE EmployerDB;
    PRINT 'Database EmployerDB created successfully.';
END
GO

USE EmployerDB;
GO

-- =============================================
-- 2. XÓA BẢNG CŨ (Clean up - Xóa bảng con trước, bảng cha sau)
-- =============================================
IF OBJECT_ID('dbo.DonXinNghi', 'U') IS NOT NULL DROP TABLE dbo.DonXinNghi;
IF OBJECT_ID('dbo.BangLuong', 'U') IS NOT NULL DROP TABLE dbo.BangLuong;
IF OBJECT_ID('dbo.LichLamViec', 'U') IS NOT NULL DROP TABLE dbo.LichLamViec;
IF OBJECT_ID('dbo.NhanVien_ChucVu', 'U') IS NOT NULL DROP TABLE dbo.NhanVien_ChucVu;
IF OBJECT_ID('dbo.NhanVien', 'U') IS NOT NULL DROP TABLE dbo.NhanVien;
IF OBJECT_ID('dbo.ChucVu', 'U') IS NOT NULL DROP TABLE dbo.ChucVu;
IF OBJECT_ID('dbo.PhongBan', 'U') IS NOT NULL DROP TABLE dbo.PhongBan;
GO

-- =============================================
-- 3. TẠO CẤU TRÚC BẢNG MỚI
-- =============================================

-- 3.1 Bảng Phòng Ban
CREATE TABLE PhongBan (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TenPhongBan NVARCHAR(100) NOT NULL UNIQUE,
    MoTa NVARCHAR(200)
);

-- 3.2 Bảng Chức Vụ
CREATE TABLE ChucVu (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TenChucVu NVARCHAR(50) NOT NULL UNIQUE,
    MoTa NVARCHAR(200)
);

-- 3.3 Bảng Nhân Viên (ĐÃ KHÔI PHỤC TenDangNhap và MatKhau)
CREATE TABLE NhanVien (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MaNV VARCHAR(20) NOT NULL UNIQUE,        
    HoTen NVARCHAR(100) NOT NULL,            
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    SoDienThoai VARCHAR(20),
    LuongCoBan DECIMAL(18, 0) DEFAULT 0,
    NgayVaoLam DATE DEFAULT GETDATE(),
    AnhDaiDien VARBINARY(MAX),
    
    PhongBanId INT,
    
    -- [ĐÃ THÊM LẠI]
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE, 
    MatKhau NVARCHAR(100) NOT NULL,           

    CONSTRAINT FK_NhanVien_PhongBan FOREIGN KEY (PhongBanId) REFERENCES PhongBan(Id) ON DELETE SET NULL
);

-- 3.4 Bảng Trung Gian (Nhiều - Nhiều)
CREATE TABLE NhanVien_ChucVu (
    NhanVienId INT NOT NULL,
    ChucVuId INT NOT NULL,
    NgayBoNhiem DATE DEFAULT GETDATE(),
    PRIMARY KEY (NhanVienId, ChucVuId),
    CONSTRAINT FK_NVCV_NhanVien FOREIGN KEY (NhanVienId) REFERENCES NhanVien(Id) ON DELETE CASCADE,
    CONSTRAINT FK_NVCV_ChucVu FOREIGN KEY (ChucVuId) REFERENCES ChucVu(Id) ON DELETE CASCADE
);

-- 3.5 Bảng Lịch làm việc
CREATE TABLE LichLamViec (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NhanVienId INT NOT NULL,
    NgayLamViec DATE NOT NULL,
    CaLam NVARCHAR(50),
    MoTaCongViec NVARCHAR(200),
    TrangThai NVARCHAR(50) DEFAULT N'Chưa hoàn thành',
    CONSTRAINT FK_Lich_NhanVien FOREIGN KEY (NhanVienId) REFERENCES NhanVien(Id) ON DELETE CASCADE
);

-- 3.6 Bảng Lương
CREATE TABLE BangLuong (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NhanVienId INT NOT NULL,
    Thang INT NOT NULL,
    Nam INT NOT NULL,
    LuongCoBan DECIMAL(18, 0),
    Thuong DECIMAL(18, 0) DEFAULT 0,
    Phat DECIMAL(18, 0) DEFAULT 0,
    ThucLinh DECIMAL(18, 0),
    NgayChiTra DATETIME DEFAULT GETDATE(),
    CONSTRAINT UQ_Luong_ThangNam UNIQUE (NhanVienId, Thang, Nam),
    CONSTRAINT FK_BangLuong_NhanVien FOREIGN KEY (NhanVienId) REFERENCES NhanVien(Id) ON DELETE CASCADE
);

-- 3.7 Bảng Đơn Xin Nghỉ
CREATE TABLE DonXinNghi (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NhanVienId INT NOT NULL,
    TuNgay DATE NOT NULL,
    DenNgay DATE NOT NULL,
    LyDo NVARCHAR(200),
    TrangThai NVARCHAR(50) DEFAULT N'Chờ duyệt',
    NgayTao DATE DEFAULT GETDATE(),
    CONSTRAINT FK_DonNghi_NhanVien FOREIGN KEY (NhanVienId) REFERENCES NhanVien(Id) ON DELETE CASCADE
);
GO

-- =============================================
-- 4. INSERT DỮ LIỆU MẪU
-- =============================================

-- Phòng Ban
INSERT INTO PhongBan (TenPhongBan) VALUES 
(N'Ban Giám Đốc'), (N'Phòng Nhân Sự'), (N'Phòng Kỹ Thuật'), (N'Phòng Kinh Doanh');

-- Chức Vụ
INSERT INTO ChucVu (TenChucVu) VALUES 
(N'Giám đốc'), (N'Trưởng phòng'), (N'Nhân viên'), (N'Thực tập sinh'), (N'Quản trị viên (Admin)');

-- Nhân Viên (Đã thêm dữ liệu TenDangNhap và MatKhau)
INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, GioiTinh, SoDienThoai, LuongCoBan, NgayVaoLam, PhongBanId, TenDangNhap, MatKhau) 
VALUES 
('ADM01', N'Nguyễn Quản Trị', '1990-01-01', N'Nam', '0901234567', 35000000, '2020-01-01', 1, 'admin', '123'),
('NV001', N'Thái Vĩnh Phú', '1998-12-10', N'Nam', '0911223344', 15000000, '2022-03-10', 3, 'phutv', '123'),
('NV002', N'Lê Thị Thu', '2000-05-20', N'Nữ', '0988776655', 12000000, '2023-06-01', 2, 'thule', '123');

-- Gán Chức Vụ
INSERT INTO NhanVien_ChucVu (NhanVienId, ChucVuId) VALUES (1, 1), (1, 5), (2, 2), (3, 3);

-- Đơn Xin Nghỉ
INSERT INTO DonXinNghi (NhanVienId, TuNgay, DenNgay, LyDo, TrangThai) VALUES 
(2, '2026-02-10', '2026-02-12', N'Đi đám cưới người thân', N'Chờ duyệt'),
(3, '2026-01-20', '2026-01-21', N'Bị ốm', N'Đã duyệt');

GO

-- =============================================
-- 5. TỰ ĐỘNG SINH DỮ LIỆU LƯƠNG (2024 - 2026)
-- =============================================
DECLARE @NhanVienId INT;
DECLARE @LuongHienTai DECIMAL(18,0);
DECLARE @Nam INT;
DECLARE @Thang INT;
DECLARE @Thuong DECIMAL(18,0);
DECLARE @Phat DECIMAL(18,0);

DECLARE cur CURSOR FOR SELECT Id, LuongCoBan FROM NhanVien;
OPEN cur;
FETCH NEXT FROM cur INTO @NhanVienId, @LuongHienTai;

WHILE @@FETCH_STATUS = 0
BEGIN
    -- >> NĂM 2024 (Lương 90% hiện tại)
    SET @Nam = 2024; SET @Thang = 1;
    WHILE @Thang <= 12
    BEGIN
        SET @Thuong = FLOOR(RAND()*(1000000-0)+0); -- Thưởng random 0 - 1tr
        SET @Phat = CASE WHEN RAND() > 0.9 THEN 200000 ELSE 0 END; -- 10% cơ hội bị phạt
        
        INSERT INTO BangLuong (NhanVienId, Thang, Nam, LuongCoBan, Thuong, Phat, ThucLinh)
        VALUES (@NhanVienId, @Thang, @Nam, @LuongHienTai * 0.9, @Thuong, @Phat, (@LuongHienTai * 0.9) + @Thuong - @Phat);
        
        SET @Thang = @Thang + 1;
    END

    -- >> NĂM 2025 (Lương 100% hiện tại)
    SET @Nam = 2025; SET @Thang = 1;
    WHILE @Thang <= 12
    BEGIN
        SET @Thuong = FLOOR(RAND()*(2000000-0)+0); -- Thưởng random 0 - 2tr
        SET @Phat = CASE WHEN RAND() > 0.95 THEN 500000 ELSE 0 END; -- 5% cơ hội bị phạt
        
        INSERT INTO BangLuong (NhanVienId, Thang, Nam, LuongCoBan, Thuong, Phat, ThucLinh)
        VALUES (@NhanVienId, @Thang, @Nam, @LuongHienTai, @Thuong, @Phat, @LuongHienTai + @Thuong - @Phat);
        
        SET @Thang = @Thang + 1;
    END

    -- >> NĂM 2026 (3 tháng đầu)
    SET @Nam = 2026; SET @Thang = 1;
    WHILE @Thang <= 3
    BEGIN
        SET @Thuong = FLOOR(RAND()*(1500000-0)+0);
        
        INSERT INTO BangLuong (NhanVienId, Thang, Nam, LuongCoBan, Thuong, Phat, ThucLinh)
        VALUES (@NhanVienId, @Thang, @Nam, @LuongHienTai, @Thuong, 0, @LuongHienTai + @Thuong);
        
        SET @Thang = @Thang + 1;
    END

    FETCH NEXT FROM cur INTO @NhanVienId, @LuongHienTai;
END

CLOSE cur;
DEALLOCATE cur;
GO

-- =============================================
-- 6. KIỂM TRA KẾT QUẢ SAU KHI CHẠY
-- =============================================
PRINT 'Tao Database thanh cong!'
PRINT 'Danh sach nhan vien:'
SELECT Id, MaNV, HoTen, TenDangNhap, MatKhau FROM NhanVien;

PRINT 'Mau bang luong vua sinh:'
SELECT TOP 10 
    nv.HoTen, 
    bl.Thang, 
    bl.Nam, 
    FORMAT(bl.ThucLinh, '#,##0') as ThucLinh 
FROM BangLuong bl
JOIN NhanVien nv ON bl.NhanVienId = nv.Id
ORDER BY bl.Nam DESC, bl.Thang DESC;

select * from ChucVu;
select * from PhongBan;
select * from NhanVien;