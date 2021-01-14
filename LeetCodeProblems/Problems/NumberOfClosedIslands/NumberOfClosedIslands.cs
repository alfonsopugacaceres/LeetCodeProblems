using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.NumberOfClosedIslands
{
    public class NumberOfClosedIslands
    {

        public int ClosedIsland(int[][] grid)
        {
            IDictionary<int, IList<int>> islands = new Dictionary<int, IList<int>>();
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        MapIsland(i, j, grid, islands);
                    }
                }
            }
            return 0;

        }
        public void MapIsland(int i, int j, int[][] map, IDictionary<int, IList<int>> islands)
        {
            if (i < 0 || j < 0 || i > map.Length - 1 || j > map[i].Length - 1)
            {
                return;
            }
            else if (map[i][j] == 0)
            {
                map[i][j] = 2;//marking island slot that was already checked 

                if (!islands.ContainsKey(i))
                {
                    islands[i] = new List<int>();
                }
                islands[i].Add(j);
                MapIsland(i - 1, j, map, islands);
                MapIsland(i + 1, j, map, islands);
                MapIsland(i, j - 1, map, islands);
                MapIsland(i, j + 1, map, islands);

            }
        }
    }
}
