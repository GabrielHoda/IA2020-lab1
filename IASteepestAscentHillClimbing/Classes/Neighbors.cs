using System;
using System.Collections.Generic;
using System.Text;

namespace IASteepestAscentHillClimbing.Classes
{
    class Neighbors
    {
        public static List<List<int>> neighborsList(List<int> solution)
        {
            List<List<int>> allNeighbors = new List<List<int>>();
            int i;
            for(i = 0; i < solution.Count; i++)
            {
                if (solution[i] == 0)
                {
                    solution[i] = 1;
                    if (Solutions.isValid(solution))
                        allNeighbors.Add(solution);
                    else
                        solution[i] = 0;
                }
            }
            return allNeighbors;
        }

        public  static List<int> bestNeighbor (List<int> solution)
        {
            List<int> best = solution;
            List<List<int>> neighbors = neighborsList(solution);
            int i;
            for (i=0; i < neighbors.Count; i++)
            {
                if (Solutions.evalSolution(best) < Solutions.evalSolution(neighbors[i]))
                {
                    best = neighbors[i];
                }
            }
            return best;
        }

    }
}
