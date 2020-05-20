using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Properties read only and write only

namespace Encapsulation
{
    class Employee
    {
        private string empId;
        private string empName;
        private int age;
        private string password;

        public Employee()
        {

        }

        public Employee(string id, string name, int age)
        {
            this.empId = id;
        }

        public string EmpId // read only prop
        {
            get => empId;
        }

        public string Password
        {
            set
            {
                // conditions..
                password = value;
            }
        }
    }
}
