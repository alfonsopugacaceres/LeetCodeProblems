using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.DynamicProgrammingTabulation.MaximumPopulationYear
{
    //1854. Maximum Population Year
    //    You are given a 2D integer array logs where each logs[i] = [birthi, deathi] indicates the birth and death years of the ith person.

    //The population of some year x is the number of people alive during that year. The ith person is counted in year x's population if x is in the inclusive range [birthi, deathi - 1]. Note that the person is not counted in the year that they die.

    //Return the earliest year with the maximum population.
    class MaximumPopulationYear
    {
        public int MaximumPopulation(int[][] logs)
        {
            int[] dp = new int[101];
            int max = int.MinValue;

            for (int i = 0; i < logs.Length; i++)
            {

                int j = logs[i][0] - 1950;
                while (j < logs[i][1] - 1950)
                {
                    dp[j]++;
                    max = Math.Max(dp[j], max);
                    j++;
                }
            }

            for (int i = 0; i < dp.Length; i++)
                if (dp[i] == max)
                    return i + 1950;

            return 0;
        }
    }
}
