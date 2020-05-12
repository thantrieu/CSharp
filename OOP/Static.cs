using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Static
    {
        static void Main()
        {
            // static keyword
            SavingAcc acc1 = new SavingAcc();
            SavingAcc acc2 = new SavingAcc();
            SavingAcc acc3 = new SavingAcc();
            SavingAcc acc4 = new SavingAcc();
            SavingAcc.interestRate = 0.6f;
            SavingAcc.interestRate = 0.3f;
        }
    }
}
