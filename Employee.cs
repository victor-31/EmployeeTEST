using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set;}



        public Employee (string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;

        }

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                    _salary = value;
            }
        }
    }
}