using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExercise
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
                Console.WriteLine("1. Check if the entered number is positive or negative");
                Console.WriteLine("2. Calculate the product 1*2*3*4*...*n, where n is entered from the keyboard");
                Console.WriteLine("3. Find GCD");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter a number: ");
                            int number = int.Parse(Console.ReadLine());

                            string result = KTAmDuong.KiemTraAmDuong(number);
                            Console.WriteLine("The number {0} is {1}", number, result);

                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter a number: ");
                            int n = int.Parse(Console.ReadLine());

                            int product = TinhTich.Tich(n);

                            Console.WriteLine("The product of numbers from 1 to {0} is: {1}", n, product);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter number a: ");
                            int a = int.Parse(Console.ReadLine());

                            Console.Write("Enter number b: ");
                            int b = int.Parse(Console.ReadLine());

                            int gcd = GCD.CalculateGCD(a, b);

                            Console.WriteLine("The greatest common divisor of {0} and {1} is: {2}", a, b, gcd);
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
                Console.WriteLine();
            } while (true);
        }
    }
}
