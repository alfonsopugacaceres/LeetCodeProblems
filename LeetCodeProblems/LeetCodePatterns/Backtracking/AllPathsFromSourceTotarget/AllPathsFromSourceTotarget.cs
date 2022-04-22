using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Backtracking.AllPathsFromSourceTotarget
{
    class AllPathsFromSourceTotarget
    {

        //797. All Paths From Source to Target
        //Given a directed acyclic graph(DAG) of n nodes labeled from 0 to n - 1, find all possible paths from node 0 to node n - 1 and return them in any order.
        //The graph is given as follows: graph[i] is a list of all nodes you can visit from node i (i.e., there is a directed edge from node i to node graph[i][j]).
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            IList<IList<int>> res = new List<IList<int>>();
            IDictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
            for (int i = 0; i < graph.Length; i++)
                adjacencyList.Add(i, new List<int>(graph[i]));

            int target = adjacencyList.Count - 1;

            BacktrackHelper(0, target, new List<int>(), adjacencyList, res);
            return res;
        }

        public void BacktrackHelper(int location, int target, IList<int> traversal, IDictionary<int, List<int>> adjacenecyList, IList<IList<int>> res)
        {
            traversal.Add(location);
            if (location == target)
            {
                res.Add(traversal);
                return;
            }
            foreach (int adjacentNode in adjacenecyList[location])
            {
                IList<int> branchingTraversal = new List<int>(traversal);
                BacktrackHelper(adjacentNode, target, branchingTraversal, adjacenecyList, res);
            }
        }
    }
}
