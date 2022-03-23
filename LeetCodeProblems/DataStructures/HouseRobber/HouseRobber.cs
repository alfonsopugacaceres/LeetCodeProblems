using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.HouseRobber
{
    class HouseRobber
    {
        public int rob(int [] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int[] memo = new int[nums.Length + 1];
            memo[0] = 0;
            memo[1] = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                memo[i + 1] = Math.Max(memo[i], memo[i - 1] + nums[i]);
            }

            return memo[memo.Length - 1];
        }
    }
}
