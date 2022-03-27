using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.HashTable.MusicPairs
{
    class MusicPairs
    {
        //1010. Pairs of Songs With Total Durations Divisible by 60
        //You are given a list of songs where the ith song has a duration of time[i] seconds.
        //Return the number of pairs of songs for which their total duration in seconds 
        //is divisible by 60. Formally, we want the number of indices i, j such that i<j with (time[i] + time[j]) % 60 == 0

        /// <summary>
        /// This problem is easily solved by a hash table. The trick is to check if we have
        /// any complements that can create values which are divisible by 60.
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public int NumPairsDivisibleBy60(int[] time)
        {
            int counter = 0;
            IDictionary<int, int> memo = new Dictionary<int, int>();//create  a dictionary
                                                                    //to keep track of numbers
                                                                    //and incidence

            for(int i = 0; i < time.Length; i++)//loop through all the times
            {
                int remainder = time[i] % 60;//check remainders
                //if the remainder is 0, then we know its divisible by 60, then
                //that means adding another number divisible by 60 will also be
                //divisible by 60. Therefore we always put it in the 0 slot.
                //For any other numbers we create a complement to create 60
                int missingNumber = (remainder == 0) ? 0 : 60 - remainder;

                if (memo.ContainsKey(missingNumber))//if we find the missing complement
                    counter += memo[missingNumber];//we add the counter to our current count
                                                   //remember there could be more than 1
                if (!memo.ContainsKey(remainder))//if the memo does not contain the remainder
                    memo.Add(remainder, 1);//add ther remainder
                else
                    memo[remainder]++;//otherwise we just increment the remainder count
            }

            return counter;//return the counter
        }

    }
}
