using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateValue = new DateTime();
            dateValue = DateTime.Now;

            Console.WriteLine("The current date and time is {0}.", dateValue);
            Console.WriteLine("Please enter a number:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("In {0} hours, the date and time will be {1}.", x, dateValue.AddHours(x));

            Console.ReadLine();
        }
    }
}
