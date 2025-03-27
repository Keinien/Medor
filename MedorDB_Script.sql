IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'MedorDB')
BEGIN
    CREATE DATABASE MedorDB;
END
GO

USE MedorDB;
GO

IF OBJECT_ID(N'dbo.MedorData', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.MedorData (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        BtcEur DECIMAL(18,8) NOT NULL,
        BtcCze DECIMAL(18,8) NOT NULL,
        Date DATETIME NOT NULL,
        Note NVARCHAR(500) NULL,
        DateCreated DATETIME NOT NULL DEFAULT GETDATE(),
        DateModified DATETIME NULL
    );
END
GO