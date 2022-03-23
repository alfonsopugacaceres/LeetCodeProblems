using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.FindDuplicate
{
    class FindDuplicate
    {
        public int FindDuplicate1(int[] nums)
        {


            //floyds algorithm https://www.youtube.com/watch?v=wjYnzkAhcNk
            int slow = 0, fast = 0;

            while (true)
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
                if (slow == fast)
                    break;
            }

            int slow2 = 0;

            while (true)
            {
                slow = nums[slow];
                slow2 = nums[slow2];
                if (slow == slow2)
                    return slow;
            }
        }
    }
}
