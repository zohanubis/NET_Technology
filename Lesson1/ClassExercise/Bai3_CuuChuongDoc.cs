using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class Ex3_MultiplicationTable
    {
        public static void PrintMultiplicationTableColumn()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.WriteLine(" {0} x {1} = {2}", i, j, result);
                }

                Console.WriteLine();
            }
        }
    }
}
