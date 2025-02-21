CREATE DATABASE RetailStore;
USE RetailStore;
CREATE TABLE Customer(
	CustomerID INT NOT NULL PRIMARY KEY,
	FirstName varchar(255),
	LastName varchar(255),
	Email varchar(255),
	RegistrationDate DATE
);
CREATE TABLE Products(
	ProductID INT NOT NULL PRIMARY KEY,
	ProductName varchar(255),
	Category varchar(255),
	Price DECIMAL(10,2),
	StockQuantity INT
);
CREATE TABLE Orders(
	OrderID INT NOT NULL PRIMARY KEY,
	CustomerID INT,
	FOREIGN KEY(CustomerID) REFERENCES Customer(CustomerID),
	ProductID INT,
	FOREIGN KEY(ProductID) REFERENCES Products(ProductID),
	OrderDate DATE,
	QUANTITY INT
);
INSERT INTO Customer (CustomerID,FirstName, LastName, Email, RegistrationDate) VALUES
(1,'Sara', 'Mostafa', 'sara.m@gmail.com', '2023-01-24'),
(2,'maryam', 'mohamed', 'maryam.a@gmail.com', '2020-03-15'),
(3,'amira', 'Johnson', 'amira.johnson@gmail.com', '2019-05-20'),
(4,'Bob', 'Brown', 'bob.brown@gmail.com', '2022-07-25'),
(5,'Charlie', 'Davis', 'charlie.davis@gmail.com', '2007-09-05');
INSERT INTO Products (ProductID,ProductName, Category, Price, StockQuantity) VALUES
(1,'Laptop', 'Electronics', 1200.00, 10),
(2,'Smartphone', 'Electronics', 800.00, 20),
(3,'Headphones', 'Accessories', 150.00, 50),
(4,'Monitor', 'Electronics', 300.00, 15),
(5,'Keyboard', 'Accessories', 50.00, 100);
INSERT INTO Orders (OrderID,CustomerID, ProductID, OrderDate, Quantity) VALUES
(1,1, 1, '2009-1-10', 1),
(2,2, 3, '2024-6-12', 2),
(3,3, 2, '2023-12-15', 1),
(4,4, 4, '2022-5-20', 1),
(5,5, 5, '2010-1-22', 3);
SELECT * FROM Customer;
SELECT * FROM Products;
SELECT * FROM Orders;

SELECT * FROM Customer
WHERE RegistrationDate='2023-01-24';

SELECT * FROM Products
SELECT TOP 3 * FROM Products ORDER BY Price DESC;

SELECT O.OrderID, C.FirstName, C.LastName, P.ProductName, P.Category, O.Quantity, P.Price, (O.Quantity * P.Price) AS TotalAmount, O.OrderDate
FROM Orders O
INNER JOIN Customer C ON O.CustomerID = C.CustomerID
INNER JOIN Products P ON O.ProductID = P.ProductID;

SELECT C.CustomerID, C.FirstName, C.LastName, SUM(O.Quantity * P.Price) AS TotalSpent
FROM Orders O
INNER JOIN Customer C ON O.CustomerID = C.CustomerID
INNER JOIN Products P ON O.ProductID = P.ProductID
GROUP BY C.CustomerID, C.FirstName, C.LastName
ORDER BY TotalSpent DESC;

SELECT C.CustomerID, C.FirstName, C.LastName, COUNT(O.OrderID) AS NumberOfOrders
FROM Orders O
INNER JOIN Customer C ON O.CustomerID = C.CustomerID
GROUP BY C.CustomerID, C.FirstName, C.LastName
ORDER BY NumberOfOrders DESC;

SELECT P.ProductID, P.ProductName, P.Category, SUM(O.Quantity) AS TotalQuantitySold, SUM(O.Quantity * P.Price) AS TotalSales
FROM Orders O
INNER JOIN Products P ON O.ProductID = P.ProductID
GROUP BY P.ProductID, P.ProductName, P.Category
ORDER BY TotalSales DESC;




