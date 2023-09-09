using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExercise
{
    class DaThuc
    {
        public int Bac { get; }
        private int[] HeSo;

        public DaThuc(int bac, int[] heSo)
        {
            Bac = bac;
            HeSo = new int[bac + 1];
            for (int i = 0; i <= bac; i++)
            {
                if (i < heSo.Length)
                    HeSo[i] = heSo[i];
                else
                    HeSo[i] = 0;
            }
        }

        public DaThuc CongDaThuc(DaThuc daThuc)
        {
            int bacMax = Math.Max(Bac, daThuc.Bac);
            int[] ketQua = new int[bacMax + 1];

            for (int i = 0; i <= bacMax; i++)
            {
                int heSo1 = (i <= Bac) ? HeSo[i] : 0;
                int heSo2 = (i <= daThuc.Bac) ? daThuc.HeSo[i] : 0;
                ketQua[i] = heSo1 + heSo2;
            }

            return new DaThuc(bacMax, ketQua);
        }

        public void InDaThuc()
        {
            for (int i = 0; i <= Bac; i++)
            {
                Console.Write($"{HeSo[i]}x^{i}");
                if (i < Bac)
                    Console.Write(" + ");
            }
            Console.WriteLine();
        }
    }
}
//class Program
//{
//    static void Main()
//    {
//        int[] heSo1 = { 1, 2, 3 }; // Đa thức 1: 1x^0 + 2x^1 + 3x^2
//        int[] heSo2 = { 4, 5, 6 }; // Đa thức 2: 4x^0 + 5x^1 + 6x^2

//        DaThuc daThuc1 = new DaThuc(heSo1.Length - 1, heSo1);
//        DaThuc daThuc2 = new DaThuc(heSo2.Length - 1, heSo2);

//        Console.WriteLine("Đa thức 1: ");
//        daThuc1.InDaThuc();
//        Console.WriteLine("Đa thức 2: ");
//        daThuc2.InDaThuc();

//        DaThuc ketQua = daThuc1.CongDaThuc(daThuc2);

//        Console.WriteLine("Kết quả cộng đa thức: ");
//        ketQua.InDaThuc();

//        Console.ReadLine();
//    }
//}
