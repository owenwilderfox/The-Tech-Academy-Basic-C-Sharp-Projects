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

        //Method One
        public static Number MultiplicationLoop(Number number, int times)
        {
            for (int i = 0; i < times; i++)
            {
                int tempNumberValue = number.Value * 2;
                number.Value = tempNumberValue;
                i++;
            }
            return number;
        }

    }
}
