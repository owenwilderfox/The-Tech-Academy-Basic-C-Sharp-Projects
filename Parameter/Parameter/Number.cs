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

        //Method
        public static Number MultiplicationLoop(Number number)
        {
            for (int i = 0; i < 5; i++)
            {
                int tempNumberValue = number.Value * 5;
                number.Value = tempNumberValue;
                i++;
            }
            return number;
        }
    }
}
