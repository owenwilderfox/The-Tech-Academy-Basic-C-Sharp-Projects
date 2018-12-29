using System;
using System.Collections.Generic;
using System.Linq;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

            //#1

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

            //#2

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

            //#4

            //int[] ambientTemperature = { 99, 103, 45, 78, 67, 45, 58 };

            //Console.WriteLine("This program will print out all of the temperatures entered are warmer than OSHA requirement for room temperature.");

            //for (int i = 0; i < ambientTemperature.Length; i++)
            //{
            //    if (ambientTemperature[i] > 77)
            //    {
            //        Console.WriteLine("This room temperature is too warm: " + ambientTemperature[i]);
            //    }
            //}

            //#5

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

            //#6-8 

            //List<string> colors = new List<string>();
            //colors.Add("blue");
            //colors.Add("red");
            //colors.Add("yellow");

            //Console.WriteLine("Please type in the name of a primary color:");
            //string selectedColor = Console.ReadLine();

            //if (colors.Contains(selectedColor))
            //{
            //    Console.WriteLine("You have selected " + selectedColor + ". The index that color is at is " + colors.IndexOf(selectedColor) + ".");
            //}
            //else
            //{
            //    Console.WriteLine("You have selected a color that is not in the database.");
            //}

            
            //#9

            List<string> colors = new List<string>();
            colors.Add("blue");
            colors.Add("red");
            colors.Add("yellow");
            colors.Add("blue");

            Console.WriteLine("Please type in the name of a primary color: ");
            string selectedColor = Console.ReadLine();


            for (int i = 0; i < colors.Count; i++)
            {
                if (colors[i].Contains(selectedColor))
                {
                    Console.WriteLine(colors.IndexOf(selectedColor));
                    i++;
                }
                else
                {
                    Console.WriteLine("You have selected a color that is not listed.");
                }
            }

            Console.ReadLine();

        }
    }
}
