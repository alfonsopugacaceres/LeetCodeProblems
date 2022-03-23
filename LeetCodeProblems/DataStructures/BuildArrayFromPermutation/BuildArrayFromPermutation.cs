using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.BuildArrayFromPermutation
{
    public class BuildArrayFromPermutation
    {
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

        public int[] buildArray(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                // this is done to keep both old and new value together. 
                // going by the example of [5,0,1,2,3,4]
                // after this nums[0] will be 5 + 6*(4%6) = 5 + 24 = 29;
                // now for next index calulation we might need the original value of num[0] which can be obtain by num[0]%6 = 29%6 = 5;
                // if we want to get just he new value of num[0], we can get it by num[0]/6 = 29/6 = 4
                nums[i] = nums[i] + n * (nums[nums[i]] % n);
            }

            for (int i = 0; i < n; i++)
            {
                nums[i] = nums[i] / n;
            }

            return nums;
        }
    }
}
