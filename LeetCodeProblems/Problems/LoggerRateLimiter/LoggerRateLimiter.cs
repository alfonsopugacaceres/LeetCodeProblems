using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.LoggerRateLimiter
{
    public class LoggerRateLimiter
    {
        /** Initialize your data structure here. */
        public IDictionary<string, int> dict;
        public LoggerRateLimiter()
        {
            dict = new Dictionary<string, int>();
        }

        /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
            If this method returns false, the message will not be printed.
            The timestamp is in seconds granularity. */
        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if (dict.ContainsKey(message))
            {
                int lastTimestamp = dict[message];
                if(lastTimestamp + 10 > timestamp)
                {
                    //the same message is in the queue, we return false and no update happens since 
                    //previous message has not printed
                    return false;
                }
                else
                {
                    //in this case, we previously had said message and we successfully printed it, now that
                    //we have another iteration of the message we update the entry at the message key with 
                    //the new timestamp
                    dict[message] = timestamp;
                    return true;
                }
            }
            else
            {
                //did not find the message in the queue, as such add it to the dictionary and return true
                dict.Add(message, timestamp);
                return true;
            }
        }
    }
}
