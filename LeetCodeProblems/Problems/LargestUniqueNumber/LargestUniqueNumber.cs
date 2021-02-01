using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.LargestUniqueNumber
{
    public class LargestUniqueNumber
    {
        //1133. Largest Unique Number
        public int LargestUniqueNum(int[] A)
        {

            IDictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (dict.ContainsKey(A[i]))
                {
                    dict[A[i]]++;
                }
                else
                {
                    dict.Add(A[i], 1);
                }
            }

            int max = -1;
            foreach (int entry in dict.Keys)
            {
                if (dict[entry] == 1)
                {
                    max = Math.Max(max, entry);
                }
            }

            return max;
        }
    }
}
