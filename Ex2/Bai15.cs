using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai15
    {
        static void Main()
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            if (n < 0)
            {
                n *= -1;
            }
            int tong = 0;
            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }
            Console.WriteLine($"Tong chu so cua {m} = {tong}");
        }
    }
}
