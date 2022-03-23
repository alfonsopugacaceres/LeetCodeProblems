using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.WaysToClimbStairs
{
    class WaysToClimbStairs
    {
        public int ClimbStairs(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            int climb1 = 1;
            int climb2 = 1;
            int waysToClimb = climb1 + climb2;
            for (int i = 2; i <= n; i++)
            {
                waysToClimb = climb1 + climb2;
                climb1 = climb2;
                climb2 = waysToClimb;
            }

            return waysToClimb;
        }
    }
}
