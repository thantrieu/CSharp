using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Constructor
    {
        static void Main()
        {
            // constructor
            Dog bob = new Dog(color: "Green");
            Console.WriteLine("Name: " + bob.name);
            Console.WriteLine("Color: " + bob.color);
        }
    }
}
