using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai12
    {
        static void Main()
        {
            Console.WriteLine("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0)
            {
                long f0 = 0, f1 = 1, fn = 0;
                if (n < 2)
                {
                    fn = n;
                }
                for (int i = 2; i <= n; i++)
                {
                    fn = f0 + f1;
                    f0 = f1;
                    f1 = fn;
                }
                Console.WriteLine($"F{n} = {fn}");
            }
            else
            {
                Console.WriteLine("Nhap so tu nhien n");
            }
        }
    }
}