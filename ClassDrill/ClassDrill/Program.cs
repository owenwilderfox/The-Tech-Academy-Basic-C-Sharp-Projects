using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program will take any number entered and add 10 to it, divide it by 2, and multiply it by 20.");
            Console.WriteLine("Please enter an interger you would like to work with:");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            Number number = new Number();
            number.Value = enteredNumber;

            //Call functions from class.
            Number.Add(number);
            Number.Divide(number);
            Number.Multiply(number);

            Console.WriteLine("After processing, your number is now " + number.Value + ".");
            Console.ReadLine();

        }
    }
}
