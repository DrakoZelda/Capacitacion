CREATE DATABASE AccentureAcademyBank;
GO

USE AccentureAcademyBank;
GO

CREATE TABLE Customer
(
	Id int primary key identity(1,1),
	[Name] varchar(20) not null,
);
GO

CREATE TABLE Account
(
	Id int primary key identity(1,1),
	CustomerID int not null,
	CBU varchar(22) not null unique,
	Balance money not null,
	CONSTRAINT FK_ACCOUNT_CUSTOMER FOREIGN KEY (CustomerID)
		REFERENCES Customer(Id)
		ON DELETE CASCADE
);
GO

INSERT INTO Customer
([Name])
VALUES
('Bill Gates'),
('Warren Buffet'),
('Jeff Bezos'),
('Mark Zuckerberg')
GO