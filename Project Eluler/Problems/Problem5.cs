using System;

namespace Project_Eluler.Problems
{
    class Problem5 : IProblem
    {
        private readonly string problemDescription = "5: What is the smallest number divisible by each of the numbers 1 to 20?";

        public string GetProblemDescription()
        {
            return problemDescription;
        }

        public void SolveProblem()
        {
            bool done = false;
            uint testNum = 20;

            while (!done)
            {
                done = IsDivisable(testNum, 20);
                if (!done)
                {
                    testNum += 20;
                }
            }
            
            Console.WriteLine($"Answer:{testNum}\n");
        }
        bool IsDivisable(uint n, uint x)
        {
            if (x == 1)
            {
                return true;
            }
            else if (n % x == 0)
            {
                return IsDivisable(n, (x - 1));
            }
            else
            {
                return false;
            }
        }
    }
}
