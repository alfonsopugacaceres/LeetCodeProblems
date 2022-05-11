﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.StringManipulation.FindTheDifference
{
    class FindTheDifference
    {
        //389. Find the Difference
        //You are given two strings s and t.
        //String t is generated by random shuffling string s and then add one more letter at a random position.
        //Return the letter that was added to t.
        public char FindTheDifference1(string s, string t)
        {

            IDictionary<char, int> memo = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (memo.ContainsKey(c))
                    memo[c]++;
                else
                    memo.Add(c, 1);
            }

            foreach (char c in t)
            {
                if (memo.ContainsKey(c))
                {
                    if (memo[c] == 1)
                        memo.Remove(c);
                    else
                        memo[c]--;
                }
                else
                    return c;
            }

            return memo.Keys.FirstOrDefault();

        }
    }
}