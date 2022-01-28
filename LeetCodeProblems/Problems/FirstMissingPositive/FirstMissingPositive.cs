using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.FirstMissingPositive
{
    public class FirstMissingPositive
    {
        public int FirstMissingPositive(int[] nums)
        {
            Array.Sort(nums);
            HashSet<int> set = new HashSet<int>();
            foreach(int num in nums)
            {
                if (!set.ContainsKey(num))
                {
                    set.Add(num);
                }
            }

        }
    }
}
