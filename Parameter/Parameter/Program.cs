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

            Console.WriteLine("What number would you like to work with today?");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            //Number number = new Number();
            //number.Value = enteredNumber;
            //number = Number.MultiplicationLoop(number: number, times: 1);

            Number number = new Number();
            number.Value = enteredNumber;
            int timesMultiplied = 0;
            number = Number.MultiplicationLoop(number, out timesMultiplied, 4);

            //Number.MultiplicationLoop(number);

            Console.WriteLine("Your new number is: " + number.Value);
            Console.WriteLine("Your number (" + enteredNumber + ") was multipied by two and then added together " + timesMultiplied + " times.");
            Console.ReadLine();
        }
    }
}

//enteredNumber as parameter, times as parameter
