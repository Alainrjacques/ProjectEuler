using System;

namespace Project_Eluler.Problems
{
    class Problem2 : IProblem
    {
        private readonly string problemDescription = "2: What is the Sum of all the even numbers in theFibonacci sequence?";

        public string GetProblemDescription()
        {
            return problemDescription;
        }

        public void SolveProblem()
        {
            uint a, b, c, sum = 0;

            a = 1;
            b = 1;

            while (b < 4000000)
            {
                c = a + b;
                a = b;
                b = c;
                if (b % 2 == 0)
                {
                    sum += b;
                }
            }
            Console.WriteLine($"Answer:{sum}\n");
        }
    }
}
