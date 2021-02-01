using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.PalindromePermutation
{
    public class PalindromePermutation
    {
        //266. Palindrome Permutation
        public bool CanPermutePalindrome(string s)
        {
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!set.Contains(s[i]))
                    set.Add(s[i]);//if we do not find the letter in the hashset add it to the set
                else
                    set.Remove(s[i]);//if we match on the hashset remove the match
            }

            return (set.Count == 0 || set.Count == 1);  //palindromes can have either all characters matching or 1 character mismatching
                                                        //since we can move any letter at any position, we only need to make sure characters are
                                                        //matching properly
        }
        public bool CanPermutePalindrome1(string s)
        {
            IDictionary<char,int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], 1);
                else
                    dict[s[i]]++;
            }

            int remainder = 0;

            foreach (int val in dict.Values)
            {
                remainder += val % 2;
            }



            return (remainder == 0 || remainder == 1);  //palindromes can have either all characters matching or 1 character mismatching
                                                        //since we can move any letter at any position, we only need to make sure characters are
                                                        //matching properly
        }


    }
}
