CREATE DATABASE AccentureAcademyBookStore;
GO

USE AccentureAcademyBookStore;
GO

CREATE TABLE Genre
(
	Id int primary key identity(1,1),
	Title varchar(100) not null
)

INSERT INTO Genre
(Title)
VALUES
('Drama'),
('Ciencia Ficcion'),
('Terror'),
('Romance'),
('Policial')