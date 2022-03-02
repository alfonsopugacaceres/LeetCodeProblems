using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MaxIncreaseToKeepSkyline
{
    public class MaxIncreaseToKeepSkyline
    {
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {

            int[] rowMax = new int[grid.Length];//create an array with all the maxes for rows
            int[] colMax = new int[grid.Length];//create an array with all the maxes for columns
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    rowMax[i] = Math.Max(rowMax[i], grid[i][j]);//find the row maxes
                    colMax[j] = Math.Max(colMax[j], grid[i][j]);//find the column maxes
                }
            }
            int res = 0;//create a variable for the result
            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid.Length; j++)
                    res += Math.Min(rowMax[i], colMax[j]) - grid[i][j];//using the previous calculated maximums, pick the minimum value to 
                                                                       //maintain the skyline, finally subtract the current value to start adding
                                                                       //up how much the current building was increased

            return res;//return how much the buildings increased

        }

    }
}
