using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExercise
{
    //In tất cả các số lẻ nhỏ hơn n, trong đó n nhập từ bàn phím
    class Ex3_OddNumbersLessThanN
    {
        public static void PrintOddNumbersLessThanN(int n)
        {
            Console.WriteLine("Odd numbers less than {0}:",n);
            for (int i = 1; i < n; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
