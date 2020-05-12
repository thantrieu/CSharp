using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class SavingAcc
    {
        public static float interestRate;// = 0.4f;
        public string accNumber;
        public double ballance;

        public static void ChangeRate(float newRate)
        {
            interestRate = newRate;
        }

        static SavingAcc()
        {
            Console.WriteLine("Goi static constructor");
            interestRate = 0.5f;
        }

        public SavingAcc()
        {
            Console.WriteLine("Contructor mac dinh");
        }
    }
}
