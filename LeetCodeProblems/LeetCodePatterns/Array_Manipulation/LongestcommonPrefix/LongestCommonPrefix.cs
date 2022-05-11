using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.LongestcommonPrefix
{
    public class LongestCommonPrefix
    {

        //14. Longest Common Prefix
        //Write a function to find the longest common prefix string amongst an array of strings.
        //If there is no common prefix, return an empty string "".

        /// <summary>
        /// Using vertical scanning and the fact that a prefix starts from index 0 and goes forward we can come up
        /// with the following solution
        /// 
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix1(string[] strs)
        {

            for (int i = 0; i < strs[0].Length; i++)//loop through the first word, remember prefix starts at index 0
            {
                char c = strs[0][i];//using the first word we can check all available leftover strings for matches,
                                    //if even one of the does not match we have found the longest common prefix

                for (int j = 1; j < strs.Length; j++)//loop through the rest of the strings
                {

                    if (i == strs[j].Length || c != strs[j][i])//if the current word we are looking at is as large as
                    {                                          //as the length of the string, then we can no longer progress,
                                                               //this means we found the largest common prefix. The other case
                                                               //is that the current character does not match the current character
                                                               //at slot i in strs[j]
                        return strs[0].Substring(0, i);
                    }

                }

            }

            return strs[0];//if we reach this point, return the first string. Because the entire word is a shared prefix, and the longest one at that.

        }

    }

}
