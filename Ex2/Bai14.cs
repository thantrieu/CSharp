using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai14
    {
        static void Main()
        {
            Console.WriteLine("Nhap so tu nhien n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
            {
                long gt = 1;
                for (int i = n; i >= 1; i--)
                {
                    gt = gt * i;
                }
                Console.WriteLine($"{n}! = {gt}");
            }
            else
            {
                Console.WriteLine("Nhap n nguyen duong");
            }
        }
    }
}
