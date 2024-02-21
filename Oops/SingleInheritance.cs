using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    //Real-world example: A class hierarchy for different types of vehicles.

    internal class SingleInheritance
    {
    }

    public class Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating.");
        }
    }

}
