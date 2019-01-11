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
            Employee<string> Employees = new Employee<string>() { Things = new List<string> { "John", "Fred", "Mark" } };

            Employee<int> EmployeeID = new Employee<int>() { Things = new List<int> { 1, 2, 3 } };

            foreach (string Employee in Employees.Things)
            {
                Console.WriteLine(Employee);
            }

            foreach (int ID in EmployeeID.Things)
            {
                Console.WriteLine(ID);
            }

            Console.ReadLine();
        }
    }
}
