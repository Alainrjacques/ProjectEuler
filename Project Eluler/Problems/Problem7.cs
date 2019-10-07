using System;

namespace Project_Eluler.Problems
{
    class Problem7 : IProblem
    {
        private readonly string problemDescription = "7: What is the 1000001th prime number?";

        public string GetProblemDescription()
        {
            return problemDescription;
        }

        PrimeCalculator PrimeCalculator = new PrimeCalculator();

        public void SolveProblem()
        {
            ulong count = 1, targetPrime = 1000001, primeNum = 1;
            //Count is 1 to count for prime number of 2
            while (count < targetPrime)
            {
                primeNum = PrimeCalculator.FindNextPrime(primeNum);
                count++;
            }
            Console.WriteLine($"Answer:{primeNum}\n");
        }
    }
}
