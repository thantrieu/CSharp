using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Instructor
    {
        // id, name, age, salary
        public Instructor()
        {

        }
        public Instructor(string id )
        {
            Id = id;
        }

        public string Id { get; } = "ABC000";
        public int Age { get; set; } = 22;
        public string Name { get; set; } = "Nguyen Thuy A";
        public float Salary { get; set; } = 10;
        public Subject Subject { get; set; } = new Subject();
    }
}
