using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            const string libraryBranch = "Huron St";

            Console.WriteLine("Welcome to the {0} Branch Library.", libraryBranch);

            Book Book = new Book("Emma");

            Console.ReadLine();

        }
    }
}
