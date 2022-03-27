using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.HashTable.FirstUniqueCharacterInString
{
    //387. First Unique Character in a String
    //Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

    /// <summary>
    /// Use a dictionary to keep track of all the letters and their occurrences, then loop a
    /// second time from beginning to end and return the index of the first incidence of
    /// a character that is only found once
    /// </summary>
    class FirstUniqueCharacterInString
    {
        public int FirstUniqChar(string s)
        {
            IDictionary<char, int> memo = new Dictionary<char, int>();//dictionary of chars and incidences
            foreach (char c in s)//loop through all the characters in the string
            {
                if (memo.ContainsKey(c))//keep track of the counts
                    memo[c]++;
                else
                    memo.Add(c, 1);//add it to the dictionary
            }

            for (int i = 0; i < s.Length; i++)//loop the tring again
            {
                if (memo.ContainsKey(s[i]) && memo[s[i]] == 1)//find the first one that has an occurrence of 1
                    return i;//return the index
            }
            return -1;
        }
    }
}
