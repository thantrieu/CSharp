using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai11
    {
        static void Main()
        {
            Console.WriteLine("Nhap n > 0: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 0)
            {
                int m = 2;
                int dem = 0;
                while(dem < n)
                {
                    bool ngTo = true;
                    for (int i = 2; i <= Math.Sqrt(m); i++)
                    {
                        if(m % i == 0)
                        {
                            ngTo = false;
                            break;
                        }
                    }
                    if(ngTo)
                    {
                        Console.Write(m + " ");
                        dem++;
                    }
                    m++;
                }
            } else
            {
                Console.WriteLine("Nhap so duong n.");
            }
            Console.WriteLine();
        }
    }
}
