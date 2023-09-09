using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class Ex4_MultiplicationTableRow
    {
        public static void PrintMultiplicationTableRow()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.Write(" {0} x {1} = {2}\t", i, j, result);
                }

                Console.WriteLine();
            }
        }
    }
}
