using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExercise
{
    public class GCD
    {
        public static int CalculateGCD(int a, int b)
        {
            if (b > a)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            return a;
        }
    }
}
