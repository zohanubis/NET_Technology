using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class Matrix
    {
        public static void InputMatrix(int[,] matrix)
        {
            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Element [{0}, {1}]: ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine("Matrix elements:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        // Tổng các phần tử dương trong ma trận
        public static int SumOfPositiveElements(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
        // Tổng các phần tử trên đường chéo chính
        public static int SumOfMainDiagonalElements(int[,] matrix)
        {
            int sum = 0;
            int n = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }
        // Tổng các phần tử nằm trong tam giác trên
        public static int SumOfUpperTriangleElements(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
        // Tổng tất cả các phần tử chẵn của ma trận
        public static int SumOfEvenElements(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
        // Tính tổng các phần tử ở dòng thứ i
        public static int SumOfRowElements(int[,] matrix, int row)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[row, j];
            }
            return sum;
        }
    }
}
