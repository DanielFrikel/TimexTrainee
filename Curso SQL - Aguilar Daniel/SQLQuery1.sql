CREATE DATABASE giraffe;
DROP TABLE student;

CREATE TABLE student(
	student_id INT IDENTITY(1,1),
	name VARCHAR(20) /*NOT NULL*/,
	major VARCHAR(20) DEFAULT 'undecided'/*UNIQUE*/,
	PRIMARY KEY(student_id)
);

ALTER TABLE student ADD agp FLOAT;
--ALTER TABLE student ALTER COLUMN agp DOUBLE(2,2);
ALTER TABLE student DROP COLUMN agp;

--INSERT INTO student(student_id,name) VALUES (1, 'Jack');
INSERT INTO student(name, major) VALUES ('Jack','Biology');
INSERT INTO student(name, major) VALUES ('Kate','Sociology');
--INSERT INTO student VALUES (1, 'Jack', 'Biology');
INSERT INTO student VALUES ('Kate', 'Sociology');
INSERT INTO student VALUES ('Claire', 'Chemistry');
INSERT INTO student(name, major) VALUES ('Jack','Biology');
INSERT INTO student VALUES ('Mike', 'Computer Science');
--INSERT INTO student(student_id,name) VALUES (3, 'Claire');
--INSERT INTO student(student_id,name,major) VALUES (4, 'Jack', 'Biology');
INSERT INTO student VALUES (5, 'Mike', 'Computer Science');

DELETE FROM student WHERE student_id = 3;
SELECT TOP 5 * FROM student;

UPDATE student SET major='Bio' WHERE major='Biology';
UPDATE student SET major='Comp Sci' WHERE major='Computer Science';
UPDATE student SET major='Comp Sci' WHERE student_id = 4;
UPDATE student SET major='Biochemistry' WHERE major = 'Bio' OR major = 'Chemistry'
UPDATE student SET name='Tom', major='undecided' WHERE student_id = 1;
UPDATE student SET major='undecided'

DELETE FROM student WHERE student_id = 5;
DELETE FROM student WHERE name='Tom' AND major='undecided';

SELECT student.name, student.major FROM student ORDER BY name DESC;
SELECT * FROM student ORDER BY major, student_id DESC;
SELECT TOP 2 * FROM student ORDER BY student_id DESC;
SELECT * FROM student WHERE major = 'Biology';
SELECT * FROM student WHERE major != 'Chemistry'; --!= = <>
SELECT * FROM student WHERE student_id <= 4 AND name!='Jack';
SELECT * FROM student WHERE name IN('Claire','Kate','Mike') AND student_id>=4; --IN means multiples AND's