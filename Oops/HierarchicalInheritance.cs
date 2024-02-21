using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /* Real-world example: Representing different types of animals with a common base class. */

    internal class HierarchicalInheritance
    {
    }

    public class Animal
    {
        public string Species { get; set; }

        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    public class Mammal : Animal
    {
        public void GiveBirth()
        {
            Console.WriteLine("Mammal is giving birth.");
        }
    }

    public class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }


}
