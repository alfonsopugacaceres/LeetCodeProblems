using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.FindCenterOfStarGraph
{
    class FindCenterOfStarGraph
    {
        public int FindCenter(int[][] edges)
        {
            IDictionary<int, IList<int>> adjacencyList = new Dictionary<int, IList<int>>();

            foreach(int[] arr in edges)
            {
                if (!adjacencyList.ContainsKey(arr[0]))
                    adjacencyList.Add(arr[0], new List<int>() { arr[1] });
                else
                    adjacencyList[arr[0]].Add(arr[1]);
                if (!adjacencyList.ContainsKey(arr[1]))
                    adjacencyList.Add(arr[1], new List<int>() { arr[0] });
                else
                    adjacencyList[arr[1]].Add(arr[0]);
            }

            int nodes = adjacencyList.Keys.Count;

            foreach(KeyValuePair<int,IList<int>> pair in adjacencyList)
            {
                if (pair.Value.Count == nodes - 1)
                    return pair.Key;
            }

            return -1;

        }
    }
}
