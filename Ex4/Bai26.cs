using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai26
    {
        static void Main()
        {
            int m, n;
            int[,] a;
            int start = 0;
            Nhap(out m, out n);
            a = new int[m, n];
            int x1 = 0, x2 = n - 1;
            int y1 = 0, y2 = m - 1;
            TopRight(ref a, x1, x2, y1, y2, ref start);
            HienThi(a, m, n);
        }

        static void HienThi(int[,] a, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5}", a[i, j]);
                }
                Console.WriteLine("\n");
            }
        }

        static void TopRight(ref int[,] a, int x1, int x2, int y1, int y2, ref int start)
        {
            for (int i = x1; i <= x2; i++)
            {
                a[y1, i] = start++;
            }
            for (int i = y1 + 1; i <= y2; i++)
            {
                a[i, x2] = start++;
            }
            if(x1 < x2 && y1 < y2)
            {
                y1++;
                x2--;
                BottomLeft(ref a, x1, x2, y1, y2, ref start);
            }
        }

        static void BottomLeft(ref int[,] a, int x1, int x2, int y1, int y2, ref int start)
        {
            for (int i = x2; i >= x1; i--)
            {
                a[y2, i] = start++;
            }
            for (int i = y2 - 1; i >= y1; i--)
            {
                a[i, x1] = start++;
            }
            if (x1 < x2 && y1 < y2)
            {
                x1++;
                y2--;
                TopRight(ref a, x1, x2, y1, y2, ref start);
            }
        }

        static void Nhap(out int m, out int n)
        {
            Console.WriteLine("Nhap so hang: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
