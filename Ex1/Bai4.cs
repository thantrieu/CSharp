using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Bai4
    {
        static void Main()
        {
            Console.WriteLine("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a < b)
            {
                Console.WriteLine($"{a} < {b}");
            } else if(a == b)
            {
                Console.WriteLine($"{a} == {b}");
            } else
            {
                Console.WriteLine($"{a} > {b}");
            }
        }
    }
}
