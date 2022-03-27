using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.FindAllDuplicatesInArray
{
    class FindAllDuplicatesInArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {

            IDictionary<int, int> memo = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {

                if (memo.ContainsKey(nums[i]))
                    memo[nums[i]]++;
                else
                {
                    memo.Add(nums[i], 1);
                }
            }

            IList<int> ret = new List<int>();

            foreach (KeyValuePair<int, int> pair in memo)
            {
                if (pair.Value == 2)
                    ret.Add(pair.Key);
            }

            return ret;
        }




    }
}
