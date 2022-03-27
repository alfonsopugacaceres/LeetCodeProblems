using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.GraphTraversal.IslandPerimeter
{
    class IslandPerimeter
    {
        //463. Island Perimeter

        //You are given row x col grid representing a map where grid[i][j] = 1 represents land and grid[i][j] = 0 represents water.
        //Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells).
        //The island doesn't have "lakes", meaning the water inside isn't connected to the water around the island.One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100. Determine the perimeter of the island.
        public int IslandPerimeter1(int[][] grid)
        {

            HashSet<(int, int)> set = new HashSet<(int, int)>();
            int max = 0;

            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[0].Length; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        max = Math.Max(max, RecursiveHelper(i, j, grid, set));
                    }
                }
            }

            return max;
        }


        int RecursiveHelper(int i, int j, int[][]grid, HashSet<(int,int)> set)
        {
            if (i > grid.Length - 1 || i < 0 || j > grid[0].Length - 1 || j < 0)
                return 1;
            if (set.Contains((i, j)))
                return 0;
            if (grid[i][j] == 0)
                return 1;
            int perimeter = 0;
            set.Add((i, j));
            perimeter += RecursiveHelper(i + 1, j, grid, set)
                + RecursiveHelper(i - 1, j, grid, set)
                + RecursiveHelper(i, j + 1, grid, set)
                + RecursiveHelper(i, j - 1, grid, set);

            return perimeter;
        }

    }
}
