using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.StringManipulation.MinimumNumberOperationsTime
{
    //2224. Minimum Number of Operations to Convert Time


//You are given two strings current and correct representing two 24-hour times.
//24-hour times are formatted as "HH:MM", where HH is between 00 and 23, and MM is between 00 and 59. The earliest 24-hour time is 00:00, and the latest is 23:59.
//In one operation you can increase the time current by 1, 5, 15, or 60 minutes.You can perform this operation any number of times.
//Return the minimum number of operations needed to convert current to correct.

    class MinimumNumberOperationsTime
    {
        public int ConvertTime(string current, string correct)
        {
            DateTime start = DateTime.ParseExact(current, "HH:mm", null);
            DateTime end = DateTime.ParseExact(correct, "HH:mm", null);
            int diff = (int)((end - start).TotalMinutes);
            int res = 0;
            while (diff > 0)
            {
                res++;
                if (diff >= 60) diff -= 60;
                else if (diff >= 15) diff -= 15;
                else if (diff >= 5) diff -= 5;
                else if (diff >= 1) diff -= 1;
            }
            return res;
        }
    }
}
