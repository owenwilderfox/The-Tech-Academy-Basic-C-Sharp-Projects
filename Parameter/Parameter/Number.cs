using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    class Number
    {
        public Number()
        {
            Value = 1;
        }
        
        public int Value { get; set; }

        ////Method One
        //public static Number MultiplicationLoop(Number number, out int timesMultiplied, int times)
        //{
        //    timesMultiplied = 0;
        //    for (int i = 0; i < times; i++)
        //    {
        //        timesMultiplied++;
        //        int tempNumberValue = number.Value * 2;
        //        number.Value = tempNumberValue;
        //    }
        //    return number;
        //}

        //Method Two
        public void MultiplicationLoop(Number number, out int timesMultiplied, int times)
        {
            timesMultiplied = 0;
            for (int i = 0; i < times; i++)
            {
                timesMultiplied++;
                int tempNumberValue = number.Value * 2;
                number.Value = tempNumberValue;
            }
            //Console.WriteLine(number.Value);
            Console.WriteLine("Your number went through a multiplication loop " + timesMultiplied + " times, multipying the product by two each time.");
            Console.WriteLine("Your new number is " + number.Value + ".");
        }

    }
}
