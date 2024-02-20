namespace ConsoleApp7
{
    using System;

    public class Encapsulation
    {
        // Private fields (data)
        private string make;
        private string model;
        private int year;

        // Public properties (getters and setters)
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                // Validate the year (for example, ensure it's not negative)
                if (value >= 0)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("Invalid year");
                }
            }
        }

        // Public method
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of the Car class
            Encapsulation myCar = new Encapsulation();

            // Access and modify data using public properties
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2022;

            // Access data using public properties
            Console.WriteLine($"Car Info: {myCar.Make} {myCar.Model} {myCar.Year}");

            // Access data using a public method
            myCar.DisplayCarInfo();
        }
    }

}
