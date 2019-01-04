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

            //First Integer with Int
            Console.WriteLine("Please enter the first whole number that you would like to work with:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Integer firstInteger = new Integer();
            firstInteger.Value = firstNumber;
            Integer.Add(firstInteger);

            Console.WriteLine("Your number - " + firstNumber + " - was added to 55. Your number is now " + firstInteger.Value + ".");

            //Second Integer with Decimal
            Console.WriteLine("Let's use a different number. You may enter a decimal here:");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

            Integer secondInteger = new Integer();
            secondInteger.decValue = secondNumber;
            Integer.Multiply(secondInteger);

            Console.WriteLine("Your second number - " + secondNumber + " - was multiplied by 2. Your number is now " + secondInteger.decValue + ".");

            //Third Integer with Try/Catch
            try
            {
                Console.WriteLine("Please enter your final number: ");
                int thirdNumber = Convert.ToInt32(Console.ReadLine());

                Integer thirdInteger = new Integer();
                thirdInteger.Value = thirdNumber;
                Integer.Divide(thirdInteger);

                Console.WriteLine("Your third number - " + thirdNumber + " - was divided by 2. Your number is now " + thirdInteger.Value + ".");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("This program only accepts integers. Sorry!");
                Console.WriteLine("Please restart the program to try again.");
                return;
            }

            finally
            {
                Console.WriteLine("Thanks!");
                Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
