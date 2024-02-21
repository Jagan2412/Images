using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   /* Real-world example: Modeling a GUI framework where different UI elements inherit from 
    a base class and implement specific interfaces for functionality. */

    internal class HybridInheritance
    {
    }

    public class UIElement
    {
        public string Name { get; set; }

        public void Render()
        {
            Console.WriteLine("Rendering UI element.");
        }
    }

    public interface IClickable
    {
        void Click();
    }

    public interface IDraggable
    {
        void Drag();
    }

    public class Button : UIElement, IClickable
    {
        public void Click()
        {
            Console.WriteLine("Button clicked.");
        }
    }

    public class DragDropPanel : UIElement, IClickable, IDraggable
    {
        public void Click()
        {
            Console.WriteLine("Panel clicked.");
        }

        public void Drag()
        {
            Console.WriteLine("Panel dragged.");
        }
    }


}
