using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Bai59
    {
        static void Main()
        {
            int n;
            nhapN(out n);
            int first = FirstDigit(n);
            Console.WriteLine("Chu so dau tien cua {0} la {1}", n, first);
        }

        private static int FirstDigit(int n)
        {
            while(n > 10)
            {
                n /= 10;
            }
            return n;
        }

        private static void nhapN(out int n)
        {
            n = 0;
            while(n <= 0)
            {
                Console.WriteLine("Nhap n > 0: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
        }

        //123

    }
}
