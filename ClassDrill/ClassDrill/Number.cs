using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    public class Number
    {
        public Number()
        {
            Value = 1;
        }
        public int Value { get; set; }

        //Methods
        public static Number Add(Number number)
        {

            int tempAddnumber = number.Value + 10;
            number.Value = tempAddnumber;
            return number;

        }

        public static Number Divide(Number number)
        {

            int tempDividenumber = number.Value / 2;
            number.Value = tempDividenumber;
            return number;

        }

        public static Number Multiply(Number number)
        {
            int tempMultiplynumber = number.Value * 20;
            number.Value = tempMultiplynumber;
            return number;
        }

    }
}
