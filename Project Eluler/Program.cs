using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Project_Eluler.Problems;

namespace Project_Eluler
{

    class Program
    {
        static List<IProblem> problems = new List<IProblem>();

        static void Main(string[] args)
        {
            Console.WriteLine("Please selection an opition(0 to exit):\n\n");
            LoadProblemsIntoOptions();

            var result = GetSelection();

            while (result > 0)
            {
                Console.WriteLine("\nWorking...\n");
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                problems[result-1].SolveProblem();
               
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;

                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("RunTime " + elapsedTime + "\n");

                result = GetSelection();
            }
        }
        
        private static void LoadProblemsIntoOptions()
        {

            var types = Assembly.Load("Project Eluler")
                .GetTypes()
                .Where(x => !string.IsNullOrEmpty(x.Namespace))
                .Where(x => x.IsClass)
                .Where(x => x.Namespace.StartsWith("Project_Eluler.Problem"))
                .Where(x => x.Name.StartsWith("Problem"))
                .OrderBy(x => x.Name).ToList();

            foreach (var t in types)
            {
                var problem = Activator.CreateInstance(t) as IProblem;
                problems.Add(problem);
            }
        }

        static int GetSelection()
        {
            foreach (var problem in problems)
            {
                Console.WriteLine(problem.GetProblemDescription());
            }
            var input = Console.ReadLine();
            bool success = int.TryParse(input, out int result);
            return success ? result : 0;
        }
    }
}
