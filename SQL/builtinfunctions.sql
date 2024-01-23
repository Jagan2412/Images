
--String Functions:

-- LEN() - Returns the length of a string:
SELECT Name, LEN(Name) AS NameLength
FROM SampleTable;

--LEFT() - Returns a specified number of characters from the left side of a string:
SELECT Name, LEFT(Name, 3) AS LeftThreeCharacters
FROM SampleTable;

--RIGHT() - Returns a specified number of characters from the right side of a string:
SELECT Name, RIGHT(Name, 3) AS RightThreeCharacters
FROM SampleTable;

--CHARINDEX() - Returns the starting position of a substring within a string:
SELECT Name, CHARINDEX('Doe', Name) AS SubstringPosition
FROM SampleTable;

--SUBSTRING() - Extracts a substring from a string:
SELECT Name, SUBSTRING(Name, 2, 3) AS ExtractedSubstring
FROM SampleTable;

--CONCAT() - Concatenates two or more strings:
SELECT Name, CONCAT(Name, ' - ', Age, ' years old') AS ConcatenatedString
FROM SampleTable;


--CHARINDEX() - Returns the starting position of a substring within a string:
SELECT Name, CHARINDEX('Doe', Name) AS SubstringPosition
FROM SampleTable;

--Numeric Functions:

--SUM() - Calculates the sum of a numeric column:
SELECT SUM(Age) AS TotalAge
FROM SampleTable;

--ABS() - Returns the absolute value of a number:
SELECT Age, ABS(Age) AS AbsoluteAge
FROM SampleTable;

--ROUND() - Rounds a numeric value to the nearest integer:
SELECT Age, ROUND(Age/10.0, 0) * 10 AS RoundedAge
FROM SampleTable;

--RAND() - Returns a random float value between 0 and 1:
SELECT RAND() AS RandomValue;

--Date and Time Functions:

--GETDATE() - Returns the current date and time:
SELECT GETDATE() AS CurrentDateTime;

--DATEPART() - Extracts a specific part (year, month, day, etc.) from a date:
SELECT RegistrationDate, DATEPART(YEAR, RegistrationDate) AS RegistrationYear
FROM SampleTable;

--DATEDIFF() - Calculates the difference between two dates:
SELECT DATEDIFF(DAY, '2022-01-01', '2022-03-01') AS DaysDifference;

--DATEADD() - Adds or subtracts a specific time interval to a date:
SELECT RegistrationDate, DATEADD(MONTH, 3, RegistrationDate) AS AddedThreeMonths
FROM SampleTable;

--Conversion Functions:

-- Using CAST to convert Age from INT to VARCHAR
SELECT Name, Age, CAST(Age AS VARCHAR(5)) AS AgeAsString
FROM SampleTable;

-- Using CONVERT to change the format of RegistrationDate
SELECT Name, RegistrationDate, CONVERT(VARCHAR, RegistrationDate, 103) AS FormattedRegistrationDate
FROM SampleTable;

-- Using PARSE to convert a string to a datetime
SELECT '2022-01-15' AS DateString,
       PARSE('2022-01-15' AS DATETIME) AS ParsedDate;

--Logical Functions:

-- Using CASE to categorize individuals based on Age
SELECT Name, Age,
    CASE
        WHEN Age < 25 THEN 'Young'
        WHEN Age >= 25 AND Age < 35 THEN 'Adult'
        ELSE 'Senior'
    END AS AgeCategory
FROM SampleTable;


-- Using IIF to categorize individuals based on Age
SELECT Name, Age,
    IIF(Age < 25, 'Young', 'Adult') AS AgeCategory
FROM SampleTable;




