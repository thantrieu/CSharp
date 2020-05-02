using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so tu nhien n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("Cac so chan thoa man: ");
                for (int i = 0; i <= n; i += 2)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Cac so le thoa man: ");
                for (int i = 1; i <= n; i += 2)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nhap n > 0.");
            }
        }
    }
}
