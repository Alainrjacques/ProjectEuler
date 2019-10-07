using System;

namespace Project_Eluler.Problems
{
    class Problem1 : IProblem
    {
        private readonly string problemDescription = "1: What is the Sum of all the multiples of 3 or 5 below 1000?";

        public string GetProblemDescription()
        {
            return problemDescription;
        }

        public void SolveProblem()
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Answer:{sum}\n");
        }
    }
}
