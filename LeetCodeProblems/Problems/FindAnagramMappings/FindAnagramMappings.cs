using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.FindAnagramMappings
{
    public class FindAnagramMappings
    {
        //760. Find Anagram Mappings
        public int[] AnagramMappings(int[] A, int[] B)
        {
            IDictionary<int, int> keymap = new Dictionary<int, int>();
            int[] res = new int[A.Length];


            int counter = 0;
            foreach(int i in B)
            {
                keymap[i] = counter;
                counter++;
            }

            counter = 0;
            foreach(int i in A)
            {
                res[counter] = keymap[i];
                counter++;
            }

            return res;
        }
    }
}
