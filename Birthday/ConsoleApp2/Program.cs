using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your date of birth (MM/DD/YYYY):");
            DateTime DOB = DateTime.Parse(Console.ReadLine());
            TimeSpan age = DateTime.Now - DOB;

            Console.WriteLine("Your age: {0} years", (int)(age.Days / 365.25));

            Console.ReadLine();


        }
    }
}
