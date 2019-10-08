using System;

namespace Project_Eluler.Problems
{
    class Problem3 : IProblem
    {
        PrimeCalculator PrimeCalculator = new PrimeCalculator();
        private readonly string problemDescription = "3: Finds the largest prime Factor of a number";

        public string GetProblemDescription()
        {
            return problemDescription;
        }

        public void SolveProblem()
        {
            ulong testNum = 600851475143;

            ulong largestPrime = 2;

            while (testNum != 1)
            {
                if (testNum % largestPrime == 0)
                {
                    testNum /= largestPrime;
                }
                else
                    largestPrime = PrimeCalculator.FindNextPrime(largestPrime + 1);
            }
            Console.WriteLine($"Answer:{largestPrime}\n");
        }
    }
}
