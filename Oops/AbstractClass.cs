using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    // Abstract class
    class AbstractClass
    {
        static void Main()
        {
            // Creating instances of derived classes
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            // Calling abstract method and concrete method
            circle.Draw();
            circle.DisplayArea();
            Console.WriteLine($"Circle area: {circle.CalculateArea()}");

            Console.WriteLine();

            // Calling abstract method and overridden method
            rectangle.Draw();
            rectangle.DisplayArea(); // Calls the overridden method in Rectangle
        }
    }

    public abstract class Shape
    {
        // Abstract method (to be implemented by derived classes)
        public abstract void Draw();

        // Concrete method
        public void DisplayArea()
        {
            Console.WriteLine("Area calculation not implemented for this shape.");
        }
    }

    // Derived class (inherits from Shape)
    public class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        // Implementation of the abstract method
        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {radius}");
        }

        // Additional method specific to Circle
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class (inherits from Shape)
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        // Implementation of the abstract method
        public override void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with length {length} and width {width}");
        }

        // Implementation of the DisplayArea method for rectangles
        public new void DisplayArea()
        {
            Console.WriteLine($"Area of the rectangle: {length * width}");
        }
    }

}
