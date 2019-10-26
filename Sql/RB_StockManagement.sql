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

SELECT * FROM Purchases WHERE Date = '2019-10-22'

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
DELETE FROM Sales

DROP TABLE Sales

CREATE VIEW Stock
AS
SELECT pr.ID AS ID, pr.Code AS Code, pr.Name AS Product, ISNUll(SUM(p.Quantity),0) AS "IN", ISNUll(SUM(s.Quantity),0) AS "OUT" FROM Products AS pr
LEFT JOIN Purchases As p ON  pr.ID = p.ProductID
LEFT JOIN Sales AS s ON pr.ID = s.ProductID 
GROUP BY pr.ID, pr.Code, pr.Name

SELECT * FROM Stock WHERE ID BETWEEN 1 AND 3

CREATE VIEW ST
AS
SELECT pr.ID AS ID, pr.Code AS Code, pr.Name AS Name, p.Date AS PDate, s.Date AS SDate, ISNUll(SUM(p.Quantity),0) AS "StockIn", ISNUll(SUM(s.Quantity),0) AS "StockOut", ISNULL(Sum(p.Quantity),0)-ISNULL(SUM(s.Quantity),0) AS "ClosingBalance" FROM Products AS pr
LEFT JOIN Purchases As p ON  pr.ID = p.ProductID
LEFT JOIN Sales AS s ON pr.ID = s.ProductID
--WHERE (p.Date  PDate BETWEEN '2019-10-17' AND '2019-10-30') OR (s.Date AS SDate BETWEEN '2019-10-17' AND '2019-10-30')
GROUP BY pr.ID, pr.Code, pr.Name, s.Date, p.Date

Drop VIEW ST

SELECT ID, Code,Sum(StockIn) AS "IN", Sum(StockOut) AS "OUT", Sum(ClosingBalance) AS "Closing Balance" FROM ST
WHERE (PDate BETWEEN '2019-10-27' AND '2019-10-28') --AND (SDate BETWEEN '2019-10-17' AND '2019-10-17')
GROUP BY ID, Code


SELECT ID, ISNULL(Sum(Quantity),0) FROM Purchases
WHERE Date > '2019-10-27' --AND '2019-10-30'
GROUP BY ID


DROP VIEW Stock


SELECT pr.ID AS ID, pr.Code AS Code, ISNUll(SUM(p.Quantity),0) AS "Total IN", ISNULL(SUM(s.Quantity),0) As "Total Out" From Products AS pr
LEFT JOIN Sales AS s ON  ID = s.ProductID
LEFT JOIN Purchases AS p ON ID =  p.ProductID
GROUP BY Code

