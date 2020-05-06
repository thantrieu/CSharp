using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai6
    {
        static void Main()
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n > 0)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Phan tu thu {i}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                int demChan = 0;
                int tongChan = 0;
                int tongLe = 0;
                for (int i = 0; i < n; i++)
                {
                    if(arr[i] % 2 == 0)
                    {
                        tongChan += arr[i];
                        demChan++;
                    } else
                    {
                        tongLe += arr[i];
                    }
                }

                Console.WriteLine("Cac phan tu trong mang: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                double tbc = (demChan == 0) ? 0 : 1.0 * tongChan / demChan;
                double tbl = (n - demChan == 0) ? 0 : tongLe / (n - demChan);
                Console.WriteLine("TB chan = " + tbc);
                Console.WriteLine("TB le = " + tbl);
            }
        }
    }
}
