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
            Employee<string> Employees = new Employee<string>() { "John", "Fred" };

            Employee<int> EmployeeID = new Employee<int>() { 1, 2, 3 };
        }
    }
}
