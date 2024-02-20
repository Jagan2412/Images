using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    // Base class

    class Inheritance
    {
        static void Main()
        {
            // Creating an instance of the derived class
            Dog myDog = new Dog();

            // Accessing methods from the base class
            myDog.Eat();    // Output: Animal is eating
            myDog.Sleep();  // Output: Animal is sleeping

            // Accessing method from the derived class
            myDog.Bark();   // Output: Dog is barking
        }
    }

    //Base Class
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }

    // Derived class inheriting from Animal
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }


}
