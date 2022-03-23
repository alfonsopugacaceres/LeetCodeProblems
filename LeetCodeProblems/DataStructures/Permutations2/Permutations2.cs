using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.Permutations2
{
    class Permutations2
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {

            IDictionary<int, int> memo = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (!memo.ContainsKey(nums[i]))
                    memo.Add(nums[i], 1);
                else
                    memo[nums[i]]++;
            }

            IList<IList<int>> res = new List<IList<int>>();



        }

        public void DFSHelper(IDictionary<int, int> memo, List<int> permutation, IList<IList<int>> res, int length)
        {
            if (length == permutation.Count)
            {
                List<int> temp = new List<int>();
                foreach (int x in permutation)
                    temp.Add(x);
                res.Add(temp);
                permutation.Clear();
                return;
            }

            foreach (KeyValuePair<int, int> pair in memo)
            {
                if (pair.Value > 0)
                {
                    permutation.Add(pair.Key);
                    memo[pair.Key]--;
                    DFSHelper(memo, permutation, res, length);

                }

            }


        }
    }

}
