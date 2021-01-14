using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.SingleRowKeyboard
{
    //1165. Single-Row Keyboard
    public class SingleRowKeyboard
    {
        public int CalculateTime(string keyboard, string word)
        {
            IDictionary<char, int> timeDistance = new Dictionary<char, int>();
            int counter = 0;
            foreach(char c in keyboard)
            {
                if (timeDistance.ContainsKey(c))
                {
                    continue;
                }
                else
                {
                    timeDistance.Add(c, counter);
                    counter++;
                }
            }


            int res = timeDistance[word[0]];
            int prev = res;

            for (int i = 1; i < word.Length; i++)
            {
                res += Math.Abs(prev - timeDistance[word[i]]);
                prev = timeDistance[word[i]];
            }


            return res;
        }
    }
}
