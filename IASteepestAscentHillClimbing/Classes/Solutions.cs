using System;
using System.Collections.Generic;
using System.Text;

namespace IASteepestAscentHillClimbing.Classes
{
    class Solutions
    {
        private static readonly Random rand = new Random();

        public static bool isValid(List<int> solution)
        {
            int totalWeight = 0;
            for (int i = 0; i < solution.Count; i++)
            {
                if (solution[i] == 1)
                {
                    totalWeight += Backpack.objectsList[i].weight;
                }
            }
            return totalWeight <= Backpack.capacity;
        }

        public static List<int> genRandomSolution(int length)
        {
            List<int> solRandom = new List<int>();
            for (int i = 0; i < length; i++)
            {
                solRandom.Add(rand.Next(0, 2));
            }
            if (isValid(solRandom))
            {
                return solRandom;
            }
            else
            {
                return genRandomSolution(length);
            }
        }

        public static int evalSolution(List<int> solution)
        {
            int fitness = 0;
            for (int i = 0; i < solution.Count; i++)
            {
                if (solution[i] == 1)
                {
                    fitness += Backpack.objectsList[i].value;
                }
            }
            return fitness;
        }
    }

}
