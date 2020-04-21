using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class ParamsModifier
    {
        static void Main()
        {
            // params modifier
            float[] marks = { 5, 6.5f, 8.5f, 9, 7.5f, 8 };
            float math = 9;
            float bio = 8.5f;
            float vi = 6;
            float it = 7.5f;

            float avg = Avg(); // math, bio, vi, it
            Console.WriteLine("Diem trung binh = " + avg);
        }

        static float Avg(params float[] marks)
        {
            float sum = 0;
            foreach (var item in marks)
            {
                sum += item;
            }
            return (marks.Length == 0) ? 0 : sum / marks.Length;
        }
    }
}
