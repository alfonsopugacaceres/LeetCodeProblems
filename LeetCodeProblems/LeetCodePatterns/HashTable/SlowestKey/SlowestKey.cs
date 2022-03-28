using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.HashTable.SlowestKey
{
    class SlowestKey
    {
        public char SlowestKey1(int[] releaseTimes, string keysPressed)
        {

            IDictionary<int, IList<char>> memo = new Dictionary<int, IList<char>>();

            memo.Add(releaseTimes[0], new List<char>() { keysPressed[0] });//initial case is different
            int maxDuration = releaseTimes[0];


            for (int i = 1; i < keysPressed.Length; i++)
            {
                int currentDuration = releaseTimes[i] - releaseTimes[i - 1];
                maxDuration = Math.Max(maxDuration, currentDuration);
                if (memo.ContainsKey(currentDuration))
                    memo[currentDuration].Add(keysPressed[i]);
                else
                    memo.Add(currentDuration, new List<char>() { keysPressed[i] });
            }

            IList<char> res = memo[maxDuration].OrderByDescending(f => f).ToList();


            return res[0];

        }
    }
}
