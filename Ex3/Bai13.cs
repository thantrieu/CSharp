using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises3
{
    class Bai13
    {
        static void Main()
        {
            for (int i = 100000000; i <= 999999999; i++)
            {
                int tmp = i;
                int dao = 0;
                int dem = 0;
                while(tmp > 0)
                {
                    dao = dao * 10 + tmp % 10;
                    tmp /= 10;
                }
                if(i == dao)
                {
                    dem++;
                    Console.Write(i + "\t");
                    if(dem % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
