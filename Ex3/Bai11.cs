using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises3
{
    class Bai11
    {
        static void Main()
        {
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if((i == 1 && (j == 1 || j == 4 || j == 7)) || (i == 4 && (j == 1 || j == 7))
                        || (i == 5 && (j <= 2 || j >= 6)) || (i == 6 && j != 4))
                    {
                        Console.Write("   ");
                    } else
                    {
                        Console.Write(" * ");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
