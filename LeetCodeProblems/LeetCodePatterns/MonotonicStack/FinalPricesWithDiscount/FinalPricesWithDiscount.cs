using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.MonotonicStack.FinalPricesWithDiscount
{
    class FinalPricesWithDiscount
    {
        //1475. Final Prices With a Special Discount in a Shop

        //Given the array prices where prices[i] is the price of the ith item in a shop.
        //There is a special discount for items in the shop, if you buy the ith item, 
        //then you will receive a discount equivalent to prices[j] where j is the 
        //minimum index such that j > i and prices[j] <= prices[i], otherwise, you 
        //will not receive any discount at all.
        //Return an array where the ith element is the final price you will pay 
        //for the ith item of the shop considering the special discount.


        public int[] FinalPrices(int[] prices)
        {
            int[] ret = new int[prices.Length];
            Stack<int> s = new Stack<int>();
            IList<int> maintainStack = new List<int>();
            

            for (int j = prices.Length - 1; j >= 0; j--)
            {
                if (s.Count == 0)
                {
                    ret[j] = prices[j];
                    s.Push(prices[j]);
                }
                else
                {
                    bool discountFound = false;
                    while (s.Count > 0)
                    {
                        int current = s.Pop();
                        maintainStack.Add(current);
                        if (current <= prices[j])
                        {
                            ret[j] = prices[j] - current;
                            discountFound = true;
                            break;
                        }
                    }

                    if (!discountFound)
                        ret[j] = prices[j];

                    for (int i = maintainStack.Count - 1; i >= 0; i--)
                        s.Push(maintainStack[i]);
                    s.Push(prices[j]);
                    maintainStack.Clear();
                }
            }

            return ret;

        }
    }
}
