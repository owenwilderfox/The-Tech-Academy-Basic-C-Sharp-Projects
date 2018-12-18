using System;

namespace BooleanLogicProject
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("What is your age?");
            string answerAge = Console.ReadLine();
            int applicantAge = Convert.ToInt32(answerAge);
            bool isOldEnough = applicantAge > 15;

            Console.WriteLine("Have you ever had a DUI?");
            string answerDUI = Console.ReadLine();
            bool applicantDUI = Convert.ToBoolean(answerDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string answerTickets = Console.ReadLine();
            int numberTickets = Convert.ToInt32(answerTickets);
            bool applicantTickets = numberTickets < 3;

            Console.WriteLine("Does applicant qualify for insurance?");
            Console.WriteLine(isOldEnough == true && applicantDUI == false && applicantTickets == true);

            Console.ReadLine();

        }
    }
}
