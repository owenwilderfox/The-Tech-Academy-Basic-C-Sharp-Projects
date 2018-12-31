using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] mathArray = new int[5];


                for (int i = 0; i < mathArray.Length; i++)
                {
                    Console.WriteLine("Please enter an integer: ");
                    mathArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Please enter an integer that you would like the divide your previously entered integers by:");
                int divideBy = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dividing numbers now...");

                for (int i = 0; i < mathArray.Length; i++)
                {
                    int answer = mathArray[i] / divideBy;
                    Console.WriteLine(mathArray[i] + " divided by " + divideBy + " is " + answer + ".");
                }
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
                return;
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please only enter integers.");
                return;
            }

            finally
            {
                Console.ReadLine();
            }

        }
    }
}
