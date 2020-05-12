using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static OOP.Calculator;
using static System.Console;

namespace OOP
{
    class StaticClass
    {
        static void Main(string[] args)
        {
            int a = 120, b = 500;
            WriteLine("a + b = " + Add(a, b));
        }
    }
}
