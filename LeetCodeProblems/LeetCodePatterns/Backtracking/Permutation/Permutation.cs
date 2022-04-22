using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Backtracking.Permutation
{
    class Permutation
    {
        //46. Permutations
        //Given an array nums of distinct integers, return all the possible permutations.You can return the answer in any order.
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<int> listform = new List<int>(nums);

            return CalculatePermutation(listform);
        }

        IList<IList<int>> CalculatePermutation(IList<int> list) {
            if (list == null || list.Count == 0)
                return new List<IList<int>>();
            else
            {
                IList<IList<int>> result = new List<IList<int>>();
                for (int i = 0; i < list.Count; i++)
                {
                    int current = list[0];
                    list.RemoveAt(0);
                    IList<IList<int>> permutations = CalculatePermutation(list);

                    for (int j = 0; j < permutations.Count; j++)
                    {
                        permutations[j].Insert(permutations.Count - 1, current);
                        result.Add(permutations[j]);
                    }
                }

                return result;
            }

        }


    }
}
