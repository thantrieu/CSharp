using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class TestReadOnlyDataField
    {
        static void Main()
        {
            ReadOnlyDataField r = new ReadOnlyDataField();
            Console.WriteLine("Truong readonly: " + r.MY_NUMBER);
        }
    }
}
