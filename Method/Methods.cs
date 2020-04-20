using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    /*
     * Phương thức trong C#
     * - Định nghĩa
     * - Mục đích sử dụng
     * - Cú pháp tổng quát
     * - Kiểu trả về
     * - Ví dụ minh họa
     */
    class Methods
    {
        static void Main(string[] args)
        {
            // data_type name(parameters) {.....}
            // ten(tham so);
            int sum = Sum(100, 255);
            int a = 120, b = 66;
            int sum2 = Sum(b, 80);
            ShowResult(sum);
            ShowResult(sum2);
        }

        static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static double div(int a, int b)
        {
            return 1.0 * a / b;
        }

        static bool isEven(int n)
        {
            return (n % 2 == 0);
        }

        static void ShowResult(int n)
        {
            Console.WriteLine(n);
        }
    }
}
