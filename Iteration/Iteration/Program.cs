using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

            //#1: 1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each string in the Array, adding the user’s text to the string. Then create a loop that prints off each string in the Array on a separate line.

            //string[] dogNames = new string[5];
            //Console.WriteLine("Let's make a list of five dog names you enjoy:");

            //for (int i = 0; i < dogNames.Length; i++)
            //{
            //    Console.WriteLine("What name do you like?");
            //    dogNames[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Here are the names that you like:");

            //for (int i = 0; i < dogNames.Length; i++)
            //{
            //    Console.WriteLine(dogNames[i]);
            //}

            //#2. Create an infinite loop.

            //Console.WriteLine("Let's do some multiplication. Please enter a number:");
            //int enteredNumber = Convert.ToInt32(Console.ReadLine());
            //for (; ; )
            //{
            //    enteredNumber = enteredNumber * 9;
            //    Console.WriteLine(enteredNumber);
            //}

            //#3. Fix the infinite loop so it will execute.

            //Console.WriteLine("Let's do some multipliation. Please enter a number:");
            //int enteredNumber = Convert.ToInt32(Console.ReadLine());
            //for (int n = 1; n < 5; n++)
            //{
            //    enteredNumber = enteredNumber * 9;
            //    Console.WriteLine(enteredNumber);
            //}

            //4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

            //int[] ambientTemperature = { 99, 103, 45, 78, 67, 45, 58 };

            //Console.WriteLine("This program will print out all of the temperatures entered are warmer than OSHA requirement for room temperature.");

            //for (int i = 0; i < ambientTemperature.Length; i++)
            //{
            //    if (ambientTemperature[i] > 77)
            //    {
            //        Console.WriteLine("This room temperature is too warm: " + ambientTemperature[i]);
            //    }
            //}

            //5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

            //int[] rentalAges = { 18, 45, 34, 56, 23, 20, 21 };

            //for (int i = 0; i < rentalAges.Length; i++)
            //{
            //    if (20 <= rentalAges[i])
            //    {
            //        Console.WriteLine("A driver who is " + rentalAges[i] + " can rent a car.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("A driver who is " + rentalAges[i] + " cannot rent a car.");
            //    }
            //}

            //6. Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List. Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.

            //List<string> bookTitles = new List<string>();

            //bookTitles.Add("SENSE AND SENSIBILITY");
            //bookTitles.Add("PRIDE AND PREJUDICE");
            //bookTitles.Add("MANSFIELD PARK");
            //bookTitles.Add("EMMA");
            //bookTitles.Add("NORTHANGER ABBEY");
            //bookTitles.Add("PERSUASION");
            //bookTitles.Add("LADY SUSAN");

            //Console.WriteLine("Please enter the name of a Jane Austen novel you'd like to search for in the database. You may enter a partial name: ");
            //string searchTitle = Console.ReadLine().ToUpper();

            //foreach (string title in bookTitles)
            //{
            //    if (title.Contains(searchTitle))
            //    {
            //        Console.WriteLine(title);
            //    }
            //}

            List<string> bookTitles = new List<string>();
            List<string> foundTitles = new List<string>();

            bookTitles.Add("SENSE AND SENSIBILITY");
            bookTitles.Add("PRIDE AND PREJUDICE");
            bookTitles.Add("MANSFIELD PARK");
            bookTitles.Add("EMMA");
            bookTitles.Add("NORTHANGER ABBEY");
            bookTitles.Add("PERSUASION");
            bookTitles.Add("LADY SUSAN");


            Console.WriteLine("Please enter the name of a Jane Austen novel you'd like to search for in the database. You may enter a partial name: ");
            string searchTitle = Console.ReadLine().ToUpper();

            foreach (string title in bookTitles)
            {
                if (title.Contains(searchTitle))
                {
                    foundTitles.Add(title);
                }
            }

            Console.WriteLine(foundTitles);

            if (foundTitles.Count > 0)
            {
                foundTitles.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("The database was unable to find a title that contained " + searchTitle + ".");
            }

            Console.ReadLine();

        }
    }
}
