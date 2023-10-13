CREATE DATABASE CashPal;
USE CashPal;

CREATE TABLE users (
	id INTEGER,
	name TEXT,
	age INTEGER,
	is_admin BIT);

INSERT into users (id, name, age, is_admin) values (1, 'John Doe', 27, 0);
INSERT into users (id, name, age, is_admin) values (2, 'Sally Rae', 18, 1);

SELECT * FROM users;

EXEC sp_help users;
EXEC sp_rename 'usuarios', 'users';

CREATE TABLE alumnos(
	idAlumno  INT PRIMARY KEY IDENTITY(1,1),
	nombreAlumno VARCHAR(20),
	edadAlumno INT
);

CREATE TABLE materias(
	idMateria INT PRIMARY KEY,
	nombreMateria VARCHAR(20),
);

CREATE TABLE inscripcion(
	idInscripcion INT PRIMARY KEY,
	idMateria INT,
	idAlumno INT,
	FOREIGN KEY (idMateria) REFERENCES materias(idMateria) ON DELETE SET NULL,
	FOREIGN KEY (idAlumno) REFERENCES alumnos(idAlumno) ON DELETE SET NULL
);

CREATE TABLE Promedios (
    idPromedio INT PRIMARY KEY IDENTITY(1,1),
    idAlumno INT,
    idMateria INT,
    Promedio DECIMAL(5, 2),
    FOREIGN KEY (idAlumno) REFERENCES alumnos(idAlumno) ON DELETE CASCADE,
    FOREIGN KEY (idMateria) REFERENCES materias(idMateria) ON DELETE CASCADE
);

INSERT INTO alumnos VALUES('Daniel', 26);
INSERT INTO alumnos VALUES('Miguel', 23);
INSERT INTO alumnos VALUES('Ernesto', 24);
SELECT * FROM alumnos;

INSERT INTO materias VALUES(5, 'Matematicas');
INSERT INTO materias VALUES(8, 'Biologia');
INSERT INTO materias VALUES(10, 'Psicologia');
INSERT INTO materias VALUES(21, 'Calculo');
INSERT INTO materias VALUES(32, 'Redes');

SELECT * FROM materias;

INSERT INTO inscripcion VALUES(1, 5, 1);
INSERT INTO inscripcion VALUES(2, 32, 1);
INSERT INTO inscripcion VALUES(3, 21, 1);

INSERT INTO inscripcion VALUES(4, 8, 2);
INSERT INTO inscripcion VALUES(5, 21, 2);

INSERT INTO inscripcion VALUES(6, 5, 3);
INSERT INTO inscripcion VALUES(7, 8, 3);
INSERT INTO inscripcion VALUES(8, 32, 3);

SELECT * FROM inscripcion;

INSERT INTO Promedios VALUES(1,5,10.00);
INSERT INTO Promedios VALUES(1,32,8.10);
INSERT INTO Promedios VALUES(1,21,8.30);
INSERT INTO Promedios VALUES(2,8,5.50);
INSERT INTO Promedios VALUES(2,21,7.00);
INSERT INTO Promedios VALUES(3,5,8.70);
INSERT INTO Promedios VALUES(3,8,8.00);
INSERT INTO Promedios VALUES(3,32,9.50);

SELECT * FROM Promedios;

SELECT * FROM alumnos 
	WHERE idAlumno
	IN (
		 SELECT idAlumno FROM inscripcion
		 WHERE idMateria = 32
	   );

--Mal
SELECT a.nombreAlumno, m.nombreMateria, p.Promedio
FROM materias m
INNER JOIN inscripcion i ON m.idMateria = i.idMateria
INNER JOIN alumnos a ON i.idAlumno = a.idAlumno
INNER JOIN Promedios p ON p.idAlumno = a.idAlumno;


--Nombre de Alumno, Materia y su promedio (se deben relacionar con el ultimo valor)
SELECT a.nombreAlumno, m.nombreMateria, p.Promedio
FROM alumnos a
INNER JOIN Promedios p ON a.idAlumno = p.idAlumno
INNER JOIN materias m ON p.idMateria = m.idMateria;



