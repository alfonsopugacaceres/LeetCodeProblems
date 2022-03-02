using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MaximumPairSumArray
{
    public class MaximumPairSumArray
    {
        public int MinPairSum(int[] nums)
        {
            Array.Sort(nums);//sort the numbers

            int i = 0;//create front counter
            int j = nums.Length - 1;//create back counter
            int max = -1;//start the max variable
            while (i < j)//while the start pointer is not past the end pointer
            {
                max = Math.Max(max, nums[i] + nums[j]);//since we sorted the array, we already know we are picking the lowest sum
                j--;                                   //by adding the largest number with the lowest number, now the last step is to
                i++;                                   //pick the largest number from the minimized maxes
            }
            return max;//return the answer
        }
    }
}
