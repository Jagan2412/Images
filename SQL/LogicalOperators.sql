-- Create a table
CREATE TABLE LogicalExample (
    id INT,
    age INT,
    salary INT
);

-- Insert data
INSERT INTO LogicalExample (id, age, salary)
VALUES (1, 25, 50000), (2, 30, 70000), (3, 22, 45000);

-- Logical AND
SELECT id, age, salary
FROM LogicalExample
WHERE age > 22 AND salary > 50000;

-- Logical OR
SELECT id, age, salary
FROM LogicalExample
WHERE age > 28 OR salary > 60000;

-- Logical NOT
SELECT id, age, salary
FROM LogicalExample
WHERE NOT (age > 25);
