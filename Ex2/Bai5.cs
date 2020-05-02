using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai5
    {
        static void Main()
        {
            Console.WriteLine("Nhap so duong n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                long giaiThua = 1;
                long tongGT = 0;
                for (int i = 1; i <= n; i++)
                {
                    giaiThua *= i;
                    tongGT += giaiThua;
                }
                Console.WriteLine("S = 1! + 2 ! + ... + n! = " + tongGT);
            }
            else
            {
                Console.WriteLine("Nhap n > 0.");
            }
        }
    }
}
