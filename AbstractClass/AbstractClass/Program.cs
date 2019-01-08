using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            person.SayName();
            Console.ReadLine();

        }
    }
}
