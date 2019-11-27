CREATE DATABASE AccentureAcademyBookStore;
GO

USE AccentureAcademyBookStore;
GO

CREATE TABLE Book
(
	Id int primary key identity(1,1),
	Title varchar(100) not null
)
GO

CREATE TABLE Autor
(
	Id int primary key identity(1,1),
	AuthorName varchar(100) not null
)
GO

CREATE TABLE WrittenBy
(
	Id int primary key identity(1,1),
	Author_Id int not null,
	Book_Id int not null,
	CONSTRAINT FK_AUTOR FOREIGN KEY (Author_Id)
		REFERENCES Autor(Id)
		ON DELETE CASCADE,
	CONSTRAINT FK_BOOK FOREIGN KEY (Book_Id)
		REFERENCES Book(Id)
		ON DELETE CASCADE,
	CONSTRAINT UQ_BOOL_AUTHOR UNIQUE (Author_Id, Book_Id)
)
GO

INSERT INTO Autor
(AuthorName)
VALUES
('juan'),
('jorge'),
('pablo'),
('mingo')