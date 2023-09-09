using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Ex9_FindPrimesLessThanN
    {
        public static List<int> FindPrimesLessThan(int n1)
        {
            List<int> primes = new List<int>();

            for (int number1 = 2; number1 < n1; number1++)
            {
                if (IsPrime(number1))
                    primes.Add(number1);
            }

            return primes;
        }

        private static bool IsPrime(int number1)
        {
            if (number1 <= 1)
                return false;

            for (int i = 2; i * i <= number1; i++)
            {
                if (number1 % i == 0)
                    return false;
            }

            return true;
        }
    }
}
