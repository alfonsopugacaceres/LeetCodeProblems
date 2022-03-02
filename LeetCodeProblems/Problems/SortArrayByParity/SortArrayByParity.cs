using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.SortArrayByParity
{
    /// <summary>
    /// 905. Sort Array By Parity
    /// </summary>
    public class SortArrayByParity
    {
        public int[] SortArrayByParity1(int[] nums)
        {
            int[] ret = new int[nums.Length];//create a return array
            for (int i = 0, k = 0, j = nums.Length - 1; k <= j; i++)//create two pointer variables besides the regular counter
            {                                                       //pay attention to the stopping condition, when the indexes pass each other, you know that the array is ready
                if (nums[i] % 2 != 0)//check if the number is odd
                {
                    ret[j] = nums[i];//odd numbers get placed at the end of the array using the j index
                    j--;//decrement the index
                }
                else
                {
                    ret[k] = nums[i];//even numbers get put at the front of the array with the k index
                    k++;//increment the index
                }
            }
            return ret;//return the answer
        }

    }
}
