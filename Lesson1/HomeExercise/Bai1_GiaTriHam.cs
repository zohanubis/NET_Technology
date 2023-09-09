using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExercise
{
    class Ex1_FunctionValue
    {
        public static double CalculateFunctionValue1(double x)
        {
            if (x > 0)
            {
                return 3 * x + Math.Sqrt(x);
            }
            else
            {
                return Math.Exp(x) + 4;
            }
        }
        public static double CalculateFunctionValue2(double x)
        {
            if (x >= 1)
            {
                return Math.Sqrt(Math.Pow(x, 2) + 1);
            }
            else if (x > -1 && x < 1)
            {
                return 3 * x + 5;
            }
            else
            {
                return Math.Pow(x, 2) + 2 * x - 1;
            }
        }
    }
}
