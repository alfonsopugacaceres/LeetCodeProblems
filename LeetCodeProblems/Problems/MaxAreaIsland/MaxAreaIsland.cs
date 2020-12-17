using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MaxAreaIsland
{
    public class MaxAreaIsland
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            int ret = int.MinValue;


            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    int maxareacur = maxArea(grid, i, j);
                    if(maxareacur > ret)
                    {
                        ret = maxareacur;
                    }
                }
            }
            return ret;

        }

        public int maxArea(int[][] grid, int i, int j)
        {
            if(i < 0 || i > grid.Length - 1)
            {
                return 0;
            }
            else if(j < 0 || j > grid[i].Length - 1)
            {
                return 0;
            }
            else if(grid[i][j] == 0)
            {
                return 0;
            }
            else if(grid[i][j] == 1)
            {
                grid[i][j] = 0;//we just checked this, so do not check it again
                return 1 + maxArea(grid, i + 1, j) + maxArea(grid, i, j + 1) + maxArea(grid, i - 1, j) + maxArea(grid, i, j - 1);
            }
            else
            {
                return 0;
            }
        }
    }
}
