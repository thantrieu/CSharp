using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai18
    {
        static void Main()
        {
            Console.WriteLine("Nhap do chinh xac(vd: 0.00001)");
            double a = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            int k = 0;
            double tmp = 1.0 / (2 * k + 1);
            while (true)
            {
                tmp = 1.0 / (2 * k + 1);
                sum += Math.Pow(-1, k) * tmp;
                k++;
                if (tmp <= a)
                {
                    break;
                }
            }

            Console.WriteLine("PI = " + (4 * sum));
        }
    }
}
