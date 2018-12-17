using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());

            //int product = 10 * 5;
            //Console.WriteLine("Ten times five = " + product.ToString());

            //int quotient = 10 / 5;
            //Console.WriteLine("Ten divided by five = " + quotient.ToString());

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);

            //bool trueOrFalse = 12 < 5;
            //Console.Write(trueOrFalse.ToString());

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature == roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);

            Console.WriteLine("Please enter a number you would like to multiply by 50: ");
            string firstNumber = Console.ReadLine();
            int multiplyByfifty = Convert.ToInt32(firstNumber);
            int product = multiplyByfifty * 50;
            Console.WriteLine(multiplyByfifty + " multiplied by 50 is " + product.ToString() + ".");

            Console.WriteLine("Please enter a number you would like to add to 25:");
            string secondNumber = Console.ReadLine();
            int addTwentyFive = Convert.ToInt32(secondNumber);
            int combined = addTwentyFive + 25;
            Console.WriteLine(addTwentyFive + " added to 25 is " + combined.ToString() + ".");

            Console.WriteLine("Please enter a number you would like to divide by 12.5: ");
            string thirdNumber = Console.ReadLine();
            double divideNumber = Convert.ToDouble(thirdNumber);
            double quotient = divideNumber / 12.5;
            Console.WriteLine(divideNumber + " divided by 12.5 is " + quotient.ToString() + ".");

            Console.WriteLine("Is your number larger than 50? Let's check. Enter a number, please: ");
            string fourthNumber = Console.ReadLine();
            int checkNumber = Convert.ToInt32(fourthNumber);
            bool isLarger = checkNumber > 50;
            Console.WriteLine(isLarger.ToString());

            Console.WriteLine("Please enter a number you would like to divide by 7: ");
            string fifthNumber = Console.ReadLine();
            int divideSecondNumber = Convert.ToInt32(fifthNumber);
            int remainder = divideSecondNumber % 7;
            Console.WriteLine(divideSecondNumber + " divided by 7 has a remainder of " + remainder + ".");


            Console.ReadLine();
        }
    }
}
