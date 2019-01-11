using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number()
            {
                Amount = 1.5M
            };

            Console.WriteLine("Amount: {0}", number.Amount);
            Console.ReadLine();
        }
    }
}
