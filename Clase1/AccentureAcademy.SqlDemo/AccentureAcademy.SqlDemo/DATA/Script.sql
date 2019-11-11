CREATE DATABASE [AccentureAcademy.SqlDemo];

GO

USE [AccentureAcademy.SqlDemo]
GO

 -- Creo una tabla demo
CREATE TABLE Demo
(
	Id int primary key identity(1,1),
	Nombre varchar(20) not null,
	Valor int not null
)
GO

INSERT INTO Demo
(Nombre, Valor)
VALUES
('Demo', 1),
('Ejemplo', 56),
('Monitor', 33);
GO
