using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises3
{
    class Bai12
    {
        static void Main()
        {
            Console.WriteLine("Nhap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b > a: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    bool ngTo = true;
                    if (i < 2)
                    {
                        ngTo = false;
                    }
                    else
                    {
                        for (int j = 2; j <= Math.Sqrt(i); j++)
                        {
                            if(i % j == 0)
                            {
                                ngTo = false;
                                break;
                            }
                        }
                    }
                    if(ngTo)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nhap b > a");
            }
        }
    }
}
