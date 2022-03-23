using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.SquaresOfSortedArray
{
    class SquaresOfSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] res = new int[nums.Length];
            for (int i = 0, j = nums.Length - 1, k = res.Length - 1; i <= j; k--)
            {
                if (Math.Abs(nums[j]) >= Math.Abs(nums[i]))
                {
                    res[k] = nums[j] * nums[j];
                    j--;
                }
                else
                {
                    res[k] = nums[i] * nums[i];
                    i++;
                }

            }

            return res;
        }
    }
}
