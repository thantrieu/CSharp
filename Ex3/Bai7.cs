using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises3
{
    class Bai7
    {
        static void Main()
        {
            Console.WriteLine("Nhap h: ");
            int h = Convert.ToInt32(Console.ReadLine());

            if(h > 0)
            {
                for (int i = h; i >= 1; i--)
                {
                    for (int j = 1; j <= h; j++)
                    {
                        if(j <= (h - i))
                        {
                            Console.Write("   ");
                        } else
                        {
                            Console.Write(" * ");
                        }
                    }
                    Console.WriteLine("\n");
                }
            } else
            {
                Console.WriteLine("Nhap chieu cao h > 0");
            }
        }
    }
}
