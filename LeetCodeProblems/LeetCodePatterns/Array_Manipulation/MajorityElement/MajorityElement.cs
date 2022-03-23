using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.MajorityElement
{
    class MajorityElement
    {
        public int MajorityElement1(int[] nums)
        {
            Array.Sort(nums);
            int max = 1;
            int maxNum = nums[0];
            int curCounter = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                    curCounter = 1;
                else
                    curCounter++;
                if (curCounter > max)
                {
                    maxNum = nums[i];
                    max = Math.Max(curCounter, max);
                }
            }

            return maxNum;
        }
    }
}
