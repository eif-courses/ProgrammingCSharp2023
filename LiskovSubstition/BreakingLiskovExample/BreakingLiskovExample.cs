using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp2023.LiskovSubstition.BreakingLiskovExample
{
    class MathOperation
    {
        internal virtual long CalculateSquare(int number)
        {
            return number * number;
        }
    }

    class PositiveMathOperation : MathOperation
    {
        internal override long CalculateSquare(int number)
        {
            if (number < 0)
            {
                throw new Exception("Negative value");
            }
            return number * number;
        }
    }
}
