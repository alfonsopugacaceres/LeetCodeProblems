using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.MaximumSubArray
{
    class MaximumSubArray
    {
        //53. Maximum Subarray
        //Given an integer array nums, find the contiguous subarray(containing at least one number) which has the largest sum and return its sum.
        //A subarray is a contiguous part of an array.

        /// <summary>
        /// Kadane's Algorithm
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxSubArray1(int[] nums)
        {
            int max = nums[0];//initialize the max to the first number
            int currentSum = nums[0];//initialize the current sum to the first number

            for (int i = 1; i < nums.Length; i++)//loop for the rest of the array
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);//check if the current number we are checking is larger than the previous accumulation of sums plus the current number
                                                                     //if the current number is larger, it means that all the previously accumulated numbers do not really provide any value
                                                                     //for the current calculation of max, therefore, discard them, and set them equal to the current value
                max = Math.Max(max, currentSum);//set the maximum to be the max between the current max and the current sum
            }

            return max;//return the max
        }
    }
}
