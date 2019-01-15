using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good afternoon! Please enter a number:");
            int enteredText = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\My DELL\logs\log.txt", true))
            {
                file.WriteLine(enteredText);
            }
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\My DELL\logs\log.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
