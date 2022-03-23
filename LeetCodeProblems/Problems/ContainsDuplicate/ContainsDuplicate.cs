using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ContainsDuplicate
{
    class ContainsDuplicate
    {
        public bool ContainsDuplicate1(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                if (set.Contains(num))
                    return true;
                else
                    set.Add(num);
            }

            return false;
        }
    }
}
