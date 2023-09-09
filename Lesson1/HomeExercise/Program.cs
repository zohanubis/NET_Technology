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
            int choice;
            do
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Function Value ");
                Console.WriteLine("2. Print Unique Two Digit Numbers");
                Console.WriteLine("3. Print OddNumbers Less Than N");
                Console.WriteLine("4. Count Even Numbers In Range N & M");
                Console.WriteLine("0. Exit");
                Console.WriteLine("---------------------------------------");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            //f(x)={ 3x + \sqrtx, x>0 ; ex + 4, x\le0 }
                            Console.WriteLine("---------Ex a ---------------");
                            Console.Write("Enter a value for x: ");
                            double x = double.Parse(Console.ReadLine());

                            double result = Ex1_FunctionValue.CalculateFunctionValue1(x);

                            Console.WriteLine("The value of f(x) is: {0}", result);
                            Console.WriteLine("---------Ex b ---------------");
                            Console.Write("Enter a value for x: ");
                            double n = double.Parse(Console.ReadLine());

                            double result1 = Ex1_FunctionValue.CalculateFunctionValue2(n);

                            Console.WriteLine("The value of f(x) is: {0}", result1);

                            break;
                        }
                    case 2:
                        {
                            Ex2_UniqueTwoDigitNumbers.PrintUniqueTwoDigitNumbers();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter a number (n): ");
                            int n = int.Parse(Console.ReadLine());

                            Ex3_OddNumbersLessThanN.PrintOddNumbersLessThanN(n);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Enter the starting number (n): ");
                            int n = int.Parse(Console.ReadLine());

                            Console.Write("Enter the ending number (m): ");
                            int m = int.Parse(Console.ReadLine());

                            int count = Ex4_CountEvenNumbers.CountEvenNumbersInRange(n, m);

                            Console.WriteLine("The number of even numbers in the range [{0}, {1}]: {2}",n,m,count);
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
