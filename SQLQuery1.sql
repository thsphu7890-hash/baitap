USE EmployerDB;
GO

-- =============================================
-- 1. XÓA CÁC BẢNG CŨ (Theo thứ tự để không bị lỗi khóa ngoại)
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LichLamViec]') AND type in (N'U'))
    DROP TABLE LichLamViec;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien_ChucVu]') AND type in (N'U'))
    DROP TABLE NhanVien_ChucVu;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucVu]') AND type in (N'U'))
    DROP TABLE ChucVu;
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type in (N'U'))
    DROP TABLE NhanVien;
GO

-- =============================================
-- 2. TẠO CÁC BẢNG MỚI
-- =============================================

-- Bảng Nhân Viên (Bỏ cột ChucVu đơn lẻ)
CREATE TABLE NhanVien (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MaNV VARCHAR(20) NOT NULL UNIQUE,      
    HoTen NVARCHAR(100) NOT NULL,          
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    SoDienThoai VARCHAR(20),
    Email VARCHAR(100),
    DiaChi NVARCHAR(200),
    LuongCoBan DECIMAL(18,0) DEFAULT 0,
    NgayVaoLam DATE DEFAULT GETDATE(),
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(100) NOT NULL
);
GO

-- Bảng Chức Vụ (Danh mục chức vụ)
CREATE TABLE ChucVu (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TenChucVu NVARCHAR(50) NOT NULL UNIQUE,
    MoTa NVARCHAR(200)
);
GO

-- Bảng Trung Gian (Kết nối Nhân viên - Chức vụ)
-- Một nhân viên có nhiều chức vụ, một chức vụ có nhiều nhân viên
CREATE TABLE NhanVien_ChucVu (
    NhanVienId INT NOT NULL,
    ChucVuId INT NOT NULL,
    NgayBoNhiem DATE DEFAULT GETDATE(),
    PRIMARY KEY (NhanVienId, ChucVuId),
    FOREIGN KEY (NhanVienId) REFERENCES NhanVien(Id) ON DELETE CASCADE,
    FOREIGN KEY (ChucVuId) REFERENCES ChucVu(Id) ON DELETE CASCADE
);
GO

-- Bảng Lịch làm việc
CREATE TABLE LichLamViec (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NhanVienId INT NOT NULL,
    NgayLamViec DATE NOT NULL,
    CaLam NVARCHAR(50),
    MoTaCongViec NVARCHAR(200),
    TrangThai NVARCHAR(50) DEFAULT N'Chưa hoàn thành',
    CONSTRAINT FK_NhanVien_Lich FOREIGN KEY (NhanVienId) 
        REFERENCES NhanVien(Id) ON DELETE CASCADE
);
GO

-- =============================================
-- 3. THÊM DỮ LIỆU MẪU CHUẨN
-- =============================================

-- Thêm các chức vụ mẫu
INSERT INTO ChucVu (TenChucVu) VALUES (N'Admin'), (N'Trưởng phòng'), (N'Kế toán'), (N'Nhân viên'), (N'Kỹ thuật');

-- Thêm nhân viên
INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, GioiTinh, SoDienThoai, Email, DiaChi, LuongCoBan, NgayVaoLam, TenDangNhap, MatKhau) 
VALUES ('ADM01', N'Nguyễn Quản Trị', '1990-01-01', N'Nam', '0901234567', 'admin@hr.com', N'Hà Nội', 25000000, '2020-01-01', 'admin', '123');

INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, GioiTinh, SoDienThoai, Email, DiaChi, LuongCoBan, NgayVaoLam, TenDangNhap, MatKhau) 
VALUES ('NV001', N'Thái Vĩnh Phú', '1998-12-10', N'Nam', '0911223344', 'phu.tv@hr.com', N'TP.HCM', 15000000, '2022-03-10', 'phutv', '123');

-- Gán chức vụ (Bổ nhiệm nhiều chức danh)
-- Nguyễn Quản Trị làm cả Admin và Kỹ thuật
INSERT INTO NhanVien_ChucVu (NhanVienId, ChucVuId) VALUES (1, 1), (1, 5);

-- Thái Vĩnh Phú làm Trưởng phòng
INSERT INTO NhanVien_ChucVu (NhanVienId, ChucVuId) VALUES (2, 2);

GO

-- =============================================
-- 4. TRUY VẤN KIỂM TRA (Hiện danh sách kèm chức vụ cách nhau dấu phẩy)
-- =============================================
SELECT 
    nv.MaNV, 
    nv.HoTen, 
    STRING_AGG(cv.TenChucVu, ', ') AS DanhSachChucVu,
    nv.LuongCoBan
FROM NhanVien nv
LEFT JOIN NhanVien_ChucVu nvc ON nv.Id = nvc.NhanVienId
LEFT JOIN ChucVu cv ON nvc.ChucVuId = cv.Id
GROUP BY nv.MaNV, nv.HoTen, nv.LuongCoBan;