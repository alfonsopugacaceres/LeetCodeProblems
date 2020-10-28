using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems
{
    public class AmazonFresh
    {
        public AmazonFresh()
        {

        }

        public bool Solve(string[][] winnerItems, string[] shoppingCart)
        {

            if (winnerItems == null || shoppingCart == null)
            {
                return false;
            }



            bool matched = true;
            int k = 0;
            int i = 0;

            while (k < shoppingCart.Length && i < winnerItems.Length)
            {
                matched = true;
                for (int j = 0; j < winnerItems[i].Length; j++)
                {
                    if(k > shoppingCart.Length)
                    {
                        break;
                    }
                    else if (winnerItems[i][j] != "anything" && winnerItems[i][j] != shoppingCart[k])
                    {
                        matched = false;
                        break;
                    }
                    else
                    {
                        k++;
                    }
                }

                if (matched)
                {
                    i++;
                }
                k++;
            }



            return i == winnerItems.Length;
        }

    }
}
