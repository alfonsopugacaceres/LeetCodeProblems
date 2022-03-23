using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ClimbingStairProblem
{
    public class ClimbingStairProblem
    {
        //70. Climbing Stairs
        public int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;//if there is one stair, the answer is 1
            else if (n == 2)
                return 2;//2 stairs the answer is 2
            else
            {
                int waysToClimb = 0;//this is our runningcount
                int prev1 = 2;//previous number
                int prev2 = 1;//the previous previous number
                for (int i = 3; i <= n; i++)
                {
                    waysToClimb = prev1 + prev2;//the addition of both previouses gives you the total ways to climb of the current. This is a mathematical proof
                    prev2 = prev1;//replace the previous previous with the previous
                    prev1 = waysToClimb;//update previous with the current sum
                }

                return waysToClimb;//return the ways to climb
            }
        }
    }
}
