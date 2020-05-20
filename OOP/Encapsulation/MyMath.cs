using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    // truong du lieu la hang so
    class MyMath
    {

        public const float PI = 3.14f;
        public MyMath()
        {
           
        }
        // perimeter
        public float Perimeter(float r)
        {
            const float x = PI;
            return 2 * x * r;
        }
        // area
        public float Area(float r)
        {
            return PI * r * r;
        }
    }
}
