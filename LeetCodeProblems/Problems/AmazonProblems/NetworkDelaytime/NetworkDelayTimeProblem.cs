using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems.NetworkDelaytime
{
    public class NetworkDelayTimeProblem
    {
        //public int NetworkDelayTime(int[][] times, int N, int K)
        //{
        //    if(N < 1 || N > 100)
        //    {
        //        return -1;
        //    }
        //    else if(K < 1 || K > N)
        //    {
        //        return -1;
        //    }
        //    else if(times.Length > 6000 || times.Length < 1)
        //    {
        //        return -1;
        //    } 
        //    else
        //    {
        //        IDictionary<int, IList<int[]>> paths = new Dictionary<int, IList<int[]>>();
        //        IDictionary<int, int> shortestPath = new Dictionary<int, int>();
        //        bool[] visited = new bool[N];

        //        //map every possible path based on source index
        //        for(int i = 0; i < times.Length; i++)
        //        {
        //            if (!paths.ContainsKey(times[i][0]))
        //            {
        //                paths.Add(times[i][0], new List<int[]>() { new int[] { times[i][1], times[i][2] } });
        //            }
        //            else
        //            {
        //                paths[i].Add(new int[] { times[i][1], times[i][2] });
        //            }
        //        }

        //        //intialize shortest distances and visited flags
        //        for(int i = 0; i < K; i++)
        //        {
        //            shortestPath.Add(i, int.MaxValue);
        //            visited[i] = false;
        //        }

        //        while (true)
        //        {
        //            int candNode = -1;
        //            int candDist = int.MaxValue;

        //            for(int i = 0; i < N; i++)
        //            {
        //                if(!visited[i])
        //            }

        //        }



        //        return 0;
        //    }
        //}
    }
}
