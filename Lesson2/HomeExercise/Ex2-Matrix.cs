using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExercise
{
    class Ex2
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
        //Liệt kê phần tử trên đường chéo chính
        public static void PrintMainDiagonal(int[,] matrix)
        {
            Console.WriteLine("Main diagonal elements:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine();
        }
        //Liệt kê phần tử trên đường chéo phụ
        public static void PrintSecondaryDiagonal(int[,] matrix)
        {
            Console.WriteLine("Secondary diagonal elements:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i, matrix.GetLength(0) - i - 1] + " ");
            }
            Console.WriteLine();
        }
        //Liệt kê phần tử tam giác trên
        public static void PrintUpperTriangle(int[,] matrix)
        {
            Console.WriteLine("Upper triangle elements:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
        //Liệt kê phần tử tam giác dưới
        public static void PrintLowerTriangle(int[,] matrix)
        {
            Console.WriteLine("Lower triangle elements:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
        //Tổng phần tử đường chéo chính
        public static int CalculateSumOfMainDiagonal(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }
        //Tổng phần tử đường chéo phụ
        public static int CalculateSumOfSecondaryDiagonal(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, matrix.GetLength(0) - i - 1];
            }
            return sum;
        }

        //Tổng phần tử tam giác trên

        public static int CalculateSumOfUpperTriangle(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }
        //Tổng phần tử tam giác phụ
        public static int CalculateSumOfLowerTriangle(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
    }
}
