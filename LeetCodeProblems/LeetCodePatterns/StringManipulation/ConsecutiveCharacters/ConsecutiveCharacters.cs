using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.StringManipulation.ConsecutiveCharacters
{

    //1446. Consecutive Characters
    //    The power of the string is the maximum length of a non-empty substring that contains only one unique character.
    //Given a string s, return the power of s.
    class ConsecutiveCharacters
    {
        public int MaxPower(string s)
        {

            char prev = ' ';
            int currentCount = 0;
            int max = 0;
            foreach (char c in s)
            {
                if (prev != c)
                {
                    currentCount = 1;
                    prev = c;
                }
                else
                    currentCount++;

                max = Math.Max(max, currentCount);
            }

            return max;
        }
    }
}
