using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai8
    {
        static void Main()
        {
            int[] arr = NhapMang();
            bool doiXung = KiemTra(arr);
            HienThi(arr);
            if(doiXung)
            {
                Console.WriteLine("Mang doi xung");
            } else
            {
                Console.WriteLine("Mang khong doi xung");
            }
        }

        static void HienThi(int[] arr)
        {
            Console.WriteLine("Cac phan tu trong mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static bool KiemTra(int[] arr)
        {
            int mid = arr.Length / 2;
            for (int i = 0; i <= mid; i++)
            {
                if(arr[i] != arr[arr.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static int[] NhapMang()
        {
            int n = 0;
            while(n <= 0)
            {
                Console.WriteLine("Nhap so phan tu mang: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Phan tu thu {i}: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            return a;
        }
    }
}
