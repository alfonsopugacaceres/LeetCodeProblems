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
            int start = 0;
            int end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandBoundaries(s, i, i);//this handles the general palindrome case
                int len2 = ExpandBoundaries(s, i, i + 1);//this handles the exception case which deals with a middle character like racecar
                int max = Math.Max(len1, len2);//check which one is the larger one

                if (max > end - start)//if the currentmax is larger than the current length (comparing end and start)
                {
                    start = i - ((max - 1) / 2);//update start to be i - ((max - 1)/2). We are moving the pointer to the left. The minus one acounts for the 0 index
                    end = i + (max / 2);//update start to be i + (max / 2). We are moving the pointer to the right
                    //remember that the loop is tracking palindromes using i as the middle point, therefore we need to calculate
                    //the start and end
                }
            }

            return s.Substring(start, end + 1);
        }

        public int ExpandBoundaries(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length - 1 && s[left] == s[right])//while the character at the left boundary and the right boundary are the same, expand boundary
            {
                left--;
                right++;
            }
            return right - left - 1;//return the total length of the substring
        }


        public string LongestPalindromeFromMiddle(string s)
        {

            HashSet<string> palindromes = new HashSet<string>();

            char[] sChars = s.ToCharArray();
            int j = 1;
            for (int i = 0; i < s.Length; i++)
            {
                string cur = s.Substring(i, j);
                while ( j < s.Length && IsPalindrome(cur))
                {
                    palindromes.Add(cur);
                    j++;
                }
                i++;
                j = i + 1;
            }


            return s;
        }

        public bool IsPalindrome(string s)
        {
            char[] s1 = s.ToCharArray();
            char[] s2 = s.ToCharArray();
            Array.Reverse(s1);
            if (s1 == s2)
                return true;
            else
                return false;
        }
    }
}
