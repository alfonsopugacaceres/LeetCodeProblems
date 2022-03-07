using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.BestSightseeingPair
{
    public class BestSightseenPair
    {
        //1014. Best Sightseeing Pair
        public int MaxScoreSightseeingPair(int[] values)
        {

            int currentI = 0;//start the current index at 0
            int ret = -1;//since we do not have a starting max until we reach a second spot, start the max at -1

            for (int i = 1; i < values.Length; i++)//loop through the array starting at index 1, because we cannot get a distance if we stay at the same spot
            {

                ret = Math.Max(ret, values[i] - i + values[currentI] + currentI);//using the equation for determining the best sightseeing spot, we compare the maxes
                                                                                 //note, the first time this runs the ret val is bogus since we havent travelled anywhere
                                                                                 //values[i] - i satisfies our requirements for calculating the best path travelled from the initial spot

                currentI = (values[currentI] + currentI < values[i] + i) ? i : currentI;//to update the initial spot, we have to figure out which value gives us the best outcome
                                                                                        //note that our max is not yet calculated when we update the starting point, also note that we do not
                                                                                        //need to check any previous values because of the CONDITION STATED I < J, THEREFORE YOU DO NOT EVER LOOK BACK
                                                                                        //YOU ONLY CHECK FORWARD
            }

            return ret;

        }
    }
}
