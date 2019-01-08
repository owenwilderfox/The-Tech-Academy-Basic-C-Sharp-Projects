using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill2
{
    class Number
    {

        public void Division(int enteredNumber)
        {
            int quotient = enteredNumber / 2;
            Console.WriteLine("Answer: {0}", quotient);
            return;
        }

        public int Multiplication(int enteredNumber2, out int times)
        {
            times = 5;
            int product = enteredNumber2 * times;
            return product;
        }

        public int Multiplication(int enteredNumber3, int enteredNumber4, out int times2)
        {
            times2 = 5;
            int product1 = enteredNumber3 * enteredNumber4;
            int product2 = product1 * times2;
            return product2;
        }

        public static int Static()
        {
            int product3 = 4 * 5;
            return product3;
        }

    }
}
