using System;
using System.Linq;

namespace Project_Eluler
{
    class PrimeCalculator
    {
        public ulong FindNextPrime(ulong prime)
        {
            if (!IsPrime(prime))
            {
                return FindNextPrime(prime + 1);
            }
            return prime;
        }

        public static bool IsPrime(ulong number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (ulong)Math.Floor(Math.Sqrt(number));

            for (ulong i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
