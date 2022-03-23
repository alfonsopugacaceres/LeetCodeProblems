using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.LongestPalindromicSubstring
{
    //5. Longest Palindromic Substring
    public class LongestPalindromicSubstring
    {
        public string LongestPalindromeFromMiddle(string s)
        {
            if (s.Length < 1 || s.Length > 1000)
                return null;
            else
            {
                int midpoint = s.Length / 2;
                int i = midpoint;
                int j = midpoint;


                while (true)
                {
                    if(s[i] == s[j])
                    {
                        i++;
                        j++;
                    }
                    else
                    {

                    }
                }


            }
        }

    }
}
