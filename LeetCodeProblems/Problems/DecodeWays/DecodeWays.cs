using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.DecodeWays
{
    public class DecodeWays
    {
        public int NumDecodings(string s)
        {
            IDictionary<char, int> dict = new Dictionary<char, int>();
            char c = 'A';
            for(int i = 1; i <= 26; i++)
            {
                dict.Add(c, i);
                c = (char)(c + 1);
            }



        }
    }
}
