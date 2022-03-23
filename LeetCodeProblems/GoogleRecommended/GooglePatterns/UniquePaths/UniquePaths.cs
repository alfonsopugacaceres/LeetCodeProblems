using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.UniquePaths
{
    class UniquePaths
    {
        public int UniquePaths1(int m, int n)
        {

            int[][] grid = new int[m + 1][];
            int leftBound = 0;
            int upBound = 0;
            int downBound = m + 1;
            int rightBound = n + 1;


            for (int i = 0; i < downBound; i++)
            {
                grid[i] = new int[rightBound];
            }

            grid[1][1] = 1;

            for (int i = 0; i < downBound; i++)
            {
                for (int j = 0; j < rightBound; j++)
                {
                    if (grid[i][j] >= 1)
                    {
                        if (i < downBound - 1)
                        {
                            grid[i + 1][j] += grid[i][j];
                        }
                        if (j < rightBound - 1)
                        {
                            grid[i][j + 1] += grid[i][j];
                        }
                    }
                }
            }

            return grid[downBound - 1][rightBound - 1];


        }
    }
}
