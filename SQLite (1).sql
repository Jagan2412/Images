--SELECT Clause:
SELECT first_name, last_name FROM employees;

--FROM Clause:
SELECT product_name, price FROM products;

--WHERE Clause:
SELECT product_name, price FROM products WHERE price > 50;

--ORDER BY Clause:
SELECT product_name, price FROM products ORDER BY price DESC;

--GROUP BY Clause:
SELECT category, COUNT(*) FROM products GROUP BY category;

--HAVING Clause:
SELECT category, COUNT(*) FROM products GROUP BY category HAVING COUNT(*) > 5;

--DISTINCT Clause:
SELECT DISTINCT country FROM customers;

--JOIN Clause:
SELECT orders.order_id, customers.customer_name
FROM orders
INNER JOIN customers ON orders.customer_id = customers.customer_id;

--UPDATE Clause:
UPDATE employees SET salary = salary * 1.1 WHERE department_id = 2;

--DELETE Clause:
DELETE FROM customers WHERE last_purchase_date < '2023-01-01';

--INSERT INTO Clause:
INSERT INTO products (product_name, price) VALUES ('New Product', 75.99);

--TOP Clause:
SELECT TOP 5 product_name, price FROM products ORDER BY price DESC;

--EXISTS Clause:
SELECT product_name FROM products WHERE EXISTS (SELECT * FROM low_stock_products WHERE products.product_id = low_stock_products.product_id);

--CASE Statement:
SELECT product_name, 
       CASE 
         WHEN price > 100 THEN 'Expensive'
         WHEN price > 50 THEN 'Moderate'
         ELSE 'Inexpensive'
       END AS price_category
FROM products;

--UNION and UNION ALL:
SELECT employee_id, first_name FROM employees
UNION
SELECT employee_id, first_name FROM temporary_employees;

--IN Clause:
SELECT product_name, price FROM products WHERE category IN ('Electronics', 'Appliances');

--LIKE Clause:
SELECT product_name FROM products WHERE product_name LIKE 'Laptop%';

--BETWEEN Clause:
SELECT order_id, order_date FROM orders WHERE order_date BETWEEN '2023-01-01' AND '2023-12-31';






