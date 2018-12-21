using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

            //#1: 1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each string in the Array, adding the user’s text to the string. Then create a loop that prints off each string in the Array on a separate line.

            string[] dogNames = new string[5];
            Console.WriteLine("Let's make a list of five dog names you enjoy:");

            for (int i = 0; i < dogNames.Length; i++)
            {
                Console.WriteLine("What name do you like?");
                dogNames[i] = Console.ReadLine();
            }

            Console.WriteLine("Here are the names that you like:");

            for (int i = 0; i < dogNames.Length; i++)
            {
                Console.WriteLine(dogNames[i]);
            }

            //#2. Create an infinite loop.

            //Console.WriteLine("Let's do some multiplication. Please enter a number:");
            //int enteredNumber = Convert.ToInt32(Console.ReadLine());
            //for (; ; )
            //{
            //    enteredNumber = enteredNumber * 9;
            //    Console.WriteLine(enteredNumber);
            //}

            //#3. Fix the infinite loop so it will execute.

            Console.WriteLine("Let's do some multipliation. Please enter a number:");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            for (int n = 1; n < 5; n++)
            {
                enteredNumber = enteredNumber * 9;
                Console.WriteLine(enteredNumber);
            }



            Console.ReadLine();

            //int[] testScores = { 98, 99, 95, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; 1 < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}

            //string[] names = { "Jesse", "Daniel", "Christopher", "Abram" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}

            //List<int> testScores = new List<int>();

            //testScores.Add(98);
            //testScores.Add(100);
            //testScores.Add(67);
            //testScores.Add(99);
            //testScores.Add(78);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}

            //List<string> names = new List<string>() { "Jesse", "Erik", "Daniel", "Adam" };

            //foreach (string name in names)
            //{
            //     Console.WriteLine(name);
            //}

            //List<int> testScores = new List<int>() { 100, 98, 87, 76 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}

            //Console.WriteLine(passingScores.Count);

            //Console.ReadLine();
        }
    }
}
