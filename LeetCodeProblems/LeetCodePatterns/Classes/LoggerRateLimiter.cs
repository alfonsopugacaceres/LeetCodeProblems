using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Classes
{
    class LoggerRateLimiter
    {

        //359. Logger Rate Limiter

        //Design a logger system that receives a stream of messages along with their 
        //timestamps.Each unique message should only be printed at most every 
        //10 seconds (i.e.a message printed at timestamp t will prevent other 
        //identical messages from being printed until timestamp t + 10).
        //All messages will come in chronological order.Several messages may arrive at the same timestamp.
        //Implement the Logger class:
        //Logger() Initializes the logger object.
        //bool shouldPrintMessage(int timestamp, string message) Returns true if the message should be printed in the given timestamp, otherwise returns false.

        private IDictionary<string, int> memo;

        public LoggerRateLimiter()
        {
            memo = new Dictionary<string, int>();
        }

        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if (memo.ContainsKey(message))
            {
                if (memo[message] <= timestamp)
                {
                    memo[message] = timestamp + 10;
                    return true;
                }
                else
                    return false;
            }
            else
                memo.Add(message, timestamp + 10);
            return true;
        }
    }
}
