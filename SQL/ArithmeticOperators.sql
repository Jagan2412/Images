-- Create a table
CREATE TABLE ArithmeticExample (
    id INT,
    value1 INT,
    value2 INT
);

-- Insert data
INSERT INTO ArithmeticExample (id, value1, value2)
VALUES (1, 10, 5), (2, 15, 3), (3, 8, 2);

-- Addition
SELECT id, value1, value2, value1 + value2 AS sum_result
FROM ArithmeticExample;

-- Subtraction
SELECT id, value1, value2, value1 - value2 AS difference_result
FROM ArithmeticExample;

-- Multiplication
SELECT id, value1, value2, value1 * value2 AS product_result
FROM ArithmeticExample;

-- Division
SELECT id, value1, value2, value1 / value2 AS division_result
FROM ArithmeticExample;

-- Modulo
SELECT id, value1, value2, value1 % value2 AS modulo_result
FROM ArithmeticExample;
