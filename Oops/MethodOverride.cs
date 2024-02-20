using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    class MethodOverride
    {
        static void Main()
        {
            Shape shape1 = new Circle();
            Shape shape2 = new Square();

            shape1.Draw(); // Drawing a circle
            shape2.Draw(); // Drawing a square
        }
    }

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }

}
