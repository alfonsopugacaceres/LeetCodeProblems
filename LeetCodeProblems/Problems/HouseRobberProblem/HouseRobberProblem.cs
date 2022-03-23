using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.HouseRobberProblem
{
    public class HouseRobberProblem
    {
        public int Rob(int[] nums)
        {
            int robChoice1 = 0, robChoice2 = 0;
            
            //The trick with this problem is how we can process the array dynamically and keeping track of the previous 2 steps to find
            //the maximum amount.
            //Take a look at the following example array [1,2,3,4]
            //Lets first visit house 0, the MAX we can get from this house is 1
            //Lets take a visit to house 1, the Max we can get from this house is either avoid house 0 and take house 1, or take house 0
            //This means Max(House[0], House[1]), because we can always just not rob house 1 and stick to house 0 if it had more money
            //Now take a look at house 2, since the condition states, ROBBING TWO ADJACENT HOUSES SETS OFF THE ALARM, we can either 
            //Take house 2 + house 0 avoiding house 2 OR we can take house 1. 
            //Therefore house 2 = Math.Max(house2 + house 0, house 1);
            //The same thing for house 3, house 3 = Math.Max(house[3] + house[1], house[2])
            //As we progress through the array we update the values with the maxes, this way we can always make sure we get the largest value
            for(int i = 0; i < nums.Length; i++)
            {
                int curMax = Math.Max(nums[i] + robChoice1, robChoice2);
                robChoice1 = robChoice2;
                robChoice2 = curMax;
            }

            return robChoice2;
        }
    }
}
