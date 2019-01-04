using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program will do math operations on entered numbers.");

            //First Integer
            Console.WriteLine("Please enter the first whole number that you would like to work with:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Integer firstInteger = new Integer();
            firstInteger.Value = firstNumber;
            Integer.Add(firstInteger);

            Console.WriteLine("Your number - " + firstNumber + " - was added to 55. Your number is now " + firstInteger.Value + ".");

            //Second Integer
            Console.WriteLine("Let's use a different number. You may enter a decimal here:");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

            Integer secondInteger = new Integer();
            secondInteger.decValue = secondNumber;
            Integer.Multiply(secondInteger);

            Console.WriteLine("Your second number - " + secondNumber + " - was multiplied by 2. Your number is now " + secondInteger.decValue + ".");

            Console.ReadLine();

        }
    }
}
