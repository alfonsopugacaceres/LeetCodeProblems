using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.ProductOfArrayExceptSelf
{
    class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf1(int[] nums)
        {
            int[] ret = new int[nums.Length];
            int[] prefix = new int[nums.Length];
            int[] postfix = new int[nums.Length];

            prefix[0] = 1;
            postfix[postfix.Length - 1] = 1;

            for (int i = 1; i < nums.Length; i++)
                prefix[i] = prefix[i - 1] * nums[i - 1];

            for (int i = postfix.Length - 2; i >= 0; i--)
                postfix[i] = postfix[i + 1] * nums[i + 1];

            for (int i = 0; i < ret.Length; i++)
                ret[i] = prefix[i] * postfix[i];

            return ret;

        }
        //public int[] ProductExceptSelfOptimized(int[] nums)
        //{
        //    int[] ret = new int[nums.Length];

        //    ret[0] = 1;
        //    int temp = 1;

        //    for (int i = 1; i < nums.Length; i++)
        //        ret[i] = ret[i - 1] * nums[i - 1];

        //    for (int j = nums.Length - 1; j >= 0; j--)
        //    {
        //        ret[j] = temp * ret[j];
        //        temp *= ret[j];
        //    }

        //    return ret;
        //}
    }
}
