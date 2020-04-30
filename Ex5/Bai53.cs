using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Bai53
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            n = Math.Abs(n);
            bool result = thuanNghich(n);
            if(result)
            {
                Console.WriteLine($"{n} la so thuan nghich");
            } else
            {
                Console.WriteLine($"{n} khong la so thuan nghich");
            }
        }

        // 1234
        // dao: 4321
        // m: 0
        static bool thuanNghich(int n)
        {
            int dao = 0;
            int m = n;
            while(m > 0)
            {
                dao = dao * 10 + m % 10;
                m /= 10;
            }
            return dao == n;
        }
    }
}
