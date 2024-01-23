--INNER JOIN:
SELECT *
FROM employees
INNER JOIN departments ON employees.department_id = departments.department_id;

--This query retrieves all columns from both tables where there is a match based on the department_id. Only the rows with matching values in both tables are returned.

--LEFT JOIN:
SELECT *
FROM employees
LEFT JOIN departments ON employees.department_id = departments.department_id;

--This query returns all rows from the employees table and the matching rows from the departments table. If there is no match, NULL values are returned for columns from the departments table.

--RIGHT JOIN:
SELECT *
FROM employees
RIGHT JOIN departments ON employees.department_id = departments.department_id;

--This query returns all rows from the departments table and the matching rows from the employees table. If there is no match, NULL values are returned for columns from the employees table.

--FULL JOIN:
SELECT *
FROM employees
FULL JOIN departments ON employees.department_id = departments.department_id;

--This query returns all rows when there is a match in either the employees or departments table. If there is no match, NULL values are returned for columns from the table without a match.

--CROSS JOIN:
SELECT *
FROM employees
CROSS JOIN departments;

--This query returns the Cartesian product of the two tables, meaning all possible combinations of rows from both tables.

--SELF JOIN:
SELECT e1.employee_id, e1.employee_name, e2.manager_name
FROM employees e1
INNER JOIN employees e2 ON e1.manager_id = e2.employee_id;

--This query retrieves information about employees and their corresponding managers from the same table. It uses a self-join on the manager_id and employee_id columns.
