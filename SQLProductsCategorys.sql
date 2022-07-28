USE SQLProductsCategorys

CREATE TABLE Products
(
    Id INT PRIMARY KEY IDENTITY,
    ProductName NVARCHAR(20),
);

CREATE TABLE Categorys
(
    Id INT PRIMARY KEY IDENTITY,
    CategoryName NVARCHAR(20),
);

CREATE TABLE Storage
(
    Id INT IDENTITY PRIMARY KEY,
    ProductId INT NOT NULL REFERENCES Products(Id) ON DELETE CASCADE,
    CategoryId INT NOT NULL REFERENCES Categorys(Id) ON DELETE CASCADE,
);

INSERT INTO Products 
VALUES
('bananas'),
('tomatos'),
('pistachios'),
('strawberrys'),
('apples'),
('cucumbers'),
('hazelnuts'),
('blueberrys'),
('meats')



INSERT INTO Categorys
VALUES
('fruits'),
('vegetables'),
('nuts'),
('berries')

INSERT INTO Storage 
VALUES
( 
    (SELECT Id FROM Products WHERE ProductName='bananas'), 
    (SELECT Id FROM Categorys WHERE CategoryName='fruits')
),
( 
    (SELECT Id FROM Products WHERE ProductName='tomatos'), 
    (SELECT Id FROM Categorys WHERE CategoryName='vegetables')
),
( 
    (SELECT Id FROM Products WHERE ProductName='pistachios'), 
    (SELECT Id FROM Categorys WHERE CategoryName='nuts')
),
( 
    (SELECT Id FROM Products WHERE ProductName='strawberrys'), 
    (SELECT Id FROM Categorys WHERE CategoryName='berries')
),
( 
    (SELECT Id FROM Products WHERE ProductName='apples'), 
    (SELECT Id FROM Categorys WHERE CategoryName='fruits')
),
( 
    (SELECT Id FROM Products WHERE ProductName='cucumbers'), 
    (SELECT Id FROM Categorys WHERE CategoryName='vegetables')
),
( 
    (SELECT Id FROM Products WHERE ProductName='blueberrys'), 
    (SELECT Id FROM Categorys WHERE CategoryName='berries')
),
( 
    (SELECT Id FROM Products WHERE ProductName='hazelnuts'), 
    (SELECT Id FROM Categorys WHERE CategoryName='nuts')
)


SELECT CONCAT(Products.ProductName, ' - ',  ISNULL(Categorys.CategoryName, 'NULL') ) AS 'ProductName - CategoryName'
FROM Products 
LEFT JOIN Storage ON Storage.ProductId = Products.Id
LEFT JOIN Categorys ON Storage.CategoryId = Categorys.Id