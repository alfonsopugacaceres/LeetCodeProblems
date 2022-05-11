using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.GraphTraversal.NumberOfIslands
{
    class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            IDictionary<(int, int), char> memo = new Dictionary<(int, int), char>();
            int islandCount = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1' && !memo.ContainsKey((i, j)))
                    {
                        Helper(i, j, grid, memo);
                        islandCount++;
                    }
                }
            }

            return islandCount;
        }

        public void Helper(int i, int j, char[][] grid, IDictionary<(int, int), char> memo)
        {

            if (memo.ContainsKey((i, j)))
                return;
            if (OutOfBounds(i, j, grid))
            {
                return;
            }
            if (grid[i][j] == '1')
                memo.Add((i, j), grid[i][j]);
            else
                return;

            Helper(i + 1, j, grid, memo);
            Helper(i - 1, j, grid, memo);
            Helper(i, j + 1, grid, memo);
            Helper(i, j - 1, grid, memo);
        }

        public bool OutOfBounds(int i, int j, char[][] grid)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length)
                return true;
            else
                return false;
        }
    }
}
