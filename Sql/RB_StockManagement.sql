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

DROP TABLE Purchases

SELECT * FROM Purchases

CREATE VIEW ReportOnPurchase
AS
SELECT pr.Code AS "Code", pr.Name AS "Product", c.Name AS "Category", ISNULL(Sum(p.Quantity),0) AS "AvailableQuantity", ISNULL(AVG(p.UnitPrice),0) AS "UnitPrice", ISNULL(AVG(p.MRP),0) AS "MRP", ISNULL(AVG(p.MRP),0) - ISNULL(AVG(p.UnitPrice),0) AS "Profit" FROM Purchases AS p
LEFT JOIN Products AS pr ON pr.ID = p.ProductID
LEFT JOIN Categories AS C ON c.ID = pr.CategoryID
GROUP BY pr.Code, pr.Name, c.Name

SELECT * FROM ReportOnPurchase

DELETE FROM Purchases

Select * FROM Purchases Where ProductID = 1

SELECT UnitPrice, MRP FROM Purchases WHERE ID IN (SELECT max(ID) FROM Purchases WHERE ProductID = 1)

CREATE VIEW AvailableQuantity
AS
SELECT p.ProductID AS ProductID, SUM(p.Quantity) - ISNULL(SUM(s.Quantity),0) As Quantity  From Purchases AS p
LEFT JOIN Sales AS s ON p.ProductID = s.ProductID 
GROUP BY p.ProductID

Select * FROM AvailableQuantity WHERE ProductID = 1

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

CREATE VIEW ReportOnSale
AS
SELECT pr.Code AS "Code", pr.Name AS "Product", c.Name AS "Category", ISNULL(SUM(s.Quantity),0) AS "SoldQuantity", ISNULL(AVG(p.UnitPrice),0) AS "CP" , ISNULL(AVG(s.Price),0) AS "MRP", ISNULL(AVG(s.Price),0)-ISNULL(AVG(p.UnitPrice),0) AS Profit  FROM Sales AS s
LEFT JOIN Purchases AS p ON p.ProductID = s.ProductID
LEFT JOIN Products AS pr ON pr.ID = s.ProductID
LEFT JOIN Categories AS C ON c.ID = pr.CategoryID
GROUP BY pr.Code, pr.Name, c.Name

DROP TABLE Sales

CREATE VIEW PV
AS
SELECT pr.ID AS "ID", pr.Code AS "Code", pr.Name AS "Product", p.Date AS PDate, ISNUll(SUM(p.Quantity),0) AS "StockIn" FROM Purchases AS p
LEFT JOIN Products AS pr ON p.ProductID = pr.ID
GROUP BY pr.ID, pr.Code, pr.Name, p.Date

SELECT * FROM PV

CREATE VIEW SV
AS
SELECT s.ProductID AS "ID", s.Date AS SDate, ISNUll(SUM(s.Quantity),0) AS "StockOut" FROM Sales AS s
LEFT JOIN Products AS pr ON s.ProductID = pr.ID
GROUP BY s.ProductID, s.Date

SELECT * FROM PV
SELECT * FROM SV

CREATE VIEW Stocks
AS
SELECT pv.Code AS "Code", pv.Product AS "Product", ISNULL(SUM(0),0) AS "OpeningBalance", ISNULL(SUM(pv.StockIn),0) AS "StockIn", ISNULL(SUM(sv.StockOut),0) AS "StockOut", ISNULL(SUM(pv.StockIn),0) - ISNULL(SUM(sv.StockOut),0) AS "ClosingBalance" FROM PV AS pv
LEFT JOIN SV as sv ON sv.ID = pv.ID
GROUP BY pv.Code, pv.Product
