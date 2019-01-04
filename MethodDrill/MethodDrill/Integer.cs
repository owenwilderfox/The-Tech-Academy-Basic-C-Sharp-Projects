using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill
{
    class Integer
    {
        public Integer()
        {
            Value = 1;
        }

        public int Value { get; set; }
        public decimal decValue { get; set; }

        //Method One
        public static Integer Add(Integer firstInteger)
        {
            int tempFirstInteger = firstInteger.Value + 55;
            firstInteger.Value = tempFirstInteger;
            return firstInteger;
        }

        //Method Two
        public static Integer Multiply(Integer secondInteger)
        {
            decimal tempSecondIntger = secondInteger.decValue * 2;
            secondInteger.decValue = tempSecondIntger;
            return secondInteger;
        }
    }
}
