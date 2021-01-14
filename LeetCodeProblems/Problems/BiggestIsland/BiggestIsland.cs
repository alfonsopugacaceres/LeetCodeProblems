using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.NumberOfIslands
{
    public class BiggestIsland
    {
        public int ClosedIsland(int[][] grid)
        {
            int maxIsland = 0;
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        int ret = RecursiveCheck(i, j, ref grid);
                        if(maxIsland < ret)
                        {
                            maxIsland = ret;
                        }
                    }
                }
            }
            return maxIsland;
        }

        public int RecursiveCheck(int i, int j, ref int[][] map)
        {
            int counter = 0;
            if (i < 0 || j < 0 || i > map.Length - 1 || j > map[i].Length - 1)
            {
                return 0;
            }
            else if (map[i][j] == 1)
            {
                map[i][j] = 0;
                counter++;
                counter += RecursiveCheck(i - 1, j, ref map);
                counter += RecursiveCheck(i + 1, j, ref map);
                counter += RecursiveCheck(i, j - 1, ref map);
                counter += RecursiveCheck(i, j + 1, ref map);

                return counter;
            }
            else
            {
                return 0;
            }
        }
    }
}
