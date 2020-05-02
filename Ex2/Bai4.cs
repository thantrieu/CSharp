using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai4
    {
        static void Main()
        {
            Console.WriteLine("Nhap so tu nhien n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int tong = 0;
                int tongChan = 0;
                int tongLe = 0;
                int nLe = 0;
                int nChan = 0;

                for (int i = 1; i <= n; i++)
                {
                    tong += i;
                    if (i % 2 != 0)
                    {
                        tongLe += i;
                        nLe += 1;
                    }
                    else
                    {
                        tongChan += i;
                        nChan++;
                    }
                }

                // Ctrl K Ctrl D
                Console.WriteLine("TBC = " + 1f * tong / n);
                if (nChan > 0)
                {
                    Console.WriteLine("TBC so chan = " + tongChan * 1f / nChan);
                }
                else
                {
                    Console.WriteLine("TBC so chan = 0");
                }

                if (nLe > 0)
                {
                    Console.WriteLine("TBC le = " + 1f * tongLe / nLe);
                }
                else
                {
                    Console.WriteLine("TBC le = 0");
                }
            }
            else
            {
                Console.WriteLine("Nhap n > 0.");
            }
        }
    }
}
