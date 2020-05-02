using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Bai6
    {
        static void Main()
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            if(a == b && b ==c && c == d)
            {
                Console.WriteLine("Khong co gia tri thoa man");
            } else
            {
                // tim max
                int max = a;
                if(max < b)
                {
                    max = b;
                }
                if(max < c)
                {
                    max = c;
                }
                if(max < d)
                {
                    max = d;
                }

                // tim min:
                int min = a;
                if(min > b)
                {
                    min = b;
                }
                if(min > c)
                {
                    min = c;
                }
                if(min > d)
                {
                    min = d;
                }

                // tim max2
                int max2 = min;
                if(max2 < a && a != max)
                {
                    max2 = a;
                }
                if (max2 < b && b != max)
                {
                    max2 = b;
                }
                if (max2 < c && c != max)
                {
                    max2 = c;
                }
                if (max2 < d && d != max)
                {
                    max2 = d;
                }

                Console.WriteLine("Gia tri lon nhat: "  + max);
                Console.WriteLine("Gia tri lon thu hai: " + max2);
            }
        }
    }
}
