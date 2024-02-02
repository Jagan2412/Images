using System;
namespace ConsoleApp2
{
    public class GenericExample
    {
        // Generic method to swap two values
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Main()
        {
            int x = 5, y = 10;
            Console.WriteLine($"Before swapping: x = {x}, y = {y}");

            Swap(ref x, ref y);

            Console.WriteLine($"After swapping: x = {x}, y = {y}");

            string str1 = "Hello", str2 = "World";
            Console.WriteLine($"Before swapping: str1 = {str1}, str2 = {str2}");

            Swap(ref str1, ref str2);

            Console.WriteLine($"After swapping: str1 = {str1}, str2 = {str2}");
        }
    }
}
