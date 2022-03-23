using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MissingNumber
{
    class MissingNumber
    {
        public int MissingNumber1(int[] nums)
        {
            int missing = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                missing ^= i ^ nums[i];
            }
            return missing;
        }
        public int MissingNumber2(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i <= nums.Length; i++)
                set.Add(i);

            for (int i = 0; i < nums.Length; i++)
                set.Remove(nums[i]);

            foreach (int i in set)
                return i;

            return -1;
        }
    }
}
