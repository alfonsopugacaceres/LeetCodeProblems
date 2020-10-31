using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems.CutOffTree
{
    public class CutOffTree
    {

        public CutOffTree()
        {

        }

        public int Solve(IList<IList<int>> forest)
        {
            if(forest.Count < 1 || forest.Count > 50)
            {
                return -1;
            }

            IDictionary<int, KeyValuePair<int, int>> shortest = new Dictionary<int, KeyValuePair<int, int>>();
            int max = 0;
            for (int i = 0; i < forest.Count; i++)
            {
                IList<int> target = forest[i];
                for(int j = 0; j < target.Count; j++)
                {
                    shortest[target[j]] = new KeyValuePair<int, int>(i, j);
                    if(target[j] > max)
                    {
                        max = target[j];
                    }
                }
            }

            int start = 0;

            int xMove = 0;
            int yMove = 0;
            int steps = 0;

            ICollection<int> d = shortest.Keys;
            foreach(int x  in d)
            {
                start += 1;
                KeyValuePair<int, int> axis = shortest[x];
                xMove = Math.Abs(xMove - axis.Key);
                yMove = Math.Abs(yMove - axis.Value);
                steps += xMove + yMove;
                xMove = axis.Key;
                yMove = axis.Value;
            }

            return steps;

        }
    }
}


//[[1,2,3],
//[0,0,4],
//[7,6,5]]