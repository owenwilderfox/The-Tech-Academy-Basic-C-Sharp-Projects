using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 100
            };

            Employee employee2 = new Employee()
            {
                FirstName = "S.",
                LastName = "Student",
                Id = 100
            };

            employee1.SayName();
            employee2.SayName();

            if (employee1 == employee2)
                Console.WriteLine("These employees are equal.");
            else
                Console.WriteLine("These employees are not equal.");

            Console.ReadLine();
        }
    }
}
