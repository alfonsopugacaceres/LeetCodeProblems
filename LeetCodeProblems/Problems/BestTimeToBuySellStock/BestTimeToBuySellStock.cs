﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.BestTimeToBuySellStock
{
    public class BestTimeToBuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            int max = 0;//since we cant sell on the same day and make a dime, the max is 0 as the initial case
            int curIndex = 0;//start at the first index, you cant sell on the same day and get a profit


            for (int i = 1; i < prices.Length; i++)//loop through the prices over time, we start in time 1 because we need a starting point to compare forward
            {
                max = Math.Max(prices[i] - prices[curIndex], max);//check if the current max is the max between selling at the current index and i 
                curIndex = (prices[curIndex] > prices[i]) ? i : curIndex;//update the index if there was a better price to buy at in the future, notice
                                                                         //our max did not change, this is calculated next go around
            }

            if (max <= 0)//if we had any loses or we are at 0
                return 0;//return 0
            else
                return max;//otherwise the max

        }
    }
}
