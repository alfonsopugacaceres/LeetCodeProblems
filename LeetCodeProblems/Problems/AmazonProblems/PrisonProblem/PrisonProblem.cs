using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems.PrisonProblem
{
    public class PrisonProblem
    {
        private int _prisonCellRowLength = 8;
        public int[] PrisonAfterNDays(int[] cells, int N)
        {
            if(N < 0 || N > 1000000000)
            {
                return null;
            }

            int[] currentIteration = new int[cells.Length];
            int[] nextIteration = new int[cells.Length];
            Array.Copy(cells, currentIteration, cells.Length);
            for (int i = 0; i < N; i++)
            {
                bool edgeCase = true;
                int currentCase = 0;
                for (int j = 0; j < currentIteration.Length; j++)
                {
                    nextIteration[j] = (WillBeOccupied(j, currentIteration)) ? 1 : 0;
                    if (edgeCase)
                    {
                        if (j == 0)
                        {
                            currentCase = nextIteration[j];
                        }
                        else
                        {
                            if (currentCase == nextIteration[j])
                            {
                                edgeCase = false;
                            }
                            else
                            {
                                currentCase = nextIteration[j];
                            }
                        }
                    }
                }
                int[] temp = currentIteration;
                currentIteration = nextIteration;
                nextIteration = temp;
                if (edgeCase)
                {
                    break;
                }
            }
            return currentIteration;

        }

        public bool WillBeOccupied(int target, int[] cells)
        {
            if(target - 1 < 0 || target + 1 > cells.Length - 1)
            {
                return false;
            }
            else
            {
                return (cells[target - 1] == 0 && cells[target + 1] == 0) || (cells[target - 1] == 1 && cells[target + 1] == 1);
            }
        }

    }
}
//IDictionary<int, int> occupied = new Dictionary<int, int>();
//IDictionary<int, int> empty = new Dictionary<int, int>();

//for (int i = 0; i < cells.Length; i++)
//{
//    if(cells[i] == 0)
//    {
//        empty.Add(i, 1);
//    }
//    else if(cells[i] == 1)
//    {
//        occupied.Add(i, 1);
//    }
//}

//for(int i = 0; i < N; i++)
//{
//    IList<int> occupiedIndexes = occupied.Keys.ToList();
//    for(int j = 0; j < occupiedIndexes.Count; j++)
//    {

//    }
//}
//return null;