using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.BuildArrayPermutation
{
    class BuildArrayPermutation
    {
        //1920. Build Array from Permutation
        /// <summary>
        ///This Algorithm is O(n) for computational complexity because we looped through all the members of the array
        /// and O(n) for space complexity because we made an array of the same size
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] BuildArray(int[] nums)
        {
            if (nums == null || nums.Length < 1 || nums.Length > 1000)//check for edge conditions
                return null;
            else
            {
                int[] ret = new int[nums.Length];//create an array thats the same length as the input
                for (int i = 0; i < nums.Length; i++)//loop through the input array
                    ret[i] = nums[nums[i]];//apply the permutation
                return ret;//return the answer
            }
        }
    }
}
