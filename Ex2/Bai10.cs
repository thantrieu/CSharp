using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai10
    {
        static void Main()
        {
            Console.WriteLine("Nhap so duong n > 1: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 1)
            {
                Console.Write($"{n} = ");
                int i = 2;
                while (n > 1)
                {
                    if (n % i == 0)
                    {
                        Console.Write(i);
                        if (n != i)
                        {
                            Console.Write("x");
                        }
                        n /= i;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Nhap n > 1.");
            }
            Console.WriteLine();
        }
    }
}
