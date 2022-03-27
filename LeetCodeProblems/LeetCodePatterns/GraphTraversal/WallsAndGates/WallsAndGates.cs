using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.GraphTraversal.WallsAndGates
{
    class WallsAndGates
    {
        //286. Walls and Gates

        //You are given an m x n grid rooms initialized with these three possible values.
        //-1 A wall or an obstacle.
        //0 A gate.
        //INF Infinity means an empty room.We use the value 231 - 1 = 2147483647 
        //to represent INF as you may assume that the distance to a gate is less than 2147483647.
        public void WallsAndGates1(int[][] rooms)
        {

            Queue<(int, int, int)> queue = new Queue<(int, int, int)>();//this is the queue 
            HashSet<(int, int)> set = new HashSet<(int, int)>();
            for (int i = 0; i < rooms.Length; i++)
            {
                for (int j = 0; j < rooms[0].Length; j++)
                {
                    if (rooms[i][j] == 0)
                    {
                        queue.Enqueue((i, j, 0));
                    }
                }
            }
            int distance = 0;
            while (queue.Count > 0)
            {
                int layer = queue.Count;
                for (int i = 0; i < layer; i++)
                {
                    (int, int, int) current = queue.Dequeue();
                    set.Add((current.Item1, current.Item2));
                    rooms[current.Item1][current.Item2] = Math.Min(current.Item3, rooms[current.Item1][current.Item2]);
                    if (CheckValidity(current.Item1 + 1, current.Item2, rooms, set))
                        queue.Enqueue((current.Item1 + 1, current.Item2, distance + 1));
                    if (CheckValidity(current.Item1 - 1, current.Item2, rooms, set))
                        queue.Enqueue((current.Item1 - 1, current.Item2, distance + 1));
                    if (CheckValidity(current.Item1, current.Item2 + 1, rooms, set))
                        queue.Enqueue((current.Item1, current.Item2 + 1, distance + 1));
                    if (CheckValidity(current.Item1, current.Item2 - 1, rooms, set))
                        queue.Enqueue((current.Item1, current.Item2 - 1, distance + 1));
                }
                distance++;
            }

        }

        public bool CheckValidity(int i, int j, int[][] grid, HashSet<(int, int)> set)
        {
            if (i < 0 || i > grid.Length - 1 || j < 0 || j > grid[0].Length - 1)
            {
                return false;
            }
            if (set.Contains((i, j)))
            {
                return false;
            }
            if (grid[i][j] == -1)
            {
                return false;
            }
            return true;
        }
    }
}
