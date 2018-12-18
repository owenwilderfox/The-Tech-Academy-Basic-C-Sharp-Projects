using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I am thinking of an animal. Can you guess what I am thinking of? It's black and white.");
            string animal = Console.ReadLine();

            bool isAnimal = animal == "zebra";
            
            while (!isAnimal)
            {
                switch (animal)
                {
                    case "cow":
                        Console.WriteLine("You guessed a cow. You're so close! Try again!");
                        Console.WriteLine("Guess another animal: ");
                        animal = Console.ReadLine();
                        break;
                    case "panda":
                        Console.WriteLine("You guessed a panda. You're close! This black and white animal has hooves. Please guess again.");
                        Console.WriteLine("Guess another animal: ");
                        animal = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You guessed the incorrect animal. Would you like to try again?");
                        Console.WriteLine("Guess another animal: ");
                        animal = Console.ReadLine();
                        break;
                    case "zebra":
                        Console.WriteLine("You guessed a zebra. Good job! You're great at guessing.");
                        isAnimal = true;
                        break;
                }
            }

            Console.WriteLine("I'm having fun guessing with you. You're really good at this! Let's try again. I am thinking of a city on the West Coast. What city am I thinking of?");
            string city = Console.ReadLine();

            bool isCity = city == "Anacortes";

            do
            {
                {
                    switch (city)
                    {
                        case "Portland":
                            Console.WriteLine("You guessed Portland. I'm sorry, that's incorrect. This city is in Washington.");
                            Console.WriteLine("Guess another city: ");
                            city = Console.ReadLine();
                            break;
                        case "Los Angeles":
                            Console.WriteLine("You guessed Los Angeles. I'm sorry, that's incorrect. This city is in Washington.");
                            Console.WriteLine("Guess another city: ");
                            city = Console.ReadLine();
                            break;
                        case "Seattle":
                            Console.WriteLine("You guess Seattle. That's so close! I am thinking of a city near the San Juan Islands.");
                            Console.WriteLine("Guess another city: ");
                            city = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("I'm sorry! That's incorrect. Please try again.");
                            Console.WriteLine("Guess another city: ");
                            city = Console.ReadLine();
                            break;
                        case "Anacortes":
                            Console.WriteLine("You guessed Anacortes! Good job! I knew you would get it!");
                            isCity = true;
                            break;
                    }
                }
            }

            while (!isCity);
            
            Console.ReadLine();
        }
    }
}
