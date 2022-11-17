CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Products
VALUES
	(1, 'BigMac'),
	(2, 'BoxMaster'),
	(3, 'Whopper'),
	(4, 'BigSub'),
	(5, 'Water');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Categories
VALUES
	(1, 'Burger'),
	(2, 'FastFood'),
	(3, 'McDonalds');

CREATE TABLE ProductCategories (
	ProductId INT,
	CategoryId INT,
	FOREIGN KEY (ProductId) REFERENCES Products(Id),
	FOREIGN KEY (CategoryId) REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

	
INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 2),
	(1, 3),
	(2, 1),
	(2, 2),
	(3, 1),
	(3, 2),
	(4, 2);

SELECT P.Name as "ProductName", C.Name as "CategoryName"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;