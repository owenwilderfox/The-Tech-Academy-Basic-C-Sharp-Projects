using System;

class Program
    {
        static void Main()
        {

        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Study Daily Report");

        Console.WriteLine("What course are you on?");
        string currentCourse = Console.ReadLine();

        Console.WriteLine("What page are you on?");
        string currentPage = Console.ReadLine();
        int pageNumber = Convert.ToInt32(currentPage);

        Console.WriteLine("Do you need help with anything? Please enter true or false.");
        string requireHelp = Console.ReadLine();
        bool isHelp = Convert.ToBoolean(requireHelp);

        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string positiveExperience = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string otherFeedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        int studyHours = Convert.ToInt32(hoursStudied);

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        Console.ReadLine();

        }
    }