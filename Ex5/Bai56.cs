using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Bai56
    {
        static void Main()
        {
            int n;
            nhapN(out n);
            hienThiKQ(n);
            Console.WriteLine();
        }

        static void hienThiKQ(int n)
        {
            long f0 = 0, f1 = 1, fn;
            for (int i = 0; i < n; i++)
            {
                if(i < 2)
                {
                    fn = i;
                } else
                {
                    fn = f0 + f1;
                    f0 = f1;
                    f1 = fn;
                }
                Console.Write(fn + " ");
            }
        }

        static void nhapN(out int n)
        {
            n = 0;
            while(n <= 0)
            {
                Console.WriteLine("Nhap n > 0: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
