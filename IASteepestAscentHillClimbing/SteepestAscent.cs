using System;
using System.Collections.Generic;
using System.Text;
using IASteepestAscentHillClimbing.Classes;
namespace IASteepestAscentHillClimbing
{
    class SteepestAscent
    {
        public static List<int> solution(int k)
        {
            List<int> c = Solutions.genRandomSolution(Backpack.objectNumber);
            List<int> best = c;
            for (int i = 0; i < k; i++)
            {
                List<int> x = Neighbors.bestNeighbor(c);
                if (Solutions.evalSolution(x) <= Solutions.evalSolution(c))
                {
                    best = c;
                    c = Solutions.genRandomSolution(Backpack.objectNumber);
                }
                else
                    c = x;
            }
            return best;
        }
    }
}
