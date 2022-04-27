using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.ProductOfArrayExceptSelf
{
    class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] postfix = new int[nums.Length];
            int[] prefix = new int[nums.Length];
            int[] ret = new int[nums.Length];


            prefix[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] * nums[i];
            }

            postfix[nums.Length - 1] = nums[nums.Length - 1];
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                postfix[i] = postfix[i + 1] * nums[i];
            }

            ret[0] = postfix[1];
            ret[ret.Length - 1] = prefix[ret.Length - 2];
            for (int i = 1; i < nums.Length - 1; i++)
            {
                ret[i] = prefix[i - 1] * postfix[i + 1];
            }

            return ret;
        }
    }
}