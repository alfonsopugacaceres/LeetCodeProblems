using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ConcatenationOfArray
{
    public class ConcatenationOfArray
    {
        public int[] GetConcatenation(int[] nums)
        {
            if (nums.Length < 1 || nums.Length > 1000)
                return null;
            else
            {
                int[] ans = new int[2 * nums.Length];
                int i = 0;
                bool secondGoAround = false;
                while(i < nums.Length && secondGoAround)
                {
                    if(nums.Length == i)
                    {
                        secondGoAround = true;
                        i = 0;
                    }
                    ans[i] = nums[i];
                    i++;
                }
                return ans;

            }
        }

        public int[] GetConcatenation2(int[] nums)
        {
            int n = nums.Length;
            int[] arr = new int[2 * n];
            Array.Copy(nums, arr, n);
            Array.Copy(nums, 0, arr, n, n);
            return arr;
        }
        public int[] GetConcatenation3(int[] nums)
        {
            if (nums.Length < 1 || nums.Length > 1000)
                return null;
            else
            {
                int[] result = new int[2 * nums.Length];
                for (int i = 0, j = 0; i < result.Length; i++, j++)
                {
                    if (j == nums.Length) j = 0;
                    result[i] = nums[j];
                }

                return result;
            }
        }
        public int[] GetConcatenation4(int[] nums)
        {
            if (nums.Length < 1 || nums.Length > 1000)
                return null;
            else
            {
                int[] result = new int[nums.Length * 2];
                for (int i = 0; i < nums.Length; i++)
                    result[i + nums.Length] = result[i] = nums[i];
                return result;
            }
        }


    }
}
