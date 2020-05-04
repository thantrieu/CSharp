using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises3
{
    class Bai9
    {
        static void Main()
        {
            Console.WriteLine("Nhap h > 0: ");
            int h = Convert.ToInt32(Console.ReadLine());
            if(h > 0)
            {
                for (int i = 1; i <= h; i++)
                {
                    for (int j = 1; j < 2*h; j++)
                    {
                        int index = Math.Abs(h - j);
                        if(index < i)
                        {
                            Console.Write(" " + Math.Abs(i - index) + " ");
                        } else
                        {
                            Console.Write("   ");
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
