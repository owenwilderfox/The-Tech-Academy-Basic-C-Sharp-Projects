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

            Console.WriteLine("I am thinking of an animal. Can you guess what I am thinking of?");
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "cat":
                    Console.WriteLine("You guessed a cat. I'm sorry, that's incorrect.");
                    break;
                case "elephant":
                    Console.WriteLine("You guessed an elephant. I'm sorry, that's incorrect.");
                    break;
                case "zebra":
                    Console.WriteLine("You guessed a zebra. Good job! You're great at guessing.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
