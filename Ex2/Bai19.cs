using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai19
    {
        static void Main()
        {
            Console.WriteLine("Nhap x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap do chinh xac: ");
            double a = Convert.ToDouble(Console.ReadLine());

            int k = 0;
            double sum = 0;
            double xMuK = x;
            long g = 1;
            double tmp = 1.0 / g;
            while(true)
            {
                sum += tmp;
                k++;
                xMuK = Math.Pow(x, k);
                g *= k;
                tmp = xMuK / g;
                if(tmp <= a) {
                    break;
                }
            }
            Console.WriteLine("e^x = " + sum);
        }
    }
}
