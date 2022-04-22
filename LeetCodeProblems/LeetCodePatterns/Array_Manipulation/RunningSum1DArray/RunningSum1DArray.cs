using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.RunningSum1DArray
{
    class RunningSum1DArray
    {
        //1480. Running Sum of 1d Array
        //Given an array nums.We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
        //Return the running sum of nums.
        public int[] RunningSum(int[] nums)
        {

            for (int i = 1; i < nums.Length; i++)
                nums[i] = nums[i] + nums[i - 1];

            return nums;
        }
    }
}
