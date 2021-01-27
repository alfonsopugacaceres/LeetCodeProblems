using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.CountSubstringDistinctLetter
{
    public class CountSubstringDistinctLetter
    {
        //1180. Count Substrings with Only One Distinct Letter
        public int CountLetters(string S)
        {
            int[] substringCount = new int[S.Length];//keep track of contiguous characters that are the same
            int ret = 1;//initialize to 1 character
            substringCount[0] = 1;//initialize to the first character

            for(int i = 1; i < S.Length; i++)
            {
                if(S[i] == S[i - 1])//same character as before
                {
                    substringCount[i] = substringCount[i - 1] + 1;//add 1 to the previous substring count
                }
                else//if its not the same character as before
                {
                    substringCount[i] = 1;
                }
                ret += substringCount[i];//add the current substring count to the result
            }

            return ret;

        }
    }
}
