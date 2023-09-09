using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class Ex10_ReadIntegerSequence
    {
        public static List<int> ReadIntegerSequence()
        {
            List<int> sequence = new List<int>();

            while (true)
            {
                Console.Write("Enter an integer (enter 0 to stop): ");
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                    break;

                sequence.Add(number);
            }

            return sequence;
        }

        public static int CalculateSum(List<int> sequence)
        {
            int sum = 0;

            foreach (int number in sequence)
            {
                sum += number;
            }

            return sum;
        }

        public static int FindMax(List<int> sequence)
        {
            int max = int.MinValue;

            foreach (int number in sequence)
            {
                if (number > max)
                    max = number;
            }

            return max;
        }

        public static int FindMin(List<int> sequence)
        {
            int min = int.MaxValue;

            foreach (int number in sequence)
            {
                if (number < min)
                    min = number;
            }

            return min;
        }
    }
}
