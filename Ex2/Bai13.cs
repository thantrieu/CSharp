using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai13
    {
        static void Main()
        {
            Console.WriteLine("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n > 0)
            {
                int m = n;
                int dao = 0;
                while(m > 0)
                {
                    dao = dao * 10 + m % 10;
                    m /= 10;
                }
                if(n == dao)
                {
                    Console.WriteLine($"{n} la so thuan nghich");
                } else
                {
                    Console.WriteLine("Khong phai so thuan nghich");
                }
            } else
            {
                Console.WriteLine("Nhap lai n >= 0");
            }
        }
    }
}
