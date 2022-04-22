using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.ConcatenationOfArray
{
    //1929. Concatenation of Array
    //Given an integer array nums of length n, you want to create an array ans of length 2n 
    //where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i<n (0-indexed).
    //Specifically, ans is the concatenation of two nums arrays.
    //Return the array ans.
    class ConcatenationOfArray
    {
        public int[] GetConcatenation(int[] nums)
        {

            int[] ret = new int[nums.Length + nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                ret[i] = nums[i];
                ret[i + nums.Length] = nums[i];
            }

            return ret;

        }
    }
}
