using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the weight of the package you would like to send: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            string weightRestriction = packageWeight > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "What is the width of the package?";

            Console.WriteLine(weightRestriction);

            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the length of the package?");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            if (packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                int productDimensions = packageHeight * packageLength;
                int productSize = productDimensions * packageWeight;
                double packageProduct = Convert.ToDouble(productSize);
                double shippingQuote = packageProduct / 100;
                Console.WriteLine("The shipping quote for this package is $" + shippingQuote + ".");
            }

            Console.ReadLine();

        }
    }
}
