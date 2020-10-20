using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems
{
    public class TwoSum
    {
        public TwoSum()
        {

        }


        public int[] Solve(int[] nums, int target)
        {
            if(nums.Length < 2 || nums.Length > 100000)
                return null;
            else if (target < -1000000000 || target > 1000000000)
                return null;


            int[] result = new int[2];
            result[0] = 0;
            result[1] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < -1000000000 || nums[i] > 1000000000)
                    return null;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }

    }
}
