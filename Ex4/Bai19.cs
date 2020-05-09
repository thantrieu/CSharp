using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai19
    {
        static void Main()
        {
            int m, n;
            int[] p, q, s;
            NhapBac(out m, out n);
            int max = (m > n) ? m : n;
            p = new int[max + 1];
            q = new int[max + 1];
            s = new int[max + 1];

            Console.WriteLine("Nhap he so da thuc P: ");
            NhapHeSo(p, m);
            Console.WriteLine("Nhap he so da thuc Q: ");
            NhapHeSo(q, n);
            TinhTong(p, q, s);
            Console.WriteLine("Da thuc P(x): ");
            HienThi(p, m);
            Console.WriteLine("Da thuc Q(x): ");
            HienThi(q, n);
            Console.WriteLine("Da thuc S(x): ");
            HienThi(s, max);
        }

        static void HienThi(int[] p, int m)
        {
            for (int i = 0; i <= m; i++)
            {
                Console.Write($"{p[i]}x^{i}");
                if(i < m)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine();
        }

        static void TinhTong(int[] p, int[] q, int[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = p[i] + q[i];
            }
        }

        static void NhapHeSo(int[] p, int m)
        {
            for (int i = 0; i <= m; i++)
            {
                Console.WriteLine($"Nhap he so thu {i}: ");
                p[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void NhapBac(out int m, out int n)
        {
            m = n = 0;
            Console.WriteLine("Nhap bac cua da thuc P(x): ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap bac cua da thuc Q(x): ");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
