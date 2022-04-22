using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Backtracking.BinaryWatch
{
    class BinaryWatch
    {
        IDictionary<int, int> hours;
        IDictionary<int, int> minutes;

        BinaryWatch()
        {
            hours.Add(1, 1);
            hours.Add(2, 2);
            hours.Add(4, 4);
            hours.Add(8, 8);
            minutes.Add(1, 1);
            minutes.Add(2, 2);
            minutes.Add(4, 4);
            minutes.Add(8, 8);
            minutes.Add(16, 16);
            minutes.Add(32, 32);
        }


        //401. Binary Watch
        //A binary watch has 4 LEDs on the top which represent the hours(0-11), 
        //and the 6 LEDs on the bottom represent the minutes(0-59). 
        //Each LED represents a zero or one, with the least significant bit on the right.
        //Given an integer turnedOn which represents the number of LEDs that are currently 
        //on, return all possible times the watch could represent.You may return the answer in any order.

    }
}
