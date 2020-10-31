using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems.PalindromicSubstring
{
    public class PalindromicSubstring
    {

        public string LongestPalindrome(string s)
        {
            if(s.Length < 1 || s.Length > 1000)
            {
                return null;
            }
            else if(s.Length == 1)
            {
                return s;
            }


            HashSet<char> palindrome = new HashSet<char>();

            string longestSubstring = string.Empty;

            for(int i = s.Length; i > 0; i--)
            {


                for(int j = i; j > 0; j--)
                {
                    string toReverse = s.Substring(s.Length - i, j);
                    char[] reverse = toReverse.ToCharArray();
                    Array.Reverse(reverse);
                    string reverseString = new string(reverse);

                    if (reverseString.CompareTo(toReverse) == 0)
                    {
                        longestSubstring = (longestSubstring.Length < toReverse.Length) ? toReverse : longestSubstring;
                    }
                }
            }


            return longestSubstring;
        }
    }
}
