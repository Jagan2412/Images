using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Collections
    {
        static void Main(string[] args)
        {
            List();

            Dictionary();

            HashSet();

            Queue();

            Stack();

            ArrayList();

            LinkedList();

            Console.ReadLine();
        }

        private static void List()
        {
            // List example
            List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5 };

            // Adding elements to the list
            myNumbers.Add(6);

            // Iterating through the list
            foreach (int number in myNumbers)
            {
                Console.Write($"{number} ");
            }
        }

        private static void Dictionary()
        {
            // Dictionary example
            Dictionary<string, int> ageMap = new Dictionary<string, int>
            {
                {"John", 30},
                {"Alice", 25},
                {"Bob", 40}
            };

            // Accessing elements in the dictionary
            int johnsAge = ageMap["John"];

            // Iterating through the dictionary
            foreach (var entry in ageMap)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        private static void HashSet()
        {

            // HashSet example
            HashSet<string> uniqueNames = new HashSet<string> { "Alice", "Bob", "Alice" };

            // Iterating through the HashSet
            foreach (string name in uniqueNames)
            {
                Console.Write($"{name} ");
            }
        }

        private static void Queue()
        {
            // Queue example
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("First");
            myQueue.Enqueue("Second");

            // Dequeue elements
            while (myQueue.Count > 0)
            {
                string element = myQueue.Dequeue();
                Console.Write($"{element} ");
            }
        }

        private static void Stack()
        {
            // Stack example
            Stack<string> myStack = new Stack<string>();
            myStack.Push("First");
            myStack.Push("Second");

            // Pop elements
            while (myStack.Count > 0)
            {
                string element = myStack.Pop();
                Console.Write($"{element} ");
            }
        }

        private static void ArrayList()
        {
            // ArrayList example
            ArrayList myArrayList = new ArrayList { 1, "Hello", 3.14 };

            // Iterating through the ArrayList
            foreach (var item in myArrayList)
            {
                Console.Write($"{item} ");
            }
        }
        private static void LinkedList()
        {
            // LinkedList example
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);

            // Iterating through the LinkedList
            foreach (int number in linkedList)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
