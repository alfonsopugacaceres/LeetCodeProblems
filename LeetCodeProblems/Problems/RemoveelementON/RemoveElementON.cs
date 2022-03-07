using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.RemoveelementON
{
    public class RemoveElementON
    {
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;//this is our counter
            for (int j = 0; j < nums.Length; j++)//loop through the array
            {
                if (nums[j] != val)//if the current value is not the same as the target value
                {
                    nums[i] = nums[j];//assign the value to the pointer at i, this is what separates the good list vs the bad list
                    i++;//increment the good counter
                }
            }
            return i;//return the number of times we incremented the good counter
        }
    }
}
