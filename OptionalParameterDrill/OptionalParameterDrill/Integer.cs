using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterDrill
{
    class Integer
    {
        public int Add(int firstInteger, int optionalInteger = 56)
        {
            int result = firstInteger + optionalInteger;
            return result;
        }
    }
}
