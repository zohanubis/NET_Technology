using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExercise
{
    //Xuất số có 2 chữ số sao cho các chữ số khác nhau đôi một
    class Ex2_UniqueTwoDigitNumbers { 
        public static void PrintUniqueTwoDigitNumbers()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (i != j)
                    {
                        Console.WriteLine("{0}{1}",i,j);
                    }
                }
            }
        }
    }
}
