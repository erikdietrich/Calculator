using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public decimal Divide(decimal x, decimal y)
        {
            if (y == 0)
                throw new ArgumentException(nameof(y));

            return x / y;
        }
    }
}
