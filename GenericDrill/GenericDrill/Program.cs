using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Employees = new Employee<string>() { Things = { "John", "Fred", "Mark" } };

            Employee<int> EmployeeID = new Employee<int>() { Things = { 1, 2, 3 } };

            foreach (string employee in Employees)
            {

            }

        }
    }
}
