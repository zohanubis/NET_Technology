using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Viết chương trình tính tích 1* 2*3*4*...*n, trong đó n nhập từ bàn phím
namespace SampleExercise
{
    public class TinhTich
    {
        public static int Tich(int n)
        {
            int tich = 1;
            for (int i = 1; i <= n; i++)
            {
                tich *= i;
            }
            return tich;
        }

    }
}
