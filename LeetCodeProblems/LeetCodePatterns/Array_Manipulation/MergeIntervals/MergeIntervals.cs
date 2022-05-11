using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.MergeIntervals
{
    internal class MergeIntervals
    {

        public int[][] Merge(int[][] intervals)
        {

            int[] dp = new int[10001];
            IList<int[]> ret = new List<int[]>();
            HashSet<int> outlier = new HashSet<int>();

            foreach (int[] interval in intervals)
            {
                if (interval[0] == interval[1])
                    outlier.Add(interval[0]);

                Array.Fill(dp, 1, interval[0], interval[1] - interval[0]);
            }


            bool start = false;
            int[] current = new int[2];
            for (int i = 0; i < dp.Length; i++)
            {

                if (dp[i] == 1 && !start)
                {
                    if (outlier.Contains(i))
                        outlier.Remove(i);
                    start = true;
                    current[0] = i;
                }
                else
                {
                    if (start && outlier.Contains(i))
                        outlier.Remove(i);
                    if (dp[i] != 1 && start == true)
                    {
                        start = false;
                        current[1] = i;
                        ret.Add(current);
                        current = new int[2];
                    }
                }


            }

            foreach (int o in outlier)
                ret.Add(new int[2] { o, o });

            return ret.ToArray();

        }
    }
}
