using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class TinhPhuongTrinhBac2
    {
        public static void SolveQuadraticEquation(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                // 2 nghiệm phân biệt
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("The quadratic equation has two distinct solutions:");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            else if (delta == 0)
            {
                // Nghiệm kép
                double x = -b / (2 * a);
                Console.WriteLine("The quadratic equation has a double solution:");
                Console.WriteLine("x = {0}", x);
            }
            else
            {
                // Vô nghiệm
                Console.WriteLine("The quadratic equation has no real solutions.");

                    
            }
        }
    }
}
