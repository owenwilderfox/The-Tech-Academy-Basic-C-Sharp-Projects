using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            int[] numArray = new int[6];
            numArray[0] = 100;
            numArray[1] = 200;
            numArray[2] = 300;
            numArray[3] = 400;
            numArray[4] = 500;
            numArray[5] = 600;

            Console.WriteLine("Please select an index from the pre-built array:");
            int selectedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("That index has an integer of " + numArray[selectedNumber] + ".");

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
