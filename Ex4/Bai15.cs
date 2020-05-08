using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai15
    {
        static void Main()
        {
            int[] a, b, c;
            Console.WriteLine("Nhap mang A: ");
            NhapMang(out a);
            Console.WriteLine("Nhap mang B: ");
            NhapMang(out b);
            int k = NhapK(a.Length);
            Chen(a, b, out c, k);
            Console.WriteLine("Mang A: ");
            HienMang(a);
            Console.WriteLine("Mang B: ");
            HienMang(b);
            Console.WriteLine("Mang sau khi chen: ");
            HienMang(c);
        }

        private static void Chen(int[] a, int[] b, out int[] c, int k)
        {
            int j = 0;
            c = new int[a.Length + b.Length];
            // copy cac phan tu truoc vi tri k mang a
            // copy mang b
            // copy phan con lai cua mang a
            for (int i = 0; i < k; i++)
            {
                c[j] = a[i];
                j++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[j++] = b[i];
            }
            for (int i = k; i < a.Length; i++)
            {
                c[j++] = a[i];
            }
        }

        static int NhapK(int length)
        {
            int k = -1;
            while(k < 0 || k >= length)
            {
                Console.WriteLine($"Nhap gia tri 0 <= k < {length}");
                k = Convert.ToInt32(Console.ReadLine());
            }
            return k;
        }

        static void HienMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void NhapMang(out int[] arr)
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Phan tu thu {i} = ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Nhap so phan tu mang > 0");
                arr = null;
            }
        }

    }
}
