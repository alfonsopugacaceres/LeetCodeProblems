using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.Permutation1
{
    class Permutation1
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            int numberOfPermuations = 1;

            if (nums.Length == 1)
                return new List<IList<int>>() { new List<int>() { nums[0]} };



            IList<IList<int>> res = new List<IList<int>>();

            List<int> numsList = new List<int>(nums);

            for(int i = 0; i < nums.Length; i++)
            {
                int current = numsList[i];
                numsList.RemoveAt(0);


            }


        }

        public IList<int> DFSHelper(IList<)
        {

            if(length == permutation.Count)
            {
                return null;
            }


        }
    }
}
