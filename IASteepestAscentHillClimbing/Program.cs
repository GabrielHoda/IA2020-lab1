using System;
using System.Collections.Generic;
using IASteepestAscentHillClimbing.Classes;

namespace IASteepestAscentHillClimbing
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = Int32.Parse(args[0]);
            int runNumber = Int32.Parse(args[1]);
            using System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\gabrielh\source\repos\IASteepestAscentHillClimbing\IASteepestAscentHillClimbing\Output\backpack200-output.txt", true);

            file.WriteLine("Steepest Ascent Hill Climb");
            file.WriteLine("k= " + k);
            file.WriteLine("number of runs= " + runNumber);

            List<int> solutionArray = new List<int>();

            for (int i = 0; i < runNumber; i++)
            {
                Backpack.initializeBackpack();
                var solution = SteepestAscent.solution(k);
                var fitness = Solutions.evalSolution(solution);
                solutionArray.Add(fitness);
                file.WriteLine(i + "  " + fitness);
            }

            int bestSolution = solutionArray[0];
            int solutionSum = 0;

            for (int i = 0; i < solutionArray.Count; i++)
            {
                solutionSum += solutionArray[i];
                if (solutionArray[i] > bestSolution)
                {
                    bestSolution = solutionArray[i];
                }
            }

            file.WriteLine("best solution= " + bestSolution);
            file.WriteLine("average solution= " + solutionSum / solutionArray.Count);
        }
    }
}
