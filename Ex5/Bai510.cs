using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Bai510
    {
        static void Main()
        {
            int[] numbers = NhapMang();
            HienThiMang(numbers);
            SapXep(numbers);
            HienThiMang(numbers);
        }

        private static void SapXep(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = numbers.Length - 1; j > i; j--)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        Swap(ref numbers[j], ref numbers[j - 1]);
                    }
                }
            }
        }

        private static void Swap(ref int v1, ref int v2)
        {
            int tmp = v1;
            v1 = v2;
            v2 = tmp;
        }

        private static void HienThiMang(int[] numbers)
        {
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] NhapMang()
        {
            int n = 0;
            while (n <= 0)
            {
                Console.WriteLine("Nhap so luong phan tu mang: ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
    }
}
