using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Bai2
    {
        static void Main()
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n % 2 == 0)
            {
                Console.WriteLine($"{n} la so chan.");
            } else
            {
                Console.WriteLine($"{n} la so le.");
            }

            if(n % 3 == 0)
            {
                Console.WriteLine($"{n} chia het cho 3.");
            } else
            {
                Console.WriteLine($"{n} khong chia het cho 3.");
            }
        }
    }
}
