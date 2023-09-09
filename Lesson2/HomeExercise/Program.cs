using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1. Array - Sum Of Local Maximum");
                Console.WriteLine("2. Matrix ");
                Console.WriteLine("-----------------------------------------");
                Console.Write("Enter your choice : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter the size of the array: ");
                            int size = int.Parse(Console.ReadLine());

                            int[] arr = new int[size];
                            Ex1.InputArray(arr);
                            Ex1.PrintArray(arr);
                            int sumMax = Ex1.CalculateSumMax(arr);
                            Console.WriteLine("Sum of local maxima elements in the array: {0}", sumMax);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter the number of rows (m) in the matrix: ");
                            int m = int.Parse(Console.ReadLine());

                            Console.Write("Enter the number of columns (n) in the matrix: ");
                            int n = int.Parse(Console.ReadLine());
                            Console.WriteLine("-----------------------------------------");
                            int[,] matrix = new int[m, n];
                            Console.WriteLine("Enter array elements");
                            Ex2.InputMatrix(matrix);
                            Console.WriteLine();
                            Console.WriteLine("Print array elements");
                            Ex2.PrintMatrix(matrix);
                            Console.WriteLine();
                            Console.WriteLine("-----------------------------------------");
                            do
                            {
                                Console.WriteLine("-----------------------------------------");
                                Console.WriteLine("1. Print Main Diagonal");
                                Console.WriteLine("2. Print Secondary Diagonal");
                                Console.WriteLine("3. Print Upper Triangle");
                                Console.WriteLine("4. Print Lower Triangle");
                                Console.WriteLine("5. Calculate Sum Of Main Diagonal");
                                Console.WriteLine("6. Calculate Sum Of Secondary Diagonal");
                                Console.WriteLine("7. Calculate Sum Of Upper Triangle");
                                Console.WriteLine("8. Calculate Sum Of Lower Triangle");
                                Console.WriteLine("-----------------------------------------");
                                Console.Write("Enter your choice : ");
                                int choice1 = int.Parse(Console.ReadLine());
                                switch (choice1)
                                {
                                    case 0:
                                        {
                                            Console.WriteLine("Goodbye!");
                                            Console.ReadLine();
                                            Environment.Exit(0);
                                            break;
                                        }
                                    case 1:
                                        {
                                            Ex2.PrintMainDiagonal(matrix);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Ex2.PrintSecondaryDiagonal(matrix);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Ex2.PrintUpperTriangle(matrix);
                                            break;
                                        }
                                    case 4:
                                        {
                                            Ex2.PrintLowerTriangle(matrix);
                                            break;
                                        }
                                    case 5:
                                        {
                                            int sumOfMainDiagonal = Ex2.CalculateSumOfMainDiagonal(matrix);
                                            Console.WriteLine("Sum of main diagonal elements: {0}", sumOfMainDiagonal);
                                            break;
                                        }
                                    case 6:
                                        {
                                            int sumOfSecondaryDiagonal = Ex2.CalculateSumOfSecondaryDiagonal(matrix);
                                            Console.WriteLine("Sum of secondary diagonal elements: {0}", sumOfSecondaryDiagonal);
                                            break;
                                        }
                                    case 7:
                                        {
                                            int sumOfUpperTriangle = Ex2.CalculateSumOfUpperTriangle(matrix);
                                            Console.WriteLine("Sum of upper triangle elements: {0}", sumOfUpperTriangle);
                                            break;
                                        }
                                    case 8:
                                        {
                                            int sumOfLowerTriangle = Ex2.CalculateSumOfLowerTriangle(matrix);
                                            Console.WriteLine("Sum of lower triangle elements: {0}", sumOfLowerTriangle);
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid choice. Please try again!");
                                            break;
                                        }
                                }
                            } while (true);
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Goodbye!");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice. Please try again!");
                            break;
                        }
                }
            } while (true);
        }
    }
}
