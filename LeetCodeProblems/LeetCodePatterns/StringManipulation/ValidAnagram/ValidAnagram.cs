using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.StringManipulation.ValidAnagram
{
    public class ValidAnagram
    {
        /// <summary>
        /// first we get rid of any strings that do not have the same length, then we create a dictionary. Notice that the dictionary we create is to keep track of ocurrences 
        /// in both strings, string t decrements, string s increments, when we loop through the keys, if at any point any key does not equal 0, we know there was a mismatch
        /// between character ocurrences between both strings, therefore return false.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram(string s, string t)
        {
            IDictionary<char, int> str1Dict = new Dictionary<char, int>();

            if (s.Length != t.Length)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (!str1Dict.ContainsKey(s[i]))//if the dictionary does not contain s[i], add it
                    str1Dict.Add(s[i], 0);
                str1Dict[s[i]] += 1;//increment the count
                if (!str1Dict.ContainsKey(t[i]))//if the dictionary does not contain t[i], add it
                    str1Dict.Add(t[i], 0);
                str1Dict[t[i]] -= 1;//decrement the count
            }

            foreach (KeyValuePair<char, int> pair in str1Dict)
            {
                if (pair.Value != 0)//any key without a zero in its place means that there was a mismatch in characters, therefore not an anagram
                {
                    return false;
                }
            }

            return true;

        }

        public bool isAnagram(String s, String t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            int[] counter = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                counter[s[i] - 'a']++;
                counter[t[i] - 'a']--;
            }
            foreach (int count in counter)
            {
                if (count != 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
