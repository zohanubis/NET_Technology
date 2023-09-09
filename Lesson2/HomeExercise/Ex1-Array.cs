using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExercise
{

    //Bài 1. Viết phương thức tính tổng các phần tử cực đại trong mảng các số nguyên (phần tử cực đại là phần tử lớn hơn các phần tử xung quanh nó)
    public class Ex1
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
        public static int CalculateSumMax(int[] arr)
        {
            int sum = 0;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    Console.Write(arr[i] + " ");
                    sum += arr[i];
                }
            }
            Console.WriteLine();
            return sum;
        }
    }
}
