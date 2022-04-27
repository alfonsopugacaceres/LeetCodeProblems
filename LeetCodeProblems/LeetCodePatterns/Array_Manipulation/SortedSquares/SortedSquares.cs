using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.SortedSquares
{
    class SortedSquares
    {
        public int[] SortedSquares1(int[] nums)
        {
            int[] ret = new int[nums.Length];

            int i = 0, j = nums.Length - 1, k = nums.Length - 1;

            while (i <= j && k < nums.Length)
            {
                if (Math.Abs(nums[i]) > Math.Abs(nums[j]))
                {
                    ret[k] = nums[i] * nums[i];
                    i++;
                }
                else
                {
                    ret[k] = nums[j] * nums[j];
                    j--;
                }
                k--;
            }

            return ret;

        }
    }
}
