using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExercise
{
    //Đếm số lượng số chẵn trong [n,m], trong đó n,m nhập từ bàn phím
    class Ex4_CountEvenNumbers
    {
        public static int CountEvenNumbersInRange(int n, int m)
        {
            int count = 0;

            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
