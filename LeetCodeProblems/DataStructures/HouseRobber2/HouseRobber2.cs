using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.HouseRobber2
{
    class HouseRobber2
    {
        public int Rob(int[] nums)
        {
            int[] start = new int[nums.Length-1];
            int[] end = new int[nums.Length - 1];

            for (int i = 1; i < end.Length; i++)
                end[i - 1] = nums[i];
            for (int i = 0; i < start.Length; i++)
                end[i] = nums[i];

            return Math.Max(robhelp(start), robhelp(end));
        }

        public int robhelp(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int[] memo = new int[nums.Length + 1];
            memo[0] = 0;
            memo[1] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                memo[i + 1] = Math.Max(memo[i], memo[i - 1] + nums[i]);
            }

            return memo[memo.Length - 1];
        }
    }
}
