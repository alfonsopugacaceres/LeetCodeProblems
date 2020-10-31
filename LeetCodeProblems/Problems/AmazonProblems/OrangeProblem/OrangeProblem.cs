using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems
{
    public class OrangeProblem
    {
        public int OrangesRotting(int[][] grid)
        {
            //0 = empty
            //1 = Fresh Orange
            //2 = Rotten Orange
            //REMEMBER THE ARRAY CAN BE A JAGGED ARRAY, PAY ATTENTION TO THE CONDITIONS

            if(grid.Length < 1 || grid.Length > 10)
            {
                return -1;
            }

            IDictionary<KeyValuePair<int, int>, int> none = new Dictionary<KeyValuePair<int, int>, int>();
            IDictionary<KeyValuePair<int, int>, int> fresh = new Dictionary<KeyValuePair<int, int>, int>();
            IDictionary<KeyValuePair<int, int>, int> rotten = new Dictionary<KeyValuePair<int, int>, int>();

            for (int i = 0; i < grid.Length; i++)
            {
                if(grid[i].Length < 1 || grid[i].Length > 10)
                {
                    return -1;
                }
                for (int j = 0; j < grid[i].Length; j++)
                {
                    var key = new KeyValuePair<int, int>(i, j);
                    if (grid[i][j] == 0)
                    {
                        none.Add(key, 0);
                    }
                    else if (grid[i][j] == 1)
                    {
                        fresh.Add(key, 1);
                    }
                    else if(grid[i][j] == 2)
                    {
                        rotten.Add(key, 2);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }

            bool possibleResponse = true;
            int minutes = 0;

            while (possibleResponse)
            {

                if ((rotten == null || rotten.Count <= 0) && (fresh != null && fresh.Count > 0))
                {
                    return -1;//will not have a solution
                }
                else if ((rotten == null || rotten.Count <= 0) && (fresh != null && fresh.Count == 0))
                {
                    return 0;
                }
                else if (fresh != null && fresh.Count == 0)
                {
                    return minutes;
                }
                else
                {
                    IList<KeyValuePair<int, int>> rottenKeys = rotten.Keys.ToList();
                    bool noChanges = true;
                    foreach (KeyValuePair<int, int> coordinate in rottenKeys)
                    {
                        if (coordinate.Value + 1 <= grid[coordinate.Key].Length)
                        {
                            KeyValuePair<int, int> top = new KeyValuePair<int, int>(coordinate.Key, coordinate.Value + 1);
                            if (fresh.ContainsKey(top))
                            {
                                fresh.Remove(top);
                                rotten.Add(top, 2);
                                noChanges = false;
                            }
                        }
                        if (coordinate.Value - 1 >= 0)
                        {
                            KeyValuePair<int, int> bottom = new KeyValuePair<int, int>(coordinate.Key, coordinate.Value - 1);
                            if (fresh.ContainsKey(bottom))
                            {
                                fresh.Remove(bottom);
                                rotten.Add(bottom, 2);
                                noChanges = false;
                            }

                        }
                        if (coordinate.Key + 1 <= grid.Length)
                        {
                            KeyValuePair<int, int> right = new KeyValuePair<int, int>(coordinate.Key + 1, coordinate.Value);
                            if (fresh.ContainsKey(right))
                            {
                                fresh.Remove(right);
                                rotten.Add(right, 2);
                                noChanges = false;
                            }
                        }

                        if (coordinate.Key - 1 >= 0)
                        {
                            KeyValuePair<int, int> left = new KeyValuePair<int, int>(coordinate.Key - 1, coordinate.Value);
                            if (fresh.ContainsKey(left))
                            {
                                fresh.Remove(left);
                                rotten.Add(left, 2);
                                noChanges = false;
                            }
                        }
                    }
                    minutes++;
                    if (noChanges)
                    {
                        return -1;
                    }
                }
            }
            return minutes;

        }
    }
}
