using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.LongestSubstringWithoutRepeating
{

    //3. Longest Substring Without Repeating Characters
    //Given a string s, find the length of the longest substring without repeating characters.

    //Use the sliding window principle. The sliding window principle replaces the use of a double for loop
    //Or a double while loop by consolidating the algorithm in a single loop with the usage of either two
    //storage variables or two pointers. The idea is to set up your conditions so we only update
    //one pointer for every ocurrence and the secondary pointer under a special clause. This allows us to
    //sequence the entire problem from beginning to end. 
    //The condition to use the sliding window technique is that the problem asks to find the maximum (or minimum) value for a function that calculates the answer repeatedly for a set of ranges from the array
    public class LongestsubstringwithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> hashSet = new HashSet<char>();
            int max = -1;
            int i = 0;
            int j = 0;

            if (s.Length == 0 || s == string.Empty)
            {
                return 0;
            }
            else
            {
                while (i < s.Length && j < s.Length)
                {
                    if (!hashSet.Contains(s[j]))
                    {
                        hashSet.Add(s[j]);
                        j++;
                        max = Math.Max(hashSet.Count, max);
                    }
                    else
                    {
                        hashSet.Remove(s[i]);
                        i++;
                    }
                }
                return max;
            }
        }
    }
}
