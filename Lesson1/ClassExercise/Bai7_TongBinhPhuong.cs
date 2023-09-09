using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class Ex7_SumOfSquares
    {
        public static int CalculateSumOfSquares(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int square = i * i;
                sum += square;
            }

            return sum;
        }
    }
}
