using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Bai57
    {
        static void Main()
        {
            int n;
            nhapN(out n);
            int result = tongChuSo(n);
            Console.WriteLine($"Tong chu so cua {n} = {result}");
        }

        static int tongChuSo(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static void nhapN(out int n)
        {
            n = 0;
            while(n <= 0)
            {
                Console.WriteLine("Nhap so nguyen duong n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
