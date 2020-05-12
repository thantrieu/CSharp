using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class This
    {
        static void Main()
        {
            // this keyword
            Dog bob = new Dog();
            Dog bull = new Dog(name: "Bull");
            Dog pee = new Dog(name: "Pee");
            bob.name = "Bull";
        }
    }
}
