-- Create Departments Table
CREATE TABLE departments (
    department_id INT PRIMARY KEY,
    department_name VARCHAR(255)
);

-- Insert Sample Data into Departments Table
INSERT INTO departments (department_id, department_name) VALUES
(1, 'HR'),
(2, 'IT'),
(3, 'Finance'),
(4, 'Marketing');

-- Create Employees Table
CREATE TABLE employees (
    employee_id INT PRIMARY KEY,
    employee_name VARCHAR(255),
    department_id INT,
    manager_id INT,
    salary DECIMAL(10, 2),
    FOREIGN KEY (department_id) REFERENCES departments(department_id),
    FOREIGN KEY (manager_id) REFERENCES employees(employee_id)
);

-- Insert Sample Data into Employees Table
INSERT INTO employees (employee_id, employee_name, department_id, manager_id, salary) VALUES
(1, 'John Doe', 1, NULL, 50000.00),
(2, 'Jane Smith', 1, 1, 60000.00),
(3, 'Bob Johnson', 2, 1, 55000.00),
(4, 'Alice Williams', 2, 3, 65000.00),
(5, 'Charlie Brown', 3, 1, 70000.00),
(6, 'David Lee', 3, 5, 75000.00),
(7, 'Eva Davis', 4, 3, 80000.00);

-- Note: In the employees table, the manager_id is a self-referencing foreign key indicating the manager of each employee.
