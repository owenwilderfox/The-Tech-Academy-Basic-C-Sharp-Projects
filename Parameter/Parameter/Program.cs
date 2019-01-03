using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program will take two numbers and multiply them together several times.");
            Console.WriteLine("What number would you like to work with today?");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            Number number = new Number();
            number.Value = enteredNumber;

            Number.MultiplicationLoop(number);

            Console.WriteLine("Your new number is: " + number.Value);
            Console.WriteLine("Your number (" + enteredNumber + ") was multipied " + times + " times.");
            Console.ReadLine();
        }
    }
}
