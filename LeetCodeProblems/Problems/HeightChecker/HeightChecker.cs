using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.NewFolder
{
    public class HeightChecker
    {
        //1051 height checker
        //using a counting sort

        /*
         * 
         *  1 <= heights.length <= 100
            1 <= heights[i] <= 100
         */
        public int HeightCheck(int[] heights)
        {
            int[] frequency = new int[101];

            foreach(int h in heights)
            {
                frequency[h]++; //frequency array, keeps track of how many times a height occurs 
                //uses the height as the location in the array to count
            }

            int res = 0;
            int curHeight = 0;

            for(int i = 0; i < heights.Length; i++)
            {
                while(frequency[curHeight] == 0)//skip the unfilled frequency slots until we find the first valued one
                {
                    curHeight++;
                }

                if(curHeight != heights[i])//if the first height does not match the current item at heights,
                {                          //then that height is not sorted, add to the array
                    res++;
                }
                frequency[curHeight]--;
            }

            return res;

        }
        public int HeightCheck2(int[] heights)
        {
            int[] sortedHeights = new int[heights.Length];
            Array.Copy(heights, sortedHeights, heights.Length);
            Array.Sort(sortedHeights);
            int res = 0;

            for(int i = 0; i < heights.Length; i++)
            {
                if(heights[i] != sortedHeights[i])
                {
                    res++;
                }
            }
            return res;
        }
    }
}
