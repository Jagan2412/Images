
namespace ConsoleApp2
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            SingleDimensionalArray();

            MultiDimensionalArray();

            JaggedArray();

            Console.ReadLine();
        }

        private static void SingleDimensionalArray()
        {
            // Declaration and initialization of a single-dimensional array of strings
            string[] stringArray = new string[] { "Apple", "Banana", "Orange", "Grapes" };

            // Accessing elements
            string secondElement = stringArray[1];

            // Modifying an element
            stringArray[0] = "Mango";

            // Iterating through the array
            foreach (string fruit in stringArray)
            {
                Console.WriteLine(fruit);
            }
        }

        private static void MultiDimensionalArray()
        {
            // Declaration and initialization of a 2D array of strings
            string[,] twoDStringArray = new string[,] { { "John", "Alice" }, { "Bob", "Eve" } };

            // Accessing elements
            string person = twoDStringArray[1, 0];

            // Iterating through the array
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{twoDStringArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void JaggedArray()
        {
            // Declaration and initialization of a jagged array of strings
            string[][] jaggedStringArray = new string[][]
            {
                new string[] { "Red", "Blue", "Green" },
                new string[] { "Yellow", "Purple" },
                new string[] { "Orange", "Pink", "Brown" }
            };

            // Accessing elements
            string color = jaggedStringArray[0][1];

            // Iterating through the array
            foreach (string[] colorArray in jaggedStringArray)
            {
                foreach (string item in colorArray)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
    }
}
