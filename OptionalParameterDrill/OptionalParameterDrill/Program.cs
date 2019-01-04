using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterDrill
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Please enter a number:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Optional: please enter another number:");
                string tempNumber = Console.ReadLine();

                if(tempNumber == "")
                {
                    Integer firstInteger = new Integer();
                    int result = firstInteger.Add(firstNumber);
                    Console.WriteLine("Added default number. Answer: " + result);
                }

                else
                {

                    int optionalNumber = Convert.ToInt32(tempNumber);
                    Integer firstInteger = new Integer();
                    int result = firstInteger.Add(firstNumber, optionalNumber);
                    Console.WriteLine("Answer: " + result);
                }

                Console.ReadLine();
            
        }
    }
}
