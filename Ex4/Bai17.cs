using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai17
    {
        static void Main()
        {
            int[] a = Nhap();
            int kq = Tinh(a);
            Console.WriteLine("Gia tri da thuc P(x) = " + kq);
        }

        static int Tinh(int[] a)
        {
            if(a == null)
            {
                Console.WriteLine("Da thuc can co bac > 0.");
                return 0;
            }
            Console.WriteLine("Nhap x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int kq = a[0];
            int mu = 1;
            for (int i = 1; i < a.Length; i++)
            {
                mu *= x;
                kq += a[i] * mu;
            }
            return kq;
        }

        static int[] Nhap()
        {
            int n;
            Console.WriteLine("Nhap bac da thuc: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a;
            if(n > 0)
            {
                a = new int[n + 1];
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine($"Nhap he so a{i}: ");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
            } else
            {
                a = null;
            }
            return a;
        }
    }
}
