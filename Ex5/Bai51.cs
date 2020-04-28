using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Bai51
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool kq = ktraNgTo(n);
            if(kq)
            {
                Console.WriteLine($"{n} la so nguyen to");
            } else
            {
                Console.WriteLine($"{n} khong phai so nguyen to");
            }
        }

        static bool ktraNgTo(int n)
        {
            if(n < 2) { 
                return false; 
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
