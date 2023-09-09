using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            do
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Class Exercise");
                Console.WriteLine("2. Advanced Exercise");
                Console.WriteLine("0. Exit");
                Console.WriteLine("---------------------------------------");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                { 
                    case 1:
                        {

                            int choice1;
                            do
                            {
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("1. Calculate Total Amount");// Bài 1. Tính tiền
                                Console.WriteLine("2. Electricity bill"); // Bài 2. Tiền điện
                                Console.WriteLine("3. Print Multiplication Table Column"); // Bài 3. Cửu chương theo chiều dọc
                                Console.WriteLine("4. Print Multiplication Table Row"); // Bài 4. Cửu chương theo chiều ngang
                                Console.WriteLine("5. Draw Rectangle"); // Bài 5. Vẽ hình chữ nhật
                                Console.WriteLine("6. Draw Empty Rectangle"); // Bài 6. Vẽ hình chữ nhật rỗng
                                Console.WriteLine("7. Sum of squares"); // Bài 7. Tổng bình phương
                                Console.WriteLine("8. Check prime"); // Bài 8. Kiểm tra số nguyên tố
                                Console.WriteLine("9. FindPrimesLessThan"); // Bài 9. Tìm số SNT < n
                                Console.WriteLine("10. Read Integer Sequence");
                                Console.WriteLine("---------------------------------------");
                                Console.Write("Enter your choice: ");
                                choice1 = int.Parse(Console.ReadLine());
                                switch (choice1)
                                {
                                    case 1:
                                        {
                                            Console.Write("Enter the unit price of the item: ");
                                            double unitPrice = double.Parse(Console.ReadLine());

                                            Console.Write("Enter the quantity sold: ");
                                            int quantity = int.Parse(Console.ReadLine());

                                            double totalAmount = Ex1_CalculateTotalAmount.CalculateTotalAmount(unitPrice, quantity);

                                            Console.WriteLine("Total amount to be paid: " + totalAmount);
                                            break;
                                        }

                                    case 2:
                                        {
                                            Console.Write("Enter the electricity usage (in KW): ");
                                            int electricityUsage = int.Parse(Console.ReadLine());
                                            double totalBill = Ex2_ElectricityBill.CalculateElectricityBill(electricityUsage);
                                            Console.WriteLine("Total electricity bill to be paid: " + totalBill);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Ex3_MultiplicationTable.PrintMultiplicationTableColumn();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Ex4_MultiplicationTableRow.PrintMultiplicationTableRow();
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.Write("Enter the length of the rectangle: ");
                                            int length = int.Parse(Console.ReadLine());

                                            Console.Write("Enter the width of the rectangle: ");
                                            int width = int.Parse(Console.ReadLine());

                                            Ex5_DrawRectangle.DrawRectangle(length, width);
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.Write("Enter the length of the rectangle: ");
                                            int length = int.Parse(Console.ReadLine());

                                            Console.Write("Enter the width of the rectangle: ");
                                            int width = int.Parse(Console.ReadLine());

                                            Ex6_DrawEmptyRectangle.DrawEmptyRectangle(length, width);
                                            break;
                                        }
                                    case 7:
                                        Console.Write("Enter a positive integer (n): ");
                                        int n = int.Parse(Console.ReadLine());

                                        int sumOfSquares = Ex7_SumOfSquares.CalculateSumOfSquares(n);

                                        Console.WriteLine("Sum of squares from 1 to {0}: {1}",n, sumOfSquares);
                                        break;
                                    case 8:
                                        {
                                            Console.Write("Enter a positive integer: ");
                                            int number = int.Parse(Console.ReadLine());

                                            bool isPrime = Ex8_CheckPrime.IsPrime(number);

                                            if (isPrime)
                                                Console.WriteLine("{0} is a prime number." ,number);
                                            else
                                                Console.WriteLine("{0} is not a prime number.",number);
                                            break;
                                        }
                                    case 9:
                                        {
                                            Console.Write("Enter a positive integer (n): ");
                                            int n1 = int.Parse(Console.ReadLine());

                                            List<int> primes = Ex9_FindPrimesLessThanN.FindPrimesLessThan(n1);

                                            Console.WriteLine("Prime numbers less than {n}:");
                                            foreach (int prime in primes)
                                            {
                                                Console.WriteLine(prime);
                                            }
                                            break;

                                        }
                                    case 10:
                                        {
                                            List<int> sequence = Ex10_ReadIntegerSequence.ReadIntegerSequence();

                                            int sum = Ex10_ReadIntegerSequence.CalculateSum(sequence);
                                            int max = Ex10_ReadIntegerSequence.FindMax(sequence);
                                            int min = Ex10_ReadIntegerSequence.FindMin(sequence);

                                            Console.WriteLine("Sum of the sequence: {0}",sum);
                                            Console.WriteLine("Maximum value in the sequence: {0}",max);
                                            Console.WriteLine("Minimum value in the sequence: {0}",min);
                                            break;
                                        }
                                    case 0:
                                        {
                                            Console.WriteLine("Goodbye!");
                                            Console.ReadLine();
                                            Environment.Exit(0);
                                            break;
                                        }
                                }
                            } while (true);
                            break;
                        }
                    case 2:
                        {
                            int choice2;
                            do
                            {
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("1. Degree equation ");//Bài 1: Phương trình bậc 2
                                Console.WriteLine("2. Print Empty isosceles triangle"); //Bài 2. In tam giác cân rỗng
                                Console.WriteLine("---------------------------------------");
                                Console.Write("Enter your choice: ");
                                choice2 = int.Parse(Console.ReadLine());
                                switch (choice2)
                                {
                                    case 1:
                                        {
                                            Console.Write("Enter the coefficient a: ");
                                            double a = double.Parse(Console.ReadLine());

                                            Console.Write("Enter the coefficient b: ");
                                            double b = double.Parse(Console.ReadLine());

                                            Console.Write("Enter the coefficient c: ");
                                            double c = double.Parse(Console.ReadLine());

                                            TinhPhuongTrinhBac2.SolveQuadraticEquation(a, b, c);
                                            break;
                                        }

                                    case 2:
                                        {
                                            int rows;
                                            Console.Write("Enter the number of rows: ");
                                            rows = int.Parse(Console.ReadLine());

                                            TGCanRong.TamGiacCanRong(rows);
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 0:
                                        {
                                            Console.WriteLine("Goodbye!");
                                            Console.ReadLine();
                                            Environment.Exit(0);
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
