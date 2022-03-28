using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.DynamicProgrammingTabulation.MinimumDifficultyJobSchedule
{
    class MinimumDifficultyJobSchedulecs
    {
        //1335. Minimum Difficulty of a Job Schedule
        //You want to schedule a list of jobs in d days.Jobs are dependent (i.e To work on the ith job, 
        //you have to finish all the jobs j where 0 <= j<i).
        //You have to finish at least one task every day.The difficulty of a job schedule is the sum of 
        //difficulties of each day of the d days.The difficulty of a day is the maximum difficulty of a job done on that day.
        //You are given an integer array jobDifficulty and an integer d.The difficulty of the ith job is jobDifficulty[i].
        //Return the minimum difficulty of a job schedule. If you cannot find a schedule for the jobs return -1.

        public int MinDifficulty1(int[] jobDifficulty, int d)
        {
            int totaljobs = jobDifficulty.Length;//find the total length of the jobs
            if (totaljobs < d)//if the number of jobs is less than the number of days we dont satisfy the condition of 1 job per day 
                return -1;

            int[][] memo = new int[totaljobs][];
            for(int i = 0; i < memo.Length; i++)
            {
                memo[i] = new int[d + 1];
                Array.Fill(memo[i], -1);
            }

            return dfs(d, 0, jobDifficulty, memo);
        }
        private int dfs(int d, int len, int[] jobDifficulty, int[][] memo)
        {
            int N = jobDifficulty.Length;
            if (d == 0 && len == N) 
                return 0;
            if (d == 0 || len == N) 
                return int.MaxValue;
            if (memo[len][d] != -1) 
                return memo[len][d];

            int curMax = jobDifficulty[len];
            int min = int.MaxValue;
            for (int schedule = len; schedule < N; ++schedule)
            {
                curMax = Math.Max(curMax, jobDifficulty[schedule]);
                int temp = dfs(d - 1, schedule + 1, jobDifficulty, memo);
                if (temp != int.MaxValue)
                    min = Math.Min(min, temp + curMax);
            }

            return memo[len][d] = min;
        }
    }
}
