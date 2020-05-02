using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai3
    {
        static void Main()
        {
            Console.WriteLine("Nhap n > 0: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 0)
            {
                float sum = default;
                for (int i = 1; i <= n; i++)
                {
                    sum += 1f / i;
                }
                Console.WriteLine("KQ = " + sum);
            } else
            {
                Console.WriteLine("Nhap n > 0");
            }
        }
    }
}
