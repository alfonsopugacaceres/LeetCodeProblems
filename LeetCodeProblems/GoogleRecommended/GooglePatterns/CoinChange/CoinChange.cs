using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.CoinChange
{
    class CoinChange
    {
        public int CoinChange1(int[] coins, int amount)
        {
            return Change(coins, amount, new Dictionary<int, int>());
        }


        public int Change(int[] coins, int amount, Dictionary<int, int> memo)
        {

            if (amount == 0)
                return 0;


            if (memo.ContainsKey(amount))
                return memo[amount];

            int minCoin = int.MaxValue;
            foreach (int coin in coins)
            {
                if (coin <= amount)
                {
                    int min = Change(coins, amount - coin, memo);
                    if (min < 0)
                        continue;
                    else
                        minCoin = Math.Min(minCoin, min);
                }
            }

            memo[amount] = minCoin == int.MaxValue ? -1 : minCoin + 1;
            return memo[amount];
        }

        public int DynamicCoinChange(int[] coins, int amount)
        {
            int max = amount + 1;
            int[] dp = new int[amount + 1];
            Array.Fill(dp, max);
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                    }
                }
            }
            return dp[amount] > amount ? -1 : dp[amount];

        }
    }
}
