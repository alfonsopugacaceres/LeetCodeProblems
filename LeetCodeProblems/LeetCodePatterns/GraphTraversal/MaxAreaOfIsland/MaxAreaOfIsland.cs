using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.GraphTraversal.MaxAreaOfIsland
{
    class MaxAreaOfIsland
    {
        //695. Max Area of Island
        //You are given an m x n binary matrix grid.An island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.
        //The area of an island is the number of cells with a value 1 in the island.
        //Return the maximum area of an island in grid.If there is no island, return 0.

        public int MaxAreaOfIsland1(int[][] grid)
        {

            HashSet<(int, int)> set = new HashSet<(int, int)>();
            int max = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        max = Math.Max(max, RecursiveHelper(i, j, grid, set));
                    }
                }
            }

            return max;
        }
        int RecursiveHelper(int i, int j, int[][] grid, HashSet<(int, int)> set)
        {
            if (CheckBouds(i, j, grid, set))
            {
                set.Add((i, j));
                return 1 + RecursiveHelper(i + 1, j, grid, set)
                    + RecursiveHelper(i - 1, j, grid, set)
                    + RecursiveHelper(i, j + 1, grid, set)
                    + RecursiveHelper(i, j - 1, grid, set);
            }
            else
                return 0;
        }

        public bool CheckBouds(int i, int j, int[][] grid, HashSet<(int, int)> set)
        {
            if (i > grid.Length - 1 || i < 0 || j > grid[0].Length - 1 || j < 0)
                return false;
            if (set.Contains((i, j)))
                return false;
            if (grid[i][j] == 0)
                return false;

            return true;
        }
    }
}
