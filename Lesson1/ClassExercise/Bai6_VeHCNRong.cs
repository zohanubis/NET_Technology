using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Ex6_DrawEmptyRectangle
    {
        public static void DrawEmptyRectangle(int length, int width)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || i == width - 1 || j == 0 || j == length - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }
    }
}
