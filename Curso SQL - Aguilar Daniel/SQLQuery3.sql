USE giraffe;
--It is which will define a certain action that should happen
--when a certain operation gets performed on the database
CREATE TABLE trigger_test(
	message VARCHAR(100)
);

SELECT * FROM trigger_test;


CREATE TRIGGER tr_first_trigger 
ON employee
AFTER INSERT		
AS			
	BEGIN 
		INSERT INTO trigger_test VALUES('Added new employee');
	END


INSERT INTO employee VALUES(109,'Oscar','Martinez','1968-02-19','M',69000,106,3);

SELECT * FROM employee;
SELECT * FROM trigger_test;

CREATE TRIGGER tr_second_trigger 
ON employee
AFTER INSERT		
AS			
	BEGIN 
		INSERT INTO trigger_test SELECT first_name FROM inserted;
	END


INSERT INTO employee VALUES(110,'Kevin','Malone','1978-02-19','M',69000,106,3);


CREATE TRIGGER tr_third_trigger
	ON employee
	AFTER INSERT
	AS
	BEGIN
	IF (SELECT sex FROM inserted) = 'M' 
		INSERT INTO trigger_test VALUES('Added male employee');
	ELSE IF(SELECT sex FROM inserted) = 'F'
		INSERT INTO trigger_test VALUES('Added female employee');
	ELSE
		INSERT INTO trigger_test VALUES('Added other employee');
	END


INSERT INTO employee VALUES(111,'Pam','Beesly','1998-02-19','F',69000,106,3);
SELECT * FROM employee;
SELECT * FROM trigger_test;





--HackerRank
SELECT * FROM employee WHERE emp_id % 2 = 0;
SELECT TOP 2 * FROM employee WHERE emp_id % 2 = 0;
SELECT TOP 2 LEN(first_name), first_name FROM employee WHERE first_name IS NOT NULL;
SELECT first_name FROM employee;

--HackerRank
--SELECT DISTINCT city FROM station WHERE id % 2 = 0;

--SELECT( COUNT(city) - COUNT( DISTINCT city) ) FROM station;

--SELECT TOP 2 LEN(first_name), first_name FROM employee WHERE first_name IS NOT NULL;

--SELECT TOP 1 city, LEN(city) FROM station WHERE city IS NOT NULL ORDER BY LEN(city) ASC, city ASC;
--SELECT TOP 1 city, LEN(city) FROM station WHERE city IS NOT NULL ORDER BY LEN(city) DESC, city DESC;


--The IN statement creates a series of OR statements.
--The LIKE statement doesn't need a equal symbol "=" just: LIKE '%a'
--SELECT DISTINCT city FROM station WHERE city LIKE 'a%' OR city LIKE 'e%' OR city LIKE 'i%' OR city LIKE 'o%' OR city LIKE 'u%';

--SELECT DISTINCT city FROM station WHERE city LIKE '%a' OR city LIKE '%e' OR city LIKE '%i' OR city LIKE '%o' OR city LIKE '%u';

--SELECT DISTINCT city FROM station WHERE city LIKE '[AEIOU]%[AEIOU]'
--SELECT DISTINCT city FROM station WHERE city LIKE '[A,E,I,O,U]%[A,E,I,O,U]'
--SELECT DISTINCT city FROM station WHERE city NOT LIKE '[aeiou]%';
--SELECT DISTINCT city FROM station WHERE city NOT LIKE '%[aeiou]';
--SELECT DISTINCT city FROM station WHERE city NOT LIKE '%[aeiou]' OR city NOT LIKE '[aeiou]%';

--SELECT LEN(first_name)-3 FROM employee;


--Extract 3 characters from a string (starting from right):
--SELECT name FROM students WHERE marks > 75 ORDER BY RIGHT(name,3), id ASC


SELECT first_name + ' (' + UPPER(SUBSTRING(first_name, 1, 1)) + ')' FROM employee ORDER BY first_name;
SELECT 'There are a total of '+ CONVERT(varchar(2), COUNT(DISTINCT sex))+' '+ sex+'s.' FROM employee GROUP BY sex;
--CONVERT(INT, CONVERT(VARCHAR(12), a.value))
SELECT COUNT(sex),sex FROM employee GROUP BY sex;