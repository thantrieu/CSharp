using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class ReadOnlyDataField
    {
        // truong read only
        public readonly float MY_NUMBER;

        public ReadOnlyDataField()
        {
            MY_NUMBER = Convert.ToSingle(Console.ReadLine());
        }

        public void ChangeMYNUMBER(float x)
        {
            // MY_NUMBER = x;
        }

        public void Test()
        {
            //readonly int x = 50;
        }
    }
}
