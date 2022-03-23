using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {

            int[] dp = new int[nums.Length];
            for (int i = 0; i < dp.Length; i++)//initialize the dp table to be the base case, the bare minimum longest sequence is 1, the element itself
                dp[i] = 1;

            for (int i = 1; i < nums.Length; i++)//start at index 1, this is because index 0 is bogus, we are trying to check backwards
            {
                for (int j = 0; j < i; j++)//notice, we are starting at 0, up until i, this allows us to check the previous numbers and create
                {                          //so we can follow the increasing subsequence rule
                    if (nums[i] > nums[j])//if the num[i] is larger than the current j, we know we have an increasing subsequence
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);//we check the previous dp values at index i, the i represents the ending point of the sequence.
                                                           //we either take the previously computed value currently being stored at dp[i], OR we take the current (+1)
                                                           //value and add it to the previously computer increasing subsequence
                    }
                }
            }

            int longest = 0;
            foreach (int c in dp)//get the largest one in the dp table
                longest = Math.Max(longest, c);

            return longest;
        }
    }
}
