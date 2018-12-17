using System;

namespace AnonymousIncomeComparisonProject
{
    class Program
    {
        static void Main()
        {
            //Find weekly rate and hours worked for Person 1 and Person 2
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");

            Console.WriteLine("Please enter the hourly rate for Person 1: ");
            string person1HourlyRate = Console.ReadLine();
            decimal firstHourlyRate = Convert.ToDecimal(person1HourlyRate);

            Console.WriteLine("Please enter hours worked per week by Person 1: ");
            string person1Hours = Console.ReadLine();
            decimal firstHoursWorked = Convert.ToDecimal(person1Hours);

            Console.WriteLine("Person 2");

            Console.WriteLine("Please enter the hourly rate for Person 2: ");
            string person2HourlyRate = Console.ReadLine();
            decimal secondHourlyRate = Convert.ToDecimal(person2HourlyRate);

            Console.WriteLine("Please enter the hours worked per week by Person 2: ");
            string person2Hours = Console.ReadLine();
            decimal secondHoursWorked = Convert.ToDecimal(person2Hours);

            //Need to multiply weekly take-home by weeks in a year
            decimal weeksPerYear = 52;

            decimal firstWeeklyProduct = firstHourlyRate * firstHoursWorked;
            decimal firstAnnualProduct = firstWeeklyProduct * weeksPerYear;
            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(firstAnnualProduct.ToString());

            decimal secondWeeklyProduct = secondHourlyRate * secondHoursWorked;
            decimal secondAnnualProduct = secondWeeklyProduct * weeksPerYear;
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(secondAnnualProduct.ToString());

            // Compare the annual salaries of Person 1 and Person 2
            bool isMore = firstAnnualProduct > secondAnnualProduct;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(isMore.ToString());

            Console.ReadLine();

        }
    }
}
