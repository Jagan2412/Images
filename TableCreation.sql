-- Example table: employees
CREATE TABLE employees (
    employee_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    salary DECIMAL(10, 2),
    department_id INT
);

-- Example table: products
CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100),
    price DECIMAL(10, 2),
    category VARCHAR(50)
);

-- Example table: orders
CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    customer_id INT,
    order_date DATE
);

-- Example table: customers
CREATE TABLE customers (
    customer_id INT PRIMARY KEY,
    customer_name VARCHAR(100),
    country VARCHAR(50),
    last_purchase_date DATE
);

-- Example table: low_stock_products
CREATE TABLE low_stock_products (
    product_id INT PRIMARY KEY
);

-- Example table: temporary_employees
CREATE TABLE temporary_employees (
    employee_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    salary DECIMAL(10, 2),
    department_id INT
);

-- Insert data into the tables
INSERT INTO employees VALUES
(1, 'John', 'Doe', 60000, 1),
(2, 'Jane', 'Smith', 75000, 2),
(3, 'Bob', 'Johnson', 50000, 1);

INSERT INTO products VALUES
(1, 'Laptop', 1200.99, 'Electronics'),
(2, 'Refrigerator', 799.99, 'Appliances'),
(3, 'Smartphone', 599.99, 'Electronics');

INSERT INTO orders VALUES
(101, 1, '2023-01-15'),
(102, 2, '2023-02-20'),
(103, 1, '2023-03-10');

INSERT INTO customers VALUES
(1, 'ACME Corp', 'USA', '2023-01-05'),
(2, 'Global Tech', 'Canada', '2023-02-18'),
(3, 'Tech Solutions', 'UK', '2023-03-08');

INSERT INTO low_stock_products VALUES
(2);

INSERT INTO temporary_employees VALUES
(4, 'Eva', 'Williams', 65000, 2),
(5, 'Alex', 'Brown', 55000, 1);
