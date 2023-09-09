using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class Array
    {
        public static void InputArray(int[] arr)
        {
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("Array elements : ");
            foreach (int num in arr)
            {
                Console.Write("{0}", num);
            }
            Console.WriteLine();
        }
        // Liệt kê các phần tử lẻ ở vị chẵn
        public static void PrintEvenElements(int[] arr)
        {
            Console.WriteLine("Odd elements at even positions:");
            for (int i = 0; i < arr.Length; i += 2)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            Console.WriteLine();
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        // Liệt kế các số nguyên tố đầu tiên trong mảng
        public static void PrintPrimeElements(int[] arr)
        {
            Console.WriteLine("Prime elements in the array: ");
            foreach (int num in arr)
            {
                if (IsPrime(num))
                {
                    Console.Write("{0} ", num);
                }
            }
            Console.WriteLine();
        }
        // Tìm phần tử âm đầu tiên trong mảng
        public static int FindFirstNegativeElement(int[] arr)
        {
            Console.WriteLine("Finding the first negative element in the array");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    return arr[i];
            }
            return 0;
        }
        // Tìm max, min của dãy
        public static int FindMinElement(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) { min = arr[i]; }
            }
            return min;
        }
        public static int FindMaxElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) { max = arr[i]; }
            }
            return max;
        }
        // Tính tổng các phần tử trong mảng
        public static int CalculateSum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
    }
}
