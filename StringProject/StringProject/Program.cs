using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Pablo";
            string lastName = "Neruda";
            string lifeSpan = "(1904 – 1973)";
            string poemName = "Sonnet Xvii";
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("First stanza of " + poemName.ToUpper());
            Console.WriteLine("By poet " + firstName + " " + lastName + " " + lifeSpan);

            sb.Append("I do not love you as if you were salt-rose, or topaz,");
            sb.Append(" or the arrow of carnations the fire shoots off.");
            sb.Append(" I  love you as certain dark things are to be loved,");
            sb.Append(" in secret, between the shadow and the soul.");
 
            Console.WriteLine(sb);




            Console.ReadLine();
        }
    }
}
