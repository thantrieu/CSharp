using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai7
    {
        static void Main()
        {
            Console.WriteLine("Nhap so duong n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n > 0)
            {
                int dem = 0;
                for (int i = 1; i <= n; i++)
                {
                    if(n % i == 0)
                    {
                        Console.Write(i + " ");
                        dem++;
                    }
                }
                Console.WriteLine("\nSo uoc tu nhien cua n la: " + dem);
            } else
            {
                Console.WriteLine("n phai la so nguyen duong.");
            }
        }
    }
}
