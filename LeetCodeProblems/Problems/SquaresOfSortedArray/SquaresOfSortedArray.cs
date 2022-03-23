using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.SquaresOfSortedArray
{
    public class SquaresOfSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                nums[i] *= nums[i];

            Array.Sort(nums);
            return nums;
        }

        //sliding window technique
        public int[] SortedSquares1(int[] nums)
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
        public int[] SortedSquares2(int[] nums)
        {

            int[] res = new int[nums.Length];

            for (int i = 0, j = nums.Length - 1, k = nums.Length - 1; i <= j; k--)
            {
                int atStart = nums[i] * nums[i];
                int atEnd = nums[j] * nums[j];
                if (atStart > atEnd)
                {
                    res[k] = atStart;
                    i++;
                }
                else
                {
                    res[k] = atEnd;
                    j--;
                }
            }

            return res;
        }
    }
}
