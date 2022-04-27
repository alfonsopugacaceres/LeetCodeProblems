using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.SortArrayByParity
{
    //905. Sort Array By Parity
    //    Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

    //Return any array that satisfies this condition.
    class SortArrayByParity
    {
       
        public int[] SortArrayByParity1(int[] nums)
        {

            int i = 0, j = nums.Length - 1;

            while (i <= j)
            {
                if (nums[i] % 2 != 0)
                {
                    int temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                    j--;
                }
                else
                    i++;

            }

            return nums;
        }
    }
}
