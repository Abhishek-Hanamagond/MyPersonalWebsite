CREATE DATABASE PersonalWebsiteDB;
GO

USE PersonalWebsiteDB;
GO

CREATE TABLE Sellers (
    SellerId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Email NVARCHAR(100),
    Password NVARCHAR(100)
);
GO

CREATE TABLE Products (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    SellerId INT FOREIGN KEY REFERENCES Sellers(SellerId),
    Name NVARCHAR(100),
    Description NVARCHAR(500),
    Price DECIMAL(10,2)
);
GO

CREATE TABLE Blogs (
    BlogId INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200),
    Content NVARCHAR(MAX),
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO