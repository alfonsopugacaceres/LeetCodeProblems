using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.LeetCodePatterns.Backtracking.LetterTilePossibilities
{
    class LetterTilePossibilities
    {
        public int NumTilePossibilities(string tiles)
        {
            IDictionary<char, int> charmemo = new Dictionary<char, int>();

            for (int i = 0; i < tiles.Length; i++)
            {
                if (charmemo.ContainsKey(tiles[i]))
                    charmemo[tiles[i]]++;
                else
                    charmemo.Add(tiles[i], 1);
            }

            return BacktrackingHelper(charmemo);

        }

        public int BacktrackingHelper(IDictionary<char, int> charmemo)
        {
            int sum = 0;

            if (!charmemo.Values.Any(f => f > 0))
                return 0;
            foreach (char c in charmemo.Keys)
            {
                if (charmemo[c] <= 0)
                    continue;
                else
                {
                    charmemo[c]--;
                    sum += BacktrackingHelper(charmemo) + 1;
                    charmemo[c]++;
                }
            }
            return sum;
        }
    }
}
