CREATE DATABASE RB_StockManagement

USE RB_StockManagement

CREATE TABLE Categories
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Code VARCHAR(10), 
	Name VARCHAR(20)
)

SELECT * FROM Categories

CREATE TABLE Products
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	CategoryID INT REFERENCES Categories("ID"),
	Code VARCHAR(10), 
	Name VARCHAR(20),
	ReOrderLevel INT, 
	Description VARCHAR(50)
)

SELECT * FROM Products

CREATE TABLE Customers
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Code VARCHAR(10),
	Name VARCHAR(20),
	Address VARCHAR(50),
	Email VARCHAR(20),
	Contact VARCHAR(12),
	LoyalityPoint INT
)

SELECT * FROM Customers


CREATE TABLE Suppliers
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Code VARCHAR(10),
	Name VARCHAR(20),
	Address VARCHAR(50),
	Email VARCHAR(20),
	Contact VARCHAR(12),
	ContactPerson VARCHAR(100)
)

SELECT * FROM Suppliers

CREATE TABLE Purchases
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Date DATETIME, 
	InvoiceNo VARCHAR(15),
	SupplierID INT REFERENCES Suppliers("ID"),
	ProductID INT REFERENCES Products("ID"),
	ManufacturedDate DATETIME NULL DEFAULT NULL,
	ExpireDate DATETIME NULL DEFAULT NULL,
	Quantity INT,
	UnitPrice FLOAT,
	MRP FLOAT
)

INSERT INTO Purchases (Date, InvoiceNo, SupplierID, ProductID, ManufacturedDate, ExpireDate, Quantity, UnitPrice, MRP) VALUES('2019-10-25',101,2,1,null, null,10,2500,25000);

DROP TABLE Purchases

SELECT * FROM Purchases

DELETE FROM Purchases

Select * FROM Purchases Where ProductID = 1

SELECT UnitPrice, MRP FROM Purchases WHERE ID IN (SELECT max(ID) FROM Purchases WHERE ProductID = 1)

CREATE VIEW AvailableQuantity
AS
SELECT p.ProductID AS ProductID, SUM(p.Quantity) - ISNULL(SUM(s.Quantity),0) As Quantity  From Purchases AS p
LEFT JOIN Sales AS s ON p.ProductID = s.ProductID 
GROUP BY p.ProductID

Select * FROM AvailableQuantity WHERE Product = 1

DROP VIEW AvailableQuantity

CREATE TABLE PurchaseItem
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	ProductID INT REFERENCES Products("ID"),
	ManucaturedDate DATETIME,
	ExpireDate DATETIME,
	Quantity INT, 
	UnitPrice FLOAT,
	MRP FLOAT
)
SELECT * FROM PurchaseItem

DROP TABLE PurchaseItem

CREATE TABLE Sales
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Date DATETIME,
	CustomerID INT REFERENCES Customers("ID"),
	ProductID INT REFERENCES Products("ID"),
	Quantity INT,
	Price FLOAT,
	GrandTotal FLOAT,
	DiscountPercentage FLOAT
)

SELECT * FROM Sales
DELETE FROM Sales

DROP TABLE Sales

