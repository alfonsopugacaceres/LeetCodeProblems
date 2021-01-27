using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.Problems.CutOffTreesForGolfEvent
{
    public class CutOffTreesforGolfEvent
    {
        public int CutOffTree(IList<IList<int>> forest)
        {
            IDictionary<int, IList<int>> treesToCut = new SortedList<int, IList<int>>();
            for(int i = 0; i < forest.Count; i++)
            {
                for(int j = 0; j < forest[i].Count; j++)
                {
                    if(forest[i][j] > 0)
                    {
                        if (!treesToCut.ContainsKey(forest[i][j]))
                        {
                            treesToCut[forest[i][j]] = new List<int>();
                        }
                        treesToCut[forest[i][j]].Add(forest[i][j]);
                        treesToCut[forest[i][j]].Add(i);
                        treesToCut[forest[i][j]].Add(j);
                    }
                }
            }





            return -1;
        }

        public void Traversal(int startX, int startY, IList<IList<int>> forest)
        {
            if(startX > forest.Count)
            {
                return;
            }
            else if(startY > forest[startX].Count)
            {
                return;
            }
            else
            {
                int right = startX + 1;
                int left = startX - 1;
                int up = startY + 1;
                int down = startY - 1;

            }
        }
    }
}
