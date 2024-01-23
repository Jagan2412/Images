-- Creating a sample table
CREATE TABLE SampleTable (
    ID INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT,
    RegistrationDate DATETIME
);

-- Inserting sample data
INSERT INTO SampleTable (ID, Name, Age, RegistrationDate)
VALUES
    (1, 'John Doe', 25, '2022-01-01 10:30:00'),
    (2, 'Jane Smith', 30, '2022-02-15 14:45:00'),
    (3, 'Bob Johnson', 22, '2022-03-20 08:00:00');
