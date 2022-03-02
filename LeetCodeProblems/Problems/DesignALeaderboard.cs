using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.Problems
{
    public class DesignALeaderboard
    {

        public class LeaderBoard
        {
            SortedDictionary<int, int> TopScores;
            IDictionary<int, IList<int>> scoresByPlayer;
            public LeaderBoard()
            {
                TopScores = new SortedDictionary<int, int>();
                scoresByPlayer = new Dictionary<int, IList<int>>();
            }

            public void AddScore(int playerId, int score)
            {
                if (scoresByPlayer.ContainsKey(playerId))
                    scoresByPlayer[playerId].Add(score);
                else
                    scoresByPlayer.Add(playerId, new List<int>() { score });
                if (TopScores.ContainsKey(score))
                    TopScores[score] = TopScores[score]++;
                else
                    TopScores.Add(score, 1);
            }

            public int Top(int K)
            {
                int sum = 0;
                IList<int> Keys = TopScores.Keys.ToList();
                if (K > Keys.Count)
                    foreach (int key in Keys)
                        sum += key * TopScores[key];
                else
                {
                    int i = Keys.Count;
                    while (i > K)
                    {
                        if (i - TopScores[Keys[i - 1]] >= K)
                        {
                            sum += i * TopScores[Keys[i - 1]];
                            i -= TopScores[Keys[i - 1]];
                        }
                        else
                        {
                            sum += Math.Abs(TopScores[Keys[i - 1]] - K) * TopScores[Keys[i - 1]];
                            break;
                        }
                    }
                }
                return sum;
            }

            public void Reset(int playerId)
            {
                if (scoresByPlayer.ContainsKey(playerId))
                {
                    foreach (int x in scoresByPlayer[playerId])
                    {
                        TopScores[x]--;
                        if (TopScores[x] <= 0)
                            TopScores.Remove(x);
                    }
                    scoresByPlayer[playerId].Clear();

                }
            }

        }
    }
}
