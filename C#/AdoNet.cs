using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Replace with your actual connection string
        string connectionString = "Data Source=(local);Initial Catalog=YourDatabase;Integrated Security=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            while (true)
            {
                Console.WriteLine("Choose operation:");
                Console.WriteLine("1. Select");
                Console.WriteLine("2. Insert");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SelectOperation(connection);
                        break;
                    case "2":
                        InsertOperation(connection);
                        break;
                    case "3":
                        UpdateOperation(connection);
                        break;
                    case "4":
                        DeleteOperation(connection);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

    static void SelectOperation(SqlConnection connection)
    {
        Console.WriteLine("Executing SELECT operation:");

        // Replace with your actual SELECT query
        string query = "SELECT * FROM YourTable";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Display the selected data, adjust as needed
                    Console.WriteLine($"{reader["Column1"]}, {reader["Column2"]}, ...");
                }
            }
        }
    }

    static void InsertOperation(SqlConnection connection)
    {
        Console.WriteLine("Executing INSERT operation:");

        // Replace with your actual INSERT query and parameterization
        string query = "INSERT INTO YourTable (Column1, Column2, ...) VALUES (@Value1, @Value2, ...)";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            // Add parameters and their values
            command.Parameters.AddWithValue("@Value1", "NewValue1");
            command.Parameters.AddWithValue("@Value2", "NewValue2");
            // Add more parameters as needed

            int rowsAffected = command.ExecuteNonQuery();

            Console.WriteLine($"{rowsAffected} row(s) inserted.");
        }
    }

    static void UpdateOperation(SqlConnection connection)
    {
        Console.WriteLine("Executing UPDATE operation:");

        // Replace with your actual UPDATE query and parameterization
        string query = "UPDATE YourTable SET Column1 = @NewValue1 WHERE Column2 = @ConditionValue";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            // Add parameters and their values
            command.Parameters.AddWithValue("@NewValue1", "UpdatedValue1");
            command.Parameters.AddWithValue("@ConditionValue", "ConditionValue");
            // Add more parameters as needed

            int rowsAffected = command.ExecuteNonQuery();

            Console.WriteLine($"{rowsAffected} row(s) updated.");
        }
    }

    static void DeleteOperation(SqlConnection connection)
    {
        Console.WriteLine("Executing DELETE operation:");

        // Replace with your actual DELETE query and parameterization
        string query = "DELETE FROM YourTable WHERE Column1 = @ConditionValue";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            // Add parameters and their values
            command.Parameters.AddWithValue("@ConditionValue", "ConditionValue");
            // Add more parameters as needed

            int rowsAffected = command.ExecuteNonQuery();

            Console.WriteLine($"{rowsAffected} row(s) deleted.");
        }
    }
}
