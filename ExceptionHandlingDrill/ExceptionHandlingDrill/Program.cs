using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0)
                {
                    throw new InvalidAge();
                }
                else
                {
                    Console.WriteLine("Your age is {0}.", age);
                    Console.ReadLine();
                }
            }
            catch (InvalidAge ex)
            {
                Console.WriteLine("You've entered an age that is not a whole number greater than zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There has been an error. Please contact a System Administrator.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
