using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Bai512
    {
        static void Main()
        {
            LietKe();
        }

        private static void LietKe()
        {
            int count = 0;
            for (int i = 10000000; i < 100000000; i++)
            {
                if(ChuSoNgTo(i) && NgTo(i) && TongCSNGTo(i))
                {
                    Console.Write(i + " ");
                    count++;
                    if(count % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        private static bool TongCSNGTo(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return NgTo(sum);
        }

        private static bool ChuSoNgTo(int n)
        {
            while(n > 0)
            {
                int d = n % 10;
                if(!NgTo(d))
                {
                    return false;
                }
                n /= 10;
            }
            return true;
        }

        private static bool NgTo(int n)
        {
            if(n < 2)
            {
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
