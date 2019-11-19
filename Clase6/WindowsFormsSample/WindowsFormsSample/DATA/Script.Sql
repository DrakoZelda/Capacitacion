CREATE DATABASE [AccentureAcademyAsync.Sql];
GO

USE [AccentureAcademyAsync.Sql];
GO

CREATE TABLE Nombres
(
	Id int primary key identity(1,1),
	Nombre varchar(50),
	CONSTRAINT UQ_NOMBRES_NOMBRE UNIQUE (Nombre) 
)

INSERT INTO Nombres
(Nombre)
VALUES
('Juan'),
('Max'),
('Pedro'),
('Susana'),
('Carla'),
('Ofelia')