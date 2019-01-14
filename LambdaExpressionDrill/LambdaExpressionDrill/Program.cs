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
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Smith", ID = 1 });
            employeeList.Add(new Employee { FirstName = "Elizabeth", LastName = "Anderson", ID = 2 });
            employeeList.Add(new Employee { FirstName = "Kelly Anne", LastName = "Franklin", ID = 3 });
            employeeList.Add(new Employee { FirstName = "Elliott", LastName = "McCall", ID = 4 });
            employeeList.Add(new Employee { FirstName = "Graham", LastName = "Fox", ID = 5 });
            employeeList.Add(new Employee { FirstName = "Fuller", LastName = "Bryant", ID = 6 });
            employeeList.Add(new Employee { FirstName = "Grant", LastName = "Colton", ID = 7 });
            employeeList.Add(new Employee { FirstName = "Emily", LastName = "Rainier", ID = 8 });
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Helens", ID = 9 });
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Everett", ID = 10 });

            // Working solution for #2: create a foreach loop that singles out everyone with the first name "Joe" and add to a new list
            List<Employee> joeList = new List<Employee>();

            foreach (var employee in employeeList)
            {
                if (employee.FirstName.Contains("Joe"))
                {
                    joeList.Add(employee);
                }
            }

            foreach (var joe in joeList)
            {
                Console.WriteLine("{0} {1} {2}", joe.FirstName, joe.LastName, joe.ID);
            }

            // Working solution for #3: create a separate list for employees with the first name "Joe" with a Lambda expression
            List<Employee> joeList2 = employeeList.Where(x => x.FirstName.Contains("Joe")).ToList();
            foreach (Employee joe in joeList2)
            {
                Console.WriteLine("{0} {1} {2}", joe.FirstName, joe.LastName, joe.ID);
            }

            // Working solution for #4: create a seperate list for employees with an ID greater than 5 with a Lambda expression
            List<Employee> joeList3 = employeeList.Where(x => x.ID > 5).ToList();
            foreach (Employee joe in joeList3)
            {
                Console.WriteLine("{0} {1} {2}", joe.FirstName, joe.LastName, joe.ID);
            }

            Console.ReadLine();
        }
    }
}
