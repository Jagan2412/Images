using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    class MethodOverloading
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            int result1 = calculator.Add(5, 10);
            double result2 = calculator.Add(3.5, 7.2);
            string result3 = calculator.Add("Hello, ", "World!");

            Console.WriteLine(result1); // 15
            Console.WriteLine(result2); // 10.7
            Console.WriteLine(result3); // Hello, World!
        }
    }
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }
    }

}
