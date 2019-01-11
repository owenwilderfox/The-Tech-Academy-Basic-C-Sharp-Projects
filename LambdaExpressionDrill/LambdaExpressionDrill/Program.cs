using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionDrill
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList= new List<Employee>();
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Smith", ID = 100 });
            employeeList.Add(new Employee { FirstName = "Elizabeth", LastName = "Anderson", ID = 101 });
            employeeList.Add(new Employee { FirstName = "Kelly Anne", LastName = "Franklin", ID = 102 });
            employeeList.Add(new Employee { FirstName = "Elliott", LastName = "McCall", ID = 103 });
            employeeList.Add(new Employee { FirstName = "Graham", LastName = "Fox", ID = 104 });
            employeeList.Add(new Employee { FirstName = "Fuller", LastName = "Bryant", ID = 105 });
            employeeList.Add(new Employee { FirstName = "Grant", LastName = "Colton", ID = 106 });
            employeeList.Add(new Employee { FirstName = "Emily", LastName = "Rainier", ID = 107 });
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Helens", ID = 108 });
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Everett", ID = 109 });

            //Working foreach loop
            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                Console.WriteLine("{0} {1} {2}", employee.FirstName, employee.LastName, employee.ID);
            }

            //Console.WriteLine(employeeList);
            Console.ReadLine();
        }
    }
}
