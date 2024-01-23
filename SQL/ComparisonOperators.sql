-- Create a table
CREATE TABLE ComparisonExample (
    id INT,
    score INT
);

-- Insert data
INSERT INTO ComparisonExample (id, score)
VALUES (1, 80), (2, 95), (3, 60);

-- Equal to
SELECT id, score
FROM ComparisonExample
WHERE score = 95;

-- Not equal to
SELECT id, score
FROM ComparisonExample
WHERE score <> 60;

-- Greater than
SELECT id, score
FROM ComparisonExample
WHERE score > 80;

-- Less than or equal to
SELECT id, score
FROM ComparisonExample
WHERE score <= 80;
