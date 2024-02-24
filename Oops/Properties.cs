using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Properties
    {
        //Read-Only Property:

        private int readOnlyValue = 10;

        public int ReadOnlyProperty
        {
            get { return readOnlyValue; }
        }

        //Write-Only Property:

        private int writeOnlyValue;

        public int WriteOnlyProperty
        {
            set { writeOnlyValue = value; }
        }

        //Read-Write Property:
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Auto-implemented Property
        public int AutoProperty { get; set; }

        //Property with Validation
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Age cannot be negative.");
            }
        }

        //Static Property
        private static int staticValue;

        public static int StaticProperty
        {
            get { return staticValue; }
            set { staticValue = value; }
        }


    }

    class Program
    {
        static void Main()
        {
            Properties example = new Properties();

            // Read-Only Property
            int readOnlyValue = example.ReadOnlyProperty;

            // Write-Only Property
            example.WriteOnlyProperty = 20;

            // Read-Write Property
            example.Name = "John";
            string name = example.Name;

            // Auto-implemented Property
            example.AutoProperty = 42;
            int autoPropertyValue = example.AutoProperty;

            // Property with Validation
            example.Age = -5; // Will print "Age cannot be negative."

            // Static Property
            Example.StaticProperty = 100;
            int staticPropertyValue = Example.StaticProperty;
        }
    }

}
