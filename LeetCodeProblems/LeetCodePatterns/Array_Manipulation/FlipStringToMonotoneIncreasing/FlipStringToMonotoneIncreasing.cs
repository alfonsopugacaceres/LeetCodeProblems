using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.FlipStringToMonotoneIncreasing
{
    class FlipStringToMonotoneIncreasing
    {
        //926. Flip String to Monotone Increasing
        //A binary string is monotone increasing if it consists of some number of 0's
        //(possibly none), followed by some number of 1's(also possibly none).
        //You are given a binary string s.You can flip s[i] changing it from 0 to 1 or from 1 to 0.
        //Return the minimum number of flips to make s monotone increasing.
        public int MinFlipsMonoIncr(string s)
        {
            int[] dp = new int[s.Length + 1];
            for (int i = 0; i < s.Length; ++i)
                dp[i + 1] = dp[i] + (s[i] == '1' ? 1 : 0);//initialize the dp table to the accumulation of 1s

            int ans = int.MaxValue;
            for (int j = 0; j <= s.Length; ++j)
            {
                ans = Math.Min(ans, dp[j] + s.Length - j - (dp[s.Length] - dp[j]));
            }

            return ans;
        }
    }
}
