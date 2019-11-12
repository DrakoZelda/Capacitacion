CREATE DATABASE [AccentureAcademyWorks.Sql]
GO

use [AccentureAcademyWorks.Sql]
GO

CREATE TABLE Persona
(
	id int primary key identity(1,1),
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	fechaNacimiento datetime not null,
	CONSTRAINT UQ_NOMBRE_APELLIDO UNIQUE (nombre, apellido)
);

INSERT INTO Persona
(nombre, apellido, fechaNacimiento)
VALUES
('Juan', 'Topo', CURRENT_TIMESTAMP),
('jhin', 'Khada', GETDATE()),
('Max', 'Power', '1980-11-10'),
('Aquiles', 'Baeza', DATEFROMPARTS(1990,3,2)),
('Ted', 'Tonks', DATEADD(YEAR, -10, GETDATE()))


UPDATE Persona
SET fechaNacimiento = DATEFROMPARTS(1995, 9, 14)
WHERE nombre = 'Max'

UPDATE Persona
SET fechaNacimiento = DATEADD(YEAR, -10, fechaNacimiento)
WHERE nombre = 'jhin'

/*
-- el query falla debido al constraint impuesto. (uq_nombre_apellido)

INSERT INTO Persona
(nombre, apellido, fechaNacimiento)
VALUES
('Max', 'Power', GETDATE())
*/