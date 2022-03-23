using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.BuildBrickWall
{
    public class BuildBrickWall
    {

        public int BuildWall(int height, int width, int[] bricks)
        {
            if (height < 1 || height > 100 || width < 1 || width > 10 || bricks.Length <= 0 || bricks.Length > 10)
                return 0;
            else
            {
                double ret = 0;
                IDictionary<int, (int, int)> rowToBrickEdge = new Dictionary<int, (int, int)>();
                HashSet<int> usableBricks = new HashSet<int>();
                

                for(int i = 0; i < bricks.Length; i++)
                {
                    if (bricks[i] < width)
                        usableBricks.Add(bricks[i]);
                }

                if (usableBricks.Count == 0)
                    return 0;
                else
                {

                }

                return (int)(ret % (1000000000 + 7));
            }
        }
    }
}
