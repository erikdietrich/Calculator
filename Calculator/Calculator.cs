using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public decimal Add(decimal x, decimal y)
        {
            var answer = x + y;
            File.WriteAllText("answers.txt", answer.ToString());
            return answer;
        }

        public decimal Divide(decimal x, decimal y)
        {
            if (y == 0)
                throw new ArgumentException(nameof(y));

            return x / y;
        }
    }
}
