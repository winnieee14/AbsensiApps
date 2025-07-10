-- CREATE DATABASE (optional, kalau belum ada)
CREATE DATABASE AbsensiDB;
GO

USE AbsensiDB;
GO

-- DROP TABLES IF EXIST (clean reset)
IF OBJECT_ID('Absen', 'U') IS NOT NULL DROP TABLE Absen;
IF OBJECT_ID('Employee', 'U') IS NOT NULL DROP TABLE Employee;
GO

-- CREATE Employee Table
CREATE TABLE Employee (
    NIK VARCHAR(10) PRIMARY KEY,
    Nama VARCHAR(100) NOT NULL
);
GO

-- CREATE Absen Table
CREATE TABLE Absen (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    NIK VARCHAR(10) NOT NULL,
    TanggalAbsen DATE NOT NULL,
    CONSTRAINT FK_Absen_Employee FOREIGN KEY (NIK) REFERENCES Employee(NIK)
);
GO

-- INSERT Sample Employee
INSERT INTO Employee (NIK, Nama) VALUES
('A001', 'Andi'),
('A002', 'Susi'),
('A003', 'Toni'),
('A004', 'Hendra');
GO

-- INSERT Sample Absen Data
INSERT INTO Absen (NIK, TanggalAbsen) VALUES
('A001', '2014-08-30'),
('A001', '2014-09-02'),
('A002', '2014-08-30'),
('A002', '2014-08-31'),
('A002', '2014-09-01'),
('A003', '2014-08-29'),
('A003', '2014-09-02'),
('A004', '2014-08-29'),
('A004', '2014-08-31');
GO
