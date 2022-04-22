using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.NumberOfGoodPairs
{
    class NumberOfGoodPairs
    {
        //1512. Number of Good Pairs
        //Given an array of integers nums, return the number of good pairs.
        //A pair(i, j) is called good if nums[i] == nums[j] and i<j.
        public int NumIdenticalPairs(int[] nums)
        {
            int res = 0;
            int[] count = new int[101];
            foreach (int a in nums)
            {
                res += count[a]++;
            }
            return res;
        }
    }
}
