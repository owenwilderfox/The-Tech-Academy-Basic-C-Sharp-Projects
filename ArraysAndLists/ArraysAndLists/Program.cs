using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            // String array
            string[] catName = { "Chief", "Loki", "Graham", "Elliott" };
            Console.WriteLine("Please select an index from the array:");
            int selectedCat = Convert.ToInt32(Console.ReadLine());
            if (selectedCat > 3)
            {
                Console.WriteLine("That index does not exist.");
            }
            else
            {
                Console.WriteLine("That index has a string value of " + catName[selectedCat] + ".");
            }


            // Int array
            int[] numArray = { 100, 200, 300, 400, 500, 600 };
            Console.WriteLine("Next, please select an index from the pre-built array:");
            int selectedNumber = Convert.ToInt32(Console.ReadLine());
            if (selectedNumber > 5)
            {
                Console.WriteLine("That index does not exist.");
            }
            else
            {
                Console.WriteLine("That index has an integer of " + numArray[selectedNumber] + ".");
            }

            // List of strings
            List<string> intList = new List<string>();
            intList.Add("Chief");
            intList.Add("Loki");
            intList.Add("Elliott");
            intList.Add("Graham");

            Console.WriteLine("Please select another index to get a cat name from the list:");
            int listNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have selected index " + listNumber + ". The cat name at that index is " + intList[listNumber] + ".");

            Console.ReadLine();



            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 500 };
            //int[] numArray2 = { 1, 2, 3, 200, 5400, 212 };

            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();

            //List<string> intList = new List<string>();
            //intList.Add("Hello");
            //intList.Add("Fred");

            //Console.WriteLine(intList[1]);
            //Console.ReadLine();
        }
    }
}
