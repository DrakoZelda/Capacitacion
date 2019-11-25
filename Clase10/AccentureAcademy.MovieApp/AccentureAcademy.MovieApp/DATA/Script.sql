CREATE DATABASE AccentureAcademyMovieDb;
GO

USE AccentureAcademyMovieDb;
GO

CREATE TABLE Movie
(
	Id int primary key identity(1,1),
	Title varchar(200) not null,
	ReleaseDate Date not null,
	RunningTime int not null,
	CONSTRAINT UQ_MOVIE_TITLE_RealeaseDate UNIQUE (Title, ReleaseDate),
	CONSTRAINT CHK_MOVIE_DURATION CHECK (RunningTime between 1 and 500)
);
GO

INSERT INTO Movie
(Title,ReleaseDate, RunningTime)
VALUES
('Terminator: Dark Fate','2019-10-31',120)
