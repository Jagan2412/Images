using System;
namespace ConsoleApp2
{
    // Generic class to represent a pair of values
    public class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
    }

    public class GenericClassExample
    {
        public static void Main()
        {
            Pair<string, int> person = new Pair<string, int>
            {
                First = "John",
                Second = 30
            };

            Console.WriteLine($"Name: {person.First}, Age: {person.Second}");
        }
    }
}
