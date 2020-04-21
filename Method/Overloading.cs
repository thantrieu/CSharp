using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Overloading
    {
        static void Main()
        {
            // Nạp chồng phương thức
            int sum = Add(120, 300);
            float s2 = Add(12, 12.36f);
            long s3 = Add(10L, 20, 6);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static float Add(int b, float a)
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static long Add(long a, long b)
        {
            return a + b;
        }

        static long Add(long a, int b, short c)
        {
            return a + b + c;
        }

        static long Add(long a, long b, short c)
        {
            return a + b + c;
        }
    }
}
