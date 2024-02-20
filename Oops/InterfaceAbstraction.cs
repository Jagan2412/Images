using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class InterfaceAbstraction
    {
        static void Main()
        {
            // Creating an instance of the Circle class
            Circle circle = new Circle(5);

            // Calling methods through interfaces
            ((IDrawable)circle).Draw();
            Console.WriteLine($"Circle area: {((ICalculatable)circle).CalculateArea()}");
        }
    }

    // Interface
    public interface IDrawable
    {
        void Draw();
    }

    // Another interface
    public interface ICalculatable
    {
        double CalculateArea();
    }

    // Class implementing both interfaces
    public class Circle : IDrawable, ICalculatable
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        // Implementation of the Draw method from IDrawable
        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {radius}");
        }

        // Implementation of the CalculateArea method from ICalculatable
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }



}
