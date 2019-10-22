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

