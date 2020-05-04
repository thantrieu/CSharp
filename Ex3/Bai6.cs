using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises3
{
    class Bai6
    {
        static void Main()
        {
            Console.WriteLine("Nhap chieu cao h: ");
            int h = Convert.ToInt32(Console.ReadLine());

            if(h > 0)
            {
                for (int i = 1; i <= h; i++)
                {
                    for (int j = 1; j <= h; j++)
                    {
                        if(j <= h - i)
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
                Console.WriteLine("Nhap chieu cao > 0.");
            }
        }
    }
}
