using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.DotProductVectors
{
    public class SparseVector
    {
        int[] value;
        Dictionary<int, int> dict;
        public SparseVector(int[] nums)
        {
            value = nums;
            dict = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
                if (nums[i] != 0)
                    dict.Add(i, nums[i]);
        }

        // Return the dotProduct of two sparse vectors
        public int DotProduct(SparseVector vec)
        {
            int result = 0;
            for(int i = 0; i < this.value.Length; i++)
                result += vec.value[i] * this.value[i];

            return result;
        }
        public int DotProduct2(SparseVector vec)
        {
            int result = 0;
            foreach (KeyValuePair<int, int> pair in dict)
            {
                if (!vec.dict.ContainsKey(pair.Key))
                    continue;
                else
                    result += pair.Value * vec.dict[pair.Key];
            }
            return result;
        }
    }
    
}
